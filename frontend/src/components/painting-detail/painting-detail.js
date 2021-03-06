import React from 'react';
import { ClipLoader } from 'react-spinners';
import styles from './painting-detail.module.css';
import AliceCarousel from 'react-alice-carousel';
import "react-alice-carousel/lib/alice-carousel.css";
import AudioPlayer from "../audio-player/index";
import Api from '../../services/api';
import { css } from '@emotion/core';
import InfoSection from '../info-section/info-section';
import Translation from '../../services/translation';
import PaintingStory from '../painting-story/painting-story';
import ReactNotification from "react-notifications-component";

const override = css`
    display: block;
    margin: 0 auto;
    border-color: red;
`;

class PaintingDetail extends React.Component{

    constructor(props){
        super(props);

        this.state = {
            loading : true,
            data : null,
            currentStoryIndex : 0,
            availableLanguages : []
        };
        this.goBackToSelection = this.goBackToSelection.bind(this);
        this.changeLanguage = this.changeLanguage.bind(this);
        this.addLanguages = this.addLanguages.bind(this);
        this.selectLanguage = this.selectLanguage.bind(this);
        
    }

    async componentWillMount(){
        let dataJSON = await Api.getPaintingDetail(this.props.match.params.id, localStorage.getItem("language"));
        if(dataJSON.status === 404){
            this.props.history.push({
                pathname : `/choose-painting`,
                state:{notFound : true, paintingNumber : this.props.match.params.id}
            });
            window.location.reload();
        }
        else if(dataJSON.translations.length !== 0)
            await this.setState({data : dataJSON, loading : false, currentStoryIndex : 0, availableLanguages : []});
        else{
            let languages = await Api.getAvailableLanguages();
            await this.setState({data : dataJSON, loading : false, currentStoryIndex : 0, availableLanguages : languages});
            this.addLanguages();
        }
    }

    handleOnDragStart(e){
        e.preventDefault();
    }

    handleChange = (e) => {
        let dataState = this.state.data;
        let loadingState = this.state.loading;
        this.setState({data : dataState, loading : loadingState, currentStoryIndex : e.item})
    }

    goBackToSelection(){
        this.props.history.push(`/choose-painting`);
    }

    changeLanguage(isLanguageMissing){
        this.props.history.push({
            pathname : `/`,
            state:{
                previousUrl : `paintings/detail/${this.props.match.params.id}`,
                isLanguageMissing : isLanguageMissing
            }
        });
    }

    addLanguages(){
        let body = document.getElementById("languages");
        let goTo = document.getElementById("goTo");
        console.log(body.childNodes[0])
        let line;
        for(let i =0; i < this.state.availableLanguages.length; i++){
            let lan = document.createElement("td");
            lan.onclick = ()=>{
                this.selectLanguage(this.state.availableLanguages[i].code);
            }
            lan.id = `${localStorage.getItem("language")}-missing-${this.state.availableLanguages[i].code}`;
            lan.innerHTML = this.state.availableLanguages[i].name;
            if(i%2 === 0){
                line = document.createElement("tr");
                body.insertBefore(line, goTo);
            }
            line.append(lan);
        }
    }

    selectLanguage(language){
        localStorage.setItem("language",language);
        this.props.history.push(`/paintings/detail/${this.props.match.params.id}`);
        window.location.reload();
    }

    render(){
        if(this.state.loading)
            return(
                <div className='sweet-loading'>
                    <ClipLoader
                        css={override}
                        sizeUnit={"px"}
                        size={100}
                        color={'#787B7D'}
                        loading={true}
                    />
                </div>
            );

        if(!this.state.loading && this.state.data.translations.length === 0)
                return(
                    <div>
                        <ReactNotification ref={this.notificationDOMRef} />
                        <div className={`container ${styles.missingLanguage}`}>
                            <span id={styles.missingSentence}>{Translation.Translate("missingLanguage")}</span>
                            <table className="table table-borderless">
                                <tbody id="languages">
                                </tbody>
                            </table>
                        </div>
                    </div>
                );

        if(!this.state.loading)
            return(
            <div className="">
                <nav className={`navbar sticky-top navbar-expand navbar-light bg-light ${styles.navBackground}`}>
                    <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className={`collapse navbar-collapse ${styles.fontColor}`} id="navbarNav">
                        <ul className="navbar-nav">
                            <li className="nav-item" onClick={this.goBackToSelection}>
                                <i className={styles.materialIcon}>&#xe5cb;</i>
                            </li>
                        </ul>
                        <ul className="navbar-nav mx-auto">
                            <li className="nav-item ">
                                <a className="nav-link" id="ArtistLink" href={`#Artist-${this.props.match.params.id}`}>{Translation.Translate("artist")}</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" id="MovementLink" href={`#Movement-${this.props.match.params.id}`}>{Translation.Translate("movement")}</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" id="TechniqueLink" href={`#Technique-${this.props.match.params.id}`}>{Translation.Translate("technique")}</a>
                            </li>
                        </ul>
                    </div>
                </nav>

                <div className={styles.body}>
                    <div>
                        <AliceCarousel autoPlayInterval={15000} autoPlay={true} mouseDragEnabled buttonsDisabled={true} onSlideChanged={this.handleChange}>
                            {
                                this.state.data.stories.map(s => <PaintingStory key={s.id} story={s}></PaintingStory>)
                            }
                        </AliceCarousel>
                    </div>

                    <div id={`Artist-${this.props.match.params.id}`} className="container">

                        <div className={styles.content}>
                            <InfoSection type="artist" sourceLink={this.state.data.author.translations[0].sourceLink} storyTitle={`${this.state.data.author.firstName} ${this.state.data.author.lastName}`} content={this.state.data.author.translations[0].description}></InfoSection>
                        </div>

                        <hr id={`Movement-${this.props.match.params.id}`} className={styles.separation}></hr>

                        <div className={styles.content}>
                            <InfoSection  type="movement" sourceLink={this.state.data.movement.translations[0].sourceLink} storyTitle={this.state.data.movement.translations[0].name} content={this.state.data.movement.translations[0].description}></InfoSection>
                        </div>

                        <hr id={`Technique-${this.props.match.params.id}`} className={styles.separation}></hr>

                        <div className={styles.content}>
                            <InfoSection type="technique" sourceLink={this.state.data.technique.translations[0].sourceLink} storyTitle={this.state.data.technique.translations[0].name} content={this.state.data.technique.translations[0].description}></InfoSection>
                        </div>

                        <hr className={styles.separation}></hr>

                        <div id="Artwork" className={styles.content}>
                            <InfoSection type="artwork" sourceLink={this.state.data.translations[0].sourceLink} storyTitle={Translation.Translate("aboutArtwork")} content={this.state.data.translations[0].description}></InfoSection>
                        </div>

                        <hr className={styles.separation}></hr>

                        <div id="Info" className={`${styles.content}`}>
                            <h5 className={styles.title}>Info</h5>
                            <div className={`row ${styles.infoSection}`}>
                                <div className={`col-2`}>
                                    <div className={styles.line}></div>
                                </div>
                                <div className="col-10">
                                    <table className={`table table-borderless ${styles.paintDetails}`}>
                                        <tbody>
                                            <tr>
                                                <td>{Translation.Translate("title")}</td>
                                                <td>{this.state.data.translations[0].name}</td>
                                            </tr>
                                            <tr>
                                                <td>{Translation.Translate("artist")}</td>
                                                <td>{`${this.state.data.author.firstName} ${this.state.data.author.lastName}`}</td>
                                            </tr>
                                            <tr>
                                                <td>{Translation.Translate("year")}</td>
                                                <td>{this.state.data.year}</td>
                                            </tr>
                                            <tr>
                                                <td>{Translation.Translate("size")}</td>
                                                <td>{`${this.state.data.height} x ${this.state.data.width} cm`}</td>
                                            </tr>
                                            <tr>
                                                <td>{Translation.Translate("technique")}</td>
                                                <td>{this.state.data.technique.translations[0].name}</td>
                                            </tr>
                                            <tr>
                                                <td>{Translation.Translate("movement")}</td>
                                                <td>{this.state.data.movement.translations[0].name}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
               </div>
                <footer className={`fixed-bottom`}>
                    {this.state.data.audios.length > 0 ? <AudioPlayer src={this.state.data.audios[0].audioUrl}/> : null}
               </footer>
            </div>
        );
    }
}

export default PaintingDetail;
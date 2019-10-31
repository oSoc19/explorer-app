import React from 'react';
import { ClipLoader } from 'react-spinners';
import styles from './painting-detail.module.css';
import AliceCarousel from 'react-alice-carousel';
import "react-alice-carousel/lib/alice-carousel.css";
import AudioPlayer from "../audio-player/index";
import Api from '../../services/api';
import { css } from '@emotion/core';
import InfoSection from '../info-section/info-section';
import LanguageSection from '../language-section/language-section';
import Translation from '../../services/translation';
import PaintingStory from '../painting-story/painting-story';
import ReactNotification from "react-notifications-component";

const override = css`
    border-color: #22A4B4;
    display: block;
    margin: 0 auto;
    position: relative;
    top: 40vh;
`;

class PaintingDetail extends React.Component{

    constructor(props){
        super(props);

        this.state = {
            loading : true,
            data : null,
            currentStoryIndex : 0,
            availableLanguages : [],
            prevScrollpos: window.pageYOffset,
            hidden: false,
            buttonHidden: false,
            descriptionFlag: true
        };

        this.goBackToSelection = this.goBackToSelection.bind(this);
        this.changeLanguage = this.changeLanguage.bind(this);
        this.addLanguages = this.addLanguages.bind(this);
        this.selectLanguage = this.selectLanguage.bind(this);
        this.handleScroll = this.handleScroll.bind(this);
        this.lastScrollTop = window.pageYOffset;
    }

    async componentWillMount(){
        console.log(localStorage);
        if( localStorage.getItem("language") === null || localStorage.getItem("language") === "false" ){
            let language = navigator.language || navigator.userLanguage;
            language = language.substring(0, 2).toUpperCase();
            localStorage.setItem("language",language);
            if( language !== "EN" || language !== "NL" || language !== "FR" ){
                localStorage.setItem("language","EN");
            }
        }
        console.log(localStorage.getItem("language"));
        let dataJSON = await Api.getPaintingDetail(this.props.match.params.id, localStorage.getItem("language"));
        window.addEventListener("scroll", this.handleScroll);

        // TODO:Foolproof maken
        let extraStory = {};
        extraStory.id = 1000;
        extraStory.imageUrl = dataJSON.imageUrl;
        extraStory.language = {};
        extraStory.subtitle = "";
        extraStory.text = dataJSON.translations[0].name;
        extraStory.title = "";
        extraStory.type = 'title';
        dataJSON.stories.unshift(extraStory);

        if(dataJSON.status === 404){
            this.props.history.push({
                pathname : `/choose-painting`,
                state:{notFound : true, paintingNumber : this.props.match.params.id}
            });
            window.location.reload();
        }        
        else if(dataJSON.translations.length !== 0)
            await this.setState({data : dataJSON, loading : false, currentStoryIndex : 0, availableLanguages : []});    
        else {
            let languages = await Api.getAvailableLanguages();
            await this.setState({data : dataJSON, loading : false, currentStoryIndex : 0, availableLanguages : languages});
            this.addLanguages();
        }
    }

    componentWillUnmount() {
        window.removeEventListener("scroll", this.handleScroll);
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
        let line;
        for(let i =0; i < this.state.availableLanguages.length; i++){
            let lan = document.createElement("td");
            lan.onclick = ()=>{
                this.selectLanguage(this.state.availableLanguages[i].code);
            }
            lan.id = `${localStorage.getItem("preferred-language")}-missing-${this.state.availableLanguages[i].code}`;
            lan.className = 'select-fallback-language';
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

    handleScroll(){
        let navbar = document.getElementById("navbar");
        const currentScrollTop = window.pageYOffset;

        // Navigation
        if (!this.state.hidden && currentScrollTop >= this.lastScrollTop) {
            this.setState({ hidden: true });
        } else if (this.state.hidden && currentScrollTop < this.lastScrollTop) {
            this.setState({ hidden: false });
        }

        // Scroll button totop
        if( currentScrollTop > 200 ){
            this.setState({ buttonHidden: true });
        } else {
            this.setState({ buttonHidden: false });
        }
        this.lastScrollTop = currentScrollTop;
    };

    render(){
        if(this.state.loading)
            return(
                <div className='sweet-loading'>
                    <ClipLoader
                        css={override}
                        sizeUnit={"px"}
                        size={100}
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
                            <a href="#" class="select-fallback-language">Not available</a>
                        </div>
                    </div>
                );

        if(!this.state.loading)
            return(
            <div className="" id="totop">
                <nav id="navbar" className={`navbar sticky-top navbar-expand navbar-light bg-light ${(this.state.hidden ? styles.navBackgroundHide : styles.navBackground)}`}>
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
                                <a className="nav-link" id="DescriptionLink" href={`#Description-${this.props.match.params.id}`}>{Translation.Translate("schilderij")}</a>
                            </li>
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
                    {/* { this.state.data.stories.length !== 0 */}
                        {/* ?    */}
                        <div className={`${styles.aliceContainer}`}>
                                <AliceCarousel 
                                    autoPlay={false} 
                                    mouseDragEnabled 
                                    buttonsDisabled={(this.state.data.stories.length>1) ? false : true}
                                    //buttonsDisabled={false}
                                    slideToIndex={this.currentStoryIndex}
                                    swipeDisabled={true}
                                    onSlideChanged={this.handleChange}>
                                    {
                                        this.state.data.stories.map(s => <PaintingStory key={s.id} story={s} paintingId={this.props.match.params.id} objectType="painting"></PaintingStory>)
                                    }
                                </AliceCarousel>
                            </div>
                        {/* :   <div className={`${styles.aliceContainer}`}><img src={this.state.data.imageUrl} /></div>
                    } */}
                    
                    <div className={`container ${styles.infocontainer}`}>

                        <div id="Info" className={`${styles.content}`}>
                            <h5 className={styles.title}>Info</h5>
                            <div className={`${styles.line}`}></div>
                            <div className={`col-12 row ${styles.infoSection}`}>
                                <table className={`table table-borderless ${styles.paintDetails}`}>
                                    <tbody>
                                        <tr>
                                            <td>{Translation.Translate("title")}</td>
                                            <td><a id="DescriptionInfoLink" href={`#Description-${this.props.match.params.id}`}>{this.state.data.translations[0].name}</a></td>
                                        </tr>
                                        <tr>
                                            <td>{Translation.Translate("artist")}</td>
                                            <td><a id="ArtistInfoLink" href={`#Artist-${this.props.match.params.id}`}>{`${this.state.data.author.firstName} ${this.state.data.author.lastName}`}</a></td>
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
                                            <td><a id="TechniqueInfoLink" href={`#Technique-${this.props.match.params.id}`}>{this.state.data.technique.translations[0].name}</a></td>
                                        </tr>
                                        <tr>
                                            <td>{Translation.Translate("movement")}</td>
                                            <td><a id="MovementInfoLink" href={`#Movement-${this.props.match.params.id}`}>{this.state.data.movement.translations[0].name}</a></td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>

                        <hr className={styles.separation}></hr>
                        <a id={`Description-${this.props.match.params.id}`} className={styles.anchor}></a>
                        <div id="Artwork" className={styles.content}>
                            { this.state.data.translations.length !== 0
                                ?   <InfoSection type="artwork" sourceLink={this.state.data.translations[0].sourceLink} storyTitle={Translation.Translate("aboutArtwork")} content={this.state.data.translations[0].description}></InfoSection>
                                :   <LanguageSection type="artist"storyTitle={Translation.Translate("aboutArtwork")}></LanguageSection>
                            }
                        </div>

                        <hr className={styles.separation}></hr>
                        <a id={`Artist-${this.props.match.params.id}`} className={styles.anchor}></a>
                        <div className={styles.content}>
                            { this.state.data.author.translations.length !== 0
                                ?   <InfoSection type="artist" sourceLink={this.state.data.author.translations[0].sourceLink} storyTitle={`${this.state.data.author.firstName} ${this.state.data.author.lastName}`} content={this.state.data.author.translations[0].description}></InfoSection>
                                :   <LanguageSection type="artist"storyTitle={`${this.state.data.author.firstName} ${this.state.data.author.lastName}`}></LanguageSection>
                            }
                        </div>

                        <hr className={styles.separation}></hr>
                        <a id={`Movement-${this.props.match.params.id}`} className={styles.anchor}></a>
                        <div className={styles.content}>
                            { this.state.data.technique.translations.length !== 0
                                ?   <InfoSection type="movement" sourceLink={this.state.data.movement.translations[0].sourceLink} storyTitle={this.state.data.movement.translations[0].name} content={this.state.data.movement.translations[0].description}></InfoSection>
                                :   <LanguageSection type="artist"storyTitle={Translation.Translate("movement")}></LanguageSection>
                            }
                        </div>

                        <hr className={styles.separation}></hr>
                        <a id={`Technique-${this.props.match.params.id}`} className={styles.anchor}></a>
                        <div className={styles.content}>
                            { this.state.data.technique.translations.length !== 0
                                ?   <InfoSection type="technique" sourceLink={this.state.data.technique.translations[0].sourceLink} storyTitle={this.state.data.technique.translations[0].name} content={this.state.data.technique.translations[0].description}></InfoSection>
                                :   <LanguageSection type="artist"storyTitle={Translation.Translate("technique")}></LanguageSection>
                            }
                        </div>

                        <hr className={styles.separation}></hr>
                        <div className={styles.feedback}>
                            <p>
                                {Translation.Translate("useful")}
                            </p>
                            <a className={styles.positiveFeedback} href={`#positive-${this.props.match.params.id}`}><i className="far fa-smile fa-3x"></i></a>
                            <a className={styles.negativeFeedback} href={`#negative-${this.props.match.params.id}`}><i className="far fa-frown fa-3x"></i></a>
                            <p>{Translation.Translate("thanks")}</p>
                        </div>
                        
                    </div>
               </div>
                <a className={`fas fa-arrow-circle-up fa-3x ${(this.state.buttonHidden ? styles.btnToTop : styles.btnToTopHide)}`} href="#totop"><span>totop</span></a>
                {this.state.data.audios.length > 0 
                    ? <footer className={`fixed-bottom`}><AudioPlayer src={this.state.data.audios[0].audioUrl}/></footer>
                    : null
                }
            </div>
        );
    }
}

export default PaintingDetail;
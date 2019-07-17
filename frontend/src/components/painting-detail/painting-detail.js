import React from 'react';
import { ClipLoader } from 'react-spinners';
import styles from './painting-detail.module.css';
import AliceCarousel from 'react-alice-carousel';
import "react-alice-carousel/lib/alice-carousel.css";
import AudioPlayer from "react-h5-audio-player";
import Api from '../../services/api';
import { css } from '@emotion/core';
import Image from '../../assets/images/story.jpg';
import InfoSection from '../info-section/info-section';
import queryString from 'query-string'
import ReadMore from '../read-more/read-more';
import Translation from '../../services/translation';
import PaintingStory from '../painting-story/painting-story';

const override = css`
    display: block;
    margin: 0 auto;
    border-color: red;
`;

const images = [
    {
        url : "https://via.placeholder.com/500",
        content : "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam euismod metus ut quam tincidunt finibus. Ut purus tortor, semper convallis hendrerit sed, viverra in arcu. Sed aliquam velit nec nunc rhoncus euismod. Ut eget condimentum magna, vitae aliquam velit. Nullam gravida dolor eleifend interdum varius. Nulla fermentum dictum neque, et feugiat ligula fermentum eu. Curabitur a iaculis neque, eu vulputate urna. Donec elit turpis, consequat ut ligula sit amet, congue porta augue. Nulla turpis nunc, tempor in fringilla ac, pulvinar vitae orci. Vestibulum vel iaculis magna. Morbi in orci vitae justo porta pretium vel sed dui. Sed lobortis tellus et sapien pretium, eu maximus lorem imperdiet. Ut ut diam dolor. Duis nec turpis massa.",
        storyTitle : "Baroque 0"
    },
    {
        url : "https://via.placeholder.com/500",
        content : "This is the content of the card 1",
        storyTitle : "Baroque 1"
    },
    {
        url : "https://via.placeholder.com/500",
        content : "This is the content of the card 2",
        storyTitle : "Baroque 2"
    }
];

class PaintingDetail extends React.Component{

    constructor(props){
        super(props);

        this.state = {
            loading : true,
            data : null,
            currentStoryIndex : 0
        };
        this.goBackToSelection = this.goBackToSelection.bind(this);
        this.changeLanguage = this.changeLanguage.bind(this);
    }

    async componentWillMount(){
        let dataJSON = await Api.getPaintingDetail(this.props.match.params.id, queryString.parse(this.props.location.search).language);
        if(dataJSON.status === 404){
            this.props.history.push({
                pathname : `/choose-painting?language=${queryString.parse(this.props.location.search).language}`,
                state:{notFound : true}
            });
            window.location.reload();
        }
        else
            await this.setState({data : dataJSON, loading : false, currentStoryIndex : 0});
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
        this.props.history.push(`/choose-painting?language=${queryString.parse(this.props.location.search).language}`);
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
                    <div className={`container ${styles.missingLanguage}`}>
                        <span>{Translation.Translate("missingLanguage")}</span>
                        <div>
                            <button onClick={() => this.changeLanguage(true)} className={styles.changeLanguage}>{Translation.Translate("changeLanguage")}</button>
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
                    <div className="collapse navbar-collapse" id="navbarNav">
                        <ul className="navbar-nav">
                            <li className="nav-item" onClick={this.goBackToSelection}>
                                <i className="material-icons">&#xe5cb;</i>
                            </li>
                        </ul>
                        <ul className="navbar-nav mx-auto">
                            <li className="nav-item ">
                                <a className="nav-link" id="ArtistLink" href="#Artist">{Translation.Translate("artist")}</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" id="MovementLink" href="#Movement">{Translation.Translate("movement")}</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" id="TechniqueLink" href="#Technique">{Translation.Translate("technique")}</a>
                            </li>
                        </ul>
                        <ul className="navbar-nav ml-auto">
                            <li className="nav-item" onClick={()=>this.changeLanguage(false)}>
                                <i className="material-icons">&#xe8e2;</i>
                            </li>
                        </ul>
                    </div>
                </nav>

                <div className={styles.body}>
                    <div>
                        <AliceCarousel mouseDragEnabled buttonsDisabled={true} onSlideChanged={this.handleChange}>
                            {
                                // images.map(i => <img id={`img-fact-${i.storyTitle}`} key={i.url} src={Image} onDragStart={this.handleOnDragStart} className="img-fluid"></img>)
                                images.map(i => <PaintingStory></PaintingStory>)
                            }
                        </AliceCarousel>
                    </div>

                    <div className="container">
                        <hr id="Artist"></hr>

                        <div className={styles.content}>
                            <InfoSection maxLength={150} storyTitle={`${this.state.data.author.firstName} ${this.state.data.author.lastName}`} content={this.state.data.author.translations[0].description}></InfoSection>
                        </div>

                        <hr id="Movement"></hr>

                        <div className={styles.content}>
                            <InfoSection storyTitle={this.state.data.movement.translations[0].name} content={this.state.data.movement.translations[0].description}></InfoSection>
                        </div>

                        <hr id="Technique"></hr>

                        <div className={styles.content}>
                            <InfoSection storyTitle={this.state.data.technique.translations[0].name} content={this.state.data.technique.translations[0].description}></InfoSection>
                        </div>

                        <hr></hr>

                        <div id="Artwork" className={styles.content}>
                            <InfoSection storyTitle="About the artwork" content={this.state.data.translations[0].description}></InfoSection>
                        </div>

                        <hr></hr>

                        <div id="Info" className={`${styles.content}`}>
                            <h5 className={styles.title}>Info</h5>
                            <div className={`row ${styles.infoSection}`}>
                                <div className={`col-1 ${styles.line}`}></div>
                                <div className="col">
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
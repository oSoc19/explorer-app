import React from 'react';
import { ClipLoader } from 'react-spinners';
import styles from './painting-detail.module.css';
import AliceCarousel from 'react-alice-carousel';
import "react-alice-carousel/lib/alice-carousel.css";
import AudioPlayer from "react-h5-audio-player";
import Api from '../../services/api';
import { css } from '@emotion/core';
import Image from '../../assets/images/story.jpg';
import ChoosePaiting from '../choose-painting/choose-painting';
import InfoSection from '../info-section/info-section';

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

const TESTURL = "https://en.wikipedia.org/w/api.php?prop=imageinfo&format=json&action=query&titles=File:Portret van Fovin de Hasque, circa 1669 - circa 1670, Groeningemuseum, 0040728000.jpg&iiprop=url&origin=*";
const AUDIO = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/48641ebd9e794a7a8fb2f579990e4af155eea4585d12466591e87f3fd3d5dd99/browse.mp3";
const sampleText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam euismod metus ut quam tincidunt finibus. Ut purus tortor, semper convallis hendrerit sed, viverra in arcu. Sed aliquam velit nec nunc rhoncus euismod. Ut eget condimentum magna, vitae aliquam velit. Nullam gravida dolor eleifend interdum varius. Nulla fermentum dictum neque, et feugiat ligula fermentum eu. Curabitur a iaculis neque, eu vulputate urna. Donec elit turpis, consequat ut ligula sit amet, congue porta augue. Nulla turpis nunc, tempor in fringilla ac, pulvinar vitae orci. Vestibulum vel iaculis magna. Morbi in orci vitae justo porta pretium vel sed dui. Sed lobortis tellus et sapien pretium, eu maximus lorem imperdiet. Ut ut diam dolor. Duis nec turpis massa.";

class PaintingDetail extends React.Component{

    constructor(props){
        super(props);

        this.state = {
            loading : true,
            data : null,
            currentStoryIndex : 0
        };
    }

    async componentWillMount(){
        let dataJSON = await Api.getPaintingDetail(this.props.match.params.id);
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

    render(){
        if(!this.state.loading && this.state.data.status === 404)
            return (
                <ChoosePaiting></ChoosePaiting>
            );

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

        if(!this.state.loading)
            return(
            <div className="">
                <nav className={`navbar sticky-top navbar-expand navbar-light bg-light ${styles.navBackground}`}>
                    <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className="collapse navbar-collapse" id="navbarNav">
                        <ul className="navbar-nav mx-auto">
                            <li className="nav-item ">
                                <a className="nav-link" id="ArtistLink" href="#Artist">Artist</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" id="MovementLink" href="#Movement">Movement</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" id="TechniqueLink" href="#Technique">Technique</a>
                            </li>
                            {/* <li className="nav-item">
                                <img src="https://img.icons8.com/metro/26/000000/google-translate.png"></img>
                            </li> */}
                        </ul>
                    </div>
                </nav>

                <div className={styles.body}>
                    <div>
                        <AliceCarousel mouseDragEnabled buttonsDisabled={true} onSlideChanged={this.handleChange}>
                            {images.map(i => <img id={`img-fact-${i.storyTitle}`} key={i.url} src={Image} onDragStart={this.handleOnDragStart} className="img-fluid"></img>)}
                        </AliceCarousel>
                    </div>

                    <div className="container">
                        <div id="Artist" className={styles.content}>
                            <InfoSection storyTitle={images[this.state.currentStoryIndex].storyTitle} content={images[this.state.currentStoryIndex].content}></InfoSection>
                        </div>

                        <hr></hr>

                        <div id="Artwork" className={styles.content}>
                            <InfoSection storyTitle={images[this.state.currentStoryIndex].storyTitle} content={images[this.state.currentStoryIndex].content}></InfoSection>
                        </div>

                        <hr></hr>

                        <div id="Technique" className={styles.content}>
                            <InfoSection storyTitle={images[this.state.currentStoryIndex].storyTitle} content={images[this.state.currentStoryIndex].content}></InfoSection>
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
                                                <td>Artist</td>
                                                <td>Artist infos</td>
                                            </tr>
                                            <tr>
                                                <td>Year</td>
                                                <td>XXX</td>
                                            </tr>
                                            <tr>
                                                <td>Size</td>
                                                <td>300 x 400 cm</td>
                                            </tr>
                                            <tr>
                                                <td>Technique</td>
                                                <td>Oil painting</td>
                                            </tr>
                                            <tr>
                                                <td>Movement</td>
                                                <td>Baroque</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
               </div>
                <footer className={`fixed-bottom`}>
                    <AudioPlayer
                            src={AUDIO}
                    />
               </footer>
            </div>
        );
    }
}

export default PaintingDetail;
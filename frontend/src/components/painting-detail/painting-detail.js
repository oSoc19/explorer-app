import React from 'react';
import { ClipLoader } from 'react-spinners';
import styles from './painting-detail.module.css';
import AliceCarousel from 'react-alice-carousel';
import "react-alice-carousel/lib/alice-carousel.css";
import AudioPlayer from "react-h5-audio-player";
import ReadMoreAndLess from 'react-read-more-less';
import ReadMore from '../read-more/read-more';

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

class PaintingDetail extends React.Component{

    constructor(props){
        super(props);

        this.state = {
            loading : false,
            data : 'null',
            currentStoryIndex : 0
        };
    }

    async getImage(){
        const headers = {
            'Access-Control-Allow-Origin' : '*',
            'Content-Type' : 'application/json',
            'Origin' : '*'
        };
        const proxyurl = "https://cors-anywhere.herokuapp.com/";
        let response = await fetch(proxyurl + TESTURL, {headers : headers});
        let dataJSON = await response.json();
        await this.setState({data : dataJSON, loading : false, currentStoryIndex : 0});
    }

    componentWillMount(){
        this.getImage();
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
        return(
            this.state.loading ?
            <div className='sweet-loading'>
                <ClipLoader
                    css={styles.override}
                    sizeUnit={"px"}
                    size={100}
                    color={'#787B7D'}
                    loading={this.state.loading}
                />
            </div>  
            
            :

            <div className="container">
                <div id="Stories"></div>
                <nav className="navbar sticky-top navbar-expand navbar-light bg-light">
                    <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className="collapse navbar-collapse" id="navbarNav">
                        <ul className="navbar-nav mx-auto">
                            <li className="nav-item ">
                                <a className="nav-link" href="#Stories">Short story</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#Artwork">The artwork</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#Infos">Info</a>
                            </li>
                        </ul>
                    </div>
                </nav>

                <div className={styles.body}>
                    <div >
                        <AliceCarousel mouseDragEnabled buttonsDisabled={true} onSlideChanged={this.handleChange}>
                            {images.map(i => <img key={i.url} src={i.url} onDragStart={this.handleOnDragStart} className="img-fluid"></img>)}
                        </AliceCarousel>
                    </div>

                    <div id="StoryInfo" className={styles.content}>
                        <ReadMore obj={images[this.state.currentStoryIndex]} maxLength={150}></ReadMore>
                    </div>

                    <div id="Artwork" className={styles.content}>
                        <h5 className={styles.title}>About the artwork</h5>
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam euismod metus ut quam tincidunt finibus. Ut purus tortor, semper convallis hendrerit sed, viverra in arcu. Sed aliquam velit nec nunc rhoncus euismod. Ut eget condimentum magna, vitae aliquam velit. Nullam gravida dolor eleifend interdum varius. Nulla fermentum dictum neque, et feugiat ligula fermentum eu. Curabitur a iaculis neque, eu vulputate urna. Donec elit turpis, consequat ut ligula sit amet, congue porta augue. Nulla turpis nunc, tempor in fringilla ac, pulvinar vitae orci. Vestibulum vel iaculis magna. Morbi in orci vitae justo porta pretium vel sed dui. Sed lobortis tellus et sapien pretium, eu maximus lorem imperdiet. Ut ut diam dolor. Duis nec turpis massa.
                    </div>

                    <div id="Infos" className={styles.content}>
                        <h5 className={styles.title}>Info</h5>
                        <table className={`table table-borderless ${styles.paintDetails}`}>
                            <tbody>
                                <tr>
                                    <td>Genre</td>
                                    <td>Portait</td>
                                </tr>
                                <tr>
                                    <td>Movement</td>
                                    <td>Barok</td>
                                </tr>
                                <tr>
                                    <td>Size</td>
                                    <td>300 x 400 cm</td>
                                </tr>
                                <tr>
                                    <td>Technique</td>
                                    <td>Oil painting</td>
                                </tr>

                            </tbody>
                        </table>
                    </div>
               </div>
               <footer className={`fixed-bottom`}>
                    <div className="container">
                        <AudioPlayer
                                src={AUDIO}
                                className={styles.AudioPlayer}
                        />
                    </div>
               </footer>
            </div>

            // <div className="container">
            //     <div className="row">
            //         <div className="col-sm">
            //             <img className={`img-fluid ${styles.imageSize}`} src="https://via.placeholder.com/500" alt="Placeholder"/>
            //         </div>
            //         <div className="col-sm">
            //             <div className="container">
            //                 <div className={`row ${styles.paintTitle}`}>Portret van Fovin de Hasque</div>
            //                 <div className={`row ${styles.paintArtist}`}>Jakob van Oost</div>
            //             </div>
            //             <div className={`container ${styles.paintDescription}`}>
            //                 Portret van Fovin de Hasque (Jacob I van Oost, circa 1669 - circa 1670); collection: Musea Brugge - Groeningemuseum
            //             </div>
            //         </div>
            //     </div>
            //     <div className="row">
            //         <div className="col-sm">
            //             <div className={`container ${styles.paintDetailsContainer}`}>
            //                 <div className="container">
            //                     <div className="row">
            //                         Details
            //                     </div>
            //                 </div>
                        //     <table className={`table table-borderless ${styles.paintDetails}`}>
                        //         <tbody>
                        //             <tr>
                        //                 <td>Title</td>
                        //                 <td>Portret van Fovin de Hasque</td>
                        //             </tr>
                        //             <tr>
                        //                 <td>Author</td>
                        //                 <td>Jakob van Oost</td>
                        //             </tr>
                        //             <tr>
                        //                 <td>Date</td>
                        //                 <td>Between circa 1669 and circa 1670</td>
                        //             </tr>
                        //             <tr>
                        //                 <td>Place</td>
                        //                 <td>Brugge</td>
                        //             </tr>
                        //             <tr>
                        //                 <td>Size</td>
                        //                 <td>Height: 106 cm (41.7 ″); Width: 83 cm (32.6 ″)</td>
                        //             </tr>
                        //             <tr>
                        //                 <td>Category</td>
                        //                 <td>Portrait</td>
                        //             </tr>
                        //             <tr>
                        //                 <td>Owner</td>
                        //                 <td>Groeningemuseum</td>
                        //             </tr>
                        //         </tbody>
                        //     </table>
                        // </div>
            //         </div>
            //         <div className="col-sm">
            //             <div className={`container ${styles.tagsContainer}`}>
            //                 <p className="">Tags</p>
            //                <div className="container">

            //                </div>
            //            </div>
            //         </div>
            //     </div>
            // </div>
        );
    }
}

export default PaintingDetail;
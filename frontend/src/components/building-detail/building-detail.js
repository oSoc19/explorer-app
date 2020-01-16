import React from 'react';
import { ClipLoader } from 'react-spinners';
import styles from './building-detail.module.css';
import AliceCarousel from 'react-alice-carousel';
import "react-alice-carousel/lib/alice-carousel.css";
import Api from '../../services/api';
import { css } from '@emotion/core';
import InfoSection from '../info-section/info-section';
import PaintingStory from '../painting-story/painting-story';
import Translation from '../../services/translation';
import ReactNotification from "react-notifications-component";

const override = css`
    border-color: #22A4B4;
    display: block;
    margin: 0 auto;
    position: relative;
    top: 40vh;
`;

class BuildingDetail extends React.Component{

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
            descriptionFlag: true,
            languageFlag: false
        };
        
        this.goBackToSelection = this.goBackToSelection.bind(this);
        this.changeLanguage = this.changeLanguage.bind(this);
        this.addLanguages = this.addLanguages.bind(this);
        this.selectLanguage = this.selectLanguage.bind(this);
        this.handleScroll = this.handleScroll.bind(this);
        this.lastScrollTop = window.pageYOffset;        
        
    }

    async componentWillMount(){
        console.log(localStorage.getItem("language"));
        if( localStorage.getItem("language") === null || localStorage.getItem("language") === "false" ){
            let language = navigator.language || navigator.userLanguage;
            language = language.substring(0, 2).toUpperCase();
            localStorage.setItem("language",language);
            if( language !== "EN" && language !== "NL" && language !== "FR" ){
                localStorage.setItem("language","EN");
            }
        }

        let dataJSON = await Api.getBuildingDetail(this.props.match.params.id, localStorage.getItem("language"));
        window.addEventListener("scroll", this.handleScroll);

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
                previousUrl : `buildings/detail/${this.props.match.params.id}`,
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
            lan.id = `${localStorage.getItem("language")}-missing-${this.state.availableLanguages[i].code}`;
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
        this.props.history.push(`/buildings/detail/${this.props.match.params.id}`);
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
            <div className="" id="totop">
                {/* <nav id="navbar" className={`navbar sticky-top navbar-expand navbar-light bg-light ${(this.state.hidden ? styles.navBackgroundHide : styles.navBackground)}`}>
                    <span className={styles.backButton} onClick={this.goBackToSelection}>
                        <i className={styles.materialIcon}>&#xe5cb;</i>
                    </span>
                    <div className="col align-self-top bruggeLogo">
                        <img alt="Brugge logo" src={Logo} ></img>
                    </div>
                </nav> */}
                
                {/* <nav id="navbar" className={`navbar sticky-top navbar-expand navbar-light bg-light ${(this.state.hidden ? styles.navBackgroundHide : styles.navBackground)}`}>
                    <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className={`collapse navbar-collapse ${styles.fontColor}`} id="navbarNav">
                        <ul className="navbar-nav">
                            
                        </ul>
                        {<ul className="navbar-nav mx-auto">
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
                        </ul>}
                    </div>
                </nav> */}
                <div className={styles.body}>

                    { this.state.data.stories.length !== 0
                        ?   <div className={`${styles.aliceContainer}`}>
                                <AliceCarousel 
                                    autoPlay={false} 
                                    mouseDragEnabled 
                                    buttonsDisabled={false}
                                    slideToIndex={this.currentStoryIndex}
                                    swipeDisabled={true}
                                    onSlideChanged={this.handleChange}>
                                    {
                                        this.state.data.stories.map(s => <PaintingStory key={s.id} story={s} paintingId={this.props.match.params.id} objectType="building"></PaintingStory>)
                                    }
                                </AliceCarousel>
                            </div>
                        :   null
                    }

                    <div className="container info-container">
                        {/* <div id="Info" className={`${styles.content}`}>
                            <h5 className={styles.title}>{this.state.data.translations[0].name}</h5>
                            <div className={styles.line}></div>
                            <div className={`row ${styles.infoSection}`}>
                                <div className="col-12">
                                    <table className={`table table-borderless ${styles.paintDetails}`}>
                                        <tbody>
                                            <tr>
                                                <td>{Translation.Translate("constructionyear")}</td>
                                                <td>{this.state.data.year}</td>
                                            </tr>
                                            <tr>
                                                <td>{Translation.Translate("movement")}</td>
                                                <td>{this.state.data.movement.translations[0].name}</td>
                                            </tr>
                                            <tr>
                                                <td>{Translation.Translate("use")}</td>
                                                <td>{this.state.data.use.translations[0].name}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        
                        <hr className={styles.separation}></hr> */}
                        { this.state.data.translations[0].description
                            ?   <div id={`Description-${this.props.match.params.id}`} className={styles.content}>
                                    <InfoSection type="artwork" sourceLink={this.state.data.translations[0].sourceLink} storyTitle={this.state.data.translations[0].name} content={this.state.data.translations[0].description}></InfoSection>
                                </div>
                            :   <div id="Description" className={styles.content}>
                                    {Translation.Translate("missingLanguage")}
                                </div>
                        }

                        { this.state.data.id !== 6 && this.state.data.id !== 1
                            ?   <div id={`Movement-${this.props.match.params.id}`} className={styles.content}>
                                    <hr className={styles.separation}></hr>
                                    <InfoSection  type="movement" sourceLink={this.state.data.movement.translations[0].sourceLink} storyTitle={this.state.data.movement.translations[0].name} content={this.state.data.movement.translations[0].description}></InfoSection>
                                </div>
                            :   <div id="Movement" className={styles.content}></div>
                        }

                        { this.state.data.author.id !== 1
                            ?   <div id={`Author-${this.props.match.params.id}`} className={styles.content}>
                                    <hr className={styles.separation}></hr>
                                    <InfoSection type="author" sourceLink={this.state.data.author.translations[0].sourceLink} storyTitle={this.state.data.author.firstName + ' ' + this.state.data.author.lastName} content={this.state.data.author.translations[0].description}></InfoSection>
                                </div>
                            :   <div id="Author" className={styles.content}></div>
                        }

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
            </div>
        );

        return null;

    }
}

export default BuildingDetail;
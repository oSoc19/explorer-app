import React from 'react';
import styles from './painting-story.module.css';
import Translation from '../../services/translation';
import PinchZoomPan from "react-responsive-pinch-zoom-pan";

class PaintingStory extends React.Component{

    constructor(props){
        super(props);

        this.renderLink = this.renderLink.bind(this);
        this.renderZoom = this.renderZoom.bind(this);
        this.backgroundImage = {
            backgroundImage: "url(" + this.props.story.imageUrl + ")"
        };
        this.emptyBackgroundImage = {
            backgroundImage: 'url(https://upload.wikimedia.org/wikipedia/commons/a/a9/Jacob_van_Oost_-_The_calling_of_St_Matthew.jpg)'
        };
          
        
    }

    renderLink(param) {

        switch(param) {
            case 'technique':
            case 'tecnique':
                return (<a class="technique" href={`#Technique-${this.props.paintingId}`} id={styles.storyLink}>{Translation.Translate("learnMore")}</a>)
            case 'style':
            case 'sttle':
                return (<a class="movement" href={`#Movement-${this.props.paintingId}`} id={styles.storyLink}>{Translation.Translate("learnMore")}</a>)
            case 'artwork':
                return (<a class="description" href={`#Description-${this.props.paintingId}`} id={styles.storyLink}>{Translation.Translate("learnMore")}</a>)
            case 'artist':
                return (<a class="artist" href={`#Artist--${this.props.paintingId}`} id={styles.storyLink}>{Translation.Translate("learnMore")}</a>)
            case 'title':
                return null;
            default:
                return param;
        }
    }

    renderZoom(param) {
        return <div>
        { param == 'painting'
            ? <img className={`${styles.imgFluid}`} src={`${this.props.story.imageUrl}`}/>
            : (<PinchZoomPan initialScale="1" zoomButtons={false}><img alt="Loading" className={`${styles.imgFluid}`} src={`${this.props.story.imageUrl}`}/></PinchZoomPan>)
        }
        </div>;
    }

    renderBackgroundImage(param){
        return {
            backgroundImage: "url(" + { param } + ")"
        }
    }


    render(){
        return (
            <div className={styles.container}>
                <div className={styles.containerBackground} style={(this.props.story.imageUrl !== null && this.props.story.imageUrl !== "") ? this.backgroundImage : this.emptyBackgroundImage}></div>
                <div>
                    { this.props.story.imageUrl !== null && this.props.story.imageUrl.trim() !== ""
                        ?   this.renderZoom(this.props.objectType)
                        :   null
                    }
                    <div className={`${styles.text}`}>
                        <div className={styles.content}>
                            <h5 id={styles.story}>{this.props.story.text}</h5>
                            <hr className={styles.storyLine}></hr>
                            {this.renderLink(this.props.story.type)}
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}

export default PaintingStory;
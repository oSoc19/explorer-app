import React from 'react';
import styles from './painting-story.module.css';
import Translation from '../../services/translation';
import PinchZoomPan from "react-responsive-pinch-zoom-pan";

class PaintingStory extends React.Component{

    constructor(props){
        super(props);

        this.renderLink = this.renderLink.bind(this);
        this.renderZoom = this.renderZoom.bind(this);
        
    }

    renderLink(param) {

        switch(param) {
            case 'technique':
            case 'tecnique':
                return (<a href={`#Technique-${this.props.paintingId}`} id={styles.storyLink}>{Translation.Translate("learnMore")}</a>)
            case 'style':
            case 'sttle':
                return (<a href={`#Movement-${this.props.paintingId}`} id={styles.storyLink}>{Translation.Translate("learnMore")}</a>)
            case 'artwork':
                return (<a href={`#Description-${this.props.paintingId}`} id={styles.storyLink}>{Translation.Translate("learnMore")}</a>)
            case 'artist':
                return (<a href={`#Artist--${this.props.paintingId}`} id={styles.storyLink}>{Translation.Translate("learnMore")}</a>)
            default:
                return param;
        }
    }

    renderZoom(param) {
        return <div>
        { param == 'painting'
            ? <img alt="Story" className={`${styles.imgFluid}`} src={`${this.props.story.imageUrl}`}/>
            : (<PinchZoomPan initialScale="1" zoomButtons={false}><img alt="Story" className={`${styles.imgFluid}`} src={`${this.props.story.imageUrl}`}/></PinchZoomPan>)
        }
        </div>;
    }


    render(){
        return (
            <div className={styles.container}>
                <div className="img-fluid">
                    { this.props.story.imageUrl !== 0 && this.props.story.imageUrl.trim() !== ""
                        ?   this.renderZoom(this.props.objectType)
                        :   null
                    }
                    <div className={`${styles.text}`}>
                        <div className={styles.content}>
                            <h5 id={styles.story}>
                                {this.props.story.text}
                            </h5>
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
import React from 'react';
import styles from './painting-story.module.css';

const BASE_URL = process.env.NODE_ENV === 'development' ? "https://localhost:5001":"https://api.story-api.be";

class PaitingStory extends React.Component{

    render(){
        return (
            <div className={styles.container}>
                <div className="img-fluid">
                    <img className="img-fluid" src={`${this.props.story.imageUrl}`}/>
                    <div className={`${styles.text}`}>
                        <div className={styles.content}>
                            <span id={styles.movement}>{this.props.story.title.toUpperCase()}</span>
                            <hr></hr>
                            <span id={styles.technique}>{this.props.story.subtitle}</span>
                            <div id={styles.story}>
                                {this.props.story.text}
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}

export default PaitingStory;
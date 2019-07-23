import React from 'react';
import styles from './painting-story.module.css';

class PaitingStory extends React.Component{

    render(){
        return (
            <div className={styles.container}>
                <div className="img-fluid">
                    <img alt="Story" className="img-fluid" src={`${this.props.story.imageUrl}`}/>
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
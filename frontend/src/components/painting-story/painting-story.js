import React from 'react';
import styles from './painting-story.module.css';

class PaintingStory extends React.Component{

    render(){
        return (
            <div className={styles.container}>
                <div className="img-fluid">
                    { this.props.story.imageUrl !== 0
                        ?   <img alt="Story" className={`${styles.imgFluid}`} src={`${this.props.story.imageUrl}`}/>
                        :   null
                    }
                    <div className={`${styles.text}`}>
                        <div className={styles.content}>
                            <h5 id={styles.story}>
                                {this.props.story.text}
                            </h5>
                            <hr className={styles.storyLine}></hr>
                            <a href="#" id={styles.technique}>{this.props.story.subtitle}</a>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}

export default PaintingStory;
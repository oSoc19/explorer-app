import React from 'react';
import styles from './painting-story.module.css';
import PlaceHolder from '../../assets/images/story.jpg';

class PaitingStory extends React.Component{
    render(){
        return (
            <div className={styles.container}>
                <img className="img-fluid" src={PlaceHolder}/>
                {/* <div className={styles.text}>
                    <div className={styles.content}>
                        <span id={styles.movement}>Baroque</span>
                        <hr></hr>
                        <span id={styles.technique}>Oil painting</span>
                        <div id={styles.story}>
                        "The painter used raw brush strokes to paint the leaves on the trees, not every leave separately"
                        </div>
                    </div>
                </div> */}
            </div>
        );
    }
}

export default PaitingStory;
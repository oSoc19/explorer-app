import React from 'react';
import styles from './painting-story.module.css';
import PlaceHolder from '../../assets/images/story.jpg';

class PaitingStory extends React.Component{
    render(){
        return (
            <div className={styles.container}>
                <img className="img-fluid" src={PlaceHolder}/>
                {/* <div className={styles.text}>This is a sample text on a placeholder</div> */}
            </div>
        );
    }
}

export default PaitingStory;
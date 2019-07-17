import React from 'react';
import styles from './painting-story.module.css';

class PaitingStory extends React.Component{
    render(){
        return (
            <div className={styles.container}>
                <img className="img-fluid" src="https://via.placeholder.com/375x609"/>
                <div className={styles.text}>This is a sample text on a placeholder</div>
            </div>
        );
    }
}

export default PaitingStory;
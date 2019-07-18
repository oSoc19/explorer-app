import React from 'react';
import styles from './info-section.module.css';

class InfoSection extends React.Component{

    constructor(props){
        super(props);
    }


    render(){
        return (
            <div>
                <h5 className={styles.title}>{this.props.storyTitle}</h5>
                <div className={`row ${styles.content}`}>
                    <div className={`col-1 ${styles.line}`}></div>
                    <div className="col-10">
                        {this.props.content}
                        <br></br>
                        <a href={this.props.sourceLink}>{this.props.sourceLink}</a>
                    </div>
                </div>
            </div>
        );
    }
}

export default InfoSection;
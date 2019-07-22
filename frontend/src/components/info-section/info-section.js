import React from 'react';
import styles from './info-section.module.css';
import Translation from '../../services/translation';

class InfoSection extends React.Component{

    constructor(props){
        super(props);
    }


    render(){
        return (
            <div>
                <h5 className={styles.title}>{this.props.storyTitle}</h5>
                <div className={`row ${styles.content}`}>
                    <div className={`col-2`}>
                        <div className={`${styles.line}`}></div>
                    </div>
                    <div className={`col-10 ${styles.infos}`}>
                        {this.props.content}
                        <br></br>
                        <a className={`${styles.link} link-to-${this.props.type}`} href={this.props.sourceLink} target="_blank">{Translation.Translate("learnMore")}</a>
                    </div>
                </div>
            </div>
        );
    }
}

export default InfoSection;
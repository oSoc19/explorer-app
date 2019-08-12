import React from 'react';
import styles from './language-section.module.css';
import Translation from '../../services/translation';

class InfoSection extends React.Component{
    render(){
        return (
            <div>
                <h5 className={styles.title}>{this.props.storyTitle}</h5>
                <div className={`${styles.line}`}></div>
                <div className={`row ${styles.content}`}>
                    <div className={`col-12 ${styles.infos}`}>
                        <p>{Translation.Translate("missingLanguage")}</p>
                    </div>
                </div>
            </div>
        );
    }
}

export default InfoSection;
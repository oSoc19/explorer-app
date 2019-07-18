import React from 'react';
import Logo from '../../assets/images/logo_brugge.svg';
import styles from './choose-language.module.css';
import ReactNotification from "react-notifications-component";
import "react-notifications-component/dist/theme.css";
import Api from '../../services/api';
import {Link} from 'react-router-dom';

const PAINTING_SELECTION_PAGE = "/choose-painting";

class ChooseLanguage extends React.Component{

    constructor(props){
        super(props);
        this.state = {
            language : undefined,
            languages : []
        };

        this.notificationDOMRef = React.createRef();
        this.selectLanguage = this.selectLanguage.bind(this);
    }

    async componentWillMount(){
        if(this.props.location.state !== undefined && this.props.location.state.isLanguageMissing){
            let languages = await Api.getAvailableLanguages();
            await this.setState({
                language : undefined,
                languages : languages
            });
        }
    }

    selectLanguage(language){
        this.props.history.push(`/${this.props.location.state === undefined? 'choose-painting' : this.props.location.state.previousUrl}?language=${language}`);
    }

    renderAllLanguages(){
        return(
            <tbody>
                <tr>
                    <td id='EN' className="selectableLanguage" onClick={()=>this.selectLanguage('EN')}>
                        English
                    </td>
                    <td id='DE' className="selectableLanguage" onClick={()=>this.selectLanguage('DE')}>German</td>
                </tr>
                <tr>
                    <td id='NL' className="selectableLanguage" onClick={()=>this.selectLanguage('NL')}>Nederlands</td>
                    <td id='ES' className="selectableLanguage" onClick={()=>this.selectLanguage('ES')}>Espanol</td>
                </tr>
                <tr>
                    <td id='FR' className="selectableLanguage" onClick={()=>this.selectLanguage('FR')}>Français</td>
                    <td id='IT' className="selectableLanguage" onClick={()=>this.selectLanguage('IT')}>Italiano</td>
                </tr>
                <tr>
                    <td id='JA' className="selectableLanguage" onClick={()=>this.selectLanguage('JA')}>日本の</td>
                    <td id='RU' className="selectableLanguage" onClick={()=>this.selectLanguage('RU')}>русский</td>
                </tr>
            </tbody>
        );
    }

    render(){
        return(
            <div className="container">
                <ReactNotification ref={this.notificationDOMRef} />
                <div className="row">
                    <div className="col align-self-center bruggeLogo">
                        <img src={Logo} ></img>
                    </div>
                </div>

                <div className="row">
                    <div className="col h-100"></div>
                </div>

                <div className={styles.containerLanguages}>
                    <h6 className={`${styles.title}`}>
                        Select a language
                    </h6>
                    <table className={`table table-borderless align-middle`}>
                        {this.renderAllLanguages()}
                    </table>
                </div>
            </div>
        );
    }
}

export default ChooseLanguage;
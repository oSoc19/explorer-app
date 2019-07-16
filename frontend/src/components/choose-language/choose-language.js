import React from 'react';
import Logo from '../../assets/images/logo_brugge.png';
import styles from './choose-language.module.css';
import ReactNotification from "react-notifications-component";
import "react-notifications-component/dist/theme.css";
import Api from '../../services/api';
import { isFor } from '@babel/types';

class ChooseLanguage extends React.Component{

    constructor(props){
        super(props);
        this.state = {
            language : undefined,
            languages : []
        };

        this.addNotification = this.addNotification.bind(this);
        this.notificationDOMRef = React.createRef();
        this.selectLanguage = this.selectLanguage.bind(this);
        this.assignSelectionAction = this.assignSelectionAction.bind(this);
        this.addLanguages = this.addLanguages.bind(this);
    }

    addNotification() {
        this.notificationDOMRef.current.addNotification({
          message: "Please select a language !",
          type: "warning",
          insert: "top",
          container: "top-center",
          animationIn: ["animated", "fadeIn"],
          animationOut: ["animated", "fadeOut"],
          dismiss: { duration: 2000 },
          dismissable: { click: true }
        });
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

    componentDidMount(){
        this.assignSelectionAction();
    }

    addLanguages(){
        let body = document.getElementById("languages");
        let line;
        for(let i =0; i < this.state.languages.length; i++){
            let lan = document.createElement("td");
            lan.id = this.state.languages[i].code;
            lan.innerHTML = this.state.languages[i].name;
            if(i%2 === 0){
                line = document.createElement("tr");
                body.appendChild(line);
            }
            line.append(lan);
        }
    }

    assignSelectionAction(){
        let languages = document.getElementsByTagName('td');
        for(let i = 0; i < languages.length; i++){
            if(languages[i].dataset.attr === 'selectButton')
                return;
            languages[i].addEventListener('click', ()=>{
                let selectedLanguage = document.getElementsByClassName('selectedLanguage')[0];
                if(selectedLanguage)
                    selectedLanguage.classList.toggle('selectedLanguage');
                languages[i].classList.toggle('selectedLanguage');
                this.setState({language : languages[i].id});
            });
        }
    }

    selectLanguage(){
        let language = document.getElementsByClassName('selectedLanguage')[0];
        if(language){
            this.props.history.push(`/${this.props.location.state === undefined? 'choose-painting' : this.props.location.state.previousUrl}?language=${language.id}`);
        }
    }

    renderAllLanguages(){
        return(
            <tbody>
                <tr>
                    <td id='EN'>English</td>
                    <td id='DE'>German</td>
                </tr>
                <tr>
                    <td id='NL'>Nederlands</td>
                    <td id='ES'>Espanol</td>
                </tr>
                <tr>
                    <td id='FR'>Français</td>
                    <td id='IT'>Italiano</td>
                </tr>
                <tr>
                    <td id='JA'>日本の</td>
                    <td id='RU'>русский</td>
                </tr>
                <tr>
                    <td></td>
                    <td data-attr="selectButton" onClick={this.state.language ? this.selectLanguage : this.addNotification}>
                        <i className="material-icons">&#xe5cc;</i>
                    </td>
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
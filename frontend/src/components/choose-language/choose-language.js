import React from 'react';
import Logo from '../../assets/images/logo_brugge.png';
import styles from './choose-language.module.css';
import ReactNotification from "react-notifications-component";
import "react-notifications-component/dist/theme.css";

class ChooseLanguage extends React.Component{

    constructor(props){
        super(props);
        this.state = {
            language : undefined
        };

        this.addNotification = this.addNotification.bind(this);
        this.notificationDOMRef = React.createRef();
    }

    addNotification() {
        this.notificationDOMRef.current.addNotification({
          message: "Please select a language !",
          type: "warning",
          insert: "top",
          container: "bottom-center",
          animationIn: ["animated", "fadeIn"],
          animationOut: ["animated", "fadeOut"],
          dismiss: { duration: 2000 },
          dismissable: { click: true }
        });
      }

    componentDidMount(){
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

    }

    render(){
        return(
            <div className="container">
                <ReactNotification ref={this.notificationDOMRef} />
                <div className="row">
                    <div className="col align-self-center">
                        <img src={Logo} ></img>
                    </div>
                </div>

                <div className="row">
                    <div className="col h-100"></div>
                </div>

                <h6 className={styles.title}>Select a language</h6>
                <table className="table table-borderless align-middle">
                    <tbody>
                        <tr>
                            <td id='EN'>English</td>
                            <td id='GR'>German</td>
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
                            <td>English</td>
                            <td>German</td>
                        </tr>
                        <tr>
                            <td></td>
                            <td data-attr="selectButton" onClick={this.state.language ? this.selectLanguage : this.addNotification}>
                                <i className="material-icons">&#xe5cc;</i>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        );
    }
}

export default ChooseLanguage;
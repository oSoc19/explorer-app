import React from 'react';
import styles from '../choose-painting/choose-painting.module.css';
import { withRouter } from 'react-router-dom';
import Logo from '../../assets/images/logo_brugge.svg';
import ReactNotification from "react-notifications-component";
import "react-notifications-component/dist/theme.css";
import Translation from '../../services/translation';

class ChoosePainting extends React.Component{

    constructor(props){
        super(props);
        this.state = {
            isEmpty : true,
            error:false,
            errorMessage:null
        };
        this.state.placeholder = Translation.Translate("placeholder");

        this.routeChange = this.routeChange.bind(this);
        this.notificationDOMRef = React.createRef();
        this.removeNumber = this.removeNumber.bind(this);
        this.updateInput = this.updateInput.bind(this);
    }
    
    async componentDidMount(){
        if(this.props.location.state){
            await this.setState({
                isEmpty : true,
                error:true,
                errorMessage:`${Translation.Translate("codeNotFound")} ${this.props.location.state.paintingNumber}, ${Translation.Translate("tryAgain")}`
            });
        }
        document.getElementById("paintingNumber").addEventListener('focus',(evt)=>evt.target.blur());
    }

    async routeChange(event){
        
        if(document.getElementById("paintingNumber").value.length !== 0){
            var infoType = document.getElementById("paintingNumber").value                
            if(infoType.length == 1){
                infoType = 'paintings';
            } else {
                infoType = 'buildings';
            }
            this.props.history.push(`/${infoType}/detail/${document.getElementById("paintingNumber").value}`);
            window.location.reload();
        }
        else{
            await this.setState({
                isEmpty : true,
                error:true,
                errorMessage:`${Translation.Translate("codeMissing")}`
            });
        }
    }

    updateInput(number){
        return () => {
            let input = document.getElementById("paintingNumber").value;
            if(input.length === 0){
                this.setState({isEmpty : false});
            }
            document.getElementById("paintingNumber").value = input+number;
            this.routeChange();
        }
    }

    removeNumber(){
        document.getElementById("paintingNumber").value = document.getElementById("paintingNumber").value.slice(0,-1);
       
        let input = document.getElementById("paintingNumber").value;
        if(input.length === 0){
            this.setState({isEmpty : true});
        }
        
    }

    isInputEmpty(){
        return document.getElementById("paintingNumber").innerHTML === this.state.placeholder;
    }

    render(){
        return (
            <div>
                {
                    this.state.error?
                    <div id="errorMessage" className={styles.errorMessageContainer}>
                        <span className={`container ${styles.errorMessage}`}>{this.state.errorMessage}</span>
                    </div>
                    :<div className="row header"><div className="col align-self-top bruggeLogo"><a href="/"><img alt="Brugge logo" src={Logo} ></img></a><h1><span>www.</span>LearnMore<span>.be</span></h1></div></div>
                }
                
                <div className={styles.choose}>
                    <div className={`${styles.hidden}`}>
                        <label htmlFor="paintingNumber">{Translation.Translate("codeMissing")}</label>
                        <input type="text" id="paintingNumber" className={`${this.state.isEmpty ? styles.spanPlaceholder : styles.spanContent} ${styles.input}`}/>
                    </div>
                    
                    
                    <div className="table-responsive-sm">
                        <table className={`table table-borderless ${styles.chooseTable}`}>
                        <thead>
                            <tr className={`${styles.hidden}`}>
                                <th scope="col"></th>
                                <th scope="col"></th>
                                <th scope="col"></th>
                            </tr>
                        </thead>
                            <tbody>
                                <tr>
                                    <td onClick={this.updateInput('AA')}>
                                        <img className={`${styles.touchImage}`} src="https://upload.wikimedia.org/wikipedia/commons/7/7d/Burg_in_Brugge_-_Belgi%C3%AB.jpg"></img>
                                        <span className={`${styles.touchButton}`}>Burg</span>
                                    </td>
                                    <td onClick={this.updateInput('AB')}>
                                        <span className={`${styles.touchButton}`}>Landhuis</span>
                                    </td>
                                    <td onClick={this.updateInput('AC')}><span className={`${styles.touchButton}`}>Griffie</span></td>
                                </tr>
                                <tr>
                                    <td onClick={this.updateInput('AD')}><span className={`${styles.touchButton}`}>Stadhuis</span></td>
                                    <td onClick={this.updateInput('AE')}><span className={`${styles.touchButton}`}>Basiliek</span></td>
                                    <td onClick={this.updateInput('AF')}><span className={`${styles.touchButton}`}>Steen</span></td>
                                </tr>
                                <tr>
                                    <td onClick={this.updateInput('AG')}><span className={`${styles.touchButton}`}>Proosdij</span></td>
                                    <td onClick={this.updateInput('AH')}><span className={`${styles.touchButton}`}>Kathedraal</span></td>
                                </tr>
                                <tr className={`${styles.hidden}`}>
                                    <td>&nbsp;</td>
                                    <td onClick={this.routeChange} className={`search-button ${this.state.isEmpty ? null : styles.active} ${styles.playButton}`}><i className="fas fa-play-circle fa-3x"></i></td>
                                    <td className={`${styles.backspace}`} onClick={this.removeNumber}>
                                        {!this.state.isEmpty ? <i className="material-icons">&#xe14a;</i> : null}
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        );
    }
}

export default withRouter(ChoosePainting);
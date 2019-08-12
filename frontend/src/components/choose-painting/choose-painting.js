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
        }
    }

    removeNumber(){
        document.getElementById("paintingNumber").value = document.getElementById("paintingNumber").value.slice(0,-1);
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
                    :
                    <img src={Logo} alt="Brugge logo" className="bruggeLogo"></img>
                }
                
                <div className={styles.choose}>
                    <div>
                        <label for="paintingNumber">{Translation.Translate("codeMissing")}</label>
                        <input type="text" id="paintingNumber" className={`${this.state.isEmpty ? styles.spanPlaceholder : styles.spanContent} ${styles.input}`}/>
                    </div>
                    
                    
                    <div className="table-responsive-sm">
                        <table className={`table table-borderless ${styles.chooseTable}`}>
                        <thead>
                            <tr>
                                <th scope="col"></th>
                                <th scope="col"></th>
                                <th scope="col"></th>
                            </tr>
                        </thead>
                            <tbody>
                                <tr>
                                    <td onClick={this.updateInput('A')}><span className={`${styles.touchButton}`}>A</span></td>
                                    <td onClick={this.updateInput('B')}><span className={`${styles.touchButton}`}>B</span></td>
                                    <td onClick={this.updateInput('C')}><span className={`${styles.touchButton}`}>C</span></td>
                                </tr>
                                <tr>
                                    <td onClick={this.updateInput('D')}><span className={`${styles.touchButton}`}>D</span></td>
                                    <td onClick={this.updateInput('E')}><span className={`${styles.touchButton}`}>E</span></td>
                                    <td onClick={this.updateInput('F')}><span className={`${styles.touchButton}`}>F</span></td>
                                </tr>
                                <tr>
                                    <td onClick={this.updateInput('G')}><span className={`${styles.touchButton}`}>G</span></td>
                                    <td onClick={this.updateInput('H')}><span className={`${styles.touchButton}`}>H</span></td>
                                    <td onClick={this.updateInput('I')}><span className={`${styles.touchButton}`}>I</span></td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                    <td onClick={this.routeChange} className={`${this.state.isEmpty ? null : styles.active} ${styles.playButton}`}><i className="fas fa-play-circle fa-3x"></i></td>
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
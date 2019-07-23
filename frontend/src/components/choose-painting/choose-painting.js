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
            this.props.history.push(`/paintings/detail/${document.getElementById("paintingNumber").value}`);
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
                    <input type="text" placeholder={`${Translation.Translate("codeMissing")}`} id="paintingNumber" className={`${this.state.isEmpty ? styles.spanPlaceholder : styles.spanContent} ${styles.input}`}/>
                    <div className="table-responsive-sm">
                        <table className="table table-borderless">
                        <thead>
                            <tr>
                                <th scope="col"></th>
                                <th scope="col"></th>
                                <th scope="col"></th>
                            </tr>
                        </thead>
                            <tbody>
                                <tr>
                                    <td onClick={this.updateInput('A')}>A</td>
                                    <td onClick={this.updateInput('B')}>B</td>
                                    <td onClick={this.updateInput('C')}>C</td>
                                </tr>
                                <tr>
                                    <td onClick={this.updateInput('1')}>1</td>
                                    <td onClick={this.updateInput('2')}>2</td>
                                    <td onClick={this.updateInput('3')}>3</td>
                                </tr>
                                <tr>
                                    <td onClick={this.updateInput('4')}>4</td>
                                    <td onClick={this.updateInput('5')}>5</td>
                                    <td onClick={this.updateInput('6')}>6</td>
                                </tr>
                                <tr>
                                    <td onClick={this.updateInput('7')}>7</td>
                                    <td onClick={this.updateInput('8')}>8</td>
                                    <td onClick={this.updateInput('9')}>9</td>
                                </tr>
                                <tr>
                                    <td onClick={this.removeNumber}><i className="material-icons">&#xe14a;</i></td>
                                    <td onClick={this.updateInput('0')}>0</td>
                                    <td onClick={this.routeChange}><i className="material-icons search">&#xe5cc;</i></td>
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
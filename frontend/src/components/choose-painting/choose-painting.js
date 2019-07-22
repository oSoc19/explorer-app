import React from 'react';
import styles from '../choose-painting/choose-painting.module.css';
import { withRouter } from 'react-router-dom';
import queryString from 'query-string'
import Logo from '../../assets/images/logo_brugge.svg';
import ReactNotification from "react-notifications-component";
import "react-notifications-component/dist/theme.css";
import Translation from '../../services/translation';

class ChoosePainting extends React.Component{

    constructor(props){
        super(props);
        this.state = {
            isEmpty : true,
        };
        this.state.placeholder = Translation.Translate("placeholder");

        this.routeChange = this.routeChange.bind(this);
        this.addNotification = this.addNotification.bind(this);
        this.notificationDOMRef = React.createRef();
        this.removeNumber = this.removeNumber.bind(this);
        this.updateInput = this.updateInput.bind(this);
    }
    
    componentDidMount(){
        if(this.props.location.state !== undefined)
            this.addNotification(`${Translation.Translate("paintingNotFound")} ${this.props.location.state.paintingNumber}, ${Translation.Translate("tryAgain")}`);
        document.getElementById("paintingNumber").addEventListener('focus',(evt)=>evt.target.blur());
    }

    async routeChange(event){
        if(document.getElementById("paintingNumber").innerHTML !== this.state.placeholder){                
            this.props.history.push(`/paintings/detail/${document.getElementById("paintingNumber").value}`);
            window.location.reload();
        }
        else{
            this.addNotification("Enter the painting number")
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

    addNotification(message) {
        this.notificationDOMRef.current.addNotification({
          message: message,
          type: "danger",
          insert: "top",
          container: "top-center",
          animationIn: ["animated", "fadeIn"],
          animationOut: ["animated", "fadeOut"],
          dismiss: { duration: 2000 },
          dismissable: { click: true }
        });
      }

    render(){
        return (
            <div>
                <ReactNotification ref={this.notificationDOMRef} />
                <img src={Logo} className="bruggeLogo"></img>
                <div className={styles.choose}>
                    <input type="text" placeholder="Enter a code" id="paintingNumber" className={`${this.state.isEmpty ? styles.spanPlaceholder : styles.spanContent} ${styles.input}`}/>
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
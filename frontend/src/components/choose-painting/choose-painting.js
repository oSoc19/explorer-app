import React from 'react';
import styles from '../choose-painting/choose-painting.module.css';
import { withRouter } from 'react-router-dom';
import queryString from 'query-string'
import Logo from '../../assets/images/logo_brugge.png';
import ReactNotification from "react-notifications-component";
import "react-notifications-component/dist/theme.css";

const PLACE_HOLDER = "Enter the number";

class ChoosePainting extends React.Component{
    constructor(props){
        super(props);
        this.state = {isEmpty : true};

        this.routeChange = this.routeChange.bind(this);
        this.addNotification = this.addNotification.bind(this);
        this.notificationDOMRef = React.createRef();
        this.removeNumber = this.removeNumber.bind(this);
        this.updateInput = this.updateInput.bind(this);
    }
    
    componentDidMount(){
        if(this.props.location.state !== undefined)
            this.addNotification();
    }

    routeChange(event){
        if(document.getElementById("paintingNumber").innerHTML !== ""){
            this.props.history.push(`/paintings/detail/${document.getElementById("paintingNumber").innerHTML}?language=${queryString.parse(this.props.location.search).language}`);
            window.location.reload();
        }
        else{

        }
    }

    updateInput(number){
        return () => {
            let input = document.getElementById("paintingNumber").innerHTML;
            if(input === PLACE_HOLDER){
                input = "";
                this.setState({isEmpty : false});
            }
            document.getElementById("paintingNumber").innerHTML = input+number;
        }
    }

    removeNumber(){
        document.getElementById("paintingNumber").innerHTML = document.getElementById("paintingNumber").innerHTML.slice(0,-1);
        if(document.getElementById("paintingNumber").innerHTML === ""){
            document.getElementById("paintingNumber").innerHTML = PLACE_HOLDER;
            this.setState({isEmpty : true});
        }
    }

    isInputEmpty(){
        return document.getElementById("paintingNumber").innerHTML === PLACE_HOLDER;
    }

    addNotification() {
        this.notificationDOMRef.current.addNotification({
          message: "This painting does not exist!",
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
                    <label>Search the painting</label>
                    <div  className={styles.input}>
                        <span id="paintingNumber" className={this.state.isEmpty ? styles.spanPlaceholder : styles.spanContent}>{PLACE_HOLDER}</span>
                    </div>
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
                                    <td onClick={this.routeChange}><i className="material-icons">&#xe5cc;</i></td>
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
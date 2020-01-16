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
                    
                    <div className="col-grid">
                        <div className={`${styles.col1_2}`} onClick={this.updateInput('AA')}>
                            <div className={`${styles.imagecover}`}><img className={`${styles.touchImage}`} src="https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c293bb3893004c94b54d41ff03c43e2d6df2b2586c3b44359daac05da0e0eea6/browse.jpg"></img></div>
                            <span className={`${styles.touchButton}`}>{Translation.Translate("Burg")}</span>
                        </div>
                        <div className={`${styles.col1_2}`} onClick={this.updateInput('AB')}>
                            <div className={`${styles.imagecover}`}><img className={`${styles.touchImage}`} src="https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/b382e23288c947a397a1d2862c70cc358a96af88bbcd423b9305218b6b816bc7/browse.jpg"></img></div>
                            <span className={`${styles.touchButton}`}>{Translation.Translate("Landhuis")}</span>
                        </div>
                        <div className={`${styles.col1_2}`} onClick={this.updateInput('AC')}>
                            <div className={`${styles.imagecover}`}><img className={`${styles.touchImage}`} src="https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/ae5e6015ebdc4a6d8fbbec53140a186e337bffefa0ec446b9f01e036edc352a6/browse.jpg"></img></div>
                            <span className={`${styles.touchButton}`}>{Translation.Translate("Griffie")}</span>
                        </div>
                        <div className={`${styles.col1_2}`} onClick={this.updateInput('AD')}>
                            <div className={`${styles.imagecover}`}><img className={`${styles.touchImage}`} src="https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/02bcd6e29ca84abd8a417433c1de751a886873e2193b496293aee4d8a19f930a/browse.jpg"></img></div>
                            <span className={`${styles.touchButton}`}>{Translation.Translate("Stadhuis")}</span>
                        </div>
                        <div className={`${styles.col1_2}`} onClick={this.updateInput('AE')}>
                            <div className={`${styles.imagecover}`}><img className={`${styles.touchImage}`} src="https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5cd374fbf4044e78a86e2b5239dd691d923ec92b18dc432883018f0d5e004a73/browse.jpg"></img></div>
                            <span className={`${styles.touchButton}`}>{Translation.Translate("Basiliek")}</span>
                        </div>
                        <div className={`${styles.col1_2}`} onClick={this.updateInput('AF')}>
                            <div className={`${styles.imagecover}`}><img className={`${styles.touchImage}`} src="https://upload.wikimedia.org/wikipedia/commons/thumb/d/df/Bruges%2C_burg_01.JPG/1280px-Bruges%2C_burg_01.JPG"></img></div>
                            <span className={`${styles.touchButton}`}>{Translation.Translate("Steen")}</span>
                        </div>
                        <div className={`${styles.col1_2}`} onClick={this.updateInput('AG')}>
                            <div className={`${styles.imagecover}`}><img className={`${styles.touchImage}`} src="https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/dd4755c106634a4595587d90ee418325eae83fad51724c90a025df548e94de58/browse.jpg"></img></div>
                            <span className={`${styles.touchButton}`}>{Translation.Translate("Proosdij")}</span>
                        </div>
                        <div className={`${styles.col1_2}`} onClick={this.updateInput('AH')}>
                            <div className={`${styles.imagecover}`}><img className={`${styles.touchImage}`} src="https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/176de22472d54fb8acd043861293cd259b3a5772fb4142afae1454575f03b66d/browse.jpg"></img></div>
                            <span className={`${styles.touchButton}`}>{Translation.Translate("Kathedraal")}</span>
                        </div>
                    </div>

                    {/* <div className="table-responsive-sm">
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
                                        <img className={`${styles.touchImage}`} src="https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c293bb3893004c94b54d41ff03c43e2d6df2b2586c3b44359daac05da0e0eea6/browse.jpg"></img>
                                        <span className={`${styles.touchButton}`}>{Translation.Translate("Burg")}</span>
                                    </td>
                                    <td onClick={this.updateInput('AB')}>
                                        <img className={`${styles.touchImage}`} src="https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/b382e23288c947a397a1d2862c70cc358a96af88bbcd423b9305218b6b816bc7/browse.jpg"></img>
                                        <span className={`${styles.touchButton}`}>{Translation.Translate("Landhuis")}</span>
                                    </td>
                                    <td onClick={this.updateInput('AC')}>
                                        <img className={`${styles.touchImage}`} src="https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/ae5e6015ebdc4a6d8fbbec53140a186e337bffefa0ec446b9f01e036edc352a6/browse.jpg"></img>
                                        <span className={`${styles.touchButton}`}>{Translation.Translate("Griffie")}</span>
                                    </td>
                                </tr>
                                <tr>
                                    <td onClick={this.updateInput('AD')}>
                                        <img className={`${styles.touchImage}`} src="https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/02bcd6e29ca84abd8a417433c1de751a886873e2193b496293aee4d8a19f930a/browse.jpg"></img>
                                        <span className={`${styles.touchButton}`}>{Translation.Translate("Stadhuis")}</span>
                                    </td>
                                    <td onClick={this.updateInput('AE')}>
                                        <img className={`${styles.touchImage}`} src="https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5cd374fbf4044e78a86e2b5239dd691d923ec92b18dc432883018f0d5e004a73/browse.jpg"></img>
                                        <span className={`${styles.touchButton}`}>{Translation.Translate("Basiliek")}</span>
                                    </td>
                                    <td onClick={this.updateInput('AF')}>
                                        <img className={`${styles.touchImage}`} src="https://upload.wikimedia.org/wikipedia/commons/thumb/d/df/Bruges%2C_burg_01.JPG/1280px-Bruges%2C_burg_01.JPG"></img>
                                        <span className={`${styles.touchButton}`}>{Translation.Translate("Steen")}</span>
                                    </td>
                                </tr>
                                <tr>
                                    <td onClick={this.updateInput('AG')}>
                                        <img className={`${styles.touchImage}`} src="https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/dd4755c106634a4595587d90ee418325eae83fad51724c90a025df548e94de58/browse.jpg"></img>
                                        <span className={`${styles.touchButton}`}>{Translation.Translate("Proosdij")}</span>
                                    </td>
                                    <td onClick={this.updateInput('AH')}>
                                        <img className={`${styles.touchImage}`} src="https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/176de22472d54fb8acd043861293cd259b3a5772fb4142afae1454575f03b66d/browse.jpg"></img>
                                        <span className={`${styles.touchButton}`}>{Translation.Translate("Kathedraal")}</span>
                                    </td>
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
                    </div> */}
                </div>
            </div>
        );
    }
}

export default withRouter(ChoosePainting);
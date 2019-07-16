import React from 'react';
import styles from './read-more.module.css';
import Translation from '../../services/translation';

class ReadMore extends React.Component{

    constructor(props){
        super(props);

        this.state = {
            wantsMore : false,
            maxLength : this.props.maxLength ? this.props.maxLength : 150
        };
    }

    showMoreOrLess = ()=>{
        let wantsMoreState = this.state.wantsMore;
        this.setState({wantsMore : !wantsMoreState})
    }

    render(){
        if(this.props.content.length <= this.state.maxLength)
            return (
            <div>
                <h5 className={styles.title}>{this.props.storyTitle}</h5>
                {this.props.content}
            </div>);
        else
            return (
                <div>
                    <h5 className={styles.title}>{this.props.storyTitle}</h5>
                    <div className={`row ${styles.content}`}>
                        <div className={`col-1 ${styles.line}`}>
                        </div>
                        <div className="col-10">
                            {
                                this.state.wantsMore ? 
                                <span>
                                    {this.props.content}
                                </span>
                                :
                                <span>
                                    {`${this.props.content.substring(0, this.state.maxLength)}...`}
                                </span>
                            }
                            <div className={styles.readMoreButton}>
                                <span onClick={this.showMoreOrLess}>
                                    {this.state.wantsMore? Translation.Translate("readLess") : Translation.Translate("readMore") }
                                    {this.state.wantsMore ? <i className={`fa ${styles.arrow}`}>&#xf177;</i> : <i className={`fa ${styles.arrow}`}>&#xf178;</i>}
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
            );
    }
}

export default ReadMore;
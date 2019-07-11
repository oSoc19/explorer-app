import React from 'react';
import styles from './read-more.module.css';

class ReadMore extends React.Component{

    constructor(props){
        super(props);

        this.state = {
            wantsMore : false
        };
    }

    showMoreOrLess = ()=>{
        let wantsMoreState = this.state.wantsMore;
        this.setState({wantsMore : !wantsMoreState})
    }

    render(){
        if(this.props.content.length <= this.props.maxLength)
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
                        <div className="col-1">
                            <span className={`fa ${styles.hyphen}`}>&#xf068;</span>
                        </div>
                        <div className="col">
                            {
                                this.state.wantsMore ? 
                                <span>
                                    {this.props.content}
                                </span>
                                :
                                <span>
                                    {`${this.props.content.substring(0, this.props.maxLength)}...`}
                                </span>
                            }
                            <div className={styles.readMoreButton}>
                                <span onClick={this.showMoreOrLess}>
                                    {this.state.wantsMore? 'Show less' : 'Continue reading'}
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
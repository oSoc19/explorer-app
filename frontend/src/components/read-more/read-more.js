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
        if(this.props.obj.content.length <= this.props.maxLength)
            return <div>{this.props.obj.content}</div>;
        else
            return (
                <div>
                    <h5 className={styles.title}>{this.props.obj.storyTitle}</h5>
                    {
                        this.state.wantsMore ? 
                        <div>
                            {this.props.obj.content}
                        </div>
                        :
                        <div>
                            {`${this.props.obj.content.substring(0, this.props.maxLength)}...`}
                        </div>
                    }
                    <div className={styles.readMoreButton}>
                        <span onClick={this.showMoreOrLess}>
                            {this.state.wantsMore? 'Read less' : 'Read more'}
                            {this.state.wantsMore ? <i className="fa">&#xf106;</i> : <i className="fa">&#xf107;</i>}
                        </span>
                    </div>
                </div>
            );
    }
}

export default ReadMore;
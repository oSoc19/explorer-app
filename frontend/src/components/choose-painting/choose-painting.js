import React from 'react';
import styles from '../choose-painting/choose-painting.module.css';
import { withRouter } from 'react-router-dom';
import { Redirect } from 'react-router-dom'

class ChoosePainting extends React.Component{
    constructor(props){
        super(props);
        this.state = {paintingNumber : 0, isCorrect : false};
        this.handleChange = this.handleChange.bind(this);
        this.routeChange = this.routeChange.bind(this);
    }
    
    handleChange(event) {
        this.setState({value: event.target.value, isCorrect : false });
    }

    routeChange(event){
        this.setState({value: event.target.value, isCorrect : true});
        this.props.history.push(this.state.value);
    }

    render(){
        if(!this.state.isCorrect)
            return (
                <div className={styles.choose}>
                    <label htmlFor="paintingNumber">Painting number</label>
                    <div className="form-group">
                        <input id="paintingNumber" type="number" value={this.state.value} onChange={this.handleChange}/>
                    </div>
                    <button className="btn btn-secondary" onClick={this.routeChange}>Click to learn</button>
                </div>
            );
        else
            return(
                <Redirect to={`/paintings/detail/${this.state.value}`}></Redirect>
            );
    }
}

export default withRouter(ChoosePainting);
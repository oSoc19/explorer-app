import React from 'react';
import styles from '../choose-painting/choose-painting.module.css';
import { withRouter } from 'react-router-dom';
import { Redirect, Router } from 'react-router-dom'
import queryString from 'query-string'

class ChoosePainting extends React.Component{
    constructor(props){
        super(props);
        this.state = {value : '', isCorrect : false};
        this.handleChange = this.handleChange.bind(this);
        this.routeChange = this.routeChange.bind(this);
    }
    
    handleChange(event) {
        this.setState({value: event.target.value, isCorrect : false });
    }

    routeChange(event){
        this.setState({value: event.target.value, isCorrect : true});
        this.props.history.push(`/paintings/detail/${this.state.value}?language=${queryString.parse(this.props.location.search).language}`);
        window.location.reload();
    }

    getPaintingRoute(){
        return `/paintings/detail/${this.state.value}`;
    }

    render(){
        if(!this.state.isCorrect)
            return (
                <div className={styles.choose}>
                    <label htmlFor="paintingNumber">Search the painting</label>
                    <div className="form-group">
                        <input id="paintingNumber" type="text" value={this.state.value} onChange={this.handleChange} placeholder="Enter the number"/>
                    </div>
                    <button className="btn btn-secondary" onClick={this.routeChange}>Click to learn</button>
                    <div class="table-responsive-sm">
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
                                    <td>1</td>
                                    <td>2</td>
                                    <td>3</td>
                                </tr>
                                <tr>
                                    <td>4</td>
                                    <td>5</td>
                                    <td>6</td>
                                </tr>
                                <tr>
                                    <td>7</td>
                                    <td>8</td>
                                    <td>9</td>
                                </tr>
                                <tr>
                                    <td><i class="material-icons">&#xe5cd;</i></td>
                                    <td>0</td>
                                    <td><i class="material-icons">&#xe5cc;</i></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            );
        else
            return(
                <p>test</p>
                // <Redirect to={this.getPaintingRoute()}></Redirect>
            );
    }
}

export default withRouter(ChoosePainting);
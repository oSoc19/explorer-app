import React from 'react';
import { css } from '@emotion/core';
import { ClipLoader } from 'react-spinners';
import styles from './painting-detail.module.css';

const override = css`
    display: block;
    margin: 0 auto;
    border-color: red;
`;

class PaintingDetail extends React.Component{

    constructor(props){
        super(props);

        this.state = {
            loading : true,
            data : 'null'
        };
    }

    async getImage(){
        let response = await fetch(TESTURL, {headers : {'Access-Control-Allow-Origin' : '*'}});
        let dataJSON = await response.json();
        await this.setState({data : dataJSON, loading : false});
    }

    componentWillMount(){
        this.getImage();
    }

    render(){
        return(
            this.state.loading ? 
            <div className='sweet-loading'>
                <ClipLoader
                    css={override}
                    sizeUnit={"px"}
                    size={100}
                    color={'#787B7D'}
                    loading={this.state.loading}
                />
            </div>  : 
            
            <div className="container">
                <div className="row">
                    <div className="col-sm-6">
                        <div className={`container ${styles.paintImage}`}>
                            <img className={`img-fluid ${styles.imageSize}`} src={this.state.data.query.pages['-1'].imageinfo[0].url} alt="Placeholder"/>
                        </div>
                        <div className={`container ${styles.paintDetailsContainer}`}>
                            <div className="container">
                                <div className="row">
                                    Details
                                </div>
                            </div>
                            <table className={`table table-borderless ${styles.paintDetails}`}>
                                <tbody>
                                    <tr>
                                        <td>Title</td>
                                        <td>Portret van Fovin de Hasque</td>
                                    </tr>
                                    <tr>
                                        <td>Author</td>
                                        <td>Jakob van Oost</td>
                                    </tr>
                                    <tr>
                                        <td>Date</td>
                                        <td>Between circa 1669 and circa 1670</td>
                                    </tr>
                                    <tr>
                                        <td>Place</td>
                                        <td>Brugge</td>
                                    </tr>
                                    <tr>
                                        <td>Size</td>
                                        <td>Height: 106 cm (41.7 ″); Width: 83 cm (32.6 ″)</td>
                                    </tr>
                                    <tr>
                                        <td>Category</td>
                                        <td>Portrait</td>
                                    </tr>
                                    <tr>
                                        <td>Owner</td>
                                        <td>Groeningemuseum</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div className="col-sm">
                       <div className="container">
                           <div className={`row ${styles.paintTitle}`}>Portret van Fovin de Hasque</div>
                           <div className={`row ${styles.paintArtist}`}>Jakob van Oost</div>
                       </div>
                       <div className={`container ${styles.paintDescription}`}>
                            Portret van Fovin de Hasque (Jacob I van Oost, circa 1669 - circa 1670); collection: Musea Brugge - Groeningemuseum
                       </div>
                       <div className={`container ${styles.tagsContainer}`}>
                        <p className="">Tags</p>
                           <div className="container">
                            
                           </div>
                       </div>
                    </div>
                </div>
            </div>
        );
    }
}

const TESTURL = "https://en.wikipedia.org/w/api.php?prop=imageinfo&format=json&action=query&titles=File:Portret van Fovin de Hasque, circa 1669 - circa 1670, Groeningemuseum, 0040728000.jpg&iiprop=url";

export default PaintingDetail;
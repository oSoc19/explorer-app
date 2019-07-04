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
                                        <td>X</td>
                                    </tr>
                                    <tr>
                                        <td>Artist</td>
                                        <td>X</td>
                                    </tr>
                                    <tr>
                                        <td>Date</td>
                                        <td>X</td>
                                    </tr>
                                    <tr>
                                        <td>Place</td>
                                        <td>X</td>
                                    </tr>
                                    <tr>
                                        <td>Size</td>
                                        <td>X</td>
                                    </tr>
                                    <tr>
                                        <td>Category</td>
                                        <td>X</td>
                                    </tr>
                                    <tr>
                                        <td>Owner</td>
                                        <td>X</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div className="col-sm">
                       <div className="container">
                           <div className={`row ${styles.paintTitle}`}>Title</div>
                           <div className={`row ${styles.paintArtist}`}>Author</div>
                       </div>
                       <div className={`container ${styles.paintDescription}`}>
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sed diam vehicula, rutrum libero vitae, interdum nunc. Aenean dictum vel velit vitae semper. Curabitur facilisis massa vel lacus semper semper. Suspendisse a viverra sapien, non tempus neque. Donec ultricies turpis at mauris bibendum placerat. Integer malesuada eleifend vulputate. Pellentesque ac ipsum magna. Quisque quis pretium lorem. Proin et suscipit nibh, nec volutpat diam. Quisque commodo, nunc sit amet molestie rutrum, lacus nunc porta quam, in feugiat lectus ex tempus nulla. Nulla ut dui lobortis, viverra arcu maximus, euismod massa. Proin sit amet tempus odio. Integer at turpis nec ex placerat pellentesque. Suspendisse pulvinar egestas luctus. Integer condimentum purus et fermentum molestie.
                        Curabitur ullamcorper ex neque, sit amet aliquet mi hendrerit nec. Sed leo nisl, vestibulum id diam et, sollicitudin tincidunt sapien. Curabitur aliquam enim sit amet diam ultrices, ut porttitor nisi consequat. Nulla a sodales massa, et tincidunt tellus. Donec sit amet neque ut felis ultricies porta ut blandit est. Aenean ac lacinia tortor, eget gravida lectus. Praesent vitae scelerisque ante. Nam hendrerit risus ipsum, ut ultricies neque ultricies ut. Aliquam vel urna eu erat gravida imperdiet id ut odio. Quisque magna ligula, finibus non libero nec, consequat gravida tellus. Proin posuere rutrum ligula ac vehicula. Praesent malesuada tempus nisl quis mollis.
                       </div>
                       <div className={`container ${styles.tagsContainer}`}>
                        <p className="">Tags</p>
                           <div className="container">
                            <span>Author</span>
                            <span>Category</span>
                            <span>Author</span>
                            <span>Category</span>
                            <span>Category</span>   
                            <span>Category</span>
                          
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
import Logo from '../../assets/images/Logo_Bruges.jpg';
import React from 'react';

class NavBar extends React.Component{
    render(){
        return(
            <nav className="navbar navbar-expand-lg navbar-light bg-light">
                <a className="navbar-brand" href="#">
                    <img className="logo" src={Logo} alt="Brugge logo"/>
                </a>
                <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span className="navbar-toggler-icon"></span>
                </button>

                <div className="collapse navbar-collapse " id="navbarSupportedContent">
                    <ul className="navbar-nav mr-auto">
                    <li className="nav-item active">
                        <a className="nav-link" href="#">Collection <span className="sr-only">(current)</span></a>
                    </li>
                    </ul>
                </div>
            </nav>
        )
    }
}

export default NavBar;
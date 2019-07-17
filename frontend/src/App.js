import React from 'react';
import './App.css';
import PaintingDetail from './components/painting-detail/painting-detail';
import NavBar from './components/navbar/navbar';
import ChooseLanguage from '../src/components/choose-language/choose-language';
import { BrowserRouter, Route, Switch, Redirect, Router } from 'react-router-dom';
import { createBrowserHistory } from "history";
import ChoosePainting from '../src/components/choose-painting/choose-painting';

const history = createBrowserHistory();

 class App extends React.Component{
   constructor(props){
     super(props);
   }

  render(){
    return (
      <div className="App">
        {/* <NavBar></NavBar> */}
        <Router history={history}>
          <Switch>
            <Route exact={true} path="/" component={ChooseLanguage}></Route>
            <Route path="/choose-painting" component={ChoosePainting}></Route>
            <Route path="/paintings/detail/:id" component={PaintingDetail}></Route>
          </Switch>
        </Router>
      </div>
    );
  }
}

export default App;

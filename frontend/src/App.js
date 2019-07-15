import React from 'react';
import './App.css';
import PaintingDetail from './components/painting-detail/painting-detail';
import NavBar from './components/navbar/navbar';
import ChooseLanguage from '../src/components/choose-language/choose-language';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import ChoosePainting from '../src/components/choose-painting/choose-painting'

 function App(){
  return (
    <div className="App">
      {/* <NavBar></NavBar> */}
      <BrowserRouter>
        <Switch>
          <Route path="/language" component={ChooseLanguage}></Route>
          <Route path="/choose-painting" component={ChoosePainting}></Route>
          <Route path="/paintings/detail/:id" component={PaintingDetail}></Route>
        </Switch>
      </BrowserRouter>
    </div>
  );
}

export default App;

import React from 'react';
import './App.css';
import PaintingDetail from './components/painting-detail/painting-detail';
import NavBar from './components/navbar/navbar';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";

 function App(){
  return (
    <div className="App">
      <Router>
        <Route path="/paintings/detail/:id" component={PaintingDetail}></Route>
      </Router>
      {/* <PaintingDetail></PaintingDetail> */}
    </div>
  );
}

export default App;

import React from 'react';
import './App.css';
import PaintingDetail from './components/painting-detail/painting-detail';
import NavBar from './components/navbar/navbar';

 function App(){
  return (
    <div className="App">
      <NavBar></NavBar>
      <PaintingDetail></PaintingDetail>
    </div>
  );
}

export default App;

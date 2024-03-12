import React from 'react';
import './App.css';
import Header from './Header';
import BowlerList from './Bowler/BowlerList';
import TeamList from './Bowler/TeamList';

function App() {
  return (
    <div className="App">
      <Header title="McNasty Bowling League" />
      <BowlerList />
      <TeamList />
    </div>
  );
}

export default App;

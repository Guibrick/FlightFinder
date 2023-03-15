import React from 'react';
import logo from './logo.svg';
import './App.css';
import FlightListOneWay from './Components/Flight-List-Grid/flight-list-grid';
import FlightBooking from './Components/Booking/booking';
import Header from './Components/Header/header';
import Home from './Components/Home/home';
import FlightSearch from './Components/Flight-Search/flightsearch';

function App() {
    return (
        <>
            <FlightSearch />
        </>
    );
}

export default App;

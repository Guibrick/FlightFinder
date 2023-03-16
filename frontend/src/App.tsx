import React from 'react';
import logo from './logo.svg';
import './App.css';
import FlightBooking from './Components/Booking/booking';
import Header from './Components/Header/header';
import Home from './Components/Home/home';
import FlightSearch from './Components/Flight-Search/flightsearch';
import { LocalizationProvider } from '@mui/x-date-pickers';
import { AdapterDayjs } from '@mui/x-date-pickers/AdapterDayjs';
import FlightsList from './Components/Flight-List-Grid/flight-list-grid';
import IFlight from './Interfaces/IFlight';

function App() {
    return (
        <>
            <Header />
            <FlightSearch />
        </>
    );
}

export default App;

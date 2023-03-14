import React, { Suspense } from "react";

import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import { Grid, CssBaseline, Toolbar } from "@material-ui/core";

import FlightBooking from '../Booking/booking';
import Header from '../Header/header';

import "../../styles.css";
import { Dashboard } from "@mui/icons-material";

const Home = () => {
    return (
        <div className="root">
            <CssBaseline />
            <Router>
                <Header />
                <Toolbar />
                <Suspense fallback={<div>Loading...</div>}>
                    <Routes>
                        <Route path="/" element={<Dashboard />} />
                        <Route path="/flight-search" element={<FlightSearch />} />
                        <Route path="/flight-booking" element={<FlightBooking />} />
                        <Route path="/confirmation" element={<Confirmation />} />
                    </Routes>
                </Suspense>
            </Router>
        </div>
    );
};

export default Home;
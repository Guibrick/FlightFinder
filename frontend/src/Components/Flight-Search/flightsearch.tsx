import React, { useState, useEffect } from "react";
import PropTypes from "prop-types";
import { useDispatch, useSelector } from "react-redux";
import { useNavigate } from "react-router";

import { makeStyles } from "@material-ui/core/styles";
import {
    Grid,
    TextField,
    Button,
    Radio,
    FormControlLabel,
    RadioGroup,
    Typography,
    responsiveFontSizes
} from "@material-ui/core";
import { Autocomplete } from "@material-ui/lab";
import IFlight from "../../Interfaces/IFlight";
import IBooking from "../../Interfaces/IBooking";
import IUser from "../../Interfaces/IUser";

const FlightSearch = () => {
    const [booking, setBooking] = useState<IBooking[]>([]);
    const [flight, setFlight] = useState<IFlight[]>([]);
    const [user, setUser] = useState<IUser[]>([]);
    const [departure, setDeparture] = useState("");
    const [arrival, setArrival] = useState("");
    const [departureDate, setDepartureDate] = useState("");
    const [inputDeparture, setInputDeparture] = useState("");
    const [inputArrival, setInputArrival] = useState("");

    useEffect(() => {
        const getData = async () => {
            const response = await Promise.all([
                fetch("https://localhost:7095/api/Bookings/AllBookings").then(value1 => value1.json()),
                fetch("https://localhost:7095/api/Flights/AllFlights").then(value2 => value2.json()),
                fetch("https://localhost:7095/api/Users/AllUsers").then(value3 => value3.json())
            ])
                .then(([value1, value2, value3]) => {
                    setBooking(value1);
                    setFlight(value2);
                    setUser(value3);
                });
        }
        getData();
    }, []);

    return (
        <>
            {booking.map((value) => { return (<li>{value.departure} </li>) })}
            {flight.map((value) => { return (<li>{value.itineraries[0].arrivalAt} </li>) })}
            {user.map((value) => { return (<li>{value.name} </li>) })}
        </>

    );
};

export default FlightSearch;
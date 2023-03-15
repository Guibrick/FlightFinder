import React, { useState, useEffect } from "react";
import PropTypes from "prop-types";
import { useDispatch, useSelector } from "react-redux";
import { useNavigate } from "react-router";

import { makeStyles } from "@material-ui/core/styles";
import {
    TextField,
    Button,
    Radio,
    FormControlLabel,
    RadioGroup,
    Typography,
    responsiveFontSizes
} from "@material-ui/core";
import Box from '@mui/system/Box';
import Grid from '@mui/system/Unstable_Grid';

import IFlight from "../../Interfaces/IFlight";
import IBooking from "../../Interfaces/IBooking";
import IUser from "../../Interfaces/IUser";
import { DatePicker, LocalizationProvider } from "@mui/x-date-pickers";
import { Autocomplete } from "@mui/material";


const FlightSearch = () => {
    const [booking, setBooking] = useState<IBooking[]>([]);
    const [flight, setFlight] = useState<IFlight[]>([]);
    const [user, setUser] = useState<IUser[]>([]);
    const [selectTrip, setSelectTrip] = useState("one");
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

    var singleDepartures = Array.from(new Set(flight.map((option) => option.departureDestination)));
    var singleDestinations = Array.from(new Set(flight.map((option) => option.arrivalDestination)));

    const handleSelectTrip = (e: any) => {
        setSelectTrip(e.target.value);
    };

    return (
        <Box m={7} sx={{ width: 400, height: 400 }}>
            <Grid container spacing={1}>

                <Grid xs={12} sx={{ ml: 1 }}>
                    <RadioGroup row onChange={handleSelectTrip} value={selectTrip}>
                        <FormControlLabel
                            value="one"
                            control={<Radio color="primary" />}
                            label="One Way"
                        />
                        <FormControlLabel
                            value="both"
                            control={<Radio color="primary" />}
                            label="Round Trip"
                        />
                    </RadioGroup>
                </Grid>

                <Grid xs={12} >
                    <Grid spacing={2}>
                        <Autocomplete
                            freeSolo
                            disableClearable
                            options={singleDepartures}
                            renderInput={(params) => (
                                <TextField
                                    {...params}
                                    label="Departure City"
                                    variant="outlined"
                                    InputProps={{
                                        ...params.InputProps,
                                        type: 'search',
                                    }} />)} />
                    </Grid>
                    <Grid spacing={2}>
                        <Autocomplete
                            freeSolo
                            disableClearable
                            options={singleDestinations}
                            renderInput={(params) => (
                                <TextField
                                    {...params}
                                    label="Destination City"
                                    variant="outlined"
                                    InputProps={{
                                        ...params.InputProps,
                                        type: 'search',
                                    }} />)} />
                    </Grid>
                </Grid>

                <Grid sx={{ width: 180 }}>
                    <Grid xs={12}>
                        <DatePicker label="Departure Date" />
                    </Grid>
                    {selectTrip?.toUpperCase() === "BOTH" && (
                        <Grid xs={12}>
                            <DatePicker label="Return Date" />
                        </Grid>
                    )}
                </Grid>

                <Grid xs={12} sx={{ ml: 1, mt: 2 }}>
                    <Button variant="contained">
                        {`Search Flight`}
                    </Button>
                </Grid>

            </Grid>
        </Box>
    );
};

export default FlightSearch;

/*        <>
{booking.map((value) => { return (<li>{value.departure} </li>) })}
{flight.map((value) => { return (<li>{value.itineraries[0].arrivalAt} </li>) })}
{user.map((value) => { return (<li>{value.name} </li>) })}
</>*/
import React, { useState, useEffect } from "react";
import { TextField, Button, Radio, FormControlLabel, RadioGroup } from "@material-ui/core";
import { DatePicker, LocalizationProvider } from "@mui/x-date-pickers";
import { Autocomplete } from "@mui/material";
import Grid from '@mui/system/Unstable_Grid';
import Box from '@mui/system/Box';

import IFlight from "../../Interfaces/IFlight";
import IBooking from "../../Interfaces/IBooking";
import IUser from "../../Interfaces/IUser";
import Departure from "../../Interfaces/Departure";
import FlightsList from "../Flight-List-Grid/flight-list-grid";

const FlightSearch = () => {
    const [booking, setBooking] = useState<IBooking[]>([]);
    const [flight, setFlight] = useState<IFlight[]>([]);
    const [user, setUser] = useState<IUser[]>([]);
    const [selectTrip, setSelectTrip] = useState("one");
    const [departure, setDeparture] = useState<Departure>({ departure: "" });
    const [arrival, setArrival] = useState("");
    const [departureDate, setDepartureDate] = useState(null);
    const [arrivalDate, setArrivalDate] = useState(null);

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

    const handleSelectTrip = (e: any) => { setSelectTrip(e.target.value); };

    const fullInfo = () => { console.log(departure, arrival, departureDate, arrivalDate) };

    return (
        <>
            <Box m={10} sx={{ width: 400, height: 400 }}>
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
                                inputValue={departure!.departure} 
                                onInputChange={(event, newInputValue) => { setDeparture({ departure: newInputValue }); }}
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
                                inputValue={arrival}
                                onInputChange={(event, newInputValue) => { setArrival(newInputValue); }}
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
                            <DatePicker
                                value={departureDate}
                                onChange={(newValue) => setDepartureDate(newValue)}
                                label="Departure Date" />
                        </Grid>
                        {selectTrip?.toUpperCase() === "BOTH" && (
                            <Grid xs={12}>
                                <DatePicker
                                    value={arrivalDate}
                                    onChange={(newValue) => setArrivalDate(newValue)}
                                    label="Return Date" />
                            </Grid>)}
                    </Grid>

                    <Grid xs={12} sx={{ ml: 1, mt: 2 }}>
                        <Button variant="contained" onClick={fullInfo}>
                            {`Search Flight`}
                        </Button>
                    </Grid>

                </Grid>
            </Box>
            {/* @ts-expect-error Server Component */}
            <FlightsList flight={flight} departure={departure} />
        </>
    );
};

export default FlightSearch;
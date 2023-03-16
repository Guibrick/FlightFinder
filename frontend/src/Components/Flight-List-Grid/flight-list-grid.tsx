import { useState } from "react";
import IFlight from "../../Interfaces/IFlight";
import { Flight } from "@mui/icons-material";
import { format } from "date-fns";
import FlightSearch from "../Flight-Search/flightsearch";

import { Avatar, Button, Card, CardContent, CircularProgress, Grid, Typography, Table, TableBody, TableCell, TablePagination, TableRow, List } from "@material-ui/core";
import Departure from "../../Interfaces/Departure";

interface props {
    flight: IFlight
    departure: Departure | undefined
};

const FlightsList = ({ flight, departure }: props) => {

    if (departure?.departure === flight.departureDestination) {
        const list = <div>{flight.arrivalDestination}</div>


        /*const list =
            <Table>
                <TableBody>
                    {props. .map((val: any, index: any) => {
                        return (
                            <TableRow key={index}>
                                <TableCell>
                                    <Card className={classes.cardContainer}>
                                        <CardContent>
                                            <Grid container>
                                                <Grid item xs={2}>
                                                    <Avatar
                                                        src={val.airlineLogo}
                                                        alt={val.airlineName}
                                                    />
                                                </Grid>
                                                <Grid item xs={2} className={classes.textAlignCenter}>
                                                    <Typography align="center">
                                                        {val.deptTime}
                                                    </Typography>
                                                    <Typography variant="caption">
                                                        {val.deptCity}
                                                    </Typography>
                                                </Grid>
                                                <Grid item xs={2} className={classes.textAlignCenter}>
                                                    <Typography>{val.airlineName}</Typography>
                                                    <Typography variant="caption">
                                                        {val.flightNbr}
                                                    </Typography>
                                                    <br />
                                                    <Typography variant="caption">
                                                        {val.noOfStops === "0"
                                                            ? `No Stops`
                                                            : `${val.noOfStops} Stops`}
                                                    </Typography>
                                                </Grid>
                                                <Grid item xs={2} className={classes.textAlignCenter}>
                                                    <Typography>{val.arivalTime}</Typography>
                                                    <Typography variant="caption">
                                                        {val.arivalCity}
                                                    </Typography>
                                                </Grid>
                                                <Grid item xs={4} className={classes.textAlign}>
                                                    <Button
                                                        variant="contained"
                                                        color="primary"
                                                        onClick={() => bookNow(val)}
                                                    >{`Rs. ${thousandSeparator(val?.price)}`}</Button>
                                                </Grid>
                                            </Grid>
                                        </CardContent>
                                    </Card>
                                </TableCell>
                            </TableRow>
                        );
                    })}
                </TableBody>
            </Table>
    );
} else if (flightList?.result?.length === 0) {
<Typography>{`No Records Found..`}</Typography>;*/

        return (
            <Grid container>
                <Grid item xs={12}>
                    {list}
                </Grid>
            </Grid>
        );
    };

};
export default FlightsList;




/*import React, { useState } from "react";
import PropTypes from "prop-types";

import { makeStyles } from "@material-ui/core/styles";



const useStyles = makeStyles(() => ({
    textAlign: {
        textAlign: "right"
    },
    textAlignCenter: {
        textAlign: "center"
    },
    cardContainer: {
        marginBottom: 5
    }
}));

const FlightListOneWay = (props: any) => {
    const { flightList, bookNow } = props;
    const classes = useStyles();
    const [page, setPage] = useState("");
    const [rowsPerPage, setRowsPerPage] = useState("");
    let component = null;

    const handleChangePage = (event: any, newPage: any) => {
        setPage(newPage);
    };

    const handleChangeRowsPerPage = (event: any) => {
        setRowsPerPage(parseInt(event.target.value, 10));
        setPage(0);
    }

    if (flightList?.loading) {
        component = <CircularProgress />;
    } else 
    } else if (flightList?.error) {
        component = <Typography>{`Unable to fetch Data...`}</Typography>;
    }

    return (
        <Grid container>
            <Grid item xs={12}>
                {component}
            </Grid>
        </Grid>
    );
};

FlightListOneWay.propTypes = {
    classes: PropTypes.object,
    flightList: PropTypes.object,
    bookNow: PropTypes.func
};

export default FlightListOneWay;

<TablePagination
                    rowsPerPageOptions={[5, 10, 25]}
                    component="div"
                    count={flightList.result.length}
                    rowsPerPage={rowsPerPage}
                    page={page}
                    onChangePage={handleChangePage}
                    onChangeRowsPerPage={handleChangeRowsPerPage}
                />*/


/*    const handleClick = () => { };

return (
    <div>
        <div className="listContainer">
            <div className="listWrapper">
                <div className="listSearch">
                    <h1 className="lsTitle">Search</h1>
                    <div className="lsItem">
                        <label>Destination</label>
                        <input placeholder={props.departureDestination} type="text" />
                    </div>
                    <div className="lsOptionItem">
                        <span className="lsOptionText">Adult</span>
                        <input
                            type="number"
                            min={1}
                            className="lsOptionInput"
                            placeholder={props.arrivalDestination}
                        />
                    </div>
                    <div className="lsOptionItem">
                        <span className="lsOptionText">Children</span>
                        <input
                            type="number"
                            min={1}
                            className="lsOptionInput"
                            placeholder={props.departureDestination}
                        />
                    </div>
                </div>
            </div>
            <button onClick={handleClick}>Search</button>
        </div>
    </div>
);*/


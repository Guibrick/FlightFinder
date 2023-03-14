import React from "react";
import PropTypes from "prop-types";

import { makeStyles } from "@material-ui/core/styles";
import {
    Avatar,
    Button,
    Card,
    CardContent,
    CircularProgress,
    Grid,
    Typography,
    Table,
    TableBody,
    TableCell,
    TablePagination,
    TableRow
} from "@material-ui/core";
import { thousandSeparator } from "../../Services/global-services";


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
    const [page, setPage] = React.useState(0);
    const [rowsPerPage, setRowsPerPage] = React.useState(5);
    let component = null;

    /*const handleChangePage = (event: any, newPage: any) => {
        setPage(newPage);
    };

    const handleChangeRowsPerPage = (event: any) => {
        setRowsPerPage(parseInt(event.target.value, 10));
        setPage(0);
    };*/

    if (flightList?.loading) {
        component = <CircularProgress />;
    } else if (flightList?.result?.length > 0) {
        component = (
            <Table>
                <TableBody>
                    {flightList.result
                        .slice(page * rowsPerPage, page * rowsPerPage + rowsPerPage)
                        .map((val: any, index: any) => {
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
        component = <Typography>{`No Records Found..`}</Typography>;
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

/*<TablePagination
                    rowsPerPageOptions={[5, 10, 25]}
                    component="div"
                    count={flightList.result.length}
                    rowsPerPage={rowsPerPage}
                    page={page}
                    onChangePage={handleChangePage}
                    onChangeRowsPerPage={handleChangeRowsPerPage}
                />*/
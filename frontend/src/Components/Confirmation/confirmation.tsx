import React from "react";
import PropTypes from "prop-types";
import { useNavigate } from "react-router-dom";

import { Typography, Button } from "@material-ui/core";
import { makeStyles } from "@material-ui/core/styles";

const useStyles = makeStyles(() => ({
    button: {
        marginTop: 10
    }
}));

const Confirmation = () => {
    const history = useNavigate();
    const classes = useStyles();

    return (
        <>
            <Typography
                variant="body2"
                color="textPrimary"
            >{"Thank you for the Booking. Click the button below to return to home page."}</Typography>
            <Button
                variant="outlined"
                color="primary"
                className={classes.button}
                onClick={() => history("/")}
            >{`Back to Home`}</Button>
        </>
    );
};

Confirmation.propTypes = {
    history: PropTypes.object,
    classes: PropTypes.object
};

export default Confirmation;
interface IBooking {
    bookingId: string;
    userId: string;
    flightId: string;
    name: string;
    surname: string;
    departure: string;
    arrival: string;
    totalPrice: number;
    adultSeats: number;
    childSeats: number;
};

export default IBooking;

# Flight Finder

This project is a full stack application for a flight finder. The backend is responsible for handling the API endpoints that the frontend can connect to. It should allow users to search for flights and book them. The backend should also handle connecting flights with layovers, error checking for invalid bookings and saving bookings in the database. The frontend should allow users to search for flights, display available flights and book seats.

## Backend

The backend should include endpoints for the following:
- Get all possible flights and their corresponding information (prices, availability of seats, departureDate, etc.)
- Get a specific flight
- Get connecting flights to a specific flight
- Book individual flights
- Set a price-range in search
- Handle error checking for invalid bookings
- Handle flights with layovers

The provided JSON-file should be used to seed a database of your choice.

## Frontend

The frontend should include the following features:
- A search bar to search for flights
  - Validation for this search including departure destination and arrival destination, one way trip or round trip, departure date and possible return date, and number of passengers (adults and/or children)
- After a search has been made display a list of available flights
- When a flight is chosen display the information regarding the chosen flight
  - Flight duration
  - Destinations and their arrival times
  - Availability of seats
  - Price for flight
  - Button to book flight
- Booking a seat should remove the available seats from the flight while booking, but only ping the backend when it is actually booked.
- Eventually any layovers in the flight
- Sorting flights depending on price, no layovers, time traveling
- Showing a calendar of prices/flights
- Display the price in other currencies

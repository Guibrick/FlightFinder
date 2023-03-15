export interface IFlight {
    route_id: string
    departureDestination: string
    arrivalDestination: string
    itineraries: IItinerary[]
}

export interface IItinerary {
    flight_id: string
    departureAt: string
    arrivalAt: string
    availableSeats: number
    prices: IPrices
}

export interface IPrices {
    currency: string
    adult: number
    child: number
}

export default IFlight;
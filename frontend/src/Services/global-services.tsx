const validateSearch = (source: string, dest: string, deptDate: string, returnDate: string, selectTrip: string) => {
    let flag = true;

    if (selectTrip?.toUpperCase() === "ONE") {
        flag = source?.length === 0 || dest?.length === 0 || deptDate?.length === 0;
    } else {
        flag =
            source?.length === 0 ||
            dest?.length === 0 ||
            deptDate?.length === 0 ||
            returnDate?.length === 0;
    }
    return flag;
};

const thousandSeparator = (x: number) => {
    return x.toString().replace(/\B(?<!\.\d*)(?=(\d{3})+(?!\d))/g, ",");
};

/**
 * @function filterBySourceDest
 * @param {object} payload
 * @param {array} response
 * @description filter flight list by source and destination
 
const filterBySourceDest = (payload, response) => {
    let resultArr = [];

    let tempArr = [...response];
    const sourceCity = payload?.source;
    const destCity = payload?.destination;

    resultArr = tempArr.filter(
        (val) =>
            val?.deptCity?.toLowerCase() === sourceCity?.toLowerCase() &&
            val?.arivalCity?.toLowerCase() === destCity?.toLowerCase()
    );

    return resultArr;
};*/

export { validateSearch, thousandSeparator };

var carDealer= {
    sedan:{
        price: 200,
        available: 0
    },
    SUV: {
        price: 300,
        available: 2
    },
    Sport: {
        price: 400,
        available: 3
    },
   checkPrice(cPrice){
    return this[cPrice].price;
    },   
   checkAvail(cType){
    return this[cType].available;
    }
};
console.table(carDealer);
//console.log("We have " + carDealer.checkAvail("sedan")+" Sedans in stock");
//console.log("Current Price of the sedans: $"+ carDealer.checkPrice("sedan")+"/car");
//console.log("We have " + carDealer.checkAvail("SUV")+" SUVS in stock");
//console.log("Current Price of the SUV: $"+ carDealer.checkPrice("SUV")+"/SUV");
//console.log("We have " + carDealer.checkAvail("Sport")+" Sports car in stock");
//console.log("Current Price of the Sports cars: $"+ carDealer.checkPrice("Sport")+"/car");
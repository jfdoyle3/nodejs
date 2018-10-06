
//var stockList ={
//    stock: [],
//    displayStock: function(){
//        console.log();
//    },
//    addStockInfo: function(ticker){
//        this.stock.push({
//            ticker: ticker
//            });
//    },
//    
//};
function myLiz(){
var myTicker = document.getElementById('ticker').value;
var myName = document.getElementById('name').value;
var myPrice = document.getElementById('price').value;
var myChange = document.getElementById('change').value;
var myMarketCap= document.getElementById('marketCap').value; 

 //   document.getElementsByClassName("demo").innerHTML= myTicker + myName + myPrice + myChange+ myMarketCap;
    document.getElementById("demo").innerHTML= "ticker:" +myTicker+" Name: "+myName+" Price: $"+myPrice+"  Change: "+myChange+"%  Market Cap "+myMarketCap;
}








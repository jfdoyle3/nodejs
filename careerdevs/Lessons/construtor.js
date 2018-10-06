
function myStocks(name,price,change,marketCap){
	this.name = name;
    this.price= price;
    this.change = change;
    this.marketCap = marketCap;

}
var AMZN = new MyStocks('Amazon', 1000, 15, 800);
var FB = new MyStocks('FaceBook', 200, 7, 300);
var  myStockList= [AMZN, FB];
for (i in myStockList){
  console.log("Price $"+myStockList[i].price);   
}
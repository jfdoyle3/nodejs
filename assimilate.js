var http=require('http');

http.createServer(function(request, response){
    response.writeHead(200);
    response.write("Resistance is futile!\nYou will be assimilated!\n");
    setTimeout(function(){
        response.write("You have been assimilated!");
        response.end();
    }, 5000);
}).listen(8080);
console.log("listening on port 8080");
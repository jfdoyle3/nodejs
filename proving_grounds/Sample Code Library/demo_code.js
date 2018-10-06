var myComputer={
    Type: 'PC',
    name: 'Surface',
    OS: "win8",
    Game: function() {
        console.log(this.name);
    }
};
console.log(myComputer.Game);
function sortear() {

    var id = "";
    for(var i=0; i<15; i++){
        var numAleatorio = Math.floor((Math.random() * 25) + 1);

        id = "num"+i;
        document.getElementById(id).innerHTML = numAleatorio;
    }
}
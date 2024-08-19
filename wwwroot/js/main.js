//Includes functions for the toolbars, header and footer
const products = document.querySelector(".products-button");
var current_rotation = 0, count = 0;
products.addEventListener('click', function () {
    count++;
    current_rotation += 180;
    document.querySelector(".products-button svg").style.transform = `rotate(${current_rotation}deg)`;
    var tab = document.querySelectorAll(".pick-menu>div>a>img");
    var tabDiv = document.querySelectorAll(".pick-menu>div>a>p");
    var tabT = document.querySelectorAll(".pick-menu>div");
    if (count % 2 !== 0) {
        for (var x = 0; x < tab.length; x++) {
            tab[x].style.visibility = "visible";
        }
        for (var x = 0; x < tabDiv.length; x++) {
            tabDiv[x].style.visibility = "visible";
        }
        for (var x = 0; x < tabT.length; x++) {
            tabT[x].style.border = "1px solid #F5F5F5";
        }
        document.querySelector(".pick-menu").style.visibility = "visible";
    } else if (count % 2 === 0) {
        for (var x = 0; x < tab.length; x++) {
            tab[x].style.visibility = "hidden";
        }
        for (var x = 0; x < tabDiv.length; x++) {
            tabDiv[x].style.visibility = "hidden";
        }
        for (var x = 0; x < tabT.length; x++) {
            tabT[x].style.border = "none";
        }
        document.querySelector(".pick-menu").style.visibility = "hidden";
    }
});

document.querySelector(".completed-builds").addEventListener("click", function (){
    window.location.href="/Build";
});
/*Function for togglemenu*/

document.getElementById("sidebar").style.width = "0";
document.getElementById("main").style.marginLeft = "0";
var menuState = 1 // closed
function open_close() {
    if (menuState === 0) {
        menuState = 1;
        document.getElementById("sidebar").style.width = "350px";
        document.getElementById("main").style.marginLeft = "350px";

    } else {
        menuState = 0;
        document.getElementById("sidebar").style.width = "0";
        document.getElementById("main").style.marginLeft = "0";

    }
    console.log(menuState);
}
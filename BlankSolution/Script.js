function changeColor(obj) {
    var element = document.getElementById(obj.id);
    var col = window.getComputedStyle(element).backgroundColor;
    document.body.style.backgroundColor = col;
}

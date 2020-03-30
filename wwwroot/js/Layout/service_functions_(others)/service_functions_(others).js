function showPosition(obj) {
    alert(obj.offsetWidth);
    alert('Параметры в самом obj:\nx = ' + obj.offsetLeft + '\ny = ' + obj.offsetTop);
    var x = 0, y = 0;
    while (obj) {
        x += obj.offsetLeft;
        y += obj.offsetTop;
        obj = obj.offsetParent;
    }
    alert('Абсолютные значения:\nx = ' + x + '\ny = ' + y);
}
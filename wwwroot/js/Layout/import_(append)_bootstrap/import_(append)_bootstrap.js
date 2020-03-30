document.addEventListener('DOMContentLoaded', function () {
    var script1 = document.createElement('script');
    script1.src = "/lib/bootstrap/dist/js/bootstrap.js";
    document.body.appendChild(script1);

    var script2 = document.createElement('script');
    script2.src = "/lib/bootstrap/dist/js/bootstrap.bundle.js";
    document.body.appendChild(script2);
})
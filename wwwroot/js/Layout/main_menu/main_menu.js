function hide_main_content() {
    var x = document.getElementById("submenu");
    x.style.display = "none";

    x = document.getElementById("main_page_template_table");
    x.style.display = "none";

    x = document.getElementById("footer");
    x.style.display = "none";

    x = document.getElementById("KMMTs_logo");
    x.style.display = "none";

    x = document.getElementById("kfu_logo_mobile");
    x.style.display = "none";

    x = document.getElementById("navbar-toggler-icon");
    x.style.display = "none";

    x = document.getElementById("close_menu_button_mobile");
    x.style.display = "block";

    x = document.getElementById("navbar-toggler");
    x.style.marginLeft = "calc(50vw - 60px - 20px - 12.px)";

    var main_menu = document.getElementById("main_menu");
    main_menu.classList.remove("fixed-top");
}

function show_main_content(x) {
    var x = document.getElementById("submenu");
    x.style.display = "none";

    x = document.getElementById("main_page_template_table");
    x.style.display = "block";

    x = document.getElementById("footer");
    x.style.display = "block";

    x = document.getElementById("kfu_logo_mobile");
    x.style.display = "block";

    x = document.getElementById("KMMTs_logo");
    x.style.display = "block";

    x = document.getElementById("close_menu_button_mobile");
    x.style.display = "none";

    x = document.getElementById("navbar-toggler");
    x.style.marginLeft = "calc(50vw - 60px - 25px - 25px)";

    x = document.getElementById("navbar-toggler-icon");
    x.style.display = "block";

    var main_menu = document.getElementById("main_menu");
    main_menu.classList.add("fixed-top");
}

function switch_toggler_to_close_icon() {
    x = document.getElementById("navbar-toggler");
    x.style.display = "none";

    x = document.getElementById("close_menu_btn_desktop");
    x.style.display = "block";
}

function switch_close_icon_to_toggler() {
    x = document.getElementById("navbar-toggler");
    x.style.display = "block";

    x = document.getElementById("close_menu_btn_desktop");
    x.style.display = "none";
}

window.body_hidden = 0;

function Show_Hide_Body() {
    if (window.body_hidden == 0) {
        if ($(window).width() <= 768) {
            hide_main_content();
        }
        else {
            switch_toggler_to_close_icon();
        }

        window.body_hidden = 1;
    }

    else {
        if ($(window).width() <= 768) {
            show_main_content();
        }
        else {
            switch_close_icon_to_toggler();
            var collapse = document.getElementById("navbar-collapse");
            collapse.classList.remove("show");
        }

        window.body_hidden = 0;
    }
}

function hide_toggler() {
    var x = document.getElementById("navbar-toggler");
    x.style.display = "none";
}

document.addEventListener('fullscreenchange', (event) => {
    // document.fullscreenElement will point to the element that
    // is in fullscreen mode if there is one. If there isn't one,
    // the value of the property is null.
    if (document.fullscreenElement) {
        if ($(window).width() >= 1441) {
            hide_toggler();
        }
    }
});


$(window).resize(function () {
    if ($(window).width() <= 768) {
        $("#close_menu_btn_desktop").css("display", "none");

        if (window.body_hidden == 0) {
            $("#kfu_logo_mobile").show();
            $(".navbar-toggler").css("margin-left", "calc(50vw - 60px - 25px - 25px)");

            $(".close_menu_button_mobile").css("display", "none");
            $(".navbar-toggler-icon").css("display", "block");

            $("#submenu").css("display", "block");

            $("#main_page_template_table").css("display", "block");
            $("#footer").css("display", "block");
        }
        else {
            $(".navbar-toggler").css("margin-left", "calc(50vw - 50px)");
            $(".close_menu_button_mobile").css("display", "block");
            $(".navbar-toggler-icon").css("display", "none");
        }
    }
    else {
        $(".close_menu_button_mobile").css("display", "none");

        if (window.body_hidden == 1) {
            $(".navbar-toggler-icon").css("display", "block");
            $("#close_menu_btn_desktop").css("display", "block");
        }


        if ($(window).width() >= 769) {
            $(".navbar-toggler").css("margin-left", "(100vw - 769px) - 20px");
        }

        if ($(window).width() >= 834) {
            $(".navbar-toggler").css("margin-left", "calc(50px + (100vw - 834px) / 1.5 - 30px)");
        }

        if ($(window).width() >= 910) {
            $(".navbar-toggler").css("margin-left", "calc(100px + (100vw - 910px) - 30px)");
        }

        if ($(window).width() >= 986) {
            $(".navbar-toggler").css("margin-left", "calc(220px + (100vw - 1138px) * (240 - 220) / 76 - 30px)");
        }

        if ($(window).width() >= 1062) {
            $(".navbar-toggler").css("margin-left", "calc(240px + (100vw - 1062px) * (300 - 240) / 76)");
        }



        if ($(window).width() >= 1138) {
            $(".navbar-toggler").css("margin-left", "calc(300px + (100vw - 1138px) * (335 - 300) / 76)");
        }
        if ($(window).width() >= 1214) {
            $(".navbar-toggler").css("margin-left", "calc(355px + (100vw - 1214px) * (420 - 355) / 76)");
        }
        if ($(window).width() >= 1290) {
            $(".navbar-toggler").css("margin-left", "calc(420px + (100vw - 1290px) * (473 - 420) / 76)");
        }
        if ($(window).width() >= 1366) {
            $(".navbar-toggler").css("margin-left", "calc(473px + (100vw - 1366px) * (549 - 473) / 76)");
        }

        $('#kfu_logo_mobile').hide();
    }
});

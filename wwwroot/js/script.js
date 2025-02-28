// h�mta nuvarande url
let currentPage = window.location.pathname;
let allnavlinks = document.querySelectorAll(".nav-list li a")

// h�mtar alla meny l�nkar och s�tter en fuvktion p� den
$(allnavlinks).each(function() {
    // kollar om url matchar med n�gon av dem

    console.log($(this).attr("href"))
    
    if ($(this).attr("href") === currentPage) {
        // byter f�rg p� den l�nken som matchar url

        $(this).css("color", "#ff5733")
    }
});


/*  kommer ifr�n https://flatpickr.js.org/examples/ */ 
flatpickr('#datePicker', {
    altInput: true,
    altFormat: "F j, Y",
    dateFormat: "Y-m-d",
});  



/* Koden �r skapad genom en bladnig av ChapGPT, Googling coh tidigare kunskaper */ 
document.addEventListener("DOMContentLoaded", function () {
    // h�mtar knappar
    const goToTopLink = document.getElementById("goToTop");

    // s�tter funktionen p� knappen 
    goToTopLink.addEventListener("click", function (e) {
        e.preventDefault(); // tabort default l�nk fucktionen 

        // g�r till toppen 
        window.scrollTo({
            top: 0,
            behavior: "smooth"
        });
    });
});


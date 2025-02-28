// hämta nuvarande url
let currentPage = window.location.pathname;
let allnavlinks = document.querySelectorAll(".nav-list li a")

// hämtar alla meny länkar och sätter en fuvktion på den
$(allnavlinks).each(function() {
    // kollar om url matchar med någon av dem

    console.log($(this).attr("href"))
    
    if ($(this).attr("href") === currentPage) {
        // byter färg på den länken som matchar url

        $(this).css("color", "#ff5733")
    }
});


/*  kommer ifrån https://flatpickr.js.org/examples/ */ 
flatpickr('#datePicker', {
    altInput: true,
    altFormat: "F j, Y",
    dateFormat: "Y-m-d",
});  



/* Koden är skapad genom en bladnig av ChapGPT, Googling coh tidigare kunskaper */ 
document.addEventListener("DOMContentLoaded", function () {
    // hämtar knappar
    const goToTopLink = document.getElementById("goToTop");

    // sätter funktionen på knappen 
    goToTopLink.addEventListener("click", function (e) {
        e.preventDefault(); // tabort default länk fucktionen 

        // går till toppen 
        window.scrollTo({
            top: 0,
            behavior: "smooth"
        });
    });
});


window.refreshAos = function () {
    if (window.AOS && typeof window.AOS.refreshHard === "function") {
        window.AOS.refreshHard();
    }
};

window.scrollToTop = function () {
    window.scrollTo({ top: 0, behavior: "smooth" });
};

window.addEventListener("load", function () {
    if (window.AOS) {
        window.AOS.init({
            duration: 700,
            easing: "ease-out",
            once: true,
            mirror: false
        });
    }
});

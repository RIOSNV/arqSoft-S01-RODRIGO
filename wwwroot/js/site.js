// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", () => {
    const links = document.querySelectorAll('a:not([target="_blank"]):not([href^="#"])');
    const content = document.getElementById('page-content');

    if (content) { // Verificamos que el elemento exista
        links.forEach(link => {
            link.addEventListener('click', e => {
                e.preventDefault();
                const targetUrl = link.href;

                content.classList.remove('slide-in');
                content.classList.add('slide-out');

                setTimeout(() => {
                    window.location.href = targetUrl;
                }, 500);
            });
        });
    }
});
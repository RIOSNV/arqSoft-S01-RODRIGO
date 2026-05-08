document.addEventListener("DOMContentLoaded", () => {
    const links = document.querySelectorAll('a:not([target="_blank"]):not([href^="#"])');
    const content = document.getElementById('page-content');

    if (content) {
        links.forEach(link => {
            link.addEventListener('click', e => {
                if (link.hostname === window.location.hostname) {
                    e.preventDefault();
                    const targetUrl = link.href;

                    content.classList.remove('slide-in');
                    content.classList.add('slide-out');

                    setTimeout(() => {
                        window.location.href = targetUrl;
                    }, 500);
                }
            });
        });
    }
});
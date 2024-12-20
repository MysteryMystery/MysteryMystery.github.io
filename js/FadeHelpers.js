
window.initializeScrollEffect = () => {
    const element = document.getElementsByClassName('hero-fade');
    const container = document.getElementsByClassName('hero-fade-container');

    container.addEventListener('scroll', () => {
        const rect = element.getBoundingClientRect();
        const containerHeight = container.clientHeight;
        const elementCenter = rect.top + (rect.height / 2);
        const containerCenter = containerHeight / 2;
        const distanceFromCenter = Math.abs(elementCenter - containerCenter);
        const maxDistance = containerHeight / 2;
        const opacity = 1 - (distanceFromCenter / maxDistance);

        element.style.opacity = opacity;
    });
    }

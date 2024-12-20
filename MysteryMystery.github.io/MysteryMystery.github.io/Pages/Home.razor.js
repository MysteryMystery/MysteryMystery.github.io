export function initializeScrollEffect() {
    const containers = document.getElementsByClassName('hero-fade-container');

    window.addEventListener('scroll', () => {
        for (const container of containers) {
            const children = container.getElementsByClassName('hero-fade');

            for (const child of children) {
                const rect = child.getBoundingClientRect();
                const viewportHeight = window.innerHeight;
                const elementCenter = rect.top + (rect.height / 2);
                const screenCenter = viewportHeight / 2;
                const distanceFromCenter = Math.abs(elementCenter - screenCenter);
                const maxDistance = viewportHeight / 2;
                const opacity = 1.2 - (distanceFromCenter / maxDistance);

                let roundedOpacity = Math.abs(Math.ceil((opacity * 100) / 10) * 10);
                if (roundedOpacity > 100)
                    roundedOpacity = 100

                try {
                    child.classList.remove("bg-opacity-" + (roundedOpacity - 10))
                } catch {
                    
                }
                child.classList.add("bg-opacity-" + roundedOpacity)
            }
        }
    });
}

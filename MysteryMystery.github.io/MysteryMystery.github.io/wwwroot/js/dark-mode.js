window.applyDarkMode = function (mode) {
    try {
        const root = document.body;
        
        if (!root) {
            console.warn('documentElement not available yet');
            return;
        }

        if (mode === "dark") {
            root.classList.add("dark");
        } else {
            root.classList.remove("dark");
        }
    } catch (error) {
        console.error('Error applying dark mode:', error);
    }
}
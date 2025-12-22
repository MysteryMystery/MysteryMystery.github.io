window.applyDarkMode = function (mode) {
    const root = document.documentElement;

    if (!root) {
        console.warn('documentElement not available yet');
        return;
    }

    if (mode === "dark") {
        root.classList.add("dark");
    } else {
        root.classList.remove("dark");
    }
}

window.prefersDarkMode = function() {
    return window.matchMedia('(prefers-color-scheme: dark)').matches;
}
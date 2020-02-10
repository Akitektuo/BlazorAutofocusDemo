window.addEventListener("load", () => {
    const observer = new MutationObserver(() => {
        const elementToFocus = document.querySelector(".autofocus");
        elementToFocus && elementToFocus.focus();
    })

    observer.observe(document, { childList: true, subtree: true });
});

window.requestFocus = selector => {
    const element = typeof selector === "string" ? document.querySelector(selector) : selector;

    element.focus();
}
    
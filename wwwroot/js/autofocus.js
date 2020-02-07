window.addEventListener("load", () => {
    const observer = new MutationObserver(() => {
        const elementToFocus = document.querySelector(".autofocus");
        elementToFocus && elementToFocus.focus();
    })

    observer.observe(document, { childList: true, subtree: true });
});

window.requestFocus = selector => 
    document.querySelector(selector).focus();
window.focusCommandLine = () => {
    commandLine.focus();
};
window.autoScroll = () => {
    var element = document.documentElement;
    var bottom = element.scrollHeight - element.clientHeight;
    window.scroll(0, bottom);
};
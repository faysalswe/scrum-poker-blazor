window.clipboardCopy = {
    copyText: function (text) {
        navigator.clipboard.writeText(text).then(function () {
            alert("Copied room link!");
        })
        .catch(function (error) {
            alert(error);
        });
    }
};
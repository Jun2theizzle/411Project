var VM = VM || {};

VM.index = (function (ko, $) {
    function home() {
        var self = this;
        self.test = function () {
            alert('hi');

        };
    }
    function initModule() {
        ko.applyBindings(new home());
    }
    return { initModule: initModule };
})(ko, $);

$(function () {

    // identify which link matches the current page.
    var activeButton = $("#accordion").find("a[href='" + window.location.pathname + "']");
    // ensure accordian is open for the correct list-group-item
    var activePanelIndex = activeButton.parent().parent().data("panel-index");
    // toggle all closed.
    $('.collapse').removeClass("in");
    // toggle the correct panel
    $('.collapse[data-panel-index="' + activePanelIndex + '"]').addClass("in");
    // select the current list-group-item
    activeButton.addClass("active");

    // this works for the howto views
    var activePill = $("li[role='presentation']").find("a[href='" + window.location.pathname + "']");

    // remove active from all pills
    $("li[role='presentation']").removeClass("active");

    // set active on the correct pill
    activePill.parent().addClass("active");
});



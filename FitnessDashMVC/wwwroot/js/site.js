// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function showMacros(day) {
    day = day.slice(2)
    const id = "macroList(" + day + ")";
    const macro = document.getElementById(id);
    if (macro.style.display == "none") {
        macro.style.display = "inherit";
    } else {
        macro.style.display = "none";
    }
}
function showDailyReflection(day) {
    const id = day + "-P";
    const macro = document.getElementById(id);
    if (macro.style.display == "none") {
        macro.style.display = "inherit";
    } else {
        macro.style.display = "none";
    }
}

function removeLog(day) {
    let dayId = day.slice(5);
    document.getElementById(dayId).style.display = "none";
    console.log(dayId)
}
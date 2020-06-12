
function InitialLoad() {
    x = document.getElementById("DropBlock");
    if (x.style.display !== "block") {
        x.style.display = "none";
    }
}

function SubsectionLoad() {
    x = document.getElementById("DropBlock");
    x.style.display = "block";
}

function DropDownExpand() {
    x = document.getElementById("DropBlock");
    if (x.style.display === "none") {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}

function DropDownShrink() {
    x = document.getElementById("DropBlock");
    if (x.style.display === "block") {
        x.style.display = "none";
    }
}
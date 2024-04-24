let colors = [
    '#3498db',
    '#9b59b6',
    '#e74c3c',
    '#2c3e50',
    '#d35400',
]

let boxesDiv = document.querySelector(".boxes")
let pointSpan = document.querySelector(".points")
let btn = document.querySelector("#btn")

function renderBox(){
    colors.forEach(color =>{
        let box = document.createElement("div")
        box.classList.add("box")
        box.style.backgroundColor = color;
        box.addEventListener("click",function(){
            boxesDiv.removeChild(box);
            updatePoints(-1);
        });
        boxesDiv.appendChild(box);
    });
    updatePoints(colors.length)
}


function updatePoints(change){
    let currentPoint = parseInt(pointSpan.textContent)||0
    pointSpan.textContent = currentPoint + change;
}

btn.addEventListener("click",function(){
    renderBox()
})

renderBox()


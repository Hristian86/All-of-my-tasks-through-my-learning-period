$(document).ready(function(){
    $('.menu').click(function(){
        $('ul').toggleClass('active')
    })
})


const form = document.getElementById("formula")
const pass = document.getElementById("myPass")
const acc = document.getElementById("myAcc")
const error = document.getElementById("error")

var toDisplay = name;

form.addEventListener("submit",(e) => {
    let messeges =[];
    var passWord = ""+pass.value;
    var accaunt = ""+acc.value;
    
    if (accaunt.length < 3) {
        messeges.push("Accaunt name is to short!")
    }
    
    if (passWord.length < 3) {
        messeges.push("Password must be at least 3 symbols!")
    }
    
    if (passWord.length > 15) {
        messeges.push("Password is too long")
    }
    
    if (messeges.length > 0) {
       // error.innerText = messeges.join(",\n");  
       alert(messeges.join(`,\n`))
        clearText(pass);
        e.preventDefault()
    }
})


// function showPass(){
//     const pass1 = document.getElementById("myPass").value.toLowerCase();
//     const acc1 = document.getElementById("myAcc").value.toLowerCase();
//     const name = `My acc is >${acc1}< and,\n my password is >${pass1}<`
//     alert(name);
// }
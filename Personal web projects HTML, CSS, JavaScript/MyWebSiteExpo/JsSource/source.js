/*window.onscroll = function() { scrollFunction() };

function scrollFunction() {
    if (document.body.scrollTop > 80 || document.documentElement.scrollTop > 80) 
    {
        document.getElementById("navbar").style.padding = "30px 10px";
        document.getElementById("navi").style.fontSize = "25px";
    } 
    else 
    {
        document.getElementById("navbar").style.padding = "80px 10px";
        document.getElementById("navi").style.fontSize = "35px";
    }
}
*/
//function showPass() {
    const form = document.getElementById("formula")
    const pass = document.getElementById("myPass")
    const acc = document.getElementById("myAcc")
    const error = document.getElementById("error")
    
    var toDisplay = name;
    
    form.addEventListener("submit",(e) => {
        let messeges =[];
        var passWord = ""+pass.value;
        pass.value = "";
        var accaunt = ""+acc.value;
        acc.value = "";
        
        
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
            
          error.innerText = messeges.join(",\n");  
          
          e.preventDefault()
        }else{
            error.innerText = ""
            
        }
    
    })
            
//lert(messeges.join(`,\n`))
    // function showPass(){
    //     const pass1 = document.getElementById("myPass").value.toLowerCase();
    //     const acc1 = document.getElementById("myAcc").value.toLowerCase();
    //     const name = `My acc is >${acc1}< and,\n my password is >${pass1}<`
    //     alert(name);
    // }
    
    //}



function searching() 
{
var inpus = document.getElementById('searchbar').value
var filter = inpus.value
x = document.getElementsByName('animals')

for (var i = 0; i < x.lenght; i++) 
{
    if (!x[i].innerHTML.toLowerCase().includes(input)) 
    {
        x[i].style.display = "none"
    } 
    else 
    {
        x[i].style.display = "list-item"
    }
    
  }
  alert(x)
}

function greet() 
{
	console.log('hello')
}

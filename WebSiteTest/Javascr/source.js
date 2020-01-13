window.onscroll = function() { scrollFunction() };

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

function spazma(n) {
    var objcNumber = []
    var numAsText = "";
    var arr2 =[]
    for (var j = 0; j < objcNumber.length; j++) {
        arr2 = arr2[j]
       console.log(arr2)
        
    }
 for (var i = 1; i < n; i++) {
    numAsText+=i;
    objcNumber.push(numAsText)
    
     //console.log(numAsText + (objcNumber))
     //console.log(objcNumber[3])
     
 }
 var arr = []
for (var z = 0; z < objcNumber.length; z++) {
    arr.push(numAsText[z])
    console.log(arr)

}
}











//     let number = n;
//     var arr = [];
    
//     for (var i = 1; i < n; i++) {
//         var element = i;
//         var smalElement = parseInt(element);
//         var smaltext = smalElement.toString;
//         for (var y = 1; y < element; y++) {

//             arr.push(y);
          
//             console.log(arr)
            
//         }
//         console.log(smaltext)
//     }
// }
spazma(5);
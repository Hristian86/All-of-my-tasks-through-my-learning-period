


// MDB Lightbox Init
$(function () {
  $("#mdb-lightbox-ui").load("mdb-addons/mdb-lightbox-ui.html");
  });

$(document).ready(function(){
    $('.menu').click(function(){
        $('.list').toggleClass('active')
    })
})

function func(){
  const x = document.getElementById('hide');
  if (x.style.display == 'block') {
    x.style.display = 'none';
  }else{
    x.style.display = 'block';
  }

}


// window.onload = $(function(){  
//   $('#wrap').fadeIn('slow');  
// }); 

const x = document.getElementById('wrap');
const y = document.getElementById('buttonL');
var i = 0;


$(document).ready(function(){
  $("#wrap").hide(0).delay(500).fadeIn(1000)
  $("#buttonL").hide(0).delay(1300).fadeIn(1000)
});





// $(window).load(function(){
  // $("button").click(function(){
    // $("#wrap").fadeIn();
    // $("#buttonL").fadeIn("slow");
    // $("#buttonL").fadeIn(5000);
  // });
  // });
  
  
// window.onload = function myFunction() {

// x.style.opacity = 0;
//   var ops = 0.0;

//   // for (let i=1; i<10; i++) {
//     // setInterval() (dsp(i),1000)

//     var myVar = setInterval( function (){
//      var  s = `0.${i}`;
//      console.log(s);

//      setTimeout( function (){
      
//        x.style.opacity = s;
//       }, 750 );

//      var h = 8;
//      if(i == h) {
//        s = 1;
//        clearInterval(myVar);
//        dsp();
//        return;
//       }
//       i+=2;
//     }, 100 );
  
// }

// y.style.opacity = 0;


// function dsp(){

  
//   i = 0;
// var myVars = setInterval( function (){
//   var  s = `0.${i}`;
//   console.log(s);

//   setTimeout( function (){
   
//     y.style.opacity = s;
//    }, 750 );

//   var h = 8;
//   if(i == h) {
//     s = 1;
//     clearInterval(myVars);
//     return;
//    }
//    i+=2;
//  }, 100 );

// }



// function dsp(i) {
//   setTimeout( function timer(){
//     var  s = `0.${i}`;
//     console.log(s);
//     x.style.opacity = s;
//    }, 500 );
// }
// function asd() {
//   setTimeout( function timer(){
//     console.log("asd");
//   }, 100 );
// }


// MDB Lightbox Init
$(function () {
  $("#mdb-lightbox-ui").load("mdb-addons/mdb-lightbox-ui.html");
  });

// window.onscroll = function() {myFunction()};

// var navbar = document.getElementById("navbar");
// var sticky = navbar.offsetTop;

// function myFunction() {
//   if (window.pageYOffset >= sticky) {
//     navbar.classList.add("sticky")
//   } else {
//     navbar.classList.remove("sticky");
//   }
// };
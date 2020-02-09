
const firebaseConfig = {
    apiKey: "AIzaSyD9M5EA2Kn72-SxXtQx_m0pb8Ek_k8xvag",
    authDomain: "boza-8a350.firebaseapp.com",
    databaseURL: "https://boza-8a350.firebaseio.com",
    projectId: "boza-8a350",
    storageBucket: "boza-8a350.appspot.com",
    messagingSenderId: "642406210329",
    appId: "1:642406210329:web:8333b794e8a330d22fc388"
  };  
          
    
    
    
    const xhr = new XMLHttpRequest(); // get/post options
    const container = document.getElementById('container'); // display place
    const input = document.getElementById('input'); //search name value
    const taken = document.getElementById('taken'); //name value
    const age = document.getElementById('taken1');  //age value
    

   function createObj() { // func on creating person
    
       xhr.onload = function() { // connection check
        if (xhr.status === 200) {
            // POST   
        }else{
            console.log('it did not work');
        }
    }    

    if (taken.value !== "") { //name value diffrent from null check
        
        
        const toSend = {
            name: taken.value,
            age: age.value
        };
        
        taken.value = ""; // null name
        age.value = null; // null age

        const jsonString = JSON.stringify(toSend); // json file parset to variable
        console.log(jsonString);
        xhr.open("POST" , 'https://boza-8a350.firebaseio.com/.json'); // action for creating person and plase to connect
        xhr.setRequestHeader("Content-Type", "application/json"); // expected type
        xhr.send(jsonString); //send-ing data(object stats)
    }else{
        alert('Name is required');
    }
        
}

    function call() {

    xhr.onload = function() {
        if (xhr.status === 200) {
            var txt = xhr.responseText;
            var obj = {};
            obj = JSON.parse(txt);

            
            var current = {};
            

            const entries = Object.values(obj);
            var x = 1;
           for (var prop in entries) {
               
               //console.log(entries[prop].name);
               if (entries[prop].name == input.value) {
                   input.value = "";
                   console.log(entries[prop].name);
                   var y = ""+entries[prop].age;
                   var z = entries[prop].name;
                container.innerHTML += `${z} => ${y} `;
                break;
            }else{
                
            }
        }
        
            console.log(entries[0].age);
            // container.innerHTML = xhr.responseText;
            // container.innerHTML = 
        } else {
            console.warn('did not load');
        }
    };

    // GET

    xhr.open('get' , 'https://boza-8a350.firebaseio.com/.json', true);
    xhr.send();

}
    // POST

        // const toSend = {
        //     name: "jony",
        //     age: 22
        // };
       
    //     const jsonString = JSON.stringify(toSend);
    // console.log(jsonString);
    //     xhr.open("POST" , 'https://boza-8a350.firebaseio.com/.json');
    //     xhr.setRequestHeader("Content-Type", "application/json");
    // xhr.send(jsonString);









// function addUser() {

// }




// $(document).ready(function() {
    
//     const kinveyAppId = "kid_HyoKiB3MU";
    
//     const serviceUrl = "console.kinvey.com/apps/" +
//     kinveyAppId;
    
//     const kinveyUsername = "ico";
    
//     const kinveyPassword = "asd";
    
//     const base64auth = btoa(kinveyUsername + ":" +
//     kinveyPassword);
    
//     const authHeaders = { "Authorization": "Basic " + base64auth
//     };
    
//     $("#btnLoadPosts").click(loadPostsClick);
    
//     $("#btnViewPost").click(viewPostClick);
    
//     function loadPostsClick() { … }
    
//     function viewPostClick() { … }
    
//     function loadPostsClick() {
        
//         let loadPostsRequest = {
        
//         url: serviceUrl + "/posts",
        
//         headers: authHeaders,
        
//         };
        
//         $.ajax(loadPostsRequest)
        
//         .then(displayPosts)
        
//         .catch(displayError);
        
//         }

//         function displayPosts(posts) {
            
//             $("#container").empty();
            
//             for (let post of posts) {
            
//             let option = $("<option>")
            
//             .text(post.title)
            
//             .val(post._id);
            
//             $("#container").append(option);
            
//             }
            
//             }
    
//     });


// var xhr = new XMLHttpRequest();

// xhr.open('GET',
// ''
// );

// xhr.onload = function() {

// if (xhr.status === 200) {

// alert('User\'s name is ' +
// xhr.responseText);

// }

// else {

// alert('Request failed.Returned status of ' + xhr.status);

// }

// };

// xhr.send();


// $(document).ready(function() {

//     $("button").click(function() {

//         $.get("https://boza-8a350.firebaseio.com/.json" , function(data, status) {
//             $("#container").html(data);
            
//         })

//     });

// });
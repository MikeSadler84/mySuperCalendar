
function fetchTasks(){
    //create an ajax get request to /api/tasks
    //console log the response from the server
    $.ajax({
        url:"/api/tasks",
        type: "GET",
        success:tasks => { // If one parament, tasks => , is the same as function(tasks)
           console.log(tasks); 
           for(let i=0;i<tasks.length;i++){
               tasks[i];
               displayTask(tasks[i]);
           } 
        },
        error:details => {
            console.log("Error getting data", details);
        }
    });
}
function displayTask(tasks){
    var container = $("#tasks");
    var syntax = `
    <div class="task">
        <i class="far fa-circle check"></i>
        <div class="task-content">
            <h5 class="task-title">${tasks.title}</h5>
            <label class="task-notes">${tasks.notes}</label>
        </div>
        <i class="fas fa-star important"></i>
    </div> 
    `;
    container.append(syntax);
}
function register(){
    //get values from the form
    let title = $("#txtTitle").val();
    let notes= $("#txtNotes").val();
    let important= $("#chkImportant").is(":checked");

    //validations
    if(title.length < 5){
        alert("Please verify the title");
        return;
    }
    //create an object
    let task= {
        title: title,
        notes: notes,
        important: important
    };
    console.log(task);
    //send object to the backend
    $.ajax({
        url:"/api/createTask",
        type: "POST",
        data: JSON.stringify(task),
        contentType: "application/json",
        success:res => { // If one parament, tasks => , is the same as function(tasks)
           console.log("Server says", res); 
           displayTask(res); // shows the task on save without refreshing
        },
        error:details => {
            console.log("Error getting data", details);
        }
    })
    //clear the form
    $("#txtTitle").val("");
    $("#txtNotes").val("");
    document.getElementById("chkImportant").checked = false;
}
function init(){
    console.log("My Calendar Page");
    $("#btnSave").click(register);

    fetchTasks();
}

window.onload = init;
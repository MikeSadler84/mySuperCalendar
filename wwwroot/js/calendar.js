
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
function init(){
    console.log("My Calendar Page");
    fetchTasks();
}

window.onload = init;
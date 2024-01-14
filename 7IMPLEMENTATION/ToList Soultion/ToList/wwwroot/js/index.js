const TaskForm =document.getElementById("task-form");
const TaskList =document.getElementById("task-list");

let taskIndex=1;
//console.log(TaskForm,TaskInput)
TaskForm.addEventListener("submit", function (event){
    event.preventDefault();

    const taskInput =document.getElementById("Task-input");
    const taskText =taskInput.value.trim();

    if(taskText !== ""){
        const taskItem=document.createElement("li");
        taskItem.classList.add("task-item");
        taskItem.textContent=`${taskIndex}- ${taskText}`;

        taskItem.addEventListener("click",function(){
            console.log("completed");
            this.classList.toggle("completed");
        })

        TaskList.appendChild(taskItem);

        taskIndex++;

        taskInput.value="";
    }
});
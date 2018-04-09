// Exhibit Module Pattern
Task = require("./task")
TaskRepo = require("./taskRepo")


// Get The task from repo
var task1 = new Task(TaskRepo.get(1));

// complete the task
task1.complete();


// Get The task from repo
var task2 = new Task(TaskRepo.get(2));

// complete the task
task2.complete();

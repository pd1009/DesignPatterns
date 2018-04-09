TaskRepo = require("./taskRepo")

var Task = function(data) {
    this.name = data.name;
    this.completed = data.completed;
}


// Getting the task from  and saving the task to the db can be moved from here to 
// a different module that takes care of connecting with db

// So all this commented out here and moved to taskRepo

/*
Task.prototype.save = function () {
    console.log("Saving task: " + this.name + " to db");
}

*/

Task.prototype.complete = function () {
    console.log("Completing task: " + this.name);
    // Call Save to save it to the db
    TaskRepo.save(this);
}

module.exports = Task


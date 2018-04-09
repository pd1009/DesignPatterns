var taskRepo = function() {
   // Here we can have all the db related code

   // This is module design pattern but is looking very ugly and hard to read
   // So going to comment it out and create methods right outside
   /*
    return {
        get: function(id) {
            // get the task from db
            console.log("Getting task with " + id + " from db");
            return ({name: "Task with id: " + id + " retruned from db", completed: false});
            
        },

        save: function(task) {
            // save the task to db 
            console.log("Saving task: "+ task.name + " to db");
        }
    }*/

    var get = function(id) {
            // get the task from db
            console.log("Getting task with " + id + " from db called " + called);
            return ({name: "Task with id: " + id + " retruned from db", completed: false});
            
    };

    var save = function(task) {
            // save the task to db 
            console.log("Saving task: "+ task.name + " to db");
    };

    // This is revealing module pattern gives away all the methods available in this module and is 
    // very neat
    return {
        get: get,
        save: save
    };
}

// new or () to make it singleton
module.exports = new taskRepo
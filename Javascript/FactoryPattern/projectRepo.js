var projectRepo = function() {

    var get = function(id) {
            // get the task from db
            console.log("Getting project with " + id + " from db");
            return ({name: "Project with id: " + id + " retruned from db"});
            
    };

    // This is revealing module pattern gives away all the methods available in this module and is 
    // very neat
    return {
        get: get
    };
}

// new or () to make it singleton
module.exports = new projectRepo
var repoFactory = function() {

    // This creates a factory but caller has to call getRepo and then pass repo type
    // Commenting it out
    /*
    getRepo = function(name) {
        if (name === "user") {
            return UserRepo = require("./userRepo");
        }
        else if (name === "task") {
            if (this.taskRepo) {
                console.log("Getting task from cached task repo");
                return this.taskRepo;
            }

            console.log("Getting task from task repo");
            return TaskRepo = require("./taskRepo");
        }
        else if (name === "project") {
            return ProjectRepo = require("./projectRepo");
        }
    };
    
    return {
        getRepo: getRepo
    };*/

    // New factory implementation to make it clean while calling

    var repos = this;
    var repoList = [{name: "user", source: "./userRepo"},
                    {name: "task", source: "./taskRepo"},
                    {name: "project", source: "./projectRepo"}];

    repoList.forEach(function(repo){
        repos[repo.name] = require(repo.source);
    });

};

module.exports = new repoFactory
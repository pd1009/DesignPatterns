// Exhibit Module Pattern
Task = require("./task");
RepoFactory = require("./repoFactory");

// We don't have to import all the repos here
// Just the repo factory
/*
TaskRepo = require("./taskRepo");
UserRepo = require("./userRepo");
ProjectRepo = require("./projectRepo");
*/

// Get The task from repo

/*
var task1 = new Task(RepoFactory.getRepo("task").get(1));
var user1 = RepoFactory.getRepo("user").get(1);
var project1 = RepoFactory.getRepo("project").get(1);
*/

// After making the changes in factory code, calling can be cleaned up
var task1 = new Task(RepoFactory.task.get(1));
var user1 = RepoFactory.user.get(1);
var project1 = RepoFactory.project.get(1);



task1.user = user1;
task1.project = project1;

// complete the task
task1.complete();


// Get The task from repo
// After making the changes in factory code, calling can be cleaned up

/*
var task2 = new Task(RepoFactory.getRepo("task").get(2));
var user2 = RepoFactory.getRepo("user").get(2);
var project2 = RepoFactory.getRepo("project").get(2);
*/

// After making the changes in factory code, calling can be cleaned up
var task2 = new Task(RepoFactory.task.get(2));
var user2 = RepoFactory.user.get(2);
var project2 = RepoFactory.project.get(2);

task2.user = user2;
task2.project = project2;

// complete the task
task2.complete();

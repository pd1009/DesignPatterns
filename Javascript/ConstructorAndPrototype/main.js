// Constructor Design Pattern

// Create a function, and put new before that function call it gives an object
var Task = function(name, completed) {
    this.name = name;
    this.completed = completed;

    // This will create the method for each and every object created
    // so better to add it on the prototype
    /*
    this.complete = function() {
        this.completed = true;
        console.log(this.name + ' completed' );
    }*/
}

// This is prototype design pattern 
Task.prototype.complete = function() {
        this.completed = true;
        console.log(this.name + ' completed' );
}

// Creating an object of Task
var task1 = new Task("Create Constructor Design Pattern" , false);

console.log(task1.name + ' ' + task1.completed)

// Calling complete on task to complete it 
task1.complete();


// Creating an object of Task
var task2 = new Task("Create Module Design Pattern" , false);

console.log(task2.name + ' ' + task2.completed)

task2.complete();



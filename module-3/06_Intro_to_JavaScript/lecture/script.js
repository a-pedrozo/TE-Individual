// --------------------------------------------------------------------
// Code below is for LOCATIONS OF JS CODE
// --------------------------------------------------------------------

/*
    Example of a multi-line comment just like in C#
*/

// Single line comment

console.debug("Debug message from our JavaScript file!");
console.log("Log message from our JavaScript file!");
console.info("Info message from our JavaScript file!");
console.warn("Warning message from our JavaScript file!");
console.error("Error message from our JavaScript file!");

// Console.WriteLine won't work here
console.log("hello C#")

// Or will it? (revisit at end of lecture)



// --------------------------------------------------------------------
// Code below is for: CONST, LET, VAR & NAMED FUNCTIONS
// --------------------------------------------------------------------

/**
 * Functions start with the word function.
 * They don't have a return type and the naming convention is camel-case.
 */
function variables() {
  // TODO: Declares a variable where the value cannot be changed
  const weMissJohn = true;
  console.log(weMissJohn);
  // TODO: Declares a variable those value can be changed
  let myAge = 27;

  myAge++;

  console.log('my age is ' + myAge);
  // TODO: Declares a variable that will always be an array
  const grades = [3, 2, 6, 9, 4];

  
  // TODO: Demonstrate console logging
  console.log(grades);

}

variables();
// NOTE: Everything in JavaScript is camelCase except ClassNames

/**
 * Functions can also accept parameters.
 * Notice the parameters do not have types.
 * @param {Number} param1 The first number to display
 * @param {Number} param2 The second number to display
 */
function printParameters(param1, param2) {
  // TODO: Discuss this
  console.log(`The value of param1 is ${param1}`);
  console.log(`The value of param2 is ${param2}`);
}

/*
########################
Function Overloading
########################

Function Overloading is not available in Javascript. 
*/

function add(num1, num2) {
  return num1 + num2 + 1000;
}

function add(num1, num2, num3) { // this overwrites function on line 82
  return num1 + num2 + num3;
}



// --------------------------------------------------------------------
// Code below is for: EQUALITY & TRUTHY
// --------------------------------------------------------------------

// TODO: Discuss equality, == vs ===, and typeof

// TODO: Discuss truthy / falsy
// false, 0, '', null, undefined, and NaN are always falsy everything else is truthy

let myVariable = null;
if (myVariable){
  console.log('this value was truthy')
} else {
  console.log('the value was falsy')
}




// --------------------------------------------------------------------
// Code below is for JS DATA TYPES
// --------------------------------------------------------------------

// Common data types are:

// - strings
let city = 'Columbus';
// - numbers
let cohortNumber = 17;
// - arrays
let classes = ['.NET', 'Java Blue', 'Java Green'];
let randomJunk = [14, true, 'Hi', null];
// - undefined
let lastThingIBaked;
console.log('the last thing I baked was ' + lastThingIBaked);

// - object
let person = {
  name: 'jimothy',
  age: -0,
  spouse: null,
};

person.state = 'OH';
person.city = 'Flavortown';

console.log(person);
console.log(person.fullName);

// - functions
let loggingFunction = console.log; // note: no ()'s
console.log('my logging function ', loggingFunction);

// actually invoke the logging function 
loggingFunction('this is a weird way of calling a function');

/**
 *  Objects are simple key-value pairs
    - values can be primitive data types
    - values can be arrays
    - or they can be functions
*/
function objects() {

  // Create an object
  const person = {
    firstName: "Bill",
    lastName: "Lumbergh",
    age: 42,
    employees: [
      "Peter Gibbons",
      "Milton Waddams",
      "Samir Nagheenanajar",
      "Michael Bolton",
      "jimothy",
    ],
  };

  // TODO: Log the object
  console.log(person);


  // TODO: Log the first and last name
  console.log(person.firstName, person.lastName);
  // TODO: Log each employee
  for (let i = 0; i < person.employees.length; i++){
    console.log(person.employees[i]);

  }
  return person;
}
objects();







// --------------------------------------------------------------------
// Code below is for MATH AND STRINGS
// --------------------------------------------------------------------

/*
########################
Math Library
########################

A built-in `Math` object has properties and methods for mathematical constants and functions.
*/

function mathFunctions() {
  // TODO: Discuss this
  console.log("Math.PI : " + Math.PI);
  console.log("Math.LOG10E : " + Math.LOG10E);
  console.log("Math.abs(-10) : " + Math.abs(-10));
  console.log("Math.floor(1.99) : " + Math.floor(1.99));
  console.log("Math.ceil(1.01) : " + Math.ceil(1.01));
  console.log("Math.random() : " + Math.random());
}

/*
########################
String Methods
########################

The string data type has a lot of properties and methods similar to strings in Java/C#
*/

function stringFunctions(value) {
  // TODO: Discuss this
  console.log(`.length -  ${value.length}`);
  console.log(`.endsWith('World') - ${value.endsWith("World")}`);
  console.log(`.startsWith('Hello') - ${value.startsWith("Hello")}`);
  console.log(`.indexOf('Hello') - ${value.indexOf("Hello")}`);

  /*
    Other Methods
        - split(string)
        - substr(number, number)
        - substring(number, number)
        - toLowerCase()
        - trim()
        - https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String
    */
}









// --------------------------------------------------------------------
// Code below is for JS ARRAYS
// --------------------------------------------------------------------

// TODO: Add a function to filter out a specific value from an array
// TODO: Cover Array indexers
let numbers = [1, 2, 3, 4, 5];

console.log(numbers[0]); // indexes start at 0 
// TODO: Cover Array.Push - Appends to an array
let newNumbers = numbers.slice();
numbers.push(420);
// TODO: Cover Array.Splice
// TODO: Cover Array.Shift
numbers.shift();
console.log(numbers);
numbers.splice(0, 3); // removes the first 3 elements
console.log('after splice ', numbers);
// TODO: Cover Array.Unshift
numbers.unshift(32);
// TODO: Cover Array.Slice


// TODO: Cover Array.Concat
// pop removes the last element 
numbers.pop();
console.log(numbers);
console.log(newNumbers);

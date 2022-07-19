function add(x,y){
  return x + y;
}


/**
 * All named functions will have the function keyword and
 * a name followed by parentheses.
 * 
 * @returns {number} returns 1 always
 */
function returnOne() {
  return 1;
}

/**
 * Functions can also take parameters. These are just variables that are filled
 * in by whoever is calling the function.
 *
 * Also, we don't *have* to return anything from the actual function.
 *
 * @param {any} value the value to print to the console
 */
function printToConsole(value) {
  console.log(value);
}

/**
 * Takes an array and returns a new array of only numbers that are
 * multiples of 3
 *
 * @param {number[]} numbersToFilter numbers to filter through
 * @returns {number[]} a new array with only those numbers that are
 *   multiples of 3
 */
function allDivisibleByThree(numbersToFilter) {
let result = [];
for (let number of numbersToFilter){
  if (number % 3 == 0){ // divisible by 3 
    result.push(number); // add to the end 
  }
}
}


/**
 * Functions can return earlier before the end of the function. This could be useful
 * in circumstances where you may not need to perform additional instructions or have to
 * handle a particular situation.
 * In this example, if the firstParameter is equal to 0, we return secondParameter times 2.
 * Observe what's printed to the console in both situations.
 * 
 * @param {number} firstParameter the first parameter
 * @param {number} secondParameter the second parameter
 */
function returnBeforeEnd(firstParameter, secondParameter) {
  console.log("This will always fire.");

  if (firstParameter == 0) {
    console.log("Returning secondParameter times two.");
    return secondParameter * 2;
  }

  //this only runs if firstParameter is NOT 0
  console.log("Returning firstParameter + secondParameter.");
  return firstParameter + secondParameter;
}

/**
 * Scope is defined as where a variable is available to be used.
 *
 * If a variable is declare inside of a block, it will only exist in
 * that block and any block underneath it. Once the block that the
 * variable was defined in ends, the variable disappears.
 */
function scopeTest() {
  // This variable will always be in scope in this function
  let inScopeInScopeTest = true;

  if (inScopeInScopeTest)
  {
    // this variable lives inside this block and doesn't
    // exist outside of the block
    let scopedToBlock = inScopeInScopeTest;
  }

  // scopedToBlock doesn't exist here so an error will be thrown
  if (inScopeInScopeTest && scopedToBlock) {
    console.log("This won't print!");
  }
}

/**
 * Create an addThings method that takes in any number of number parameters and returns their total
 */




/**
 * Write a function called multiplyTogether that multiplies two numbers together. But 
 * what happens if we don't pass a value in? What happens if the value is not a number?
 *
 * @param {number} firstParameter the first parameter to multiply
 * @param {number} secondParameter the second parameter to multiply
 */
function multiplyTogether(firstParameter, secondParameter){
  return firstParameter * secondParameter;
}




/**
 * This version makes sure that no parameters are ever missing. If
 * someone calls this function without parameters, we default the
 * values to 0. However, it is impossible in JavaScript to prevent
 * someone from calling this function with data that is not a number.
 * Call this function multiplyNoUndefined
 *
 * @param {number} [firstParameter=0] the first parameter to multiply
 * @param {number} [secondParameter=0] the second parameter to multiply
 */
 function multiplyNotUndefined(firstParameter = 0, secondParameter = 0){
  return firstParameter * secondParameter;
 }




 // Let's document this function
 /** 
@param {String} name the name of the user
@param {number} age the number of years old 
@param {string[]} listOfQuirks any quirks person has 
@param {string} separator how to seperate quirks

@returns {string} information about user
*/
function createSentenceFromUser(name, age, listOfQuirks = [], separator = ', ') {
  let description = `${name} is currently ${age} years old. Their quirks are: `;
  
  return description + listOfQuirks.join(separator);
}

// Create a multiply function and store it in a variable
let multiplyFunction = function multiply(x,y){
return x * y;
}
//call this function
let result = multiplyFunction(4,2);

// Create an anonymous multiply function and store it in a variable
 multiplyFunction = function(x,y){
   return x * y;
 }
// Create an arrow multiply function and store it in a variable

// Create a single line arrow multiply function and store it in a variable
multiplyFunction = (x, y) => {
  return x * y;
}

multiplyFunction = (x, y) => x * y; // no return,this is  single line arrow function

// single arrow paramater function 
function say(message){
  console.log(message);
}

let sayFunction = (message) => {
  console.log(message);
}

// Create an array of movies

let movies = [
  {name: 'Die Hard', rating: 'PG'},
  {name: 'Princess Bride', rating: 'R'},
  {name: 'Watching Horror movies while dying from "allergies"', rating: 'F for fake'},
  {name: 'Nightmare on Elm St', rating: 'PG'},
  {name: 'Star Wars', rating: 'R'},
];

// find a specific movie 
let isMovieIWant = (movie) => {
  return movie.name === 'Watching Horror movies while dying from "allergies"';
}

let horrorMovie = movies.find(isMovieIWant);


let starWars = movies.find((movie) => {
  return movie.name === 'Star Wars'
})


// Find - Find a specific movie


// FindIndex - Find a movie by its index

// Filter - Only get movies of a certain rating
let onlyPGMovies = movies.filter((m) => m.rating === 'PG');

let numbers =[1, 2, 3, 4, 5, 6, 7, 8, 9]
let onlyDivisibleBy3 = numbers.filter((n) => n % 3== 0);

// Map - Select all movie titles
let movieTitles = movies.map((m) => m.name);

// Reduce - Pull together the total runtime of all movies

let grades = [2, 3, 4, 69, 420];
let startingTotal = 0;

function addGrade(priorTotal, grade){
  console.log('adding together ', priorTotal, grade)
  return priorTotal + grade;
}

let totalScore = grades.reduce(addGrade, startingTotal);
console.log('total grade is ' + totalScore);


function ourReducedFunction(gradeNumbers, initialTotal){
  let total = initialTotal;

  for (let grade of gradeNumbers){
    total = addGrade(grade, total);
  }

  return total;
}

/**
 * Takes an array and, using the power of anonymous functions, generates
 * their sum.
 *
 * @param {number[]} numbersToSum numbers to add up
 * @returns {number} sum of all the numbers
 */
function sumAllNumbers(numbersToSum) {
  
}

// Create a function that gets movies that match a specific function
function getMoviesMatchingFunction(allMovies, filterFunction){

  let matching = [];
let isMatch = filterFunction(movie);

if (isMatch){
  matching.push(movie);
}
return matching;
}


let matchingMovies = getMoviesMatchingFunction(movies, (m) => m.rating === 'R');
let princessMovies = getMoviesMatchingFunction(movies, (m) => m.name.includes('Star') || m.name.includes('Hard'));
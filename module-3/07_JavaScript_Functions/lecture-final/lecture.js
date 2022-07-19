function add(x = 0, y = 0) {
  return x + y;
}

// JS doesn't support overloading, so the last version of
// a function is the one that "wins"

// ...numbers says numbers will be an array of all parameters
function add(...numbers) {
  let sum = 0;

  // Add each number to our sum
  for (let i = 0; i < numbers.length; i++) {
    sum += numbers[i];
  }

  return sum;
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

returnOne();

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
  // This will always return undefined because no return 
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

  for (let number of numbersToFilter) {
    if (number % 3 == 0) { // divisible by 3
      result.push(number); // add to the end
    }
  }

  return result;
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
    console.log(scopedToBlock);

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
 * Create an addThings function that takes in any number of 
 * number parameters and returns their total
 */

// (see add above)


/**
 * Write a function called multiplyTogether that multiplies 
 * two numbers together. But 
 * what happens if we don't pass a value in? 
 * What happens if the value is not a number?
 *
 * @param {number} firstParameter the first parameter to multiply
 * @param {number} secondParameter the second parameter to multiply
 */
function multiplyTogether(firstParameter, secondParameter) {
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
function multiplyTogether(firstParameter = 0, secondParameter = 0) {
  return firstParameter * secondParameter;
}




 // Let's document this function

 /**
  * Takes information about a user and returns a string
  * 
  * @param {string} name the name of the user
  * @param {number} age the number of years old
  * @param {string[]} listOfQuirks any quirks the person has
  * @param {string} separator how to separate quirks in the quirk list
  * @returns {string} information about the user
  */
function createSentenceFromUser(name, age, listOfQuirks = [], separator = ', ') {
  let description = `${name} is currently ${age} years old. Their quirks are: `;
  
  return description + listOfQuirks.join(separator);
}

// Create a multiply function and store it in a variable
let multiplyFunction = function multiply(x, y) {
  return x * y;
}

// Call this function
let result = multiplyFunction(4,2);

// Create an anonymous multiply function and store it in a variable
 multiplyFunction = function(x, y) {
   return x * y;
 }

// Create an arrow multiply function and store it in a variable
multiplyFunction = (x, y) => { // THIS IS THE SWEET SPOT
  let total = x * y;
  return total;
}

// Create a single line arrow multiply function and store it in a variable
multiplyFunction = (x, y) => x * y; // no return


// Single Parameter Arrow Function
function say(message) {
  console.log(message);
}

let sayFunction = (message) => {
  console.log(message);
}

sayFunction = (m) => {
  console.log(m);
}

sayFunction = (m) => console.log(m);

sayFunction = m => console.log(m); // ()'s are optional if 1 parameter

sayFunction = () => console.log('Hello World');

// Create an array of movies
let movies = [
  {name: 'Die Hard', rating: 'R'}, 
  {name: 'Princess Bride', rating: 'PG'}, 
  {name: 'The Thing', rating: 'R'}, 
  {name: 'Back to the Future', rating: 'PG-13'},
  {name: 'Frozen Toy Story', rating: 'PG'},
];

// Find - Find a specific movie

let isMovieIWant = (movie) => {
  return movie.name === 'Die Hard';
}

let dieHard = movies.find(isMovieIWant);

let backToTheFuture = movies.find((movie) => {
  return movie.name === 'Back to the Future';
});

let princessBride = movies.find((m) => m.name === 'Princess Bride');

// FindIndex - Find a movie by its index
let movieName = 'Die Hard';
let dieHardIndex = movies.findIndex((m) => m.name === movieName);

// Filter - Only get movies of a certain rating
let onlyPGMovies = movies.filter((m) => m.rating === 'PG');

let numbers = [1, 2, 3, 4, 5, 6, 7];
let onlyDivisibleBy3 = numbers.filter((n) => n % 3 == 0);

// Map - Select all movie titles
let movieTitles = movies.map((m) => m.name);
let movieRatings = movies.map((m) => m.rating);
let bigNumbers = numbers.map((n) => n * 2);

// Reduce - Pull together the total runtime of all movies

let grades = [2, 3, 3, 1, 2, 0, 3];
let startingTotal = 0;

function addGrade(priorTotal, grade) {
  console.log('Adding together ', priorTotal, grade);
  return priorTotal + grade;
}

let totalScore = grades.reduce(addGrade, startingTotal);
console.log('Total grade is ' + totalScore);

function ourReduceFunction(gradeNumbers, reduceFunction, initialTotal) {
  let total = initialTotal;

  for (let grade of gradeNumbers) {
    total = reduceFunction(grade, total);
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
  let sum = 0;

  for (let number of numbersToSum) {
    sum += number;
  }

  return sum;
}

// Create a function that gets movies that match a specific function
function getMoviesMatchingFunction(allMovies, filterFunction) {
  /*
  let matching = [];

  for (let movie of allMovies) {
    let isMatch = filterFunction(movie);

    if (isMatch) {
      matching.push(movie);
    }
  }

  return matching;
  */
 return allMovies.filter(filterFunction);
}

let matchingMovies = getMoviesMatchingFunction(movies, (m) => m.rating === 'R');
let princessMovies = getMoviesMatchingFunction(movies, (m) => m.name.includes('Princess') || m.name.includes('Frozen'));

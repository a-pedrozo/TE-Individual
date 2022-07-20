// add pageTitle
let pageTitle = 'My Shopping List'
// add groceries
let groceries = ["Adult Diapers", "SUBS", "Lubricant", "Bottle of Rum", "Explosives", "Full body waifu pillow", "Crop top with gray sweatpants", "two left handed mittens", "a box of crayons", "Jeffery Epstien's Logbook" ]

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  let title = document.querySelector('#title');
  
  title.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  let groceryUl = document.getElementById('groceries');
  
  groceries.forEach((grocery) => {

    let li = document.createElement('li');
    
    li.innerText= grocery;


    groceryUl.appendChild(li);

  });
  
}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {
  let groceryUl = document.querySelectorAll('#groceries > li');

  groceryUl.forEach((liComplete) => {
    liComplete.classList.add('completed');
  });
}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});

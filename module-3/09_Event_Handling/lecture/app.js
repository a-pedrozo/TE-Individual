// Data  ------------------------------------------------------------------------------------------

const name = 'Cigar Parties for Dummies';
let description = 'Host and plan the perfect cigar party for all of your squirrelly friends.';
let reviews = [
  {
    reviewer: 'Malcolm Gladwell',
    title: 'What a book!',
    review:
      "It certainly is a book. I mean, I can see that. Pages kept together with glue and there's writing on it, in some language.",
    rating: 3
  }
];

// Pre-Built Functions ---------------------------------------------------------------------------

/**
 * Add our product name to the page title
 * Get our page page title by the id and the query the .name selector
 * once you have the element you can add the product name to the span.
 */
function setPageTitle() {
  const pageTitle = document.getElementById('page-title');
  pageTitle.querySelector('.name').innerHTML = name;
}

/**
 * Add our product description to the page.
 */
function setPageDescription() {
  document.querySelector('.description').innerHTML = description;
}

/**
 * Displays all of the reviews in the reviews array
 */
function displayReviews() {
  if ('content' in document.createElement('template')) {
    reviews.forEach((review) => displayReview(review)); // This could also be written reviews.forEach(displayReview);
  } else {
    console.error('Your browser does not support templates');
  }
}

/**
 * Displays all reviews on the page
 * @param {Object} review The review to display
 */
function displayReview(review) {
  const main = document.getElementById('main');

  // This grabs a template out of the HTML and clones it, then selects the template to customize it
  const clonedNode = document.getElementById('review-template').content.cloneNode(true);
  clonedNode.querySelector('h4').innerText = review.reviewer;
  clonedNode.querySelector('h3').innerText = review.title;
  clonedNode.querySelector('p').innerText = review.review;

  // there will always be 1 star because it is a part of the template
  for (let i = 1; i < review.rating; ++i) {
    const img = clonedNode.querySelector('img').cloneNode();
    clonedNode.querySelector('.rating').appendChild(img);
  }
  
  main.appendChild(clonedNode);
}

/**
 * Shows / hides the add review form
 * @param {Event} event the event that occurred in the browser
 */
function showHideForm(event) {
  console.log('showHideForm', event);

  const form = document.querySelector('form');
  const btn = document.getElementById('btnToggleForm');

  if (form.classList.contains('d-none')) {
    form.classList.remove('d-none');
    btn.innerText = 'Hide Form';
    document.getElementById('name').focus();
  } else {
    resetFormValues();
    form.classList.add('d-none');
    btn.innerText = 'Add Review';
  }
}

/**
 * Resets all of the values in the form.
 */
function resetFormValues() {
  const form = document.querySelector('form');
  const inputs = form.querySelectorAll('input');
  inputs.forEach((input) => {
    input.value = '';
  });
  document.getElementById('rating').value = 1;
  document.getElementById('review').value = '';
}

/**
 * Take an event on the description and swap out the description for a text box.
 * @param {Event} event the event that occurred in the browser
 */
function showDescriptionEdit(event) {
  console.log('Show Description Edit', event);

  const target = event.target; // the DOM element the event occoured on (p tag)

// get teh next child of our parent (this will be the input box)
  const textBox = target.nextElementSibling;

  // showing the text box and hiding the paragraph
  textBox.value = description;
  textBox.classList.remove('d-none'); // d-none is a bootstrap class to set it display: none

  target.classList.add('d-none'); // target is the paragraph

  // putting the keyboard focus on our textbox
  textBox.focus();
}

/**
 * Take an event on the text box and set the description to the contents
 * of the text box and then hide the text box and show the description.
 *
 * @param {Event} event the event object representing the description we're editing
 * @param {Boolean} save should we save the description text
 */
function exitDescriptionEdit(event, save) {
  const target = event.target; // Target is the thing that generated the event (our description input)

  
  // get the paragraph (currently hidden)
  const desc = target.previousElementSibling;

  // If we're saving, get the new value and set that into description and desc
  if (save) {
    description = target.value;

    desc.innerText = description;
  }
  // show the paragraph and hide the input
  target.classList.add('d-none');
  desc.classList.remove('d-none');
}

// LECTURE STARTS HERE ---------------------------------------------------------------

function initialize() {
  // set the product reviews page title
  setPageTitle();

  // set the product reviews page description
  setPageDescription();

  // display all of the product reviews on our page
  displayReviews();

  // -----------------------------------------------

  // Step 2: When the user clicks on btnToggleForm, call showHideForm
  //Find element in the DOM by it's ID
  let showButton = document.querySelector('#btnToggleForm');

  //register a click handler that get's called when clicked 
  showButton.addEventListener('click', (event) => {
    console.log('User clicked show/hide form button', event);

    showHideForm(); // provided function for us in lecture code 
  });
  // Step 3: When the user clicks btnSaveReview, call saveReview
  let saveButton = document.querySelector('#btnSaveReview');

  saveButton.addEventListener('click', (event) => {
    console.log('User clicked show/hide form button', event);

        

    saveReview(event);
  });

  // -----------------------------------------------

  // Step 4: When the user double clicks the description paragraph, 
  // call showDescriptionEdit and pass it the event
  let paragraph = document.querySelector('p.description');
  paragraph.addEventListener('dblclick', event => {
    console.log('user double-clicked the description paragraph', event);

    showDescriptionEdit(event); // another provided function from lecture code
  });

  // Step 5: When the user presses a key on the input with an ID of inputDesc, 
  // check for enter and escape and call exitDescriptionEdit
  let descriptionInput = document.querySelector('#inputDesc');
  descriptionInput.addEventListener('keydown', (event) => {
    console.log('key down', event);
    if (event.key === 'Enter'){
      exitDescriptionEdit(event, true);
    } else if (event.key === 'Escape'){
      exitDescriptionEdit(event, false);
    }
  });

  // ------------------------------------------------

  // Step 6: Add a click listener for when the user clicks the body element and talk bubbling
  document.addEventListener('click', (event) => {
    console.log('event has occoured', event.target);
  });
}


/**
 * I will save the review that was added using the add review from
 * @param {Event} event the event that occurred in the browser
 */
function saveReview(event) {
  console.log('Saving Review', event);

  //the default behavior of submitting a form is to refresh the page, we dont want that, so prevent it
  event.preventDefault();

  // Get the value of the name, title, review, and rating controls (these are their ids)
  let nameBox = document.querySelector('#name');
  let reviewName = nameBox.value;

  let titleBox = document.querySelector('#title');
  let titleName = titleBox.value;

  let ratingBox = document.querySelector('#rating');
  let ratingValue = ratingBox.value;

  let reviewBox = document.querySelector('#review');
  let reviewText = reviewBox.value;

  console.log(reviewName, titleName, ratingValue, reviewText);

  // Create a new review object with these values for reviewer, 
  // title, review, and rating
  let newReview = { // this creates new object 
    reviewer: reviewName,
    title: titleName,
    review: reviewText,
    rating: ratingValue,
  };

  // Add the new object to reviews
  reviews.push(newReview);
  console.log(reviews);
  // Call displayReview with the new review as a parameter
  displayReview(newReview);
  // Call showHideForm to toggle the form visibility
  showHideForm();
}

// Step 1: Call initialize when the DOM is ready
document.addEventListener('DOMContentLoaded', (event) => {
  console.log('DOM loaded', event);
  initialize(); // function to set title, description, and display reviews
});
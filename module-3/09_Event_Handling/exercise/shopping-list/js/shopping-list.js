let allItemsIncomplete = true;
const pageTitle = 'My Shopping List';
const groceries = [
  { id: 1, name: 'Oatmeal', completed: false },
  { id: 2, name: 'Milk', completed: false },
  { id: 3, name: 'Banana', completed: false },
  { id: 4, name: 'Strawberries', completed: false },
  { id: 5, name: 'Lunch Meat', completed: false },
  { id: 6, name: 'Bread', completed: false },
  { id: 7, name: 'Grapes', completed: false },
  { id: 8, name: 'Steak', completed: false },
  { id: 9, name: 'Salad', completed: false },
  { id: 10, name: 'Tea', completed: false }
];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const title = document.getElementById('title');
  title.innerText = pageTitle;
  title.querySelector('title')
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const ul = document.querySelector('ul');
  groceries.forEach((item) => {
    const li = document.createElement('li');
    li.innerText = item.name;
    const checkCircle = document.createElement('i');
    checkCircle.setAttribute('class', 'far fa-check-circle');
    li.appendChild(checkCircle);
    ul.appendChild(li);
  });

  
}


document.addEventListener('DOMContentLoaded', (event) => {
  console.log('do stuff damn you', event);
  setPageTitle();
  displayGroceries();
  

  let list = document.querySelectorAll('li');
  list.forEach((item) =>{
    item.addEventListener('click', (event) =>{
      console.log('this event works?', event)
        let checkCircle = item.querySelector('i');
        checkCircle.classList.add('completed');
        item.classList.add('completed');

      
    });

  });
    let toggleAll = document.querySelector('.btn');
    list = document.querySelectorAll('li');
    
    toggleAll.addEventListener('click', (event) =>{
      
      list.forEach((item) => {
        
          console.log('still working', event);
          let checkCircle = item.querySelector('i');
          checkCircle.classList.add('completed');
          item.classList.add('completed');

      });
      
    });
    list.forEach((item) =>{
      item.addEventListener('dblclick', (event) =>{
        console.log('loop deez nuts', event)
        
        
          let checkCircle = item.querySelector('i');
          checkCircle.classList.remove('completed');
          item.classList.remove('completed');
          
  
        
      });
  
    });

    toggleAll.addEventListener('dblclick', (event) =>{
      
      list.forEach((item) => {
        
          console.log('still working', event);
          let checkCircle = item.querySelector('i');
          checkCircle.classList.remove('completed');
          item.classList.remove('completed');


      });
      
    });
  
});


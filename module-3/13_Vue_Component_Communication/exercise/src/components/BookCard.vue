<template>
  <div class="card">
    <!-- Please leave <img> commented out until directed to remove open and close comment tags in the README.
    -->
    <h3 class="book-title">{{ book.title }}</h3>
    <img v-if="book.isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'" />
    <p class="book-author">{{ book.author }}</p>
    <button class="read">Mark button goes here</button>
    
  </div>
</template>

<script>
export default {
  name: "book-card",
  props: ["book"]
  
};
</script>

<style>
.card {
  border: 2px solid black;
  border-radius: 10px;
  width: 250px;
  height: 550px;
  margin: 20px;
}

.card.read {
  background-color: lightgray;
}

.card .book-title {
  font-size: 1.5rem;
}

.card .book-author {
  font-size: 1rem;
}
</style>
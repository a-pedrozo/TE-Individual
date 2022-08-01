<template>
  <div class="card" v-if="this.book.read == true" v-bind:class="read">
   
    <h3 class="book-title">{{ book.title }}</h3>
    <img v-if="book.isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'" />
    <p class="book-author">{{ book.author }}</p>
    
    <button class="mark-read" v-on:click="flipStatus()" v-if="book.read == true">Mark Unread</button>
    <button class="mark-unread" v-on:click="flipStatus()" v-if="book.read == false">Mark Read</button>
    
  </div>
</template>

<script>
export default {
  name: "book-card",
  props: ["book"],
    
    methods: {
        flipStatus(){
            this.$store.commit('FLIP_FAVORITED', this.book)
        }
    }
 
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
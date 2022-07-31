<template>
  <div class="book-container">
   <book-card/>
   <book-card/>
   <book-card/>
   <book-card/>
  </div>
</template>

<script>
import BookCard from './BookCard.vue';
export default {
  components: { BookCard },
  name: "reading-list",
  data() {
    return {
      books: [
        {
          title: "Kafka on the Shore",
          author: "Haruki Murakami",
          read: false,
          isbn: "9781400079278",
        },
        {
          title: "The Girl With All the Gifts",
          author: "M.R. Carey",
          read: true,
          isbn: "9780356500157",
        },
        {
          title: "The Old Man and the Sea",
          author: "Ernest Hemingway",
          read: true,
          isbn: "9780684830490",
        },
        {
          title: "Le Petit Prince",
          author: "Antoine de Saint-Exupéry",
          read: false,
          isbn: "9783125971400",
        },
      ],
    };
  },
};
</script>

<style>
div.book-container {
  display: flex;
  justify-content: space-evenly;
  flex-wrap: wrap;
}

</style>
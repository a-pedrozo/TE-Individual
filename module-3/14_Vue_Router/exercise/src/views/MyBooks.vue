<template>
  <div>
    <reading-list />
    <a href="NewBook.vue">Add Book to Reading List</a>

  </div>
</template>

<script>
import ReadingList from '../components/ReadingList.vue';


export default {
  components: {
    ReadingList,
    
  }
};
</script>
    

<style>
</style>
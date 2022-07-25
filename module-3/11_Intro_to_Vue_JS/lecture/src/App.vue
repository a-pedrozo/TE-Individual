<template>
  <!-- This HTML will be added to the page for App.vue -->
  <div id="app">
    <h1>Hello Vue.js</h1>
    <!-- ProductReviews goes here -->
  </div>
</template>

<script>
// This JS represents a "class" within Vue.js representing a component or part of the screen
export default {
  name: 'App',
  components: {
    // ProductReviews goes here
  }
}
</script>

<style>
/* These CSS styles are applied to anything in the app.vue or any child component */

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>

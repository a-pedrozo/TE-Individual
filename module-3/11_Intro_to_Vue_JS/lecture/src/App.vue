<template>
  <!-- This HTML will be added to the page for App.vue -->
  <div id="app">
    <h1>Property Reviews</h1>
    <!-- add in the product-reviews component to my DOM  -->
    <product-reviews />
  </div>
</template>

<script>
// This JS represents a "class" within Vue.js representing a component or part of the screen
import ProductReviews from './components/ProductReviews.vue';

export default {
  name: 'App',
  components: {
    // ProductReviews goes here
    ProductReviews // i am allowed to use ProductReviews or product-reviews in my template
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

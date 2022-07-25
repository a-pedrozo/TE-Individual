<template>
  <section>
    <h2>Property Reviews for {{productName}}</h2>

    <h3>Search</h3>
    <div>
        <label for="searchText">Search Text</label>
        <!--as the user inputs values, we want search.text to change -->
        <input type="text" id="searchText" v-model="search.text">
    </div>


    <h3>Reviews Matching '{{search.text}}' </h3>
    <!--line 7 is how to for loop, v-bind is unique identifier, hw will use email instead of int id-->
    <article v-for="review in reviews" v-bind:key="review.id"
    v-bind:class="{badRating: review.rating <=1, 
    goodRating: review.rating >= 5}"> 
      <h4>{{review.reviewer}}</h4>
      <!--Review Star Rating goes here-->
      <img v-for="stars in review.rating" v-bind:key="stars"
                src="../assets/logo.png"
                alt="Vie.js logo">
      <p>{{review.text}}</p>
    </article>
  </section>
</template>

<script>
export default {
  // Data is a function that returns the starting data for the component
  data() {
    // Create and return an object that represents the starting data
    // these are similar to C# properties. e.g. :public string productName {get; set;} = "whaterver";
    return {
        search:{
            text: '',
        }, // this search is how the hw will implement search tool. 
        //search is an object containing properties about the search. in this case, just text. we bind to this with search.text

      productName: "Underbridge Box Condo",
      reviews: [
        {id: 1, reviewer: "Chandler", rating: 3, text: "Could use more windows to lick"},
        {id: 2, reviewer: "Matt", rating: 1, text: "the place looks like a bag of ass"},
        {id: 3, reviewer: "John", rating: 5, text: "this condo be bussin bussin, no cap"}
      ],
    };
  },
  // computed is an object that has functions in it
  // computed functions are like C# derived properties
  computed: {
      filteredReviews() {
          // this keyword is REQUIRED in computed 
          // this keyword should ONLY occur in computed 
          return this.reviews.filter(r => {
              // if the user typed in some search text, and...
              // the review text doesn't include that search text, exclude this result
              if (this.search.text && !r.text.toLowerCase().includes(this.search.text.toLowerCase())) {
                  return false;
              
              }
              // true indicates it should be included in array 
              // this way will be on homework times 6
              return true;
          });
      }
  }
}
</script>

<style>
h2 {
  color: steelblue;
}

article {
    background-color: lemonchiffon;
}

article img {
    height: 50px;

}

.goodRating{
    background-color: gold;
}
.badRating{
    background-color: coral;
}
input{
    margin-left: 0.5rem;
}
</style>
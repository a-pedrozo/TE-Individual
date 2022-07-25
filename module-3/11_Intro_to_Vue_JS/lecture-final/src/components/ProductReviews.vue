<template>
  <section>
    <h2>Product Reviews for {{productName}}</h2>

    <h3>Search</h3>
    <div>
        <label for="searchText">Search Text</label>
        <!-- As the user inputs values, we want search.text to change -->
        <input type="text" id="searchText" v-model="search.text">
    </div>

    <h3>Reviews Matching '{{search.text}}'</h3>
    <!-- For every review in reviews, create a variable named review, and a copy of article (and its children)
         v-bind:key is just something unique about each item for Vue to track -->
    <article v-for="review in filteredReviews" v-bind:key="review.id"
             v-bind:class="{badRating: review.rating <= 1,
                            goodRating: review.rating >= 5}">
        <h4>{{review.reviewer}}</h4>
        <!-- Review Star Rating goes here -->
        <!-- Loops from 1 to review.rating -->
        <img v-for="stars in review.rating" v-bind:key="stars"
             src="../assets/logo.png"
             alt="Vue.js Logo">
        <p>{{review.text}}</p>
    </article>
  </section>
</template>

<script>
export default {
    // Data is a function that returns the starting data for the component
    data() {
        // Create a return and object that represents the starting data
        // These are similar to C# properties. e.g.: public string productName {get; set;} = "Glizzies";
        return {
            // search is an object containing properties about the search. In this case, just text. We bind to this with search.text
            search: {
                text: '',
            },
            productName: 'Glizzies', // A form of hot dog (supposedly)
            reviews: [
                {id: 1, reviewer: 'Chandler', rating: 4, text: 'Matt, do not put me on the spot!'},
                {id: 2, reviewer: 'Matt', rating: 1, text: 'What even is a Glizzy anyways?'},
                {id: 3, reviewer: 'John', rating: 5, text: 'Best Glizzy I have ever seen!'}
            ],
        };
    },
    // Computed is an object that has functions in it
    // computed functions are like C# derived properties
    computed: {
        filteredReviews() {
            // this keyword is REQUIRED in computed
            // this keyword should ONLY occur in computed

            return this.reviews.filter(r => {

                // If the user typed in some search text, and...
                // The review text doesn't include that search text, exclude this result  
                if (this.search.text && !r.text.toLowerCase().includes(this.search.text.toLowerCase())) {
                    return false;
                }

                // True indicates it should be included in my array
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

    .goodRating {
        background-color: gold;
    }

    .badRating {
        background-color: coral;
    }

    input {
        margin-left: 0.5rem;
    }
</style>
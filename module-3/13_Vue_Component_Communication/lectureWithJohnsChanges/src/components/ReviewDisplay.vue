<template>
  <div
    class="review"
    v-bind:class="{ favorited: reviewProp.favorited }"
    v-bind:key="reviewProp.id"
  >
    <h4>{{ reviewProp.reviewer }}</h4>
    <div class="rating">
      <img
        src="../assets/star.png"
        v-bind:title="reviewProp.rating + ' Star Review'"
        class="ratingStar"
        v-for="n in reviewProp.rating"
        v-bind:key="n"
      />
    </div>
    <h3>{{ reviewProp.title }}</h3>
    <p>{{ reviewProp.review }}</p>
    <p>
      Favorite?
      <input type="checkbox" v-bind:checked="reviewProp.favorited" />
    </p>
  </div>
</template>

<script>
export default {
  name: "review-display",

  //props: ["reviewProp"],

  props: {
    reviewProp: Object
  },

  
  methods: {
    onFavoritedChange() {},
  },
};
</script>

<style>
div.main div.review {
  border: 1px black solid;
  border-radius: 6px;
  padding: 1rem;
  margin: 10px;
}

div.main div.review.favorited {
  background-color: lightyellow;
}

div.main div.review div.rating {
  height: 2rem;
  display: inline-block;
  vertical-align: top;
  margin: 0 0.5rem;
}

div.main div.review div.rating img {
  height: 100%;
}

div.main div.review p {
  margin: 20px;
}

div.main div.review h3 {
  display: inline-block;
}

div.main div.review h4 {
  font-size: 1rem;
}
</style>

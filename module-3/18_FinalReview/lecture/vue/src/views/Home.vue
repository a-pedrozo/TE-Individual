<template>
  <div class="home">
    <h1>Trolley Problems</h1>
    <p>Take a look at the diabolical trolley problems our users have suggested.</p>
    <small>Legal disclaimer: do not tie people to railroad tracks</small>

    <!-- For every trolley problem, display a TrolleyProblem component for it -->
    <problem v-for="p in trolleyProblems" v-bind:key="p.id"
             v-bind:problem="p" />
  </div>
</template>

<script>
import ProblemService from '../services/ProblemService.js';
import Problem from '../components/Problem.vue';

export default {
  name: "home",
  components: {
    Problem
  },
  computed: {
    trolleyProblems() {
      return this.$store.state.problems;
    }
  },
  created() {
    // Call out to the API to get trolley problems
    ProblemService.getAllProblems()
      .then(response => {
        // When we get trolley problems, set their data into Vuex
        console.log('Got trolley data back', response.data);

        this.$store.commit('PROBLEMS_LOADED', response.data);
      })
  }
};
</script>

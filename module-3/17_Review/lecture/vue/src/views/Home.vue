<template>
  <div class="home">
    <h1>Trolley Problem</h1>
    <p>Take a look at at the diabolical trolley problems our users have suggested</p>
    <small> legal disclaimer: do not tie people to railroad tracks </small>

    <problem v-for="p in trolleyProblems" v-bind:key="p.id"
     v-bind:problem="p"/>
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
  computed :{
    trolleyProblems(){
      return this.$store.state.problems;
    }
  },

  created(){
    ProblemService.getAllProblems()
    .then(response =>{
      console.log('got trolley data back', response.data);

      this.$store.commit('PROBLEMS_LOADED', response.data);
    })
  }
};
</script>

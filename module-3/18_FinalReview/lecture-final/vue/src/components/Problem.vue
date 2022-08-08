<template>
  <div class="card mt-3">
    <h5 class="card-header">Problem {{problem.id}}</h5>
    <div class="card-body">
        <p class="card-text">{{problem.problem}}</p>
        <div v-if="isLoggedIn">
          <a href="#" class="btn btn-danger" v-bind:title="pulledLeverTooltip" v-on:click="pullLever()">
            Pull the Lever
            <span class="badge bg-dark">{{problem.timesPulled}}</span>
          </a>
          <a href="#" class="btn btn-secondary ml-3" v-bind:title="doNothingTooltip" v-on:click="doNothing()">
            Do Nothing
            <span class="badge bg-dark">{{problem.timesNotPulled}}</span>
          </a>
        </div>
    </div>
  </div>
</template>

<script>
import ProblemService from '../services/ProblemService.js';

export default {
    props: {
        problem: Object,
    },
    methods: {
      pullLever() {
        this.problem.timesPulled++;
        ProblemService.updateProblem(this.problem.id, this.problem)
          .then(response => {
            console.log('Updated problem', response);
          })
      },
      doNothing() {
        this.problem.timesNotPulled++;
        ProblemService.updateProblem(this.problem.id, this.problem)
          .then(response => {
            console.log('Updated problem', response);
          })
      }
    },
    computed: {
      isLoggedIn() {
        // If the user is logged in, state.token will have their JWT. Else, it's '' which is falsey
        if (this.$store.state.token) {
          return true;
        }
        return false;
      },
      pulledLeverTooltip() {
        if (this.problem.timesPulled == 1) {
          return '1 person has pulled the lever. That monster.';
        } else {
          return this.problem.timesPulled + ' people have pulled the lever. Those monsters.';
        }
      },
      doNothingTooltip() {
        if (this.problem.timesNotPulled == 1) {
          return '1 person decided to do nothing. That monster.';
        } else {
          return this.problem.timesNotPulled + ' people decided to do nothing. Those monsters.';
        }
      }
    }
}
</script>

<style>

</style>
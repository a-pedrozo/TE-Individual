<template>
  <div class="card mt-3">
    <h5 class="card-header">Problem {{problem.id}}</h5>
    <div class="card-body">
        <p class="card-text">{{problem.problem}}</p>
        <a href="#" class="btn btn-danger" v-bind:title="pulledLeverTooltip">
          Pull the Lever
          <span class="badge bg-dark">{{problem.timesPulled}}</span>
        </a>
        <a href="#" class="btn btn-secondary ml-3" v-bind:title="doNothingTooltip">
          Do Nothing
          <span class="badge bg-dark">{{problem.timesNotPulled}}</span>
        </a>
    </div>
  </div>
</template>

<script>
export default {
    props: {
        problem: Object,
    },
    computed: {
      pulledLeverTooltip() {
        if (this.problem.timesPulled == 1) {
          return '1 person has pulled the lever. That monster.';
        } else {
          return this.problem.timesPulled + ' people have pulled the lever. Those monsters.';
        }
      },
      doNothingTooltip() {
        if (this.problem.timesPulled == 1) {
          return '1 person decided to do nothing. That monster.';
        } else {
          return this.problem.timesPulled + ' people decided to do nothing. Those monsters.';
        }
      }
    }
}
</script>

<style>

</style>
<template>
  <div class="card mt-3">
    <h5 class="card-header">Problem {{problem.id}}</h5>
    <div class="card-body">
        <p class="card-text">{{problem.problem}}</p>
        <a href="#" class="btn btn-danger">Pull the Lever</a>
        <a href="#" class="btn btn-secondary ml-3">Do Nothing</a>
    </div>
  </div>
</template>

<script>
export default {
    props: {
        problem: Object,
    }
}
</script>

<style>

</style>
<template>
 <div class="card">
  <h5 class="card-header">Problem {{problem.id}}</h5>
  <div class="card-body">
    <p class="card-text">{{problem.problem}}</p>
    <a href="#" class="btn btn-danger">Pull the lever</a>
    <a href="#" class="btn btn-secondary ml-3">Do nothing</a>
  </div>
</div>
</template>

<script>
export default {
    props: ['problem']
}
</script>

<style>

</style>
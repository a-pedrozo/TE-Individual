<template>
  <div>
    <h1>Product Detail</h1>
    <h3>{{ $route.params.id }}</h3>
  </div>
</template>

<script>
export default {

created(){
    console.log(this.$route.params.id)
}
}
</script>

<style>

</style>
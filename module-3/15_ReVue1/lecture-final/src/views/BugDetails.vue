<template>
  <div>
      <h2>Bug Details: {{bug.title}}</h2>

      <p>
          Bug ID: {{bug.id}}
      </p>
  </div>
</template>

<script>
export default {
    data() {
        return {
            bug: undefined
        }
    },
    // Created is fired when the view is created
    created() {
        console.log('BugDetails created', this.$route.params);

        // id is a string because it came from params
        let id = this.$route.params.bugId;

        // Find the bug with a matching ID in Vuex
        let foundBug = this.$store.state.bugs.find(b => b.id == id);

        // Set the page's bug to that found bug
        this.bug = foundBug;
    }
}
</script>

<style>

</style>
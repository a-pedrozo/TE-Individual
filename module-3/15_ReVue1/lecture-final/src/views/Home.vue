<template>
  <div class="home">
    <h2>Current Bugs</h2>

    <div>
      <label for="searchText">Search</label>
      <input type="text" id="searchText"
             v-model.trim="filter">
    </div>

    <ul v-if="hasBugs">
      <li v-for="bug in filteredBugs" 
          v-bind:key="bug.id"
          v-bind:class="{closed: !bug.isOpen, open: bug.isOpen, 'bug-item': true}"
          >
          <router-link v-bind:to="{name: 'BugDetails', params: {bugId: bug.id}}">
            {{ bug.title }}
          </router-link>
      </li>
    </ul>

    <p v-if="!hasBugs">
      Looks like there aren't any bugs today!
    </p>
  </div>
</template>

<script>
export default {
  name: 'Home',
  // Data specific to THIS component
  data() {
    return {
      filter: ''
    };
  },
  components: {
  },
  computed: {
    hasBugs() {
      let len = this.$store.state.bugs.length;

      return len > 0;
    },
    filteredBugs() {
      return this.$store.state.bugs.filter(b => {
        // If the user typed in a filter
        if (this.filter) {
          // and we don't match it
          if (!b.title.toLowerCase().includes(this.filter.toLowerCase())) {
            // Exclude the bug from the results
            return false;
          }
        }

        // Otherwise include the bug
        return true;
      });
    }
  }
}
</script>

<style scoped>

.closed {
  color: gray;
  text-decoration: line-through;
}

</style>
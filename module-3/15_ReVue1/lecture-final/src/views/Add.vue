<template>
  <div>
      <h2>Add a new bug</h2>

      <form v-on:submit.prevent="handleSubmit">
          <div>
              <label for="inputText">Text</label>
              <input type="text" id="inputText" v-model="newBug.title" >
          </div>
          <div>
              <input type="checkbox" id="checkIsOpen" v-model="newBug.isOpen">
              <label for="checkIsOpen">Is Open?</label>
          </div>
          <div v-show="!newBug.isOpen">
              <label for="inputResolution">Resolution</label>
              <textarea id="inputResolution" v-model="newBug.resolution" />
          </div>
          
          <input type="submit" value="Save">
      </form>
  </div>
</template>

<script>
export default {
    name: 'Add', // This must be unique!
    data() {
        return {
            newBug: {
                title: '',
                isOpen: true,
                resolution: ''
            }
        };
    },
    methods: {
        handleSubmit() {
            console.log('Handle submit occurred');

            // Add the bug to the global list of bugs
            this.$store.commit('ADD_BUG', this.newBug);

            // Go somewhere else
            this.$router.push({name: 'Home'});
            // this.$router.push({name: 'BugDetails', params: {bugId: this.newBug.id}});
        }
    }
}
</script>

<style>
textarea {
    display: block;
}

form > div {
    margin-bottom: 1rem;
}
</style>
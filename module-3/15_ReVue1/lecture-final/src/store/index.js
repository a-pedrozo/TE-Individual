import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  strict: true,
  state: {
    // My data goes here!
    bugs: [
      { id: 1, title: 'Matt has a mic made out of a motorboat', isOpen: true, resolution: ''},
      { id: 2, title: 'John needs more memory for his PC', isOpen: false, resolution: 'Vinny said no'},
      { id: 3, title: 'You all cannot leave us yet', isOpen: false, resolution: 'Vinny said no'}
    ]
  },
  mutations: {
    // Vuex provides state
    // Caller provides bug
    ADD_BUG(state, bug) {
      // TODO: Assign a new bug ID to the bug

      // We modify state as needed
      state.bugs.push(bug);
    }
  },
})

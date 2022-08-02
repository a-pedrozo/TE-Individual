import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  strict: true,
  state: {
    bugs: [
      {id: 1},
      {id: 2},
      {id: 3},
    ]
  },
  mutations: {
  },
})

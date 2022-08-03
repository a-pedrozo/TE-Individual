import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'
import Add from '../views/Add.vue'
import BugDetails from '../views/BugDetails.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',      // What shows up in my URL?
    name: 'Home',   // A name I can use in routes to refer to my route
    component: Home // What do I show in router-view?
  },
  {
    path: '/add',
    name: 'NewBug',
    component: Add
  },
  {
    path: '/bugs/:bugId',
    name: 'BugDetails',
    component: BugDetails
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router

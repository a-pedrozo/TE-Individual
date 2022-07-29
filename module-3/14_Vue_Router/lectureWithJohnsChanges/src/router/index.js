import Vue from 'vue'
import VueRouter from 'vue-router'

import Products from "@/views/Products.vue"
import NotFound from "@/views/NotFound.vue"
import ProductDetail from "@/views/ProductDetail"

Vue.use(VueRouter)

const routes = [
  {
    path: "/",
    name: "Products",
    component: Products
  },

  {
    path: "/products/:id",
    name: "ProductDetail",
    component: ProductDetail
  },

  {
    path: "*",
    name: "NotFound",
    component: NotFound
  },

]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router

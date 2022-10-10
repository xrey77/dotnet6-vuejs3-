import { createRouter, createWebHistory } from 'vue-router'
import HomePage from '../views/Home.vue'
import Aboutus from '../views/Aboutus.vue'
import Contactus from '../views/Contactus.vue'
import Services from '../views/Services.vue'
import Products1 from '../views/Products1.vue'
import Products2 from '../views/Products2.vue'
import Products3 from '../views/Products3.vue'

const routes = [
    {
      path: '/',
      name: 'Home',
      component: HomePage
    },
    {
      path: '/aboutus',
      name: 'Aboutus',
      component: Aboutus
    },
    {
      path: '/contactus',
      name: 'Contactus',
      component: Contactus
    },
    {
      path: '/services',
      name: 'Services',
      component: Services
    },
    {
      path: '/prod1',
      name: 'Products1',
      component: Products1
    },
    {
      path: '/prod2',
      name: 'Products2',
      component: Products2
    },
    {
      path: '/prod3',
      name: 'Products3',
      component: Products3
    },

]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
  
<template>
    <footer>
      <div class="bg-light text-dark text-center footer fixed-bottom" style="margin-left:-15px;width:110%!important;font-size:12px;padding:10px;">
        Copyright &copy; {{ year }},  Powered by VueJS 3, Axios, Golang Restful API and Bootstrap 5
      </div>
    </footer>
  </template>
  
  <script>
  import { computed } from 'vue'
  
  export default {
    name: 'Footer',
    setup () {
      const year = computed(() => new Date().getFullYear())
      return { year }
    },  
  
  }
  </script>
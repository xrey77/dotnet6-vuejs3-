<template>
 <div class="header">
    <Login/>
    <Register/>
    <nav class="navbar navbar-expand-lg bg-light text-dark fixed-top">
      <div class="container-fluid">
        <router-link to="/" class="navbar-brand"><img alt="" class="logos" src="../assets/images/logo.png" /></router-link>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarSupportedContent">
          <ul class="navbar-nav me-auto mb-2 mb-lg-0">
            <li class="nav-item">
              <router-link to="/aboutus" class="nav-link active">About Us</router-link>
            </li>
            <li class="nav-item">
              <router-link to="/services" class="nav-link">Services</router-link>
            </li>
            <li class="nav-item dropdown">
              <a class="nav-link dropdown-toggle" to="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                Products 
              </a> 
              <ul class="dropdown-menu">
                <li><router-link to="/prod1" class="dropdown-item">Shirts and Sleeves</router-link></li>
                <li><router-link to="/prod2" class="dropdown-item">Sports Bags and Travelling Bags</router-link></li>                
                <li><hr class="dropdown-divider"></li>
                <li><router-link to="/prod3" class="dropdown-item">Jewelries</router-link></li>
              </ul>
            </li>
            <li class="nav-item">
              <router-link to="/contactus" class="nav-link">Contact Us</router-link>
            </li>
          </ul>

          <ul class="navbar-nav">
            <li class="nav-item">
              <router-link to="#" class="nav-link active" data-bs-toggle="modal" data-bs-target="#loginBackdrop">Login</router-link>
            </li>
            <li class="nav-item">
              <router-link to="#" class="nav-link active" data-bs-toggle="modal" data-bs-target="#registerBackdrop">Register</router-link>
            </li>
          </ul>

        </div>
      </div>
    </nav>
  </div>    
  </template>

<style scoped>


.logos {
    width: 80px!important;
    height: 30px!important;
  }


/* xxl applies to x-large devices (large desktops, less than 1400px) */
@media (max-width: 1399.98px) {  

  .logo {
    width: 130px!important;
    height: 30px!important;
  }

  .btnclose {
    color: white;
    z-index: 100;
  }

}

/* XX-Large devices (larger desktops, 1400px and up) */
@media (min-width: 1400px) {  

  .logo {
    width: 130px!important;
    height: 30px!important;
  }

}

/* md applies to small devices (landscape phones, less than 768px) */
@media (max-width: 767.98px) {  
  .logo {
    width: 130px!important;
    height: 30px!important;
  }

}

/* sm applies to x-small devices (portrait phones, less than 576px) */
@media (max-width: 575.98px) {  
  .logo {
    width: 130px!important;
    height: 30px!important;
  }

}

/* lg applies to medium devices (tablets, less than 992px) */
@media (max-width: 991.98px) {  
}

/* xl applies to large devices (desktops, less than 1200px) */
@media (max-width: 1199.98px) {  
}

</style>

<script>

import Login from './Login.vue'
import Register from './Register.vue'

const $ = require('jquery')
window.jQuery = window.$ = $;

export default {    
  name: 'HeaderPage',
  components: {
    Login,
    Register
  },
  data() {
    return {
      keyword: null,
      USERNAME: null,
    }
  },
  mounted() {
    this.USERNAME = localStorage.getItem('USERNAME').toUpperCase();
  },
  methods: {
    logout(event) {
      event.preventDefault();
      localStorage.removeItem('TOKEN');
      localStorage.removeItem('USERID');
      localStorage.removeItem('USERNAME');
      localStorage.removeItem('ROLE');
      localStorage.removeItem('USERPIC');
      this.$router.push("/");
      let timer = setTimeout(() => {
          location.reload();
          clearTimeout(timer);
      },900);        
    },
    searchkey: function(event) {
        if(this.keyword === null) 
        {
          return;
        } 
        else 
        {
          if (this.$route.name === "Search") {
            this.$router.replace("/Search","/Home");
            let timer = setTimeout(() => {
                this.$router.push({
                  name: 'Search',
                  params: { keyword: this.keyword }
                });
                clearTimeout(timer);
            },500);
              event.preventDefault();
              event.target.reset();
              return;



          } else {
              this.$router.push({
                name: 'Search',
                params: { keyword: this.keyword }
              });
              event.preventDefault();
              event.target.reset();
              return;
          }
          //this.$router.currentRoute.value.fullPath
          // event.stopPropagation();
          // event.target.reset();
          // event.preventDefault();
        
        }
    },
    carts() {
      this.$router.push("/cart")
    },
  }
}
</script>
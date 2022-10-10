<template>

    <div class="home">
      <CarouselPage/>
      <FooterPage/>
    </div>
  
  </template>
  
  <script>
  
  import CarouselPage from '../src/components/Carousel.vue';
  import FooterPage from '../views/Footer.vue';
  
  export default {
    name: 'Home',
    components: {
      CarouselPage,
      FooterPage
    }
  }
  </script>
  
  <style scoped>

/* xxl applies to x-large devices (large desktops, less than 1400px) */
@media (max-width: 1399.98px) {  

}

/* XX-Large devices (larger desktops, 1400px and up) */
@media (min-width: 1400px) {  

}

/* md applies to small devices (landscape phones, less than 768px) */
@media (max-width: 767.98px) {  

}

/* sm applies to x-small devices (portrait phones, less than 576px) */
@media (max-width: 575.98px) {  

}

/* lg applies to medium devices (tablets, less than 992px) */
@media (max-width: 991.98px) {  
}

/* xl applies to large devices (desktops, less than 1200px) */
@media (max-width: 1199.98px) {  
}

</style>

  
  
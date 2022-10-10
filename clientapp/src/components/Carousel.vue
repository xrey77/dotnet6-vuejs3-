<template>
<div id="carouselExampleControls" class="carousel slide" data-bs-ride="carousel">
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="../assets/images/1.jpg" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="../assets/images/2.jpg" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="../assets/images/3.jpg" class="d-block w-100" alt="...">
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>    
</template>

<style>

/*  xxl applies to x-large devices (large desktops, less than 1400px) */
@media (max-width: 1399.98px) {  
  .carousel-inner {
    margin-left: -13px!important;
    left: -13px!important;
  } 

.carousel-indicators button {
  border-radius: 50%!important;
  max-height: 10px!important;
  height: 10px!important;
  max-width: 10px!important;
  width: 10px!important;
  }                                                   
                                                                 
  .carousel-indicators .active {
  border-radius: 50%!important;
  max-height: 10px!important;
  height: 10px!important;
  max-width: 10px!important;
  width: 10px!important;
  }
}

/* XX-Large devices (larger desktops, 1400px and up) */
@media (min-width: 1400px) {  

  .carousel-inner {
    margin-left: -13px!important;
    left: -13px!important;
  }

 carousel-indicators button {
  border-radius: 50%!important;
  max-height: 10px!important;
  height: 10px!important;
  max-width: 10px!important;
  width: 10px!important;
  }                                                   
                                                                 
  .carousel-indicators .active {
  border-radius: 50%!important;
  max-height: 10px!important;
  height: 10px!important;
  max-width: 10px!important;
  width: 10px!important;
  }
 
}

/* md applies to small devices (landscape phones, less than 768px) */
@media (max-width: 767.98px) {  
 
  #carouselExampleIndicators {
    margin-top: -410px!important;
    width: 115%!important;
    bottom: 180px!important;    
  }
 
}

/* sm applies to x-small devices (portrait phones, less than 576px) */
@media (max-width: 575.98px) {  

.carousel-indicators button {
  position:relative;
  border-radius: 50%!important;
  max-height: 10px!important;
  height: 10px!important;
  max-width: 10px!important;
  width: 10px!important;
  margin-top: 20px!important;
  top: 20px!important;
  }                                                   
                                                                 
.carousel-indicators .active {
  position:relative;
  border-radius: 50%!important;
  max-height: 10px!important;
  height: 10px!important;
  max-width: 10px!important;
  width: 10px!important;
  margin-top: 20px!important;
  top: 20px!important;
  }

  #carouselExampleIndicators {
    margin-top: -260px!important;
    width: 115%!important;
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
import * as $ from 'jquery/dist/jquery';

export default {
 name: 'Carousel'
}

$(document).ready(function() {
  $("#dmenu1").click(function(){ $(".menu1").show(); });
  $("#dmenu1").mouseleave(function(){ $(".menu1").hide(); });
});

</script>
<template>
<div class="modal fade" id="registerBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="registerBackdropLabel" aria-hidden="true">
    <div class="modal-dialog modal-dialog-centered">
      <div class="modal-content">
        <div class="modal-header">
          <h1 class="modal-title fs-5" id="registerBackdropLabel">User's Registration</h1>
          <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
        </div>
        <div class="modal-body">
            <form id="form" @submit.prevent="register" autocomplete="off">

            <div class="row">
                <div class="col">
                    <div class="mb-3">                    
                        <input type="text" class="form-control" id="last_name" v-model="lastname" placeholder="enter last name" required>
                    </div>                    
                </div>
                <div class="col">
                    <div class="mb-3">                    
                        <input type="text" class="form-control" id="first_name" v-model="firstnam" placeholder="enter first name" required>
                    </div>
                </div>
            </div>            

            <div class="row">
                <div class="col">
                    <div class="mb-3">                    
                        <input type="email" class="form-control" id="email_add" v-model="emailadd" placeholder="enter email address" required>
                    </div>
                </div>
                <div class="col">
                    <div class="mb-3">                    
                        <input type="text" class="form-control" id="mobile_no" v-model="mobileno" placeholder="enter mobile no." required>
                    </div>                    
                </div>
            </div>            

            <div class="row">
                <div class="col">
                    <div class="mb-3">                    
                        <input type="text" class="form-control" id="user_name" v-model="username" placeholder="enter username" required>
                    </div>                    
                </div>
                <div class="col">
                    <div class="mb-3">                    
                        <input type="password" class="form-control" id="pass_word" v-model="password" placeholder="enter password" required>
                    </div>
                </div>
            </div>            

            <div class="register">
                <button type="submit" class="btn btn-secondary">register</button>
                <button type="button" class="btn btn-warning text-white ml-10">clear</button>

            </div>
          </form>

        </div>
        <div class="modal-footer">
            <div id="registerMsg" class="w-100 text-danger text-center">{{message}}</div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
    // import * as $ from 'jquery/dist/jquery';
    const $ = require('jquery')
    window.jQuery = window.$ = $;

    import axios from 'axios';

    const api = axios.create({
        baseURL: "https://golang-api-10.herokuapp.com",
        headers: {'Accept': 'application/json',
                'Content-Type': 'application/json'}
    })


    export default {
        name: 'Register',
        data() {
            return {
                lastname: null,
                firstname: null,
                emailadd: null,
                mobileno: null,
                username: null,
                password: null,
                register_message: null
            }
        },
        methods: {
            register: function() {                
                alert(this.lastname);

                this.register_message="register message";
            },
        }
    }
</script>

<style scoped>

/* xxl applies to x-large devices (large desktops, less than 1400px) */
@media (max-width: 1399.98px) {  
    .register {
        display: flex; justify-content: flex-start
    }
    #registerMsg {
        display: flex; justify-content: flex-start; font-size:10px;
    }
    .ml-10 {
        margin-left: 10px!important;
    }
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

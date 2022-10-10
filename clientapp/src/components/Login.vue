<template>
<div class="modal fade" id="loginBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="loginBackdropLabel" aria-hidden="true">
    <div class="modal-dialog modal-sm modal-dialog-centered">
      <div class="modal-content">
        <div class="modal-header">
          <h1 class="modal-title fs-5 text-primary" id="loginBackdropLabel">User's Login</h1>
          <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
        </div>
        <div class="modal-body">
            <form id="form" @submit.prevent="login" autocomplete="off">
                <div class="mb-3">
                    <input type="text" class="form-control" id="user_name" v-model="username" placeholder="enter Username" @change="clearloginMsg" required>
                </div>            
                <div class="mb-3">
                    <input type="password" class="form-control" id="pass_word" v-model="password" placeholder="enter password" @change="clearloginMsg" required>
                </div>            
                <div class="login">
                    <button type="submit" class="btn btn-secondary">register</button>
                </div>

          </form>
        </div>
        <div class="modal-footer">
            <div id="loginMsg" class="w-100 text-danger text-center">{{login_message}}</div>
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
        name: 'Login',
        data() {
            return {
                username: null,
                password: null,
                login_message: null
            }
        },
        methods: {
            login: function() {                
                // alert(this.username);
                // alert(this.password);
                this.login_message="login message";
            },
            clearloginMsg: function() {
                this.login_message = null;
            },
        }
    }
</script>


<style scoped>


/* xxl applies to x-large devices (large desktops, less than 1400px) */
@media (max-width: 1399.98px) {  
    .login {
        display: flex; justify-content: flex-end
    }
    #loginMsg {
        display: flex; justify-content: flex-start; font-size:10px;
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



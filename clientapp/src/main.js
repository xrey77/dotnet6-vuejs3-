import "bootstrap/dist/css/bootstrap.min.css"
import { createApp } from 'vue';
import router from '../router'
import axios from 'axios';
import VueAxios from 'vue-axios'
import App from '../src/App'
createApp(App).use(router).mount('#app')
App.use(VueAxios, axios);
import 'bootstrap/dist/js/bootstrap.js'
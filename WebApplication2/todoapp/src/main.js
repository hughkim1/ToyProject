import Vue from 'vue/dist/vue.js'
import App from './App.vue'
import router from './router';
import BootstrapVue from 'bootstrap-vue'
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import Axios from 'axios'

Vue.config.productionTip = false
Vue.use(BootstrapVue);
Axios.defaults.baseURL = "http://localhost:5000/api";

new Vue({
    el: '#app',
    router: router,
    render: h => h(App)
});

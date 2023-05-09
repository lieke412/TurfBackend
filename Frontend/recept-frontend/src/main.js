import { createApp } from 'vue'
import App from './App.vue'
import BootstrapVue3 from 'bootstrap-vue-3'
import router from './router/router'
import "./assets/style/site.css";

const app = createApp(App)
// Make BootstrapVue available throughout your project
app.use(BootstrapVue3)
app.use(router)
app.mount('#app')

import { createApp } from 'vue'
import App from './App.vue'
import BootstrapVue3 from 'bootstrap-vue-3'

const app = createApp(App)
// Make BootstrapVue available throughout your project
app.use(BootstrapVue3)
app.mount('#app')

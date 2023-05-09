<template>
  <navBar/>
  <RouterView/>
</template>

<script>
import navBar from './components/NavBar'

export default {
  name: 'App',
  components: {
    navBar
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  justify-content: left;
  color: #2c3e50;
  margin-top: 60px;
}
</style>

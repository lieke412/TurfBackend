<template>
  <navBar/>
  <recept/>
</template>

<script>
import recept from './components/ReceptenList'
import navBar from './components/NavBar'

export default {
  name: 'App',
  components: {
    recept,
    navBar
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>

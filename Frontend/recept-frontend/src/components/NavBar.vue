<template>
  <div>
    <ul class="headerList">
      <li class="headerListItem"><a href="#">Home</a></li>
      <li class="headerListItem"><a href="#">Recepten</a></li>
      <li class="headerListItem"><a href="#">Ingrediënten</a></li>
    </ul>
  </div>
</template>

<script>
export default{name: "navBar"}
</script>

<style>
.headerList {
  list-style-type: none;
  margin: 0;
  padding: 0;
  overflow: hidden;
  background-color: #cbc3aa;
  position: fixed;
  top: 0;
  width: 100%;
}

.headerListItem {
  float: left;
}

.headerListItem a {
  display: block;
  color: white;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
}

.headerListItem a:hover {
  background-color: #9c7c54;
}

.active {
  background-color: #4CAF50;
}
</style>
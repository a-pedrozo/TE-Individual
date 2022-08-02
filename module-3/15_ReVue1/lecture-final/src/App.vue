<template>
  <div id="app">

    <!-- This header is present for all pages -->
    <div id="nav">
      <ul>
        <li>
          <!-- Router links generate an "a" tag that navigates to a specific Route on click -->
          <router-link v-bind:to="{name: 'Home'}">Home</router-link>
        </li>
        <li>
          <!-- Router links generate an "a" tag that navigates to a specific Route on click -->
          <router-link v-bind:to="{name: 'NewBug'}">Add a Bug</router-link>
        </li>        
      </ul>
    </div>

    <!-- Page contents go here -->
    <router-view/>

    <!-- Page footer -->
    <footer>
      <small>Copyright &copy; Tech Elevator 2022</small>
    </footer>
  </div>
</template>

<script>
export default {
  name: 'App',
}
</script>

<style>
/*  CSS variables. These can be referenced like this:    
    color: var(--main-color);
*/
:root {
  --main-bg-color: white;
  --main-color: black;
  --accent-color: #7c09ff;
  --link-color: #42b983;
  --active-link-color: var(--accent-color);
  --hover-color: #b9429b;
}

/* Top level Styling */
html {
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  background-color: var(--main-bg-color);
  color: var(--main-color);
}

body {
  margin: 0 0 0 1rem;
}

/* Navigation Lists */
#nav ul {
  display: inline-block;
  list-style: none;
  padding-left: 0;
}

#nav li {
  display: inline-block;
  margin: 0 0.25rem;
}

/* Link Styling */
a {
  font-weight: bold;
  color: var(--link-color);
}

a.router-link-exact-active {
  color: var(--active-link-color);
}

a:hover {
  font-weight: bold;
  color: var(--hover-color);
}
</style>

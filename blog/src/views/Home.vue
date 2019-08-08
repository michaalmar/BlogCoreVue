<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/logo.png" />
    <h1>dupa</h1>
  </div>
</template>













<script>
// @ is an alias to /src
import Home from "@/components/Home.vue";

export default {
  props: ['bobby'],

  name: "home",
  components: {
    Home
  }
  
};
</script>

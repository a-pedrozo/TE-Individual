<template>
  <div>
    <h1>User List</h1>

    <table>
      <tr>
        <th> Id </th>
        <th> Username </th>
        <th> Role </th>
      </tr>
      <tr v-for="item in user" v-bind:key="item.id">
        <td>{{ item.userId }}</td>
        <td>{{ item.username }}</td>
        <td>{{ item.role }}</td>
      </tr>
    </table>
  </div>
</template>

<script>
import authService from "../services/AuthService";

export default {
  data() {
    return {
      user: [],
    };
  },

  created() {
    authService.getUsers().then((response) => {
      this.user = response.data;
      console.log(this.user);
    });
  },
};
</script>

<style>
</style>
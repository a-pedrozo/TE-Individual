<template>
  <table id="tblUsers">
    <thead>
    <tr>
        <th>First Name</th>
        <th>Last Name</th>
        <th>Username</th>
        <th>Email Address</th>
        <th>Status</th>
    </tr>
    </thead>
    <tbody>
      <tr>
        <td><input type="text" id="firstNameFilter" v-model="Filter.firstName"/></td>
        <td><input type="text" id="lastNameFilter" v-model="Filter.lastName"/></td>
        <td><input type="text" id="usernameFilter" v-model="Filter.username"/></td>
        <td><input type="text" id="emailFilter" v-model="Filter.emailAddress"/></td>
        <td>
          <select id="statusFilter" v-model="Filter.status">
            <option value="">Show All</option>
            <option value="Active">Active</option>
            <option value="Disabled">Disabled</option>
          </select>
        </td>
      </tr>
      <!-- user listing goes here , at some point will need v-model somewhere -->
      
        <tr v-for="user in filter" v-bind:key="user.emailAddress" v-bind:class="{disabled: user.status == 'Disabled'}">
        <td>{{user.firstName}}</td>
        <td>{{user.lastName}}</td>
        <td>{{user.username}}</td>
        <td>{{user.emailAddress}}</td>
        <td>{{user.status}}</td>
        </tr>
      
    </tbody>
  </table>
</template>

<script>
export default {
  name: 'user-list',
  data() {
    return {
        Filter: {
        firstName: '',
        lastName: '',
        username: '',
        emailAddress: '',
        status: '',
        
      },
      users: [
        { firstName: 'John', lastName: 'Smith', username: 'jsmith', emailAddress: 'jsmith@gmail.com', status: 'Active' },
        { firstName: 'Anna', lastName: 'Bell', username: 'abell', emailAddress: 'abell@yahoo.com', status: 'Active' },
        { firstName: 'George', lastName: 'Best', username: 'gbest', emailAddress: 'gbest@gmail.com', status: 'Disabled' },
        { firstName: 'Ben', lastName: 'Carter', username: 'bcarter', emailAddress: 'bcarter@gmail.com', status: 'Active' },
        { firstName: 'Katie', lastName: 'Jackson', username: 'kjackson', emailAddress: 'kjackson@yahoo.com', status: 'Active' },
        { firstName: 'Mark', lastName: 'Smith', username: 'msmith', emailAddress: 'msmith@foo.com', status: 'Disabled' }
      ]
    }

  },
  computed: {
    filter() {
      return this.users.filter(u => {
        if (this.Filter.firstName && !u.firstName.toLowerCase().includes(this.Filter.firstName.toLowerCase())){
          return false;
        }

        if (this.Filter.lastName && !u.lastName.toLowerCase().includes(this.Filter.lastName.toLowerCase())){
          return false;
        }
        if (this.Filter.username && !u.username.toLowerCase().includes(this.Filter.username.toLowerCase())){
          return false;
        }
        if (this.Filter.emailAddress && !u.emailAddress.toLowerCase().includes(this.Filter.emailAddress.toLowerCase())){
          return false;
        }
          if (this.Filter.status && !u.status.toLowerCase().includes(this.Filter.status.toLowerCase())){
          return false;
        }
        return true;
      });
        
      
    } 
  }
}
</script>

<style scoped>
table {
  margin-top: 20px;
  font-family:-apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif
}
th {
  text-transform: uppercase
}
td {
  padding: 10px;
}
tr.disabled {
  color: red;
}
input, select {
  font-size: 16px;
}
</style>

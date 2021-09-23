<template>
    <div>
        <h1>To Do List</h1>
        <ul>
            <li>
                <todo v-for="item in todos"
                      v-bind:todo="item"
                      v-bind:key="item.id"></todo>
            </li>
        </ul>
    </div>
</template>

<script>
    //import todo from './Todo.vue'
    import ToDoService from '@/api-services/todo.service';
    export default {
        //components: {
        //    todo
        //},
        data()
            {
                return {
                    todos: []
                }
        },
        created() {
            ToDoService.getAll().then((response) => {
                console.log(response.data);}).catch((error) => {
                console.log(error.response.data);
                //this.todos = response.data;
            });
        },
        }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>

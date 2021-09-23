<template>
    <div>
        <h1>To Do List</h1>
        <b-row>
            <b-col md="2"
                   offset-md="10">
                <a href="#">Create To Do</a>
            </b-col>
        </b-row>
        <br>
        <b-row>
            <b-col md="12">
                <div class="table-responsive">
                    <table class="table table-striped">
                        <thead>
                            <tr>
                                <th>Task Complete?</th>
                                <th>Task</th>
                                <th>Description</th>
                                <th>Update</th>
                                <th>Delete</th>
                            </tr>
                        </thead>
                        <tbody>
                            <todo-row v-for="todo in todos"
                                     :key="todo.id"
                                     :todo1 ="todo"
                                      @details="viewTodoDetail"
                                      @update="updateTodo"
                                      @delete="deleteTodo"
                                      />
                        </tbody>
                    </table>
                </div>
            </b-col>
        </b-row>

    </div>
</template>

<script>
    import ToDoService from '@/api-services/todo.service';
    import ToDoRow from '@/components/ToDoRow';
    export default {
        name: 'ToDoList',
        components: {
            'todo-row':ToDoRow
        },
        data(){
            return {
                todos: []
            };
        },
        created() {
            ToDoService.getAll().then((response) => {
                this.todos = response.data;
            });
        },
        methods: {
            viewTodoDetail(todoId) {
                console.log("ffew")
                this.$router.push({ name: 'ToDoDetails', params: { id: todoId } });
            },
            updateTodo(todoId) {
                console.log("fe")
                ToDoService.update(todoId);
            },
            deleteTodo(todoId) {
                console.log("fefew")
                ToDoService.delete(todoId);
            }
        }
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

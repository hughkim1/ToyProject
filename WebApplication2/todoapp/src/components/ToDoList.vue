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
                                      :todo1="todo"
                                      @details="viewTodoDetail"
                                      @update="updateTodo"
                                      @delete="deleteTodo" />
                        </tbody>
                    </table>
                </div>
            </b-col>
        </b-row>

        <b-modal ref="deleteConfirmModal"
                 title="Confirm your action"
                 @ok="onDeleteConfirm"
                 @hide="onDeleteModalHide">
            <p class="my-4">Are you sure you want to delete this To Do permanently?</p>
        </b-modal>
        <b-modal ref="alertModal"
                 :title="alertModalTitle"
                 :ok-only="true">
            <p class="my-4">{{ alertModalContent }}</p>
        </b-modal>
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
                todos: [],
                selectedTodoId: null,
                alertModalTitle: '',
                alertModalContent:'',
            };
        },
        created() {
            this.fetchTodos();
        },
        methods: {
            fetchTodos() {
                ToDoService.getAll().then((response) => {
                    this.todos = response.data;
                });
            },
            viewTodoDetail(todoId) {
                this.$router.push({ name: 'ToDoDetails', params: { id: todoId } });
            },
            updateTodo(todoId) {
                ToDoService.update(todoId);
            },
            deleteTodo(todoId) {
                this.selectedTodoId = todoId;
                this.$refs.deleteConfirmModal.show();
            },
            onDeleteConfirm() {
                ToDoService.delete(this.selectedTodoId).then(() => {
                    this.alertModalTitle = 'Successfully';
                    this.alertModalContent = 'Successfully deleted To Do';
                    this.$refs.alertModal.show();
                    this.fetchTodos();
                }).catch((error) => {
                    this.alertModalTitle = 'Error';
                    this.alertModalContent = error.response.data;
                    this.$refs.alertModal.show();
                });
            },
            onDeleteModalHide() {
                this.selectedTodoId = null;
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

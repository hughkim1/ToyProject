<template>
    <div>
        <div class="well">
            <div class="row">
                <div class="col-md-3">
                    <strong>Task Name:</strong>
                </div>
                <div class="col-md-3">
                    {{ ToDo.toDoName }}
                </div>
            </div>
            <div class="row">
                <div class="col-md-3">
                    <strong>Completed?:</strong>
                </div>
                <div class="col-md-3">
                    {{ ToDo.toDoStatus }}
                </div>
            </div>
            
            <div class="col-md-3">
                <div class="col-md-3">
                    <strong>Description: </strong>
                </div>
                <div class="col-md-3">
                    {{ ToDo.toDoDescription }}
                </div>
                </div>

            </div>
        </div>
        
</template>
<script>
    import ToDoService from '@/api-services/todo.service';
    export default {
        name: 'ToDoDetails',
        data() {
            return {
                ToDo: {}
            };
        },
        created() {
            ToDoService.get(this.$router.currentRoute.params.id).then((response) => {
                this.ToDo = response.data;
            });
        }
    };
</script>
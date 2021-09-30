<template>
    <tr>
        <td>{{ todo1.toDoStatus }}</td>
        <td>{{ todo1.toDoName }}</td>
        <td>
            <b-button variant="default"
                      @click="onDetailsClick">Details</b-button>
        </td>
        <td>
            <b-button variant="success"
                      @click="onUpdateClick">Update</b-button>
        </td>
        <td>
            <b-button variant="danger"
                      @click="onDeleteClick">Delete</b-button>
        </td>
    </tr>
</template>
<script>
    export default {
        name: 'ToDoRow',
        props: ['todo1'], //was testing how to change and assign prop names / argument values to the child comp from the parent
        methods: {
            onDetailsClick() {
                this.$emit('details', this.todo1.id);
            },
            onUpdateClick() {
                this.$emit('update', this.todo1.id);
            },
            onDeleteClick() {
                this.$emit('delete', this.todo1.id);
            }
        }
    };
</script>
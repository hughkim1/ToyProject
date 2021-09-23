<template>
    <b-container fluid>
        <div class="form-wrapper">
            <b-form @submit.prevent="createToDo">
                <b-form-group :label-cols="1"
                              breakpoint="md"
                              horizontal
                              label="Title: "
                              for="title">
                    <b-col :md="3">
                        <b-input id="ToDoName"
                                 v-model="formData.ToDoName"
                                 maxlength="60"
                                 required />
                    </b-col>
                </b-form-group>

                <b-form-group :label-cols="1"
                              breakpoint="md"
                              horizontal
                              label="Description: "
                              for="ToDoDescription">
                    <b-col :md="3">
                        <b-input id="ToDoDescription"
                                 v-model="formData.ToDoDescription" />
                    </b-col>
                </b-form-group>
                <br><br>
                <b-col :md="5"
                       offset="4">
                    <b-button type="submit"
                              variant="info">Save</b-button>
                    <b-button href="/ToDo/List"
                              variant="danger">Cancel</b-button>
                </b-col>
            </b-form>
        </div>
        <b-modal ref="alertModal"
                 :title="alertModalTitle"
                 :ok-only="true"
                 @ok="onAlertModalOkClick">
            <p class="my-4">{{ alertModalContent }}</p>
        </b-modal>
    </b-container>
</template>

<script>
import todoService from "@/api-services/todo.service";

    export default {
        name: 'createToDo',
        data() {
            return {
                formData: {
                    ToDoName: '',
                    ToDoDescription: ''
                },
                alertModalTitle: '',
                alertModalContent: '',
                isSuccessfully: false
            };
        },
        methods: {
            createToDo() {
                todoService.create(this.formData).then(() => {
                    this.isSuccessfully = true;
                    this.alertModalTitle = 'Successfully';
                    this.alertModalContent = 'Successfully created To Do';
                    this.$refs.alertModal.show();

                    this.formData = {
                        ToDoName: '',
                        ToDoDescription: ''
                    };
                }).catch((error) => {
                    this.isSuccessfully = false;
                    this.alertModalTitle = 'Error';
                    this.alertModalContent = error.response.data;
                    this.$refs.alertModal.show();
                });
            },
        
            onAlertModalOkClick() {
                console.log(this.isSe)
                if (this.isSuccessfully) {
                    this.$router.push({ name: 'ToDoList' });
                }
            },
        }
    }; 
</script>

<style>
    .form-wrapper {
        margin-top: 20px;
        min-height: 20px;
        padding: 19px;
        margin-bottom: 20px;
        background-color: #f5f5f5;
        border: 1px solid #e3e3e3;
        border-radius: 4px;
        box-shadow: inset 0 1px 1px rgba(0,0,0,.05);
    }
</style>
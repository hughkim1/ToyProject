import Vue from 'vue/dist/vue.js';
import VueRouter from 'vue-router';
import Home from '@/components/Home';
import TableSample from '@/components/TableSample.vue';
import NotFound from '@/components/NotFound';
import ToDoList from '@/components/ToDoList';
import ToDoDetails from '@/components/ToDoDetails';
Vue.use(VueRouter);

export default new VueRouter({
    mode: 'history',
    routes: [
        {
            path: '/',
            name: 'Home',
            component: Home
        },
        {
            path: '*',
            name: 'NotFound',
            component: NotFound
        },
        {
            path: '/TableSample',
            name: 'TableSample',
            component: TableSample
        },
        {
            path: '/ToDo/List',
            name: 'ToDoList',
            component: ToDoList
        },
        {
            path: '/ToDo/:id',
            name: 'ToDoDetails',
            component: ToDoDetails
        }
    ],
})
<template>
    <tr>
        <td>{{ product1.handle }}</td>
        <td>{{ product1.vendor }}</td>
    </tr>
</template>
<script>
    export default {
        name: 'ProductRow',
        props: ['product1'], //was testing how to change and assign prop names / argument values to the child comp from the parent
    };
</script>
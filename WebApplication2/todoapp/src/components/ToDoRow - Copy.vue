<template>
    <tr>
        <td>{{ product1.productName }}</td>
        <td>{{ product1.productStyle }}</td>
    </tr>
</template>
<script>
    export default {
        name: 'ProductRow',
        props: ['product1'], //was testing how to change and assign prop names / argument values to the child comp from the parent
    };
</script>
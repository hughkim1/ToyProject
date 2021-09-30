<template>
    <div>
        <h1>Product List</h1>
        <br>
        <b-row>
            <b-col md="12">
                <div class="table-responsive">
                    <table class="table table-striped">
                        <thead>
                            <tr>
                                <th>Product</th>
                                <th>Detail</th>
                            </tr>
                        </thead>
                        <tbody>
                            <product-row v-for="product in products"
                                      :key="product.id"
                                      :product1="product" />
                        </tbody>
                    </table>
                </div>
            </b-col>
        </b-row>
    </div>
</template>

<script>
    import ProductService from '@/api-services/product.service';
    import ProductRow from '@/components/ProductRow';
    export default {
        name: 'ProductList',
        components: {ProductRow},
        data(){
            return {
                products: []
            };
        },
        created() {
            this.fetchProducts();
        },
        methods: {
            fetchProducts() {
                ProductService.getAll().then((response) => {
                    console.log(response);
                    this.products = response.data.items;
                });
            },
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

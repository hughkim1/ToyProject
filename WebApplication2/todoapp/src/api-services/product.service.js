import Axios from 'axios';
//const config = {
//    method: 'GET',
//    url: 'https://2cf2a35051ceeddccd44ec1c09ab2d6d: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@cicom-erp-test-development.myshopify.com/admin/api/2021-07/products.json',
//    //headers: {
//    //    'Content-Type': 'application/json',
//    //    'X-Shopify-Access-Token': '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',
//    //    /*'Access-Control-Allow-Origin':"https://cicom-erp-test-development.myshopify.com/admin/api/2021-07/products.json",*/
//    //}
//};
export default {

    //getAll() {
    //    return Axios.request(config);
    //},
    getAll() {
        return Axios.get("/ShopifyProduct");
    },
    //get(id) {
    //    return Axios.get(`${}`);
    //},
    //create(data) {
    //    return Axios.post(, data);
    //},
    //update(id, data) {
    //    return Axios.put(`${RESOURCE_NAME}/${id}`, data);
    //},
    //delete(id) {
    //    console.log(`${RESOURCE_NAME}/${id}`)
    //    return Axios.delete(`${RESOURCE_NAME}/${id}`);
    //}
};
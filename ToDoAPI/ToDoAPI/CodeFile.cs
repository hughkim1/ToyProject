using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System;
using ShopifySharp;
using System.Diagnostics;
using ShopifySharp.Lists;

namespace ToDoAPI
{
    class CodeFile
    {
        private ListResult<Product> products;

        private async Task ProcessRepositories()
        {
            string myShopifyUrl = "https://cicom-erp-test-development.myshopify.com";
            string privateAppPassword = "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";
            var service = new ProductService(myShopifyUrl, privateAppPassword);
            products = await service.ListAsync();

            Debug.WriteLine("fewfewfwefwe");
            Debug.WriteLine(products);
            Debug.WriteLine("fwefewfewf");
        }

        public Task Main()
        {
            return ProcessRepositories();
        }
    }
}

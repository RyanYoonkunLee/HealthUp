using System;
using System.Collections.Generic;
using System.Text;
using HealthUp.ViewModel;
using HealthUp.DataModel;

namespace HealthUp.ServiceLayer
{
    public class ProductService
    {
        public Product ConvertViewToData(ProductViewModel productView)
        {
            var productData = UpdateProductElement(productView);
            productData.id = Guid.NewGuid();
            
            return productData;
        }

        public Product UpdateProductElement(ProductViewModel productView)
        {
            Product productData = new Product();
            productData.name = productView.name;
            productData.description = productView.description;
            productData.benefits = productView.benefits;
            productData.size = productView.size;

            if(productView.id != null)
            {
                productData.id = productView.id;
            }

            return productData;
        }


        public ProductViewModel ConvertDataToView(Product product)
        {
            ProductViewModel productView = new ProductViewModel();
            productView.id = product.id;
            productView.name = product.name;
            productView.description = product.description;
            productView.benefits = product.benefits;
            productView.size = product.size;

            return productView;
        }

        public List<ProductViewModel> ConvertDataListToView(List<Product> product)
        {
            List<ProductViewModel> productsView = new List<ProductViewModel>();

            for(int i =0; i<product.Count; i++)
            {
                var result = ConvertDataToView(product[i]);
                result.number = i + 1;

                productsView.Add(result);
            }

            return productsView;
        }
    }
}

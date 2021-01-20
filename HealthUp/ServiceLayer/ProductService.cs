using System;
using System.Collections.Generic;
using System.Text;
using HealthUp.ViewModel;
using HealthUp.DataModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace HealthUp.ServiceLayer
{
    public class ProductService
    {
        public Product ConvertViewToData(ProductViewModel productView)
        {
            var productData = UpdateProductElement(productView);
            productData.Id = Guid.NewGuid();
            
            return productData;
        }

        public Product UpdateProductElement(ProductViewModel productView)
        {
            Product productData = new Product();
            productData.Name = productView.Name;
            productData.Description = productView.Description;
            productData.Benefits = productView.Benefits;
            productData.PackSize = productView.Size;
            productData.Dosage = productView.Dosage;
            productData.Ingredients = productView.Ingredient;
            
            string function = "";
            for(var i = 0; 
                i < productView.Function.Count; i++)
            {
                function += productView.Function[i];
                if(i != productView.Function.Count - 1)
                {
                    function += "\n";
                }
            }
            productData.Functions = function;

            string category = "";
            for (var i = 0; i < productView.Category.Count; i++)
            {
                category += productView.Category[i];
                if (i != productView.Category.Count - 1)
                {
                    category += "\n";
                }
            }
            productData.Category = category;

            productData.ThumbnailImage = productView.ThumbnailImage;
            productData.ProductImages = productView.ProductImages;
            if (productView.Id != null)
            {
                productData.Id = productView.Id;
            }
            productData.ContainNoAdded = productView.ContainNoAdded;
            productData.CategoryExpose = productView.CategoryExpose;
            productData.ProductExpose = productView.ProductExpose;

            return productData;
        }

        public ProductViewModel ConvertDataToView(Product product, bool admin)
        {
            ProductViewModel productView = new ProductViewModel();
            productView.Id = product.Id;
            productView.Name = product.Name;
            if(product.Description != null)
            {
                productView.Description = Regex.Replace(product.Description, @"\r\n|\r|\\n", "<br />");
            }
            if(product.Benefits != null)
            {
                productView.Benefits = Regex.Replace(product.Benefits, @"\r\n|\r|\\n", "<br />");
            }
            if (product.Dosage != null)
            {
                productView.Dosage = Regex.Replace(product.Dosage, @"\r\n|\r|\\n", "<br />");

            }
            if (product.Ingredients != null)
            {
                productView.Ingredient = Regex.Replace(product.Ingredients, @"\r\n|\r|\\n", "<br />");

            }
            productView.Size = product.PackSize;

            if(product.Functions != null)
            {
                var function = product.Functions.Split(new string[] { "\n", @"\n" }, StringSplitOptions.None).ToList();
                productView.Function = function;
            }
            else
            {
                productView.Function = null;
            }

            if(product.Category != null)
            {
                var category = product.Category.Split(new string[] { "\n", @"\n" }, StringSplitOptions.None).ToList();
                productView.Category = category;
            }
            else
            {
                productView.Category = null;
            }

            productView.ProductImages = product.ProductImages;
            if (admin == true)
            {
                productView.ThumbnailImage = product.ThumbnailImage;
            }
            else
            {
                productView.ThumbnailImage = "/images/productpage/" + product.ThumbnailImage;
            }
            productView.ContainNoAdded = product.ContainNoAdded;
            productView.CategoryExpose = product.CategoryExpose;
            productView.ProductExpose = product.ProductExpose;
            return productView;
        }

        public List<ProductViewModel> ConvertDataListToView(List<Product> product)
        {
            List<ProductViewModel> productsView = new List<ProductViewModel>();

            for(int i =0; i<product.Count; i++)
            {
                var result = ConvertDataToView(product[i], false);

                productsView.Add(result);
            }

            return productsView;
        }

        public string[] GetImages(string imagesList)
        {
            string[] images = null;

            if (imagesList != null)
            {
                images = imagesList.Split(new string[] { "\r\n", "\\n" }, StringSplitOptions.None);

                for (var i = 0; i < images.Length; i++)
                {
                    images[i] = "/images/productimage/" + images[i];
                }
            }
     
            return images;
        }

        public List<CategoryViewModel> SelectedCategory(List<string> selected, List<Category> original)
        {
            List<CategoryViewModel> viewList = new List<CategoryViewModel>();

            for(var i = 0; i < original.Count; i++)
            {
                CategoryViewModel view = new CategoryViewModel();
                view.Id = original[i].Id;
                view.Name = original[i].Name;
                if (selected != null)
                {
                    for (var j = 0; j < selected.Count; j++)
                    {
                        if (selected[j] == original[i].Name)
                        {
                            view.Selected = true;
                            break;
                        }
                        else
                        {
                            view.Selected = false;
                        }
                    }
                }
                else
                {
                    view.Selected = false;
                }
                viewList.Add(view);
            }

            return viewList;
        }

        public List<FunctionViewModel> SelectedFunctions(List<string> selected, List<Function> original)
        {
            List<FunctionViewModel> viewList = new List<FunctionViewModel>();

            for (var i = 0; i < original.Count; i++)
            {
                FunctionViewModel view = new FunctionViewModel();
                view.Id = original[i].Id;
                view.Name = original[i].Name;
                if(selected != null)
                {
                    for (var j = 0; j < selected.Count; j++)
                    {
                        if (selected[j] == original[i].Name)
                        {
                            view.Selected = true;
                            break;
                        }
                        else
                        {
                            view.Selected = false;
                        }
                    }
                }
                else {
                    view.Selected = false;
                }
                viewList.Add(view);
            }

            return viewList;
        }

        public List<ProductListViewModel> SplitSelectedProduct(string select, List<Product> original)
        {
            List<ProductListViewModel> viewList = new List<ProductListViewModel>();
            List<string> selected = new List<string>();

            if (select != null)
            {
                selected = select.Split(new string[] { "\n", @"\n" }, StringSplitOptions.None).ToList();
            }
            else
            {
                selected = null;
            }

            var result = SelectedProduct(selected, original);
            return result;
        }

        public List<ProductListViewModel> SelectedProduct(List<string> select, List<Product> original)
        {
            List<ProductListViewModel> viewList = new List<ProductListViewModel>();

            for (var i = 0; i < original.Count; i++)
            {
                ProductListViewModel view = new ProductListViewModel();
                view.Id = original[i].Id;
                view.Name = original[i].Name;
                if (select != null)
                {
                    for (var j = 0; j < select.Count; j++)
                    {
                        if (select[j] == original[i].Name)
                        {
                            view.Selected = true;
                            break;
                        }
                        else
                        {
                            view.Selected = false;
                        }
                    }
                }
                else
                {
                    view.Selected = false;
                }
                viewList.Add(view);
            }

            return viewList;
        }
    }
}

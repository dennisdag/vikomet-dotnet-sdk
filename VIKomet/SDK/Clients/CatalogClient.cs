

using Glav.CacheAdapter.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using VIKomet.SDK.Entities.Catalog;
using VIKomet.Framework.Common; 

namespace VIKomet.SDK.Clients
{
    public class CatalogClient : BaseClient
    {


        public CatalogClient(string access_token, string cacheString, bool isHTTPSCall) : base(access_token, cacheString, isHTTPSCall) { }

        public PagedList<Brand> GetPagedBrands()
        {
            var cacheProvider = AppServices.Cache;
            return cacheProvider.Get<PagedList<Brand>>(this.GetType().FullName + "GetPagedBrands" + this.CacheString, DateTime.Now.AddMinutes(1), () =>
                {
                    HttpResponseMessage response = client.GetAsync("api/webstore/catalog/brand?q=&page=1&action=infinite_scroll&page_no=1&loop_file=loop").Result;  // Blocking call!
                    if (response.IsSuccessStatusCode)
                    {
                        // Parse the response body. Blocking!
                        var marcas = response.Content.ReadAsAsync<PagedList<Brand>>().Result;
                        return marcas;
                    }
                    else
                    {
                        throw ErrorParser(response.Content.ReadAsStringAsync().Result);
                    }
                });
        }



        public Brand GetBrandById(string id)
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/catalog/brand/id/" + id).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var marca = response.Content.ReadAsAsync<Brand>().Result;
                return marca;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }

        public PagedList<Category> GetPagedCategories(int page)
        {
            var cacheProvider = AppServices.Cache;
            return cacheProvider.Get<PagedList<Category>>(this.GetType().FullName + "GetPagedCategories" + "_Page_" + page.ToString() + "_" + this.CacheString, DateTime.Now.AddMinutes(1), () =>
                {
                    HttpResponseMessage response = client.GetAsync("api/webstore/catalog/category?q=&page=" + page.ToString() + "&action=infinite_scroll&page_no=1&loop_file=loop").Result;  // Blocking call!
                    if (response.IsSuccessStatusCode)
                    {
                        // Parse the response body. Blocking!
                        var categorias = response.Content.ReadAsAsync<PagedList<Category>>().Result;
                        return categorias;
                    }
                    else
                    {

                        throw ErrorParser(response.Content.ReadAsStringAsync().Result);
                    }
                });

        }

        public Category GetCategoryById(string id)
        {
            var cacheProvider = AppServices.Cache;
            return cacheProvider.Get<Category>(this.GetType().FullName + "GetCategoryById" + this.CacheString + "_" + id, DateTime.Now.AddMinutes(1), () =>
                {
                    HttpResponseMessage response = client.GetAsync("api/webstore/catalog/category/id/" + id).Result;  // Blocking call!
                    if (response.IsSuccessStatusCode)
                    {
                        // Parse the response body. Blocking!
                        var categoria = response.Content.ReadAsAsync<Category>().Result;
                        return categoria;
                    }
                    else
                    {

                        throw ErrorParser(response.Content.ReadAsStringAsync().Result);
                    }
                });
        }

        public Product GetProductById(string id)
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/catalog/product/id/" + id).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<Product>().Result;
                return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }

        public Product GetCollectionBySlug(string slug)
        {
            var cacheProvider = AppServices.Cache;
            return cacheProvider.Get<Product>(this.GetType().FullName + "GetCollectionBySlug" + this.CacheString + "_" + slug, DateTime.Now.AddMinutes(1), () =>
            {
                HttpResponseMessage response = client.GetAsync("api/webstore/catalog/collection/slug/" + slug).Result;  // Blocking call!
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body. Blocking!
                    var r = response.Content.ReadAsAsync<Product>().Result;
                    return r;
                }
                else
                {

                    throw ErrorParser(response.Content.ReadAsStringAsync().Result);
                }
            });

        }


        public PagedList<ProductSearch> GetProductsFromCollectionBySlug(string slug)
        {
            var cacheProvider = AppServices.Cache;
            return cacheProvider.Get<PagedList<ProductSearch>>(this.GetType().FullName + "GetProductsFromCollectionBySlug" + this.CacheString + "_" + slug, DateTime.Now.AddMinutes(1), () =>
                {
                    HttpResponseMessage response = client.GetAsync("api/webstore/catalog/collection/products/slug/" + slug).Result;  // Blocking call!
                    if (response.IsSuccessStatusCode)
                    {
                        // Parse the response body. Blocking!
                        var r = response.Content.ReadAsAsync<PagedList<ProductSearch>>().Result;
                        return r;
                    }
                    else
                    {

                        throw ErrorParser(response.Content.ReadAsStringAsync().Result);
                    }
                });

        }



        public PagedList<ProductSearch> Search(string q, SortCriteria sortCriteria, SortOrder sortOrder, int page, int itemsPerPage)
        {
            return Search(null, null, q, null, null, null, null, sortCriteria, sortOrder, page, itemsPerPage);
        }
        public PagedList<ProductSearch> Search(string q, string ep, double? lat, double? lon, double? distance, SortCriteria sortCriteria, SortOrder sortOrder, int page, int itemsPerPage)
        {
            return Search(null, null, q, ep, lat, lon, distance, sortCriteria, sortOrder, page, itemsPerPage);
        }

        public PagedList<ProductSearch> Search(string categoryId, string brandId , string q, string ep, double? lat, double? lon, double? distance, SortCriteria sortCriteria, SortOrder sortOrder, int page, int itemsPerPage)
        {
            string url = "api/webstore/catalog/search?z=";

            if (!string.IsNullOrEmpty(q))
            {
                url = url + "&q=" + HttpUtility.UrlEncode(q);
            }

            if (!string.IsNullOrEmpty(categoryId))
            {
                url = url + "&categoryId=" + HttpUtility.UrlEncode(categoryId);
            }

            if (!string.IsNullOrEmpty(brandId))
            {
                url = url + "&brandId=" + HttpUtility.UrlEncode(brandId);
            }
 
            if (!string.IsNullOrEmpty(ep))
            {
                url = url + "&ep=" + HttpUtility.UrlEncode(ep);
            }

            if (lat != null)
            {
                url = url + "&lat=" + HttpUtility.UrlEncode(lat.ToString());
            }

            if (lon != null)
            {
                url = url + "&lon=" + HttpUtility.UrlEncode(lon.ToString());
            }

            if (distance != null)
            {
                url = url + "&distance=" + HttpUtility.UrlEncode(distance.ToString());
            }

            if (!string.IsNullOrEmpty(brandId))
            {
                url = url + "&brandId=" + HttpUtility.UrlEncode(brandId.ToString());
            }

            
            if (page != 0)
            {
                url = url + "&page=" + page.ToString();
            }

            if (itemsPerPage != 0)
            {
                url = url + "&itemsPerPage=" + itemsPerPage.ToString();
            }


            //string approved = queryVars["approved"];

            HttpResponseMessage response = client.GetAsync(url).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<PagedList<ProductSearch>>().Result;
                return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }
        public PagedList<ProductSearch> SearchByCategoryId(string categoryId, SortCriteria sortCriteria, SortOrder sortOrder, int page, int itemsPerPage)
        {
            return Search(categoryId, null, null, null, null, null, null, sortCriteria, sortOrder, page, itemsPerPage);
        }

        public PagedList<ProductSearch> SearchByBrandId(string brandId, SortCriteria sortCriteria, SortOrder sortOrder, int page, int itemsPerPage)
        {
            return Search(null, brandId, null, null, null, null, null, sortCriteria, sortOrder, page, itemsPerPage);

        }

        public PagedList<ProductSearch> SearchMyProducts(SortCriteria sortCriteria, SortOrder sortOrder, int page, int itemsPerPage)
        {

            string url = "api/webstore/catalog/product/searchmyproducts?z=";

            if (page != 0)
            {
                url = url + "&page=" + page.ToString();
            }

            if (itemsPerPage != 0)
            {
                url = url + "&itemsPerPage=" + itemsPerPage.ToString();
            }


            //string approved = queryVars["approved"];

            HttpResponseMessage response = client.GetAsync(url).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<PagedList<ProductSearch>>().Result;
                return r;
            }
            else
            {
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public string InsertProduct(Product product)
        {
            var response = client.PostAsJsonAsync("api/webstore/catalog/product", product).Result;
            if (response.IsSuccessStatusCode)
            {
                var r = response.Content.ReadAsAsync<string>().Result;
                return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public Product UpdateProduct(Product product)
        {
            var response = client.PutAsJsonAsync("api/webstore/catalog/product/" + product.ProductId, product).Result;
            if (response.IsSuccessStatusCode)
            {
                var r = response.Content.ReadAsAsync<Product>().Result;
                return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public Product UpdateProductLocation(string productId, double lat, double lon)
        {
            var response = client.GetAsync("api/webstore/catalog/product/" + productId + "/location?lat=" + lat.ToString(new CultureInfo("en-US")) + "&lon=" + lon.ToString(new CultureInfo("en-US"))).Result;
            if (response.IsSuccessStatusCode)
            {
                var r = response.Content.ReadAsAsync<Product>().Result;
                return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }



        public int CountProducts()
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/catalog/product/quantity").Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<int>().Result;
                return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }

        public int CountCategories()
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/catalog/category/quantity").Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<int>().Result;
                return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }

        public int CountBrands()
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/catalog/brand/quantity").Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<int>().Result;
                return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }

        public int CountCollections()
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/catalog/collection/quantity").Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<int>().Result;
                return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }

        public int CountBundles()
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/catalog/bundle/quantity").Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<int>().Result;
                return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }
    }
}

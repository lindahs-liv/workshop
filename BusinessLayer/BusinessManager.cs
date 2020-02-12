using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessManager
    {
        DataManager dataManager = new DataManager();

        public List<Products> GetProducts()
        {
            List<Products> products = new List<Products>();
            foreach (DataLayer.Products product in dataManager.GetProducts())
                products.Add(new Products(product));

            return products;
        }

        public List<Products> GetProductsStartingWithA()
        {
            List<Products> products = new List<Products>();
            foreach (DataLayer.Products product in dataManager.GetProductsStartingWithA())
                products.Add(new Products(product));

            return products;
        }

        public object GetUnitPriceGreaterThan100()
        {
            List<Products> products = new List<Products>();
            foreach (DataLayer.Products product in dataManager.GetUnitsGreaterThan100())
                products.Add(new Products(product));

            return products;
        }


        public object SortListDescending()
        {
            List<Products> products = new List<Products>();
            foreach (DataLayer.Products product in dataManager.SortListDescending())
                products.Add(new Products(product));

            return products;
        }

        public object SortListAscending()
        {
            List<Products> products = new List<Products>();
            foreach (DataLayer.Products product in dataManager.SortListAscending())
                products.Add(new Products(product));

            return products;
        }
    }
}



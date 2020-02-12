using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataManager
    {
        public List<Products> GetProducts()
        {
            using (var db = new Northwind())
            {
                return db.Products.ToList();
            }
        }

        public List<Products> GetProductsStartingWithA()
        {
            using (var db = new Northwind())
            {
                var query = from x in db.Products
                            where x.ProductName.StartsWith("A") || x.ProductName.StartsWith("a")
                            select x;

                return query.ToList();
            }
        }
    }
}

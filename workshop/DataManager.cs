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

        public List<Products> GetUnitsGreaterThan100()
        {
            using (var db = new Northwind())
            {
                var query = from x in db.Products
                            where x.UnitPrice > 100 
                            select x;

                return query.ToList();
            }
        }

        
        public List<Products> SortListDescending()
        {
            using (var db = new Northwind())
            {
                var query = from x in db.Products
                            where x.UnitPrice <= 50
                            where x.UnitPrice < 100
                            select x;

                return query.ToList();
            }
        }

        public IEnumerable<Products> SortListAscending()
        {
            using (var db = new Northwind())
            {
                var query = from x in db.Products
                            where x.UnitPrice <= 50
                            where x.UnitPrice < 100
                            select x;

                return query.ToList();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Store.Models;
using Store.Services.DAL;

namespace Store.Services.Controllers
{
    public class ProductsController : ApiController
    {
        private StoreServicesContext db = new StoreServicesContext();

        public IQueryable<Product> GetAllProducts()
        {
            return db.Products;
        }

        public IHttpActionResult GetProductById(int id)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        public IHttpActionResult PutProduct(int id, Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.Id)
            {
                return BadRequest();
            }

            db.Entry(product).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductExists(int id)
        {
            return db.Products.Count(e => e.Id == id) > 0;
        }

        public IQueryable<Country> GetAllCountries()
        {
            return db.Countries;
        }

        public IQueryable<Category> GetAllCategories()
        {
            return db.Categories;
        }

        public IQueryable<Company> GetAllCompanies()
        {
            return db.Companies;
        }
    }
}
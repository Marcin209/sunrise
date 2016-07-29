using System;
using System.Globalization;
using System.Web.Http;
using ProductsApp.Models;
using Sunrise.Energy.Computing;


namespace ProductsApp.Controllers
{
    /// <summary>
    /// Products controller
    /// </summary>
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        private CalculateWats _calculateWats;
        Product _product;
        
        /// <summary>
        /// Get Product
        /// </summary>
        /// <remarks>Metod get two parameters string and double</remarks>
        /// <remarks>Return object type of Product or exception</remarks> 
        [Route("example1")]
        public Product GetProduct(string date, double latitude)
        {
            string format = "yyyy-MM-ddTHH:mm:ss";
            DateTime dateTime = DateTime.ParseExact(date, format,new CultureInfo("en-US"));
            dateTime = dateTime.ToUniversalTime();
            string data = dateTime.Year.ToString()+"-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString() + " T " +dateTime.Hour.ToString() +":"+ dateTime.Minute.ToString();
            _product =new Product();
            _calculateWats = new CalculateWats();
            _calculateWats.setData(dateTime);
            _calculateWats.setLatidue(latitude);
            _product.DateTime = data;
            _product.Latitude = latitude;
            _product.Wats = Math.Round(_calculateWats.getWats(), 2);
            return _product;
        }
       /// <summary>
        /// Get Present Product
        /// </summary>
        /// <remarks>Metod get one parameter double</remarks>
        /// <remarks>Return object type of Product or exception</remarks>
        [Route("example2")]    
        public Product GetProduct(double latitude)
        {
          

            DateTime dateTime = DateTime.Now;
            string data = dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString() + " T " + dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString();
            _product = new Product();
            _calculateWats = new CalculateWats();
            _calculateWats.setData(dateTime);
            _calculateWats.setLatidue(latitude);
            _product.DateTime = data;
            _product.Latitude = latitude;
            _product.Wats = Math.Round(_calculateWats.getWats(), 2);
            return _product;

        }
      /// <summary>
        /// Get Product
        /// </summary>
        /// <remarks>Metod without parameters</remarks>
        /// <remarks>Return object type of Product or exception</remarks> 
        [Route("example3")]
        public Product GetProduct()
        {
            
            double latitude = 15.0;
            DateTime dateTime = DateTime.Now;
            string data = dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString() + " T " + dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString();
            _product = new Product();
            _calculateWats = new CalculateWats();
            _calculateWats.setData(dateTime);
            _calculateWats.setLatidue(latitude);
            _product.DateTime = data;
            _product.Latitude = latitude;
            _product.Wats = Math.Round(_calculateWats.getWats(), 2);
            return _product;

        }



    }

   
}

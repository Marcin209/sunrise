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
    [RoutePrefix("api/wats")]
    public class ProductsController : ApiController
    {
        private CalculateWats kal;
        Product ob;

        /// <summary>
        /// Get Product
        /// </summary>
        /// <remarks>Metod get two parameters string and double</remarks>
        /// <remarks>Return object type of Product or exception</remarks>
        [Route("example1")]
        [HttpGet]
        public Product GetProduct(string date, double latitude)
        {
            string format = "yyyy-MM-ddTHH:mm:ss";
            DateTime dateTime = DateTime.ParseExact(date, format,new CultureInfo("en-US"));
            dateTime = dateTime.ToUniversalTime();
            
            ob =new Product();
            kal = new CalculateWats();
            kal.setData(dateTime);
            kal.setLatidue(latitude);
            ob.DateTime = dateTime;
            ob.Latitude = latitude;
            ob.Wats = kal.getWats();
            return ob;
        }
        /// <summary>
        /// Get Present Product
        /// </summary>
        /// <remarks>Metod get one parameter double</remarks>
        /// <remarks>Return object type of Product or exception</remarks>
        [Route("example1")]
        [HttpGet]
        public Product GetProduct(double latitude)
        {
            DateTime dateTime = DateTime.Now;
            ob = new Product();
            kal = new CalculateWats();
            kal.setData(dateTime);
            kal.setLatidue(latitude);
            ob.DateTime = dateTime;
            ob.Latitude = latitude;
            ob.Wats = kal.getWats();
            return ob;

        }
        /// <summary>
        /// Get Product
        /// </summary>
        /// <remarks>Metod without parameters</remarks>
        /// <remarks>Return object type of Product or exception</remarks>
        [Route("example1")]
        [HttpGet]
        public Product GetProduct()
        {
            
            double latitude = 15.0;
            DateTime dateTime = DateTime.Now;
            ob = new Product();
            kal = new CalculateWats();
            kal.setData(dateTime);
            kal.setLatidue(latitude);
            ob.DateTime = dateTime;
            ob.Latitude = latitude;
            ob.Wats = kal.getWats();
            return ob;

        }



    }

   
}

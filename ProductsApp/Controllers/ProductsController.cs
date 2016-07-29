using System;
using System.Globalization;
using System.Net;
using System.Net.Http;
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
        private CalculateSunEnergy _calculateSunEnergy;
        Product _product;
        
        /// <summary>
        /// Get Product
        /// </summary>
        /// <remarks>Metod get two parameters string and double</remarks>
        /// <remarks>Return object type of Product or exception</remarks> 
        [Route("example1")]
        public Product GetProduct(string date, double latitude)
        {
            try
            {
                string format = "yyyy-MM-ddTHH:mm:ss";
                DateTime dateTime = DateTime.ParseExact(date, format, new CultureInfo("en-US"));
                dateTime = dateTime.ToUniversalTime();
                string data = dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString() + " " + dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString();
                _product = new Product();
                _calculateSunEnergy = new CalculateSunEnergy();
                _calculateSunEnergy.setData(dateTime);
                _calculateSunEnergy.setLatidue(latitude);
                _product.DateTime = data;
                _product.Latitude = latitude;
                _product.Wats = Math.Round(_calculateSunEnergy.getWats(), 2);
                return _product;

            }
            catch (Exception e)
            {

                var resp = new HttpResponseMessage(HttpStatusCode.NotFound);
                {

                    resp.Content = new StringContent(string.Format("Exception {0}", e));
                }

                throw new HttpResponseException(resp);
            }


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
            try
           {
               
               string data = dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString() +
                             " " + dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString();
               _product = new Product();
               _calculateSunEnergy = new CalculateSunEnergy();
               _calculateSunEnergy.setData(dateTime);
               _calculateSunEnergy.setLatidue(latitude);
               _product.DateTime = data;
               _product.Latitude = latitude;
               _product.Wats = Math.Round(_calculateSunEnergy.getWats(), 2);
               return _product;

           }
           catch (Exception e)
           {

               var resp = new HttpResponseMessage(HttpStatusCode.NotFound);
               {

                   resp.Content = new StringContent(string.Format("Exception {0}", e));
               }
               
               throw new HttpResponseException(resp);
           }


        }
      /// <summary>
        /// Get Product
        /// </summary>
        /// <remarks>Metod without parameters</remarks>
        /// <remarks>Return object type of Product or exception</remarks> 
        [Route("example3")]
        public Product GetProduct()
        {
          try
            {
                double latitude = 15.0;
                DateTime dateTime = DateTime.Now;
                string data = dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString() + " " + dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString();
                _product = new Product();
                _calculateSunEnergy = new CalculateSunEnergy();
                _calculateSunEnergy.setData(dateTime);
                _calculateSunEnergy.setLatidue(latitude);
                _product.DateTime = data;
                _product.Latitude = latitude;
                _product.Wats = Math.Round(_calculateSunEnergy.getWats(), 2);
                return _product;

            }
            catch (Exception e)
            {

                var resp = new HttpResponseMessage(HttpStatusCode.NotFound);
                {

                    resp.Content = new StringContent(string.Format("Exception {0}", e));
                }

                throw new HttpResponseException(resp);
            }



        }



    }

   
}

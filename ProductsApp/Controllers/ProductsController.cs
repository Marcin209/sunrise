using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
    [RoutePrefix("api/wats")]
    public class ProductsController : ApiController
    {
        private CalculateWats kal;
        Product ob;
       
        /// <summary>
        /// Get Product
        /// </summary>
        /// <remarks>Return object type of Product or exception</remarks>
        [Route("example1")]
        [HttpGet]
        public Product GetProduct(string date, int latidue)
        {
            string format = "yyyy-MM-ddTHH:mm:ss";
            DateTime dateTime = DateTime.ParseExact(date, format,new CultureInfo("en-US"));
            
            ob =new Product();
            kal = new CalculateWats();
            kal.setData(dateTime);
            kal.setLatidue(latidue);
            ob.Wats = kal.getWats();
            return ob;
        }



        /*public Product getProduct(int year, int month,int day,int hour,int latidue)
        {   kal = new CalculateWats();
            kal.setData(new DateTime(year,month, day,hour, 0, 0));
            kal.setLatidue(latidue);
            ob = new Product();
            ob.Wats = kal.getWats();
            return ob;
        }*/
    }

   
}

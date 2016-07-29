using System;
using System.Data;

namespace Sunrise.Energy.Computing
{
 
    public class CalculateSunEnergy
    {
           
            private double _latitude;
            DateTime _dateTime;
       
            public void setData(DateTime date)
            {
                _dateTime = date;
            }

            public void setLatidue(double latitude)
            {
                if (latitude > 90 || latitude < -90)
                {
                    throw new System.ArgumentException("Parametr cannot be more than 90  or less than -90 degrees");
                }
                _latitude = latitude;
            }
            


            private double _Declination()
            {
                double tmp = (2 * Math.PI) * ((284 + _dateTime.DayOfYear) / 365.25);
                return 23.45 * (Math.PI / 180.0) * Math.Sin(tmp);
            }
          
            private double _Am(int hour, double lat)
            {
                double declinationRad = (Math.PI / 180) * _Declination();
                double HRA = (Math.PI / 180) * (15 * (hour - 12));
                double elevation = Math.Asin(Math.Sin(declinationRad) * Math.Sin(lat) + Math.Cos(declinationRad) * Math.Cos(lat) * Math.Cos(HRA));
                double declination2 = (Math.PI / 180) * 90 - elevation;

                return 1 / (1E-4 + Math.Cos(declination2));
            }


            public double getWats()
            {
            
                double declinationRad = (Math.PI / 180) * _Declination();
                _latitude = (Math.PI / 180) * _latitude;
                double x = -(Math.Sin(_latitude) * Math.Sin(declinationRad));
                x = x / (Math.Cos(_latitude) * Math.Cos(declinationRad));
                x = Math.Acos(x);
                double sunriseHour = 12.0 - x * (180 / Math.PI);
                double sunsetHour = 12.0 + x * (180 / Math.PI);
                if (_dateTime.Hour > sunriseHour && _dateTime.Hour< sunsetHour)
                {
                    double am = _Am(_dateTime.Hour, _latitude);
                    double x1 = Math.Pow(0.7, am);
                    return 1.353 * Math.Pow(x1, 0.678);
                }
                 return 0.0; 
            }



        }
    
}

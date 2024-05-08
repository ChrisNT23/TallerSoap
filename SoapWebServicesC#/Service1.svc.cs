using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapWebServicesC_
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("Los Grados en Farenheit son: {0}", (value * 9/5)+32);
            
        }

        public string GetData2(int value2)
        {
            return string.Format("Los grados en Centígrados son: {0}", (value2 - 32)* 5/9);
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Gracias";
            }
            return composite;
        }

        public string GetWeatherInfo(string location)
        {
            // Aquí puedes implementar la lógica para obtener información meteorológica
            // Puedes simular la respuesta por ahora
            WeatherInfo weather = new WeatherInfo
            {
                Temperature = "25°C",
                Humidity = "60%",
                WindSpeed = "10 km/h"
            };

            // Devuelve la información meteorológica serializada como JSON
            return SerializeToString(weather);
        }

        private string SerializeToString(WeatherInfo weather)
        {
            // Formatea la información meteorológica como una cadena de texto
            return string.Format("Temperatura: {0}\nHumedad: {1}\nVelocidad del Viento: {2}",
                                 weather.Temperature, weather.Humidity, weather.WindSpeed);
        }


    }
}

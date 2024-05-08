using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicioMio.Service1Client oClient =  new ServicioMio.Service1Client();
            string res = oClient.GetData(20);
            MessageBox.Show(res);

            ServicioMio.CompositeType oData = new ServicioMio.CompositeType();
            oData.BoolValue = true;
            var res2 = oClient.GetDataUsingDataContract(oData);
            MessageBox.Show(res2.StringValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServicioMio.Service1Client oClient2 = new ServicioMio.Service1Client();
            string res = oClient2.GetData2(90);
            MessageBox.Show(res);

            ServicioMio.CompositeType oData = new ServicioMio.CompositeType();
            oData.BoolValue = true;
            var res2 = oClient2.GetDataUsingDataContract(oData);
            MessageBox.Show(res2.StringValue);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Crear una instancia del cliente del servicio
            ServicioMio.Service1Client oClient = new ServicioMio.Service1Client();

            // Llamar al método GetWeatherInfo para obtener la información meteorológica
            string location = "New York"; // Ubicación para la cual deseas obtener la información meteorológica
            string weatherInfo = oClient.GetWeatherInfo(location);

            // Mostrar la información meteorológica en un cuadro de mensaje
            MessageBox.Show(weatherInfo);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dias_Edad_Vividos.S.S
{
    public partial class GUI : Form
    {
        double Dias = 0;TimeSpan Valor;int i=0;
        public GUI()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Valor = DateTime.Now - dtpFdNacimiento.Value;//Calcula el tiempo entre dos fechas
            Dias = Valor.Days;//Extrae la cantidad de dias transcurridos
            lblDias.Text = Dias.ToString();
            CalcularAños();//Ejecuta el calculo y animacion
        }
        private void CalcularAños()
        {
            if (Dias>87)
            {
                timeAnimacion.Start();
            }
        }
        private void timeAnimacion_Tick(object sender, EventArgs e)
        {
            if (i < 25)//Se hace la animacion del calculo
            {
                lblMercurio.Text = NumsRandom(4);
                lblVenus.Text = NumsRandom(3);
                lblTierra.Text = NumsRandom(3);
                lblJupiter.Text = NumsRandom(3);
                lblMarte.Text = NumsRandom(3);
                lblSaturno.Text = NumsRandom(3);
                lblUrano.Text = NumsRandom(3);
                lblNeptuno.Text = NumsRandom(3);
                i++;
            }
            else//Se asignan los valores en años por cada pñaneta
            {
                i = 0;
                lblMercurio.Text = (Dias / 87.9).ToString().Substring(0, 6);
                lblVenus.Text = (Dias / 224.7).ToString().Substring(0, 6);
                lblTierra.Text = (Dias / 365.25).ToString().Substring(0, 6);//Incluye años viciestos
                lblMarte.Text = (Dias / 687).ToString().Substring(0, 6);
                lblJupiter.Text = (Dias / 4337).ToString().Substring(0, 6);
                lblSaturno.Text = (Dias / 10759).ToString().Substring(0, 6);
                lblUrano.Text = (Dias / 30688).ToString().Substring(0, 6);
                lblNeptuno.Text = (Dias / 60182).ToString().Substring(0, 6);
                timeAnimacion.Stop();
            }
        }
        string NumsRandom(int Length)//Genera numeros al azar para la animacion del calculo
        {
            string tmp = "";
            Random ran = new Random();
            for (int i = 0; i < Length; i++)
            {
                tmp += ran.Next(0, 10);
            }
            return tmp;
        }
    }
}

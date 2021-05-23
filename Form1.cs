using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_no7
{
    public partial class Form1 : Form
    {
        List<Propietario> propietarios = new List<Propietario>();
        List<Propiedad> propiedades = new List<Propiedad>();
        List<Reporte> reportes = new List<Reporte>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Cargar()
        {

            {
                FileStream stream = new FileStream(@"..\..\propietarios.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    Propietario propietario = new Propietario();

                    propietario.Dpi = reader.ReadLine();
                    propietario.Nombre = reader.ReadLine();
                    propietario.Apellido = reader.ReadLine();

                    propietarios.Add(propietario);
                }

                reader.Close();
            }

            {
                FileStream stream = new FileStream(@"..\..\propiedades.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    Propiedad propiedad = new Propiedad();

                    propiedad.NoCasa = reader.ReadLine();
                    propiedad.Dpi = reader.ReadLine();
                    propiedad.Cuota = Convert.ToDouble(reader.ReadLine());


                    propiedades.Add(propiedad);
                }

                reader.Close();
            }

        }

        private void MostrarReporte(bool ordenada = false)
        {
            //por si se presiona varias veces el boton de cargar o de ordenar
            //cada vez borramos la lista
            reportes.Clear();

            foreach (var propiedad in propiedades)
            {
                Reporte reporte = new Reporte();

                Propietario propietario = propietarios.Find(p => p.Dpi == propiedad.Dpi);

                reporte.Dpi = propietario.Dpi;
                reporte.Nombre = propietario.Nombre;
                reporte.Apellido = propietario.Apellido;
                reporte.NoCasa = propiedad.NoCasa;
                reporte.Cuota = propiedad.Cuota;

                reportes.Add(reporte);
            }


            if (ordenada)
                reportes = reportes.OrderBy(r => r.Cuota).ToList();

            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = reportes;
            //por si no queremos mostrar el dpi
            dataGridViewReporte.Columns[0].Visible = false;
            dataGridViewReporte.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MostrarReporte();

        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            MostrarReporte(true);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarReporte(true);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Cargar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var repetidos = reportes.GroupBy(r => r.Dpi);

            
            int max = 0;
            
            int pos = 0;

            
            for (int i = 0; i < repetidos.Count(); i++)
            {
                
                if (repetidos.ToList()[i].Count() > max)
                {
                    max = repetidos.ToList()[i].Count();
                    pos = i;
                }
            }

           
            labelPropietario.Text = "El DPI: " + repetidos.ToList()[pos].Key;
            
            labelPropiedades.Text = "Tiene " + max.ToString() + " Propiedades";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarReporte(true);

            int cuantos = reportes.Count();

            
            labelBajas.Text = "Más Bajas: " + reportes[0].Cuota.ToString() + "," + reportes[1].Cuota.ToString() + "," + reportes[2].Cuota.ToString();
            
            labelAltas.Text = "Más Altas: " + reportes[cuantos - 1].Cuota.ToString() + "," + reportes[cuantos - 2].Cuota.ToString() + "," + reportes[cuantos - 3].Cuota.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var agrupado = reportes.GroupBy(r => r.Dpi);

            //inciar con una cuota mayor de 0 y un dpi vacio
            double maxCuota = 0;
            string maxDpi = "";


            //Recorrer cada dato agrupado
            foreach (var grupo in agrupado)
            {

                double sumaCuota = 0;
                string dpi = "";

                //se recorren cada propiedad que hay en el grupo con el mismo dpi
                //y se va sumando el total de cuotas de cada una de esas propiedades
                //y se guarda el dpi de ese grupo
                foreach (var p in grupo)
                {
                    sumaCuota += p.Cuota;
                    dpi = p.Dpi;
                }

                //si la suma de las cuotas del dpi actual es mayor que la cuota mayor
                //la suma de la cuota se convirte en la cuota mayor
                //y se guarda el dpi de esa suma de cuotas
                if (sumaCuota > maxCuota)
                {
                    maxCuota = sumaCuota;
                    maxDpi = dpi;
                }
            }


            labelPropietarioMax.Text = maxDpi;
            labelCuotaMax.Text = maxCuota.ToString();


        }
    }
}


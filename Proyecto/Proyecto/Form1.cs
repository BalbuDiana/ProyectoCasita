using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Proyecto
{
    public partial class Form1 : Form
    {
     //   Graphics g;

        int tiempo = 0;
        List<Electro_master> listaDeObjetos = new List<Electro_master>();
        public Form1()
        {
            InitializeComponent();

            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            textBox1.Text = "Tiempo transcurrido" + tiempo++;
        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            
            
            CreaObjetosForm creador = new CreaObjetosForm();

            string opcion = comboBox1.Text;

            if (opcion != "")
            {
                groupBox8.Visible = true;
            }

            if (opcion == "Cocina")
            {
                comboBox2.Text = "";
                comboBox2.SelectedItem = null;
                comboBox2.SelectedIndex = -1;

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Estufa");
                comboBox2.Items.Add("Foco");
                comboBox2.Items.Add("Licuadora");
                comboBox2.Items.Add("Microondas");
                comboBox2.Items.Add("Lampara");
                comboBox2.Items.Add("Refrigerador");
                comboBox2.Items.Add("Tostador");

            }
            else if (opcion == "Comedor")
            {
                comboBox2.Text = "";
                comboBox2.SelectedItem = null;
                comboBox2.SelectedIndex = -1;

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Foco");
                comboBox2.Items.Add("Televisión");
            }
            else if (opcion == "Habitacion")
            {
                comboBox2.Text = "";
                comboBox2.SelectedItem = null;
                comboBox2.SelectedIndex = -1;

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Consola");
                comboBox2.Items.Add("DVD");
                comboBox2.Items.Add("Estereo");
                comboBox2.Items.Add("Foco");
                comboBox2.Items.Add("Lampara");
                comboBox2.Items.Add("Laptop");
                comboBox2.Items.Add("Plancha");
                comboBox2.Items.Add("Teléfono");
                comboBox2.Items.Add("Televisión");


            }
            else if (opcion == "Habitación de huéspedes")
            {
                comboBox2.Text = "";
                comboBox2.SelectedItem = null;
                comboBox2.SelectedIndex = -1;

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Foco");
                comboBox2.Items.Add("Lampara");
                comboBox2.Items.Add("Teléfono");
                comboBox2.Items.Add("Televisión");

            }
            else if (opcion == "Patio")
            {
                comboBox2.Text = "";
                comboBox2.SelectedItem = null;
                comboBox2.SelectedIndex = -1;

                comboBox2.Items.Clear();

                comboBox2.Items.Add("Foco");
                comboBox2.Items.Add("Lampara");
                comboBox2.Items.Add("Lavadora");
                comboBox2.Items.Add("Secadora");

            }
            else if (opcion == "Sala")
            {
                comboBox2.Text = "";
                comboBox2.SelectedItem = null;
                comboBox2.SelectedIndex = -1;

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Foco");
                comboBox2.Items.Add("Lampara");
                comboBox2.Items.Add("Teléfono");
                comboBox2.Items.Add("Televisión");
            }
            else if (opcion == "WC")
            {
                comboBox2.Text = "";
                comboBox2.SelectedItem = null;
                comboBox2.SelectedIndex = -1;

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Foco");
            }
            else
            {
                MessageBox.Show("Lo sentimos, la opción seleccionada no es correcta");

            }

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string opcion = comboBox2.Text;
            string id = textBox2.Text;

            if(id=="")
            
            if (opcion == "Consola")
            {
                Electrodomesticos.Consola consola = new Electrodomesticos.Consola(id, comboBox1.Text);
                listaDeObjetos.Add(consola);
            }
            else if (opcion == "DVD")
            {
                DVD_video dvd = new DVD_video(id, comboBox1.Text);

            }
            else if (opcion == "Estereo")
            {
                Electrodomesticos.Estereo estereo = new Electrodomesticos.Estereo(id, comboBox1.Text);
            }
            else if (opcion == "Estufa")
            {
                Estufa estufa = new Estufa(id);

            }
            else if (opcion == "Foco")
            {
                try
                {

                }
                catch (FormatException)
                {

                }
                Electrodomesticos.Foco foco = new Electrodomesticos.Foco();
            }
            else if (opcion == "Lampara")
            {

            }
            else if (opcion == "Laptop")
            {

            }
            else if (opcion == "Lavadora")
            {

            }
            else if (opcion == "Licuadora")
            {

            }
            else if (opcion == "Microondas")
            {

            }
            else if (opcion == "Plancha")
            {

            }
            else if (opcion == "Refrigerador")
            {

            }
            else if (opcion == "Secadora")
            {

            }
            else if (opcion == "Teléfono")
            {

            }
            else if (opcion == "Televisión")
            {

            }
            else if (opcion == "Tostador")
            {
            }


            }
        }
    }


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
            else if (opcion == "Habitación")
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
           
           // if(id=="")
            
            if (opcion == "Consola")
            {
               Electro_master consola = new Electrodomesticos.Consola(id, comboBox1.Text);
                listaDeObjetos.Add(consola);
            }
            else if (opcion == "DVD")
            {
                    Electro_master dvd = new DVD_video(id, comboBox1.Text);
                    listaDeObjetos.Add(dvd);

            }
            else if (opcion == "Estereo")
            {
                    Electro_master estereo = new Electrodomesticos.Estereo(id, comboBox1.Text);
                    listaDeObjetos.Add(estereo);
                }
            else if (opcion == "Estufa")
            {
                    
                   Electro_master estufa = new Estufa(id);

                    listaDeObjetos.Add(estufa);
                }
            else if (opcion == "Foco")
            {
                try
                {

                }
                catch (FormatException)
                {

                }
                    Electro_master foco = new Electrodomesticos.Foco(100,id,comboBox1.Text);
                    listaDeObjetos.Add(foco);

                }
            else if (opcion == "Lampara")
            {
                    Electro_master lampara =  new Electrodomesticos.Lampara(id, comboBox1.Text);
                    listaDeObjetos.Add(lampara);
                    

                }
            else if (opcion == "Laptop")
            {
                    Electro_master laptop =  new Laptop(id, comboBox1.Text);
                    listaDeObjetos.Add(laptop);
                }
            else if (opcion == "Lavadora")
            {
                    Electro_master lavadora = new Electrodomesticos.Lavadora(250, id, comboBox1.Text);
                    listaDeObjetos.Add(lavadora);
                }
            else if (opcion == "Licuadora")
            {
                    Electro_master licuadora =  new Licuadora(id);
                    listaDeObjetos.Add(licuadora);
                }
            else if (opcion == "Microondas")
            {
                    Electro_master microondas = new Microondas(id);
                    listaDeObjetos.Add(microondas);
                }
            else if (opcion == "Plancha")
            {
                    Electro_master plancha = new Plancha(id, comboBox1.Text);
                    listaDeObjetos.Add(plancha);
                }
            else if (opcion == "Refrigerador")
            {
                    Electro_master refrigerador =  new Electrodomesticos.Refrigerador(id, comboBox1.Text);
                    listaDeObjetos.Add(refrigerador);
                }
            else if (opcion == "Secadora")
            {
                    Electro_master secadora =new Secadora(id, comboBox1.Text);
                    listaDeObjetos.Add(secadora);
                }
            else if (opcion == "Teléfono")
            {
                    Electro_master telefono =  new Electrodomesticos.Telefono(id, comboBox1.Text);
                    listaDeObjetos.Add(telefono);
                }
            else if (opcion == "Televisión")
            {
                    Electro_master tv = new Electrodomesticos.Television(id, comboBox1.Text);
                    listaDeObjetos.Add(tv);
                }
            else if (opcion == "Tostador")
            {
                    Electro_master tostador = new Tostador(id);
                    listaDeObjetos.Add(tostador);
                }
            
            else
            {
                MessageBox.Show("La opción es incorrecta, no se generará ningún objeto");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaDeObjetos == null)
            {
                label5.Text = ("No hay objetos");
            }
            else
            {
                for (int i = 0; i < listaDeObjetos.Count; i++)
                {

                    label5.Text = ("se creo un:" +listaDeObjetos[i]+"\n");
                }

            }
            

            
        }
    }
}

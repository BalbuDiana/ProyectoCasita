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
      //  Graphics g;

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
        //double rt = 0;
        private double[] cpuArray = new double[10];
        Random r = new Random();
        private void T_Tick(object sender, EventArgs e)
        {
            textBox1.Text = "Tiempo transcurrido" + tiempo++;
            chart1.Series[0].Points.AddY(r.NextDouble());
            //chart1.Series["Series 1"].Points.Clear();
            for (int i = 0; i < cpuArray.Length; i++)
            {
                //chart1.Series[0].Points.AddY(r.NextDouble());
                if (i == (cpuArray.Count() - 1))
                {
                        chart1.Series["Series1"].Points.Clear();
                }
             }
            //rt = rt + 0.1;

        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            

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
            Electro_master nuevo = null;


           /* if (opcion == "Foco") //balbu aqui lo que querias hacer para potencia
            {
                
                MessageBox.Show("Generaste un foco.", "por favor ingresa Potencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                gbPotencia.Visible = true;
               // nuevo = new Electrodomesticos.Foco(Convert.ToDouble(textBox3.Text), id, comboBox1.Text);
            }
            */
           // if(id=="")
            
            if (opcion == "Consola")
            {
                nuevo = new Electrodomesticos.Consola(id, comboBox1.Text);
                MessageBox.Show("generaste una conconsola en: " + comboBox1.Text);
                listaDeObjetos.Add(nuevo);
            }
            else if (opcion == "DVD")
            {
                    nuevo = new DVD_video(id, comboBox1.Text);
                    listaDeObjetos.Add(nuevo);


                }
            else if (opcion == "Estereo")
            {
                    nuevo = new Electrodomesticos.Estereo(id, comboBox1.Text);
                    listaDeObjetos.Add(nuevo);
                }
            else if (opcion == "Estufa")
            {
                nuevo = new Estufa(id);

            }
            else if (opcion == "Foco")
            {
                   /* //MessageBox.Show("Generaste un foco.", "por favor ingresa Potencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //gbPotencia.Visible = true;

                    //double w = 0;
                try
                {
                    w = Convert.ToDouble(textBox3.Text);
                   
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lo sentimos, lo que ha ingresado no ha sido un núnmero, inténtelo nuevamente");
                    return;

                }
                */
                nuevo = new Electrodomesticos.Foco(100, id, comboBox1.Text);
                MessageBox.Show("generaste una Foco en: " + comboBox1.Text);
                listaDeObjetos.Add(nuevo);

                }
            else if (opcion == "Lampara")
            {
                    nuevo = new Electrodomesticos.Lampara(id, comboBox1.Text);
                    listaDeObjetos.Add(nuevo);
                }
            else if (opcion == "Laptop")
            {
                    nuevo = new Laptop(id, comboBox1.Text);
                    listaDeObjetos.Add(nuevo);
                }
            else if (opcion == "Lavadora")
            {
                    nuevo = new Electrodomesticos.Lavadora(1200, id, comboBox1.Text);
                    listaDeObjetos.Add(nuevo);
                }
            else if (opcion == "Licuadora")
            {
                    nuevo = new Licuadora(id);
                    listaDeObjetos.Add(nuevo);
                }
            else if (opcion == "Microondas")
            {
                    nuevo = new Microondas(id);
                    listaDeObjetos.Add(nuevo);
                }
            else if (opcion == "Plancha")
            {
                    nuevo = new Plancha(id, comboBox1.Text);
                    listaDeObjetos.Add(nuevo);
                }
            else if (opcion == "Refrigerador")
            {
                    nuevo = new Electrodomesticos.Refrigerador(id, comboBox1.Text);
                    listaDeObjetos.Add(nuevo);
                }
            else if (opcion == "Secadora")
            {
                    nuevo = new Secadora(id, comboBox1.Text);
                    listaDeObjetos.Add(nuevo);
                }
            else if (opcion == "Teléfono")
            {
                    nuevo = new Electrodomesticos.Telefono(id, comboBox1.Text);
                    listaDeObjetos.Add(nuevo);
                }
            else if (opcion == "Televisión")
            {
                    nuevo = new Electrodomesticos.Telefono(id, comboBox1.Text);
                    listaDeObjetos.Add(nuevo);
                }
            else if (opcion == "Tostador")
            {
                    nuevo = new Tostador(id);
                    listaDeObjetos.Add(nuevo);
                }

            //listaDeObjetos.Add(nuevo);

        }


        //------------------------------------------------------------------------------------------------------
      //generando imagen

        private void button2_Click(object sender, EventArgs e)
        {
            //g = CocinaPanel.CreateGraphics();
            //  Licuadora l = new Licuadora("Hola");
             Microondas l = new Microondas("hola");
            // Electrodomesticos.Foco l = new Electrodomesticos.Foco(453, "foquito", "sala");
            //Electrodomesticos.Lampara l = new Electrodomesticos.Lampara("hu", "hue");
            l.CrearIcono();
            pictureBox2.Image = l.ObtenerIMagen();

            //pictureBox1.Refresh();
        }


        //Generando movimiento de picturebox

        int posMouseFormX, posMouseFormY;
        int posMousePictureX, posMousePictureY;
        int posActBotonX, posActBotonY;
        bool pictureclick = false;
        //-----------------------------------------------------Principalll------------------------


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //posiciones de mouse cuando pasapor formulario
            posMouseFormX = e.Location.X;
            posMouseFormY = e.Location.Y;
        }

        //----------------------secundarios

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            pictureBox2.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox2.Location.X;
            posActBotonY = pictureBox2.Location.Y;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }


        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true; //cuando le da clic que sea cierto y se mueva respecto al mause
        }



        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }


        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture(); //se debe de mover el picture

        }

        private void moverpicture()
        {
            pictureBox2.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox2.Location.X;
            posActBotonY = pictureBox2.Location.Y;
        }
        //---------------------------------------------------------------------------------------------

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox1.Location.X;
            posActBotonY = pictureBox1.Location.Y;
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }


        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true; //cuando le da clic que sea cierto y se mueva respecto al mause
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hola");
        }


        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture1(); //se debe de mover el picture
        }



        private void moverpicture1()
        {
            pictureBox1.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox1.Location.X;
            posActBotonY = pictureBox1.Location.Y;
        }


        //-----------------------------------------------------------------------------------------------------------------







        public string imprimir_lista()
        {
            string s = "";

            s = "hola";

            return s;
        }



    }
    }


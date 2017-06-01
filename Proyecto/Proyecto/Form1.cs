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

        Random r = new Random();
        private void T_Tick(object sender, EventArgs e)
        {
            textBox1.Text = "Tiempo transcurrido" + tiempo++;
            chart1.Series[0].Points.AddY(r.NextDouble());
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
                Electrodomesticos.Consola l = new Electrodomesticos.Consola(id, comboBox1.Text);
                if (l.GetUbicacion() == "Habitación")
                {

                    MessageBox.Show("generaste una conconsola en: " + comboBox1.Text, listaDeObjetos.Count().ToString());
                    l.CrearIcono();
                    pictureBox18.Image = l.ObtenerIMagen();
                    //pictureBox18.Refresh();
                    listaDeObjetos.Add(l);


                }

            }
            else if (opcion == "DVD")
            {
                DVD_video l = new DVD_video(id, comboBox1.Text);
                l.CrearIcono();
                pictureBox17.Image = l.ObtenerIMagen();
                //  pictureBox17.Refresh();
                listaDeObjetos.Add(l);

            }
            else if (opcion == "Estereo")
            {
                Electrodomesticos.Estereo l = new Electrodomesticos.Estereo(id, comboBox1.Text);
                l.CrearIcono();
                pictureBox16.Image = l.ObtenerIMagen();
                listaDeObjetos.Add(l);
            }
            else if (opcion == "Estufa")
            {

                Estufa l = new Estufa(id);
                l.CrearIcono();
                pictureBox15.Image = l.ObtenerIMagen();
                listaDeObjetos.Add(l);


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
                Electrodomesticos.Foco l = new Electrodomesticos.Foco(100, id, comboBox1.Text);
                MessageBox.Show("generaste una Foco en: " + comboBox1.Text);
                if (l.GetUbicacion() == "WC")
                {
                    l.CrearIcono();
                    pictureBox14.Image = l.ObtenerIMagen();
                    listaDeObjetos.Add(l);
                }  
               else if (l.GetUbicacion() == "Cocina")
                {
                    l.CrearIcono();
                    pictureBox30.Image = l.ObtenerIMagen();
                    //pictureBox19.Refresh();
                    listaDeObjetos.Add(l); l.CrearIcono();

                }
                else if (l.GetUbicacion() == "Habitación")
                {

                    l.CrearIcono();
                    pictureBox31.Image = l.ObtenerIMagen();
                    //pictureBox18.Refresh();
                    listaDeObjetos.Add(l);

                }
                else if (l.GetUbicacion() == "Habitación de huéspedes")
                {

                    l.CrearIcono();
                    pictureBox32.Image = l.ObtenerIMagen();
                    //pictureBox18.Refresh();
                    listaDeObjetos.Add(l);

                }
                else if (l.GetUbicacion() == "Patio")
                {

                    l.CrearIcono();
                    pictureBox34.Image = l.ObtenerIMagen();
                    //pictureBox18.Refresh();
                    listaDeObjetos.Add(l);

                }
                else if (l.GetUbicacion() == "Sala")
                {

                    l.CrearIcono();
                    pictureBox36.Image = l.ObtenerIMagen();
                    //pictureBox18.Refresh();
                    listaDeObjetos.Add(l);

                }
                else if (l.GetUbicacion() == "Comedor")
                {

                    l.CrearIcono();
                    pictureBox28.Image = l.ObtenerIMagen();
                    //pictureBox18.Refresh();
                    listaDeObjetos.Add(l);

                }
                else
                {
                    MessageBox.Show("Lo siento ya no se pueden generar mas objetos consola", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (opcion == "Lampara")
            {
                Electrodomesticos.Lampara l = new Electrodomesticos.Lampara(id, comboBox1.Text);
                if (l.GetUbicacion() == "Cocina")
                {
                    l.CrearIcono();
                    pictureBox19.Image = l.ObtenerIMagen();
                    //pictureBox19.Refresh();
                    listaDeObjetos.Add(l); l.CrearIcono();

                }
                else if (l.GetUbicacion() == "Habitación")
                {

                    l.CrearIcono();
                    pictureBox4.Image = l.ObtenerIMagen();
                    //pictureBox18.Refresh();
                    listaDeObjetos.Add(l);

                }
                else if (l.GetUbicacion() == "Habitación de huéspedes")
                {

                    l.CrearIcono();
                    pictureBox3.Image = l.ObtenerIMagen();
                    //pictureBox18.Refresh();
                    listaDeObjetos.Add(l);

                }
                else if (l.GetUbicacion() == "Patio")
                {

                    l.CrearIcono();
                    pictureBox24.Image = l.ObtenerIMagen();
                    //pictureBox18.Refresh();
                    listaDeObjetos.Add(l);

                }
                else if (l.GetUbicacion() == "Sala")
                {

                    l.CrearIcono();
                    pictureBox26.Image = l.ObtenerIMagen();
                    //pictureBox18.Refresh();
                    listaDeObjetos.Add(l);

                }
                else
                {
                    MessageBox.Show("Lo siento ya no se pueden generar mas objetos Foco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (opcion == "Laptop")
            {
                Laptop l = new Laptop(id, comboBox1.Text);
                l.CrearIcono();
                pictureBox13.Image = l.ObtenerIMagen();
                listaDeObjetos.Add(l);
            }
            else if (opcion == "Lavadora")
            {
                Electrodomesticos.Lavadora l = new Electrodomesticos.Lavadora(1200, id, comboBox1.Text);
                l.CrearIcono();
                pictureBox12.Image = l.ObtenerIMagen();
                listaDeObjetos.Add(l);
            }
            else if (opcion == "Licuadora")
            {
                Licuadora l = new Licuadora(id);
                l.CrearIcono();
                pictureBox11.Image = l.ObtenerIMagen();
                listaDeObjetos.Add(l);
            }
            else if (opcion == "Microondas")
            {
                Microondas l = new Microondas(id);
                l.CrearIcono();
                pictureBox2.Image = l.ObtenerIMagen();
                listaDeObjetos.Add(l);

                //pictureBox1.Refresh();

            }
            else if (opcion == "Plancha")
            {
                Plancha l = new Plancha(id, comboBox1.Text);
                l.CrearIcono();
                pictureBox10.Image = l.ObtenerIMagen();
                listaDeObjetos.Add(l);
            }
            else if (opcion == "Refrigerador")
            {
                Electrodomesticos.Refrigerador l = new Electrodomesticos.Refrigerador(id, comboBox1.Text);
                l.CrearIcono();
                pictureBox9.Image = l.ObtenerIMagen();
                listaDeObjetos.Add(l);
            }
            else if (opcion == "Secadora")
            {
                Secadora l = new Secadora(id, comboBox1.Text);
                l.CrearIcono();
                pictureBox8.Image = l.ObtenerIMagen();
                listaDeObjetos.Add(l);
            }
            else if (opcion == "Teléfono")
            {
                Electrodomesticos.Telefono l = new Electrodomesticos.Telefono(id, comboBox1.Text);
                if (l.GetUbicacion() == "Habitación de huéspedes")
                {
                    l.CrearIcono();
                    pictureBox7.Image = l.ObtenerIMagen();
                    listaDeObjetos.Add(l);
                }
                 else if (l.GetUbicacion() == "Habitación")
                {

                    l.CrearIcono();
                    pictureBox114.Image = l.ObtenerIMagen();
                    //pictureBox18.Refresh();
                    listaDeObjetos.Add(l);

                }
                else if (l.GetUbicacion() == "Sala")
                {

                    l.CrearIcono();
                    pictureBox115.Image = l.ObtenerIMagen();
                    //pictureBox18.Refresh();
                    listaDeObjetos.Add(l);

                }
            }
            else if (opcion == "Televisión")
            {
                Electrodomesticos.Television l = new Electrodomesticos.Television(id, comboBox1.Text);
                if (l.GetUbicacion() == "Sala")
                {
                    l.CrearIcono();
                    pictureBox6.Image = l.ObtenerIMagen();
                    listaDeObjetos.Add(l);
                }
                else if (l.GetUbicacion() == "Habitación")
                {

                    l.CrearIcono();
                    pictureBox111.Image = l.ObtenerIMagen();
                    //pictureBox18.Refresh();
                    listaDeObjetos.Add(l);

                }
                else if (l.GetUbicacion() == "Habitación de huéspedes")
                {

                    l.CrearIcono();
                    pictureBox112.Image = l.ObtenerIMagen();
                    //pictureBox18.Refresh();
                    listaDeObjetos.Add(l);

                }
                else if (l.GetUbicacion() == "Comedor")
                {

                    l.CrearIcono();
                    pictureBox113.Image = l.ObtenerIMagen();
                    //pictureBox18.Refresh();
                    listaDeObjetos.Add(l);

                }
            }
            else if (opcion == "Tostador")
            {
                Tostador l = new Tostador(id);
                l.CrearIcono();
                pictureBox5.Image = l.ObtenerIMagen();
                listaDeObjetos.Add(l);
            }

            //listaDeObjetos.Add(nuevo);

        }


        //------------------------------------------------------------------------------------------------------
      //generando imagen

        private void button2_Click(object sender, EventArgs e)
        {

            Microondas l = new Microondas("hola");
            l.CrearIcono();
            pictureBox34.Image = l.ObtenerIMagen();

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

        private void moverpicture()
        {
            //box1
            pictureBox1.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox1.Location.X;
            posActBotonY = pictureBox1.Location.Y;

            //box 2
            pictureBox2.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox2.Location.X;
            posActBotonY = pictureBox2.Location.Y;

            //box 36
            pictureBox36.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox36.Location.X;
            posActBotonY = pictureBox36.Location.Y;

            //box34
            pictureBox34.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox34.Location.X;
            posActBotonY = pictureBox34.Location.Y;

            //box 32
            pictureBox32.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox32.Location.X;
            posActBotonY = pictureBox32.Location.Y;

            //box 31
            pictureBox31.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox31.Location.X;
            posActBotonY = pictureBox31.Location.Y;

            //box 
        }
        //---------------------------------------------------------------------------------------------

            //generando movimiento por mouse

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
        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture(); //se debe de mover el picture
        }
        private void pictureBox36_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true; //cuando le da clic que sea cierto y se mueva respecto al mause
        }
        private void pictureBox36_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox36_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture(); //se debe de mover el picture
        }
        private void pictureBox36_DoubleClick(object sender, EventArgs e)
        {
            pictureBox36.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox1.Location.X;
            posActBotonY = pictureBox1.Location.Y;
        }
        private void pictureBox34_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox34_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true; //cuando le da clic que sea cierto y se mueva respecto al mause
        }
        private void pictureBox34_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture(); //se debe de mover el picture
        }
        private void pictureBox34_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox32_DoubleClick(object sender, EventArgs e)
        {
            pictureBox32.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox1.Location.X;
            posActBotonY = pictureBox1.Location.Y;
        }
        private void pictureBox32_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox32_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true; //cuando le da clic que sea cierto y se mueva respecto al mause
        }
        private void pictureBox32_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture(); //se debe de mover el picture
        }
        private void pictureBox32_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox31_DoubleClick(object sender, EventArgs e)
        {
            pictureBox31.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox1.Location.X;
            posActBotonY = pictureBox1.Location.Y;
        }
        private void pictureBox31_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox31_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true; //cuando le da clic que sea cierto y se mueva respecto al mause
        }
        private void pictureBox31_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture(); //se debe de mover el picture
        }
        private void pictureBox31_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox36_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox34_DoubleClick(object sender, EventArgs e)
        {
            pictureBox34.Image = null;

            //abrir formulario campura posiciones 
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


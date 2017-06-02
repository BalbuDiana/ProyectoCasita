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
        private double[] cpuArray = new double[30];  

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
            //chart1.Series["Series 1"].Points.Clear();
            if (chart1.Series["Series1"].Points.Count > 10)
            {
                chart1.Series["Series1"].Points.RemoveAt(0);
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

            Electro_master l = null;

            if (opcion == "Consola")
            {
                l = new Electrodomesticos.Consola(id, comboBox1.Text);
                if (l.GetUbicacion() == "Habitación")
                {
                    l.CrearIcono();
                    pictureBox18.Image = l.ObtenerIMagen();

                }
            }
            else if (opcion == "DVD")
            {
                l = new DVD_video(id, comboBox1.Text);
                l.CrearIcono();
                pictureBox17.Image = l.ObtenerIMagen();


            }
            else if (opcion == "Estereo")
            {
                l = new Electrodomesticos.Estereo(id, comboBox1.Text);
                l.CrearIcono();
                pictureBox16.Image = l.ObtenerIMagen();

            }
            else if (opcion == "Estufa")
            {

                l = new Estufa(id);
                pictureBox15.Image = l.ObtenerIMagen();

            }
            else if (opcion == "Foco")
            {

                l = new Electrodomesticos.Foco(100, id, comboBox1.Text);

                if (l.GetUbicacion() == "WC")
                {
                    l.CrearIcono();
                    pictureBox14.Image = l.ObtenerIMagen();

                }
                else if (l.GetUbicacion() == "Cocina")
                {
                    l.CrearIcono();
                    pictureBox30.Image = l.ObtenerIMagen();


                }
                else if (l.GetUbicacion() == "Habitación")
                {

                    l.CrearIcono();
                    pictureBox31.Image = l.ObtenerIMagen();

                }
                else if (l.GetUbicacion() == "Habitación de huéspedes")
                {

                    l.CrearIcono();
                    pictureBox32.Image = l.ObtenerIMagen();


                }
                else if (l.GetUbicacion() == "Patio")
                {

                    l.CrearIcono();
                    pictureBox34.Image = l.ObtenerIMagen();


                }
                else if (l.GetUbicacion() == "Sala")
                {

                    l.CrearIcono();
                    pictureBox36.Image = l.ObtenerIMagen();


                }
                else if (l.GetUbicacion() == "Comedor")
                {

                    l.CrearIcono();
                    pictureBox28.Image = l.ObtenerIMagen();


                }
                else
                {
                    MessageBox.Show("Lo siento ya no se pueden generar mas objetos consola", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (opcion == "Lampara")
            {
                l = new Electrodomesticos.Lampara(id, comboBox1.Text);

                if (l.GetUbicacion() == "Cocina")
                {
                    l.CrearIcono();
                    pictureBox19.Image = l.ObtenerIMagen();


                }
                else if (l.GetUbicacion() == "Habitación")
                {

                    l.CrearIcono();
                    pictureBox4.Image = l.ObtenerIMagen();


                }
                else if (l.GetUbicacion() == "Habitación de huéspedes")
                {

                    l.CrearIcono();
                    pictureBox3.Image = l.ObtenerIMagen();


                }
                else if (l.GetUbicacion() == "Patio")
                {

                    l.CrearIcono();
                    pictureBox24.Image = l.ObtenerIMagen();


                }
                else if (l.GetUbicacion() == "Sala")
                {

                    l.CrearIcono();
                    pictureBox26.Image = l.ObtenerIMagen();


                }
                else
                {
                    MessageBox.Show("Lo siento ya no se pueden generar mas objetos Foco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (opcion == "Laptop")
            {
                l = new Laptop(id, comboBox1.Text);

                l.CrearIcono();
                pictureBox13.Image = l.ObtenerIMagen();

            }
            else if (opcion == "Lavadora")
            {
                l = new Electrodomesticos.Lavadora(1200, id, comboBox1.Text);

                l.CrearIcono();
                pictureBox12.Image = l.ObtenerIMagen();

            }
            else if (opcion == "Licuadora")
            {
                l = new Licuadora(id);

                l.CrearIcono();
                pictureBox11.Image = l.ObtenerIMagen();

            }
            else if (opcion == "Microondas")
            {
                l = new Microondas(id);


                l.CrearIcono();
                pictureBox2.Image = l.ObtenerIMagen();




            }
            else if (opcion == "Plancha")
            {
                l = new Plancha(id, comboBox1.Text);


                l.CrearIcono();
                pictureBox10.Image = l.ObtenerIMagen();

            }
            else if (opcion == "Refrigerador")
            {
                l = new Electrodomesticos.Refrigerador(id, comboBox1.Text);

                l.CrearIcono();
                pictureBox9.Image = l.ObtenerIMagen();

            }
            else if (opcion == "Secadora")
            {
                l = new Secadora(id, comboBox1.Text);


                l.CrearIcono();
                pictureBox8.Image = l.ObtenerIMagen();

            }
            else if (opcion == "Teléfono")
            {
                l = new Electrodomesticos.Telefono(id, comboBox1.Text);
                if (l.GetUbicacion() == "Habitación de huéspedes")
                {
                    l.CrearIcono();
                    pictureBox7.Image = l.ObtenerIMagen();

                }
                else if (l.GetUbicacion() == "Habitación")
                {

                    l.CrearIcono();
                    pictureBox114.Image = l.ObtenerIMagen();


                }
                else if (l.GetUbicacion() == "Sala")
                {

                    l.CrearIcono();
                    pictureBox115.Image = l.ObtenerIMagen();

                }
            }
            else if (opcion == "Televisión")
            {
                l = new Electrodomesticos.Television(id, comboBox1.Text);


                if (l.GetUbicacion() == "Sala")
                {
                    l.CrearIcono();
                    pictureBox6.Image = l.ObtenerIMagen();

                }
                else if (l.GetUbicacion() == "Habitación")
                {

                    l.CrearIcono();
                    pictureBox111.Image = l.ObtenerIMagen();


                }
                else if (l.GetUbicacion() == "Habitación de huéspedes")
                {

                    l.CrearIcono();
                    pictureBox112.Image = l.ObtenerIMagen();


                }
                else if (l.GetUbicacion() == "Comedor")
                {

                    l.CrearIcono();
                    pictureBox113.Image = l.ObtenerIMagen();


                }
            }
            else if (opcion == "Tostador")
            {
                l = new Tostador(id);
                l.CrearIcono();
                pictureBox5.Image = l.ObtenerIMagen();

            }




            MessageBox.Show("Generaste un objeto tipo : " + opcion + "\n  Ubicación: " + comboBox1.Text);
            listaDeObjetos.Add(l);


        }


        //------------------------------------------------------------------------------------------------------
        //generando imagen

        private void button2_Click(object sender, EventArgs e)
        {

           Microondas l = new Microondas("hola");
            l.CrearIcono();

            //separar funciones de moverpicture para que no se genere el error 

            //pictureBox36.Image = l.ObtenerIMagen();  //checar
            // pictureBox29.Image = l.ObtenerIMagen(); 
            // pictureBox30.Image = l.ObtenerIMagen(); //checar
            //  pictureBox31.Image = l.ObtenerIMagen(); //**
            //pictureBox32.Image = l.ObtenerIMagen();**
            // pictureBox34.Image = l.ObtenerIMagen();
            //  pictureBox1.Image = l.ObtenerIMagen(); //solo se ve en panel
            //pictureBox2.Image = l.ObtenerIMagen(); // Ya no se ve Xc
            //pictureBox1.Refresh();
            pictureBox119.Image = l.ObtenerIMagen();
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
            if (pictureclick == true) moverpicture2(); //se debe de mover el picture

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
            if (pictureclick == true) moverpicture1(); //se debe de mover el picture
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
            if (pictureclick == true) moverpicture36(); //se debe de mover el picture
        }
        private void pictureBox36_DoubleClick(object sender, EventArgs e)
        {
            pictureBox36.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox36.Location.X;
            posActBotonY = pictureBox36.Location.Y;
        }
        private void pictureBox36_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
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
            if (pictureclick == true) moverpicture34(); //se debe de mover el picture
        }
        private void pictureBox34_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox34_DoubleClick(object sender, EventArgs e)
        {
            pictureBox34.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox34.Location.X;
            posActBotonY = pictureBox34.Location.Y;
        }

        private void pictureBox32_DoubleClick(object sender, EventArgs e)
        {
            pictureBox32.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox32.Location.X;
            posActBotonY = pictureBox32.Location.Y;
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
            if (pictureclick == true) moverpicture32(); //se debe de mover el picture
        }
        private void pictureBox32_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }

        private void pictureBox31_DoubleClick(object sender, EventArgs e)
        {
            pictureBox31.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox31.Location.X;
            posActBotonY = pictureBox31.Location.Y;
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
            if (pictureclick == true) moverpicture31(); //se debe de mover el picture
        }
        private void pictureBox31_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }

        private void pictureBox30_DoubleClick(object sender, EventArgs e)
        {
            pictureBox30.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox30.Location.X;
            posActBotonY = pictureBox30.Location.Y;
        }
        private void pictureBox30_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox30_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true; //cuando le da clic que sea cierto y se mueva respecto al mause
        }
        private void pictureBox30_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture30(); //se debe de mover el picture
        }
        private void pictureBox30_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }

        private void pictureBox29_DoubleClick(object sender, EventArgs e)
        {
            pictureBox29.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox29.Location.X;
            posActBotonY = pictureBox29.Location.Y;
        }
        private void pictureBox29_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox29_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox29_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true; //cuando le da clic que sea cierto y se mueva respecto al mause
        }
        private void pictureBox29_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture29(); //se debe de mover el picture
        }



        //-------------------------------------------------------------------------nuevos
        private void pictureBox7_DoubleClick(object sender, EventArgs e)
        {
            pictureBox7.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox7.Location.X;
            posActBotonY = pictureBox7.Location.Y;
        }
        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture7(); //se debe de mover el picture
        }
        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }

        private void pictureBox12_DoubleClick(object sender, EventArgs e)
        {
            pictureBox12.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox12.Location.X;
            posActBotonY = pictureBox12.Location.Y;
        }
        private void pictureBox12_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox12_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox12_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture12(); //se debe de mover el picture
        }
        private void pictureBox12_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }

        private void pictureBox8_DoubleClick(object sender, EventArgs e)
        {
            pictureBox8.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox8.Location.X;
            posActBotonY = pictureBox8.Location.Y;
        }
        private void pictureBox13_DoubleClick(object sender, EventArgs e)
        {
            pictureBox13.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox13.Location.X;
            posActBotonY = pictureBox13.Location.Y;
        }
        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            pictureBox4.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox4.Location.X;
            posActBotonY = pictureBox4.Location.Y;
        }
        private void pictureBox9_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox9.Location.X;
            posActBotonY = pictureBox9.Location.Y;
        }
        private void pictureBox14_DoubleClick(object sender, EventArgs e)
        {
            pictureBox14.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox14.Location.X;
            posActBotonY = pictureBox14.Location.Y;
        }
        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            pictureBox5.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox5.Location.X;
            posActBotonY = pictureBox5.Location.Y;
        }
        private void pictureBox10_DoubleClick(object sender, EventArgs e)
        {
            pictureBox10.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox10.Location.X;
            posActBotonY = pictureBox10.Location.Y;
        }
        private void pictureBox15_DoubleClick(object sender, EventArgs e)
        {
            pictureBox15.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox15.Location.X;
            posActBotonY = pictureBox15.Location.Y;
        }
        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        {
            pictureBox6.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox6.Location.X;
            posActBotonY = pictureBox6.Location.Y;
        }
        private void pictureBox11_DoubleClick(object sender, EventArgs e)
        {
            pictureBox11.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox11.Location.X;
            posActBotonY = pictureBox11.Location.Y;
        }
        private void pictureBox17_DoubleClick(object sender, EventArgs e)
        {
            pictureBox17.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox17.Location.X;
            posActBotonY = pictureBox17.Location.Y;
        }
        private void pictureBox18_DoubleClick(object sender, EventArgs e)
        {
            pictureBox18.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox18.Location.X;
            posActBotonY = pictureBox18.Location.Y;
        }
        private void pictureBox19_DoubleClick(object sender, EventArgs e)
        {
            pictureBox19.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox19.Location.X;
            posActBotonY = pictureBox19.Location.Y;
        }
        private void pictureBox28_DoubleClick(object sender, EventArgs e)
        {
            pictureBox28.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox28.Location.X;
            posActBotonY = pictureBox28.Location.Y;
        }
        private void pictureBox26_DoubleClick(object sender, EventArgs e)
        {
            pictureBox26.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox26.Location.X;
            posActBotonY = pictureBox26.Location.Y;
        }
        private void pictureBox24_DoubleClick(object sender, EventArgs e)
        {
            pictureBox24.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox24.Location.X;
            posActBotonY = pictureBox24.Location.Y;
        }
        private void pictureBox111_DoubleClick(object sender, EventArgs e)
        {
            pictureBox111.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox111.Location.X;
            posActBotonY = pictureBox111.Location.Y;
        }
        private void pictureBox112_DoubleClick(object sender, EventArgs e)
        {
            pictureBox112.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox112.Location.X;
            posActBotonY = pictureBox112.Location.Y;
        }
        private void pictureBox113_DoubleClick(object sender, EventArgs e)
        {
            pictureBox113.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox113.Location.X;
            posActBotonY = pictureBox113.Location.Y;
        }
        private void pictureBox114_DoubleClick(object sender, EventArgs e)
        {
            pictureBox114.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox114.Location.X;
            posActBotonY = pictureBox114.Location.Y;
        }
        private void pictureBox115_DoubleClick(object sender, EventArgs e)
        {
            pictureBox115.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox115.Location.X;
            posActBotonY = pictureBox115.Location.Y;
        }
        private void pictureBox116_DoubleClick(object sender, EventArgs e)
        {
            pictureBox116.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox116.Location.X;
            posActBotonY = pictureBox116.Location.Y;
        }
        private void pictureBox117_DoubleClick(object sender, EventArgs e)
        {
            pictureBox117.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox117.Location.X;
            posActBotonY = pictureBox117.Location.Y;
        }
        private void pictureBox118_DoubleClick(object sender, EventArgs e)
        {
            pictureBox118.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox118.Location.X;
            posActBotonY = pictureBox118.Location.Y;
        }
        private void pictureBox119_DoubleClick(object sender, EventArgs e)
        {
            pictureBox119.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox119.Location.X;
            posActBotonY = pictureBox119.Location.Y;
        }
        private void pictureBox16_DoubleClick(object sender, EventArgs e)
        {
            pictureBox16.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox16.Location.X;
            posActBotonY = pictureBox16.Location.Y;
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox13_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox14_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox10_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox15_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox11_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox16_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox17_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox18_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox19_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox28_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox26_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox24_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox111_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox112_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox113_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox114_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox115_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox116_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox117_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox118_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }
        private void pictureBox119_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox13_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox14_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox10_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox15_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox11_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox16_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox17_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox18_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox19_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox28_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox26_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox24_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox111_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox112_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox113_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox114_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox115_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox116_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox117_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox118_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }
        private void pictureBox119_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture8(); //se debe de mover el picture
        }
        private void pictureBox13_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture13(); //se debe de mover el picture
        }
        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture9(); //se debe de mover el picture
        }
        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture4(); //se debe de mover el picture
        }
        private void pictureBox14_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture14(); //se debe de mover el picture
        }
        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture5(); //se debe de mover el picture
        }
        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture10(); //se debe de mover el picture
        }
        private void pictureBox15_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture15(); //se debe de mover el picture
        }
        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture6(); //se debe de mover el picture
        }
        private void pictureBox11_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture11(); //se debe de mover el picture
        }
        private void pictureBox16_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture16(); //se debe de mover el picture
        }
        private void pictureBox17_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture17(); //se debe de mover el picture
        }
        private void pictureBox18_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture18(); //se debe de mover el picture
        }
        private void pictureBox19_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture19(); //se debe de mover el picture
        }
        private void pictureBox28_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture28(); //se debe de mover el picture
        }
        private void pictureBox26_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture26(); //se debe de mover el picture
        }
        private void pictureBox24_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture24(); //se debe de mover el picture
        }
        private void pictureBox111_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture111(); //se debe de mover el picture
        }
        private void pictureBox112_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture112(); //se debe de mover el picture
        }
        private void pictureBox113_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture113(); //se debe de mover el picture
        }
        private void pictureBox114_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture114(); //se debe de mover el picture
        }
        private void pictureBox115_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture115(); //se debe de mover el picture
        }
        private void pictureBox116_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture116(); //se debe de mover el picture
        }
        private void pictureBox117_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture117(); //se debe de mover el picture
        }
        private void pictureBox118_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture118(); //se debe de mover el picture
        }
        private void pictureBox119_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture119(); //se debe de mover el picture
        }

        private void pictureBox8_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox13_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox9_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox14_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox10_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox15_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox11_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox16_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox17_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox18_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox19_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox28_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox26_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox24_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox111_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox115_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox112_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox113_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox114_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox116_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox117_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox118_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        private void pictureBox119_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }
        //-------------------------------------------------------------------------------------------------------
        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            pictureBox3.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox3.Location.X;
            posActBotonY = pictureBox3.Location.Y;
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBox1.Text = "hola";
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            //posiciones de picture
            posMousePictureX = e.Location.X;
            posMousePictureY = e.Location.Y;
            pictureclick = true;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            //que se asignen las posiciones
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posMouseFormY + e.Location.Y;
            if (pictureclick == true) moverpicture3(); //se debe de mover el picture
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pictureclick = false; //si se suelta que sea falso que no se mueva 
        }



        //----------------------secundarios    ------------------ Mover picture    -------------------
        private void moverpicture1()
        {
            //box1
            pictureBox1.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox1.Location.X;
            posActBotonY = pictureBox1.Location.Y;
        }
        private void moverpicture2()
        {
            //box 2
            pictureBox2.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox2.Location.X;
            posActBotonY = pictureBox2.Location.Y;
        }
        private void moverpicture31()
        {
            //box 31
            pictureBox31.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox31.Location.X;
            posActBotonY = pictureBox31.Location.Y;
        }
        private void moverpicture36()
        {
            //box 36
            pictureBox36.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox36.Location.X;
            posActBotonY = pictureBox36.Location.Y;
        }
        private void moverpicture34()
        {
            //box34
            pictureBox34.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox34.Location.X;
            posActBotonY = pictureBox34.Location.Y;
        }
        private void moverpicture32()
        {

            //box 32
            pictureBox32.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox32.Location.X;
            posActBotonY = pictureBox32.Location.Y;

        }
        //nuevos---------------------------


        private void moverpicture30()
        {
            //box 30
            pictureBox30.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox30.Location.X;
            posActBotonY = pictureBox30.Location.Y;

        }
        private void moverpicture29()
        {

            //box29
            pictureBox29.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox29.Location.X;
            posActBotonY = pictureBox29.Location.Y;
        }
        private void moverpicture7()
        {

            //box7
            pictureBox7.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox7.Location.X;
            posActBotonY = pictureBox7.Location.Y;
        }
        private void moverpicture12()
        {

            //box12
            pictureBox12.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox12.Location.X;
            posActBotonY = pictureBox12.Location.Y;
        }
        private void moverpicture3()
        {

            //box3
            pictureBox3.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox3.Location.X;
            posActBotonY = pictureBox3.Location.Y;
        }
        private void moverpicture8()
        {

            //box8
            pictureBox8.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox8.Location.X;
            posActBotonY = pictureBox8.Location.Y;
        }
        private void moverpicture13()
        {

            //box13
            pictureBox13.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox13.Location.X;
            posActBotonY = pictureBox13.Location.Y;
        }
        private void moverpicture4()
        {

            //box4
            pictureBox4.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox4.Location.X;
            posActBotonY = pictureBox4.Location.Y;
        }
        private void moverpicture9()
        {

            //box9
            pictureBox9.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox9.Location.X;
            posActBotonY = pictureBox9.Location.Y;
        }
        private void moverpicture14()
        {

            //box14
            pictureBox14.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox14.Location.X;
            posActBotonY = pictureBox14.Location.Y;
        }
        private void moverpicture5()
        {

            //box5
            pictureBox5.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox5.Location.X;
            posActBotonY = pictureBox5.Location.Y;
        }
        private void moverpicture10()
        {

            //box10
            pictureBox10.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox10.Location.X;
            posActBotonY = pictureBox10.Location.Y;
        }
        private void moverpicture15()
        {

            //box15
            pictureBox15.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox15.Location.X;
            posActBotonY = pictureBox15.Location.Y;
        }
        private void moverpicture6()
        {

            //box6
            pictureBox6.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox6.Location.X;
            posActBotonY = pictureBox6.Location.Y;
        }
        private void moverpicture11()
        {

            //box11
            pictureBox11.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox11.Location.X;
            posActBotonY = pictureBox11.Location.Y;
        }
        private void moverpicture16()
        {

            //box16
            pictureBox16.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox16.Location.X;
            posActBotonY = pictureBox16.Location.Y;
        }
        private void moverpicture17()
        {

            //box17
            pictureBox17.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox17.Location.X;
            posActBotonY = pictureBox17.Location.Y;
        }
        private void moverpicture18()
        {

            //box18
            pictureBox18.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox18.Location.X;
            posActBotonY = pictureBox18.Location.Y;
        }
        private void moverpicture19()
        {

            //box19
            pictureBox19.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox19.Location.X;
            posActBotonY = pictureBox19.Location.Y;
        }
        private void moverpicture28()
        {

            //box28
            pictureBox28.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox28.Location.X;
            posActBotonY = pictureBox28.Location.Y;
        }
        private void moverpicture26()
        {

            //box26
            pictureBox26.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox26.Location.X;
            posActBotonY = pictureBox26.Location.Y;
        }
        private void moverpicture24()
        {

            //box24
            pictureBox24.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox24.Location.X;
            posActBotonY = pictureBox24.Location.Y;
        }
        private void moverpicture111()
        {

            //box111
            pictureBox111.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox111.Location.X;
            posActBotonY = pictureBox111.Location.Y;
        }
        private void moverpicture112()
        {

            //box112
            pictureBox112.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox112.Location.X;
            posActBotonY = pictureBox112.Location.Y;
        }
        private void moverpicture113()
        {

            //box113
            pictureBox113.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox113.Location.X;
            posActBotonY = pictureBox113.Location.Y;
        }
        private void moverpicture114()
        {

            //box114
            pictureBox114.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox114.Location.X;
            posActBotonY = pictureBox114.Location.Y;
        }
        private void moverpicture115()
        {

            //box115
            pictureBox115.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox115.Location.X;
            posActBotonY = pictureBox115.Location.Y;
        }
        private void moverpicture116()
        {

            //box116
            pictureBox116.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox116.Location.X;
            posActBotonY = pictureBox116.Location.Y;
        }
        private void moverpicture117()
        {

            //box117
            pictureBox117.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox117.Location.X;
            posActBotonY = pictureBox117.Location.Y;
        }

        private void pictureBox36_DoubleClick_1(object sender, EventArgs e)
        {
            pictureBox36.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox36.Location.X;
            posActBotonY = pictureBox36.Location.Y;
        }

        private void pictureBox16_DoubleClick_1(object sender, EventArgs e)
        {
            pictureBox16.Image = null;

            //abrir formulario campura posiciones 
            posActBotonX = pictureBox16.Location.X;
            posActBotonY = pictureBox16.Location.Y;
        }

        private void moverpicture118()
        {

            //box118
            pictureBox118.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox118.Location.X;
            posActBotonY = pictureBox118.Location.Y;
        }
        private void moverpicture119()
        {

            //box119
            pictureBox119.Location = new System.Drawing.Point(posMouseFormX - posMousePictureX, posMouseFormY - posMousePictureY);
            posActBotonX = pictureBox119.Location.X;
            posActBotonY = pictureBox119.Location.Y;
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


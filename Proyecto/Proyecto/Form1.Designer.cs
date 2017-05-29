namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HuespedPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComedorPanel = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.HabitacionPanel = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.WcPanel = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.PatioPanel = new System.Windows.Forms.Panel();
            this.SalaPanel = new System.Windows.Forms.Panel();
            this.CocinaPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cocina",
            "Comedor",
            "Habitación",
            "Habitación de huéspedes",
            "Patio",
            "Sala",
            "WC"});
            this.comboBox1.Location = new System.Drawing.Point(16, 50);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione la habitación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HuespedPanel);
            this.groupBox1.Location = new System.Drawing.Point(16, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 171);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "H. Huéspedes";
            // 
            // HuespedPanel
            // 
            this.HuespedPanel.Location = new System.Drawing.Point(26, 37);
            this.HuespedPanel.Name = "HuespedPanel";
            this.HuespedPanel.Size = new System.Drawing.Size(321, 128);
            this.HuespedPanel.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(18, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 230);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cocina";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ComedorPanel);
            this.groupBox3.Location = new System.Drawing.Point(193, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 230);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comedor";
            // 
            // ComedorPanel
            // 
            this.ComedorPanel.Location = new System.Drawing.Point(0, 38);
            this.ComedorPanel.Name = "ComedorPanel";
            this.ComedorPanel.Size = new System.Drawing.Size(200, 186);
            this.ComedorPanel.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.HabitacionPanel);
            this.groupBox4.Location = new System.Drawing.Point(605, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(209, 153);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Habitación";
            // 
            // HabitacionPanel
            // 
            this.HabitacionPanel.Location = new System.Drawing.Point(9, 34);
            this.HabitacionPanel.Name = "HabitacionPanel";
            this.HabitacionPanel.Size = new System.Drawing.Size(200, 100);
            this.HabitacionPanel.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(399, 331);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 260);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sala";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.WcPanel);
            this.groupBox6.Location = new System.Drawing.Point(375, 151);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(224, 162);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "WC";
            // 
            // WcPanel
            // 
            this.WcPanel.Location = new System.Drawing.Point(18, 43);
            this.WcPanel.Name = "WcPanel";
            this.WcPanel.Size = new System.Drawing.Size(200, 100);
            this.WcPanel.TabIndex = 6;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.PatioPanel);
            this.groupBox7.Location = new System.Drawing.Point(614, 331);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 260);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Patio";
            // 
            // PatioPanel
            // 
            this.PatioPanel.Location = new System.Drawing.Point(0, 21);
            this.PatioPanel.Name = "PatioPanel";
            this.PatioPanel.Size = new System.Drawing.Size(200, 233);
            this.PatioPanel.TabIndex = 5;
            // 
            // SalaPanel
            // 
            this.SalaPanel.Location = new System.Drawing.Point(399, 352);
            this.SalaPanel.Name = "SalaPanel";
            this.SalaPanel.Size = new System.Drawing.Size(200, 233);
            this.SalaPanel.TabIndex = 6;
            // 
            // CocinaPanel
            // 
            this.CocinaPanel.Location = new System.Drawing.Point(16, 375);
            this.CocinaPanel.Name = "CocinaPanel";
            this.CocinaPanel.Size = new System.Drawing.Size(154, 186);
            this.CocinaPanel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1841, 903);
            this.Controls.Add(this.SalaPanel);
            this.Controls.Add(this.CocinaPanel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel HuespedPanel;
        private System.Windows.Forms.Panel ComedorPanel;
        private System.Windows.Forms.Panel HabitacionPanel;
        private System.Windows.Forms.Panel WcPanel;
        private System.Windows.Forms.Panel PatioPanel;
        private System.Windows.Forms.Panel SalaPanel;
        private System.Windows.Forms.Panel CocinaPanel;
    }
}


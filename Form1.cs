using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case_à_coucher_et_Buttons_radio
{
    public partial class Form1 : Form
    {
        const int height = 489;
        const int width = 800;

        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(Form1.width, Form1.height / 2);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);// As the document says the BackColor property does not support transparent colors
            // unless the SupportsTransparentBackColor value of System.Windows.Forms.ControlStyles is set to true. 
            // By default the SupportsTransparentBackColor value of a form is set to false. 
            // To enable set transparent color for a form, you can set the SupportsTransparentBackColor value to true by inheriting from standard form.



        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            this.Size = new System.Drawing.Size(width, height);
            else
                this.Size = new Size(Form1.width, Form1.height / 2);


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           // this.BackColor = Color.Green;
            this.BackColor = Color.FromArgb(50, 0, 255, 0);
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // this.BackColor = Color.Blue;
            this.BackColor = Color.FromArgb(50, 0, 0, 255);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           // this.BackColor = Color.White;
            this.BackColor = Color.FromArgb(255, 255, 255,255);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DyscordApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.button1.Click += new EventHandler(Button1__Click);
            this.checkBox1.Click += new EventHandler(CheckBox1__Click);
            this.checkBox2.Click += new EventHandler(CheckBox2__Click);
            this.checkBox3.Click += new EventHandler(CheckBox3__Click);
            this.checkBox4.Click += new EventHandler(CheckBox4__Click);
            this.checkBox5.Click += new EventHandler(CheckBox5__Click);
            this.checkBox6.Click += new EventHandler(CheckBox6__Click);
            this.checkBox7.Click += new EventHandler(CheckBox7__Click);
            this.checkBox8.Click += new EventHandler(CheckBox8__Click);
            this.checkBox9.Click += new EventHandler(CheckBox9__Click);


            if (this.checkBox1.Checked == true)
            {
                this.button1.Visible = true;
            }
        }

        private void CheckBox1__Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.button1.Visible = true;
            }
        }

        private void CheckBox2__Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.button1.Visible = true;
            }
        }

        private void CheckBox3__Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.button1.Visible = true;
            }
        }

        private void CheckBox4__Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.button1.Visible = true;
            }
        }

        private void CheckBox5__Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.button1.Visible = true;
            }
        }

        private void CheckBox6__Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.button1.Visible = true;
            }
        }

        private void CheckBox7__Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.button1.Visible = true;
            }
        }

        private void CheckBox8__Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void CheckBox9__Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.button1.Visible = true;
            }
        }

        private void Button1__Click(object sender, EventArgs e)
        {
            this.button1.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAY_lights
{
    public partial class Form1 : Form
    {
        int bedroom1_light = 0, bedroom2_light = 0, kitchen_light = 0, wc_light = 0, living_light = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bedroom1")
            {
                pictureBox1.Image = Properties.Resources.bedroom1_off;
                bedroom1_light = 0;
            }
            else if (comboBox1.Text == "Bedroom2")
            {
                pictureBox1.Image = Properties.Resources.bedroom2_off;
                bedroom2_light = 0;
            }
            else if (comboBox1.Text == "Kitchen")
            {
                pictureBox1.Image = Properties.Resources.kitchen_off;
                kitchen_light = 0;
            }
            else if (comboBox1.Text == "WC")
            {
                pictureBox1.Image = Properties.Resources.wc_off;
                wc_light = 0;
            }
            else if (comboBox1.Text == "Living Room")
            {
                pictureBox1.Image = Properties.Resources.living_room_off;
                living_light = 0;
            }
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bedroom1")
            {
                pictureBox1.Image = Properties.Resources.bedroom1;
                bedroom1_light = 1;
            }
            else if (comboBox1.Text == "Bedroom2")
            {
                pictureBox1.Image = Properties.Resources.bedroom2;
                bedroom2_light = 1;
            }
            else if (comboBox1.Text == "Kitchen")
            {
                pictureBox1.Image = Properties.Resources.kitchen;
                kitchen_light = 1;
            }
            else if (comboBox1.Text == "WC")
            {
                pictureBox1.Image = Properties.Resources.wc;
                wc_light = 1;
            }
            else if (comboBox1.Text == "Living Room")
            {
                pictureBox1.Image = Properties.Resources.living_room;
                living_light = 1;
            }
            button1.Enabled = false;
            button2.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (comboBox1.Text == "Bedroom1")
            { if (bedroom1_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.bedroom1;
                    button2.Enabled = true;
                }
            else if(bedroom1_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.bedroom1_off;
                    button1.Enabled = true;
                }
            }
            else if(comboBox1.Text == "Bedroom2")
            {
                if (bedroom2_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.bedroom2;
                    button2.Enabled = true;
                }
                else if (bedroom2_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.bedroom2_off;
                    button1.Enabled = true;
                }
            }
            else if (comboBox1.Text == "Kitchen")
            {
                if (kitchen_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.kitchen;
                    button2.Enabled = true;
                }
                else if (kitchen_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.kitchen_off;
                    button1.Enabled = true;
                }
            }
            else if (comboBox1.Text == "WC")
            {
                if (wc_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.wc;
                    button2.Enabled = true;
                }
                else if (wc_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.wc_off;
                    button1.Enabled = true;
                }
            }
            else if (comboBox1.Text == "Living Room")
            {
                if (living_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.living_room;
                    button2.Enabled = true;
                }
                else if (living_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.living_room_off;
                    button1.Enabled = true;
                }
            }
        }
    }
}

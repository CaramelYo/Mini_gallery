using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mini_gallery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            r = new Random();

            pbs = new List<PictureBox>();

            foreach (Control c in Controls)
                if (c.GetType() == typeof(PictureBox))
                    pbs.Add((PictureBox)c);

            img_dir = "imgs/";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            image_list.Images.Clear();

            foreach (PictureBox pb in pbs)
                pb.Image = null;

            foreach (Control c in Controls)
                if (c.GetType() == typeof(TextBox))
                    c.Text = "";
        }

        private void load_image(string name)
        {
            // check the number of img
            if (image_list.Images.Count > 3)
            {
                log_textbox.Text += "out of gallery slots(max: 4 slots)\r\n";
                MessageBox.Show("out of gallery slots(max: 4 slots)");
                return;
            }

            Image img = null;

            try
            {
                img = Image.FromFile(img_dir + name + ".jpg");
            }
            catch (FileNotFoundException e)
            {
                //log_textbox.Text += e.ToString() + "\n";
                log_textbox.Text += "no image with the name: " + name + ".jpg\r\n";
                MessageBox.Show("no image with the name: " + name + ".jpg");
                return;
            }

            image_list.Images.Add(img);

            log_textbox.Text += name + ".jpg has been added\r\n";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            load_image(image_name_textbox.Text);
        }

        private void random_btn_Click(object sender, EventArgs e)
        {
            image_list.Images.Clear();

            img_names = new List<string>() { "boat", "bridge", "church", "duck", "grassland", "road" };

            for (int i = 0; i < 4; ++i)
            {
                int idx = r.Next(0, img_names.Count);
                load_image(img_names[idx]);
                img_names.RemoveAt(idx);
            }
        }

        private void generate_btn_Click(object sender, EventArgs e)
        {
            if (image_list.Images.Count != 4)
            {
                log_textbox.Text += "please select exactly 4 images\r\n";
                MessageBox.Show("please select exactly 4 images");
                return;
            }

            for (int i = 0; i < 4; ++i)
                pbs[i].Image = image_list.Images[i];
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            Form1_Load(this, e);
        }

        Random r;
        List<PictureBox> pbs;
        List<string> img_names;
        
        string img_dir;
    }
}

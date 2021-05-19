using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SweetTea
{
    public partial class SweetTea : Form
    {

        bool mouseDown;
        private Point offset;
        public SweetTea()
        {
            InitializeComponent();
        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void SweetTea_Load(object sender, EventArgs e)
        {
            // Populate Comboboxes
            MarketCB.Items.Add("PJM");
            MarketCB.Items.Add("MISO");
            MarketCB.Items.Add("SPP");
            PartCB.Items.Add(new KeyValuePair<string, string>("AMP", "0"));
            PartCB.Items.Add(new KeyValuePair<string, string>("AMP_KMPA", "1"));
            PartCB.Items.Add(new KeyValuePair<string, string>("AMP_SMIT", "2"));
            PartCB.Items.Add(new KeyValuePair<string, string>("CMWL", "3"));
            PartCB.Items.Add(new KeyValuePair<string, string>("CWAY", "4"));
            PartCB.Items.Add(new KeyValuePair<string, string>("CWLP", "5"));
            PartCB.Items.Add(new KeyValuePair<string, string>("FULT_L", "6"));
            PartCB.Items.Add(new KeyValuePair<string, string>("LAFA", "7"));
            PartCB.Items.Add(new KeyValuePair<string, string>("LEPA", "8"));
            PartCB.Items.Add(new KeyValuePair<string, string>("MU", "9"));
            PartCB.Items.Add(new KeyValuePair<string, string>("RPU", "10"));
            PartCB.Items.Add(new KeyValuePair<string, string>("SMPM", "11"));
            PartCB.Items.Add(new KeyValuePair<string, string>("NPPM", "12"));
            PartCB.Items.Add(new KeyValuePair<string, string>("SPRM", "13"));
            PartCB.Items.Add(new KeyValuePair<string, string>("TEAO_X", "14"));

            MarketCB.DisplayMember = "key";
            MarketCB.ValueMember = "value";
            PartCB.DisplayMember = "key1";
            PartCB.ValueMember = "key2";

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void MarketCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MarketCB.Items.Equals("PJM"));
            {
                MessageBox.Show("works???");
            }

        }

  
}
}

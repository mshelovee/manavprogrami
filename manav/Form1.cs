using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manav
{
    public partial class formManav : Form
    {
        public formManav()
        {
            InitializeComponent();
        }

        private void lboxMeyveler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lboxMeyveler.Items.Add(txtEkle.Text);
        }

        private void btnBosalt_Click(object sender, EventArgs e)
        {
            lboxMeyveler.Items.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lboxMeyveler.Items.Remove(lboxMeyveler.SelectedItem);
        }
    }
}

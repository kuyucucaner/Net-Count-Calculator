using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCount_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double turkceDogru, turkceYanlis, turkceNet;
            double matDogru, matYanlis, matNet;
            double fizDogru, fizYanlis, fizNet;

            turkceDogru = Convert.ToDouble(txtTurkceDogru.Text);
            turkceYanlis = Convert.ToDouble(txtTurkceYanlis.Text);

            matDogru = Convert.ToDouble(txtMatDogru.Text);
            matYanlis = Convert.ToDouble(txtMatYanlis.Text);

            fizDogru = Convert.ToDouble(txtFizDogru.Text);
            fizYanlis = Convert.ToDouble(txtFizYanlis.Text);

            turkceNet = turkceDogru - (turkceYanlis / 4);
            matNet = matDogru - (matYanlis / 4);
            fizNet = fizDogru - (fizYanlis / 4);

            txtTurkceNet.Text = turkceNet.ToString();
            txtMatNet.Text = matNet.ToString();
            txtFizNet.Text = fizNet.ToString();

        }
    }
}

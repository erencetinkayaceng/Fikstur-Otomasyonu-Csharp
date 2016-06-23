using HakemOtomasyonTD.Configure;
using HakemOtomasyonTD.Log;
using HakemOtomasyonTD.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HakemOtomasyonTD
{
    public partial class AnaForm : Form
    {
        ComponentConfiguration config;

        public AnaForm()
        {
            InitializeComponent();            
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            config = ComponentConfiguration.configureGetir();
            foreach (Control nesne in this.Controls)
            {
                if ((nesne) is Button)
                {
                    nesne.Font = config.getButonFont;
                }
            }
        }

        private void btnTakim_Click(object sender, EventArgs e)
        {
            TakimForm tk = new TakimForm();
            tk.Show();            
        }

        private void btnSalon_Click(object sender, EventArgs e)
        {
            SalonForm sl = new SalonForm();
            sl.Show();            
        }

        private void btnHakem_Click(object sender, EventArgs e)
        {
            HakemForm hk = new HakemForm();
            hk.Show();
        }        

        private void btnFikstur_Click(object sender, EventArgs e)
        {
            FiksturForm fk = new FiksturForm();
            fk.Show();
        }
    }
}

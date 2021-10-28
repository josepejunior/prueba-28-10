using AppCore.Interfaces;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class FrmGestionActivo : Form
    {
        private IActivoService service;
        public FrmGestionActivo(IActivoService service)
        {
            this.service = service;
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void FrmGestionActivo_Load(object sender, EventArgs e)
        {
            cmbTipoActivo.Items.AddRange(Enum.GetValues(typeof(TipoActivoFijo))
            .Cast<object>()
            .ToArray());
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmActivo frmActivo = new FrmActivo();
            frmActivo.aModel = service;
            frmActivo.ShowDialog();

            rtbProductView.Text = service.GetActivosAsJson();
        }
    }
}

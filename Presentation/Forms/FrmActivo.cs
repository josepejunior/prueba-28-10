using AppCore.Interfaces;
using Domain.Activo_Fijo;
using Domain.Enums;
using Infraestrecture.Activo;
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
    public partial class FrmActivo : Form
    {
        public IActivoService aModel { get; set; }
        public FrmActivo()
        {
            InitializeComponent();
        }
        private void FrmActivo_Load(object sender, EventArgs e)
        {
            cmbTipoActivo.Items.AddRange(Enum.GetValues(typeof(TipoActivoFijo))
                      .Cast<object>()
                      .ToArray());
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ActivoFijo a = new ActivoFijo()
            {
                Id = aModel.GetLastActivoId() + 1,
                NombreActivo = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                ValorActivo = (int)nudValor.Value,
                FechaAdquisicion = dtpFechaAdquisicion.Value,
                TipoActivoFijo = (TipoActivoFijo)cmbTipoActivo.SelectedIndex
            };

            aModel.Add(a);

            Dispose();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

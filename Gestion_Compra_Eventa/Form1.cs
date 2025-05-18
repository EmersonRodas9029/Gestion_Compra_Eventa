using System;
using System.Windows.Forms;

namespace Gestion_Compra_Eventa
{
	public partial class FormMenuPrincipal : Form
	{
		public FormMenuPrincipal()
		{
			InitializeComponent();
		}

		private void AbrirFormulario(Form formulario)
		{
			formulario.ShowDialog();
		}

		private void btnCompraVacunas_Click(object sender, EventArgs e)
		{
			AbrirFormulario(new FormCompraVacunas());
		}

		private void btnCompraConcentrado_Click(object sender, EventArgs e)
		{
			AbrirFormulario(new FormCompraConcentrado());
		}

		private void btnCompraVitaminas_Click(object sender, EventArgs e)
		{
			AbrirFormulario(new FormCompraVitaminas());
		}

		private void btnCompraHuevos_Click(object sender, EventArgs e)
		{
			AbrirFormulario(new FormCompraHuevos());
		}

		private void btnVentaHuevos_Click(object sender, EventArgs e)
		{
			AbrirFormulario(new FormVentaHuevos());
		}

		private void btnVentaGallinas_Click(object sender, EventArgs e)
		{
			AbrirFormulario(new FormVentaGallinas());
		}

		private void btnCompraOtros_Click(object sender, EventArgs e)
		{
			AbrirFormulario(new FormCompraOtros());
		}
	}
}

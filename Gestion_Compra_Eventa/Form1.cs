using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Compra_Eventa
{
	public partial class FormMenuPrincipal : Form
	{
		public FormMenuPrincipal()
		{
			InitializeComponent();
		}

		private void btnCompraVacunas_Click(object sender, EventArgs e)
		{
			FormCompraVacunas formCompraVacunas = new FormCompraVacunas();
			formCompraVacunas.ShowDialog();
		}

		private void btnCompraConcentrado_Click(object sender, EventArgs e)
		{
			FormCompraConcentrado formCompraConcentrado = new FormCompraConcentrado();
			formCompraConcentrado.ShowDialog();
		}

		private void btnCompraVitaminas_Click(object sender, EventArgs e)
		{
			FormCompraVitaminas formCompraVitaminas = new FormCompraVitaminas();
			formCompraVitaminas.ShowDialog();
		}

		private void btnCompraHuevos_Click_1(object sender, EventArgs e)
		{
			FormCompraHuevos formCompraHuevos = new FormCompraHuevos();
			formCompraHuevos.ShowDialog();
		}

		private void btnVentaHuevos_Click(object sender, EventArgs e)
		{
			FormVentaHuevos formVentaHuevos = new FormVentaHuevos();
			formVentaHuevos.ShowDialog();
		}

		private void btnVentaGallinas_Click(object sender, EventArgs e)
		{
			FormVentaGallinas formVentaGallinas = new FormVentaGallinas();
			formVentaGallinas.ShowDialog();
		}

		private void btnOtros_Click(object sender, EventArgs e)
		{
			FormCompraOtros formCompraOtros = new FormCompraOtros();
			formCompraOtros.ShowDialog();
		}
	}
}

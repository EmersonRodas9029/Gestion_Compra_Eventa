using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Compra_Eventa
{
	partial class FormMenuPrincipal
	{
		private System.ComponentModel.IContainer components = null;
		private GroupBox groupBoxCompras;
		private GroupBox groupBoxVentas;
		private Button btnCompraConcentrado;
		private Button btnCompraVacunas;
		private Button btnCompraHuevos;
		private Button btnVentaHuevos;
		private Button btnVentaGallinas;
		private Button btnCompraVitaminas;
		private Button btnOtros;

		private void InitializeComponent()
		{
			groupBoxCompras = new GroupBox();
			btnCompraVitaminas = new Button();
			btnCompraConcentrado = new Button();
			btnCompraVacunas = new Button();
			btnCompraHuevos = new Button();
			groupBoxVentas = new GroupBox();
			btnOtros = new Button();
			btnVentaHuevos = new Button();
			btnVentaGallinas = new Button();
			groupBoxCompras.SuspendLayout();
			groupBoxVentas.SuspendLayout();
			SuspendLayout();

			// groupBoxCompras
			groupBoxCompras.AutoSize = true;
			groupBoxCompras.BackColor = Color.FromArgb(185, 178, 154);
			groupBoxCompras.Controls.Add(btnCompraVitaminas);
			groupBoxCompras.Controls.Add(btnCompraConcentrado);
			groupBoxCompras.Controls.Add(btnCompraVacunas);
			groupBoxCompras.Controls.Add(btnCompraHuevos);
			groupBoxCompras.Location = new Point(59, 32);
			groupBoxCompras.Name = "groupBoxCompras";
			groupBoxCompras.Size = new Size(291, 270);
			groupBoxCompras.TabIndex = 0;
			groupBoxCompras.TabStop = false;
			groupBoxCompras.Text = "Compras";

			// btnCompraVitaminas
			btnCompraVitaminas.BackColor = Color.FromArgb(128, 0, 32);
			btnCompraVitaminas.ForeColor = Color.FromArgb(192, 255, 192);
			btnCompraVitaminas.Location = new Point(20, 130);
			btnCompraVitaminas.Name = "btnCompraVitaminas";
			btnCompraVitaminas.Size = new Size(250, 40);
			btnCompraVitaminas.TabIndex = 3;
			btnCompraVitaminas.Text = "Compra de Vitaminas";
			btnCompraVitaminas.UseVisualStyleBackColor = false;
			btnCompraVitaminas.Click += btnCompraVitaminas_Click;

			// btnCompraConcentrado
			btnCompraConcentrado.BackColor = Color.FromArgb(128, 0, 32);
			btnCompraConcentrado.ForeColor = Color.FromArgb(192, 255, 192);
			btnCompraConcentrado.Location = new Point(20, 26);
			btnCompraConcentrado.Name = "btnCompraConcentrado";
			btnCompraConcentrado.Size = new Size(250, 40);
			btnCompraConcentrado.TabIndex = 0;
			btnCompraConcentrado.Text = "Compra de Concentrado";
			btnCompraConcentrado.UseVisualStyleBackColor = false;
			btnCompraConcentrado.Click += btnCompraConcentrado_Click;

			// btnCompraVacunas
			btnCompraVacunas.BackColor = Color.FromArgb(128, 0, 32);
			btnCompraVacunas.ForeColor = Color.FromArgb(192, 255, 192);
			btnCompraVacunas.Location = new Point(20, 80);
			btnCompraVacunas.Name = "btnCompraVacunas";
			btnCompraVacunas.Size = new Size(250, 40);
			btnCompraVacunas.TabIndex = 1;
			btnCompraVacunas.Text = "Compra de Vacunas";
			btnCompraVacunas.UseVisualStyleBackColor = false;
			btnCompraVacunas.Click += btnCompraVacunas_Click;

			// btnCompraHuevos
			btnCompraHuevos.BackColor = Color.FromArgb(128, 0, 32);
			btnCompraHuevos.ForeColor = Color.FromArgb(192, 255, 192);
			btnCompraHuevos.Location = new Point(20, 176);
			btnCompraHuevos.Name = "btnCompraHuevos";
			btnCompraHuevos.Size = new Size(250, 40);
			btnCompraHuevos.TabIndex = 2;
			btnCompraHuevos.Text = "Compra de Huevos";
			btnCompraHuevos.UseVisualStyleBackColor = false;
			btnCompraHuevos.Click += btnCompraHuevos_Click_1;

			// groupBoxVentas
			groupBoxVentas.BackColor = Color.FromArgb(185, 178, 154);
			groupBoxVentas.Controls.Add(btnOtros);
			groupBoxVentas.Controls.Add(btnVentaHuevos);
			groupBoxVentas.Controls.Add(btnVentaGallinas);
			groupBoxVentas.Location = new Point(402, 32);
			groupBoxVentas.Name = "groupBoxVentas";
			groupBoxVentas.Size = new Size(300, 270);
			groupBoxVentas.TabIndex = 1;
			groupBoxVentas.TabStop = false;
			groupBoxVentas.Text = "Ventas";

			// btnOtros
			btnOtros.BackColor = Color.FromArgb(128, 0, 32);
			btnOtros.ForeColor = Color.FromArgb(192, 255, 192);
			btnOtros.Location = new Point(20, 176);
			btnOtros.Name = "btnOtros";
			btnOtros.Size = new Size(250, 40);
			btnOtros.TabIndex = 2;
			btnOtros.Text = "Otros";
			btnOtros.UseVisualStyleBackColor = false;
			btnOtros.Click += btnOtros_Click;

			// btnVentaHuevos
			btnVentaHuevos.BackColor = Color.FromArgb(128, 0, 32);
			btnVentaHuevos.ForeColor = Color.FromArgb(192, 255, 192);
			btnVentaHuevos.Location = new Point(20, 30);
			btnVentaHuevos.Name = "btnVentaHuevos";
			btnVentaHuevos.Size = new Size(250, 40);
			btnVentaHuevos.TabIndex = 0;
			btnVentaHuevos.Text = "Venta de Huevos";
			btnVentaHuevos.UseVisualStyleBackColor = false;
			btnVentaHuevos.Click += btnVentaHuevos_Click;

			// btnVentaGallinas
			btnVentaGallinas.BackColor = Color.FromArgb(128, 0, 32);
			btnVentaGallinas.ForeColor = Color.FromArgb(192, 255, 192);
			btnVentaGallinas.Location = new Point(20, 106);
			btnVentaGallinas.Name = "btnVentaGallinas";
			btnVentaGallinas.Size = new Size(250, 40);
			btnVentaGallinas.TabIndex = 1;
			btnVentaGallinas.Text = "Venta de Gallinas";
			btnVentaGallinas.UseVisualStyleBackColor = false;
			btnVentaGallinas.Click += btnVentaGallinas_Click;

			// FormMenuPrincipal
			BackColor = Color.FromArgb(216, 208, 200);
			ClientSize = new Size(800, 451);
			Controls.Add(groupBoxCompras);
			Controls.Add(groupBoxVentas);
			Name = "FormMenuPrincipal";
			Text = "Gestión de Compras y Ventas - Granja";
			groupBoxCompras.ResumeLayout(false);
			groupBoxVentas.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}
	}
}

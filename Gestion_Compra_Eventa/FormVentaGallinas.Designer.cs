using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gestion_Compra_Eventa
{
	partial class FormVentaGallinas
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			listBoxGallinas = new ListBox();
			txtCantidad = new TextBox();
			txtPrecioUnidad = new TextBox();
			txtTotal = new TextBox();
			btnCalcularTotal = new Button();
			btnConfirmarVenta = new Button();
			btnSumaTotal = new Button();
			btnEliminarDatos = new Button();
			dgvVentas = new DataGridView();
			colTamaño = new DataGridViewTextBoxColumn();
			colCantidad = new DataGridViewTextBoxColumn();
			colPrecioUnidad = new DataGridViewTextBoxColumn();
			colTotal = new DataGridViewTextBoxColumn();
			txtSumaTotal = new TextBox();
			lblSumaTotal = new Label();
			groupBoxGallinas = new GroupBox();
			groupBoxVenta = new GroupBox();
			lblCantidad = new Label();
			lblPrecioUnidad = new Label();
			lblTotal = new Label();
			groupBoxDatosVentas = new GroupBox();
			((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
			groupBoxGallinas.SuspendLayout();
			groupBoxVenta.SuspendLayout();
			groupBoxDatosVentas.SuspendLayout();
			SuspendLayout();
			// 
			// listBoxGallinas
			// 
			listBoxGallinas.BackColor = Color.White;
			listBoxGallinas.ForeColor = Color.Black;
			listBoxGallinas.FormattingEnabled = true;
			listBoxGallinas.Items.AddRange(new object[] { "Normal", "Aliñada" });
			listBoxGallinas.Location = new Point(18, 40);
			listBoxGallinas.Name = "listBoxGallinas";
			listBoxGallinas.Size = new Size(143, 84);
			listBoxGallinas.TabIndex = 0;
			// 
			// txtCantidad
			// 
			txtCantidad.BackColor = Color.White;
			txtCantidad.BorderStyle = BorderStyle.FixedSingle;
			txtCantidad.ForeColor = Color.Black;
			txtCantidad.Location = new Point(134, 26);
			txtCantidad.Name = "txtCantidad";
			txtCantidad.Size = new Size(89, 27);
			txtCantidad.TabIndex = 3;
			// 
			// txtPrecioUnidad
			// 
			txtPrecioUnidad.BackColor = Color.White;
			txtPrecioUnidad.BorderStyle = BorderStyle.FixedSingle;
			txtPrecioUnidad.ForeColor = Color.Black;
			txtPrecioUnidad.Location = new Point(134, 66);
			txtPrecioUnidad.Name = "txtPrecioUnidad";
			txtPrecioUnidad.Size = new Size(89, 27);
			txtPrecioUnidad.TabIndex = 4;
			// 
			// txtTotal
			// 
			txtTotal.BackColor = Color.White;
			txtTotal.BorderStyle = BorderStyle.FixedSingle;
			txtTotal.ForeColor = Color.Black;
			txtTotal.Location = new Point(134, 106);
			txtTotal.Name = "txtTotal";
			txtTotal.Size = new Size(89, 27);
			txtTotal.TabIndex = 5;
			// 
			// btnCalcularTotal
			// 
			btnCalcularTotal.BackColor = Color.FromArgb(128, 0, 32);
			btnCalcularTotal.ForeColor = Color.White;
			btnCalcularTotal.Location = new Point(18, 160);
			btnCalcularTotal.Name = "btnCalcularTotal";
			btnCalcularTotal.Size = new Size(89, 42);
			btnCalcularTotal.TabIndex = 6;
			btnCalcularTotal.Text = "Calcular Total";
			btnCalcularTotal.UseVisualStyleBackColor = false;
			btnCalcularTotal.Click += btnCalcularTotal_Click_1;
			// 
			// btnConfirmarVenta
			// 
			btnConfirmarVenta.BackColor = Color.FromArgb(128, 0, 32);
			btnConfirmarVenta.ForeColor = Color.White;
			btnConfirmarVenta.Location = new Point(116, 160);
			btnConfirmarVenta.Name = "btnConfirmarVenta";
			btnConfirmarVenta.Size = new Size(107, 42);
			btnConfirmarVenta.TabIndex = 7;
			btnConfirmarVenta.Text = "Confirmar Venta";
			btnConfirmarVenta.UseVisualStyleBackColor = false;
			btnConfirmarVenta.Click += btnConfirmarVenta_Click_1;
			// 
			// btnSumaTotal
			// 
			btnSumaTotal.BackColor = Color.FromArgb(128, 0, 32);
			btnSumaTotal.ForeColor = Color.White;
			btnSumaTotal.Location = new Point(222, 270);
			btnSumaTotal.Name = "btnSumaTotal";
			btnSumaTotal.Size = new Size(160, 39);
			btnSumaTotal.TabIndex = 11;
			btnSumaTotal.Text = "Calcular Suma Total";
			btnSumaTotal.UseVisualStyleBackColor = false;
			// 
			// btnEliminarDatos
			// 
			btnEliminarDatos.BackColor = Color.FromArgb(128, 0, 32);
			btnEliminarDatos.ForeColor = Color.White;
			btnEliminarDatos.Location = new Point(25, 267);
			btnEliminarDatos.Name = "btnEliminarDatos";
			btnEliminarDatos.Size = new Size(160, 42);
			btnEliminarDatos.TabIndex = 12;
			btnEliminarDatos.Text = "Eliminar Datos";
			btnEliminarDatos.UseVisualStyleBackColor = false;
			// 
			// dgvVentas
			// 
			dgvVentas.BackgroundColor = Color.Silver;
			dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colTamaño, colCantidad, colPrecioUnidad, colTotal });
			dgvVentas.Location = new Point(1, 40);
			dgvVentas.Name = "dgvVentas";
			dgvVentas.RowHeadersWidth = 51;
			dgvVentas.Size = new Size(627, 200);
			dgvVentas.TabIndex = 8;
			// 
			// colTamaño
			// 
			colTamaño.HeaderText = "Tamaño";
			colTamaño.MinimumWidth = 6;
			colTamaño.Name = "colTamaño";
			colTamaño.Width = 125;
			// 
			// colCantidad
			// 
			colCantidad.HeaderText = "Cantidad";
			colCantidad.MinimumWidth = 6;
			colCantidad.Name = "colCantidad";
			colCantidad.Width = 125;
			// 
			// colPrecioUnidad
			// 
			colPrecioUnidad.HeaderText = "Precio Unidad";
			colPrecioUnidad.MinimumWidth = 6;
			colPrecioUnidad.Name = "colPrecioUnidad";
			colPrecioUnidad.Width = 125;
			// 
			// colTotal
			// 
			colTotal.HeaderText = "Total";
			colTotal.MinimumWidth = 6;
			colTotal.Name = "colTotal";
			colTotal.Width = 125;
			// 
			// txtSumaTotal
			// 
			txtSumaTotal.BackColor = Color.White;
			txtSumaTotal.BorderStyle = BorderStyle.FixedSingle;
			txtSumaTotal.ForeColor = Color.Black;
			txtSumaTotal.Location = new Point(508, 320);
			txtSumaTotal.Name = "txtSumaTotal";
			txtSumaTotal.Size = new Size(89, 27);
			txtSumaTotal.TabIndex = 9;
			// 
			// lblSumaTotal
			// 
			lblSumaTotal.AutoSize = true;
			lblSumaTotal.ForeColor = Color.Black;
			lblSumaTotal.Location = new Point(511, 280);
			lblSumaTotal.Name = "lblSumaTotal";
			lblSumaTotal.Size = new Size(86, 20);
			lblSumaTotal.TabIndex = 10;
			lblSumaTotal.Text = "Suma Total:";
			// 
			// groupBoxGallinas
			// 
			groupBoxGallinas.BackColor = Color.FromArgb(185, 178, 154);
			groupBoxGallinas.Controls.Add(listBoxGallinas);
			groupBoxGallinas.ForeColor = Color.Black;
			groupBoxGallinas.Location = new Point(78, 34);
			groupBoxGallinas.Name = "groupBoxGallinas";
			groupBoxGallinas.Size = new Size(178, 160);
			groupBoxGallinas.TabIndex = 0;
			groupBoxGallinas.TabStop = false;
			groupBoxGallinas.Text = "Seleccione el tipo de gallina";
			// 
			// groupBoxVenta
			// 
			groupBoxVenta.BackColor = Color.FromArgb(185, 178, 154);
			groupBoxVenta.Controls.Add(lblCantidad);
			groupBoxVenta.Controls.Add(txtCantidad);
			groupBoxVenta.Controls.Add(lblPrecioUnidad);
			groupBoxVenta.Controls.Add(lblTotal);
			groupBoxVenta.Controls.Add(txtPrecioUnidad);
			groupBoxVenta.Controls.Add(txtTotal);
			groupBoxVenta.Controls.Add(btnCalcularTotal);
			groupBoxVenta.Controls.Add(btnConfirmarVenta);
			groupBoxVenta.ForeColor = Color.Black;
			groupBoxVenta.Location = new Point(5, 200);
			groupBoxVenta.Name = "groupBoxVenta";
			groupBoxVenta.Size = new Size(356, 225);
			groupBoxVenta.TabIndex = 2;
			groupBoxVenta.TabStop = false;
			groupBoxVenta.Text = "Datos de Venta";
			// 
			// lblCantidad
			// 
			lblCantidad.AutoSize = true;
			lblCantidad.Location = new Point(46, 33);
			lblCantidad.Name = "lblCantidad";
			lblCantidad.Size = new Size(72, 20);
			lblCantidad.TabIndex = 13;
			lblCantidad.Text = "Cantidad:";
			// 
			// lblPrecioUnidad
			// 
			lblPrecioUnidad.AutoSize = true;
			lblPrecioUnidad.Location = new Point(13, 73);
			lblPrecioUnidad.Name = "lblPrecioUnidad";
			lblPrecioUnidad.Size = new Size(105, 20);
			lblPrecioUnidad.TabIndex = 14;
			lblPrecioUnidad.Text = "Precio Unidad:";
			// 
			// lblTotal
			// 
			lblTotal.AutoSize = true;
			lblTotal.Location = new Point(73, 113);
			lblTotal.Name = "lblTotal";
			lblTotal.Size = new Size(45, 20);
			lblTotal.TabIndex = 15;
			lblTotal.Text = "Total:";
			lblTotal.Click += lblTotal_Click;
			// 
			// groupBoxDatosVentas
			// 
			groupBoxDatosVentas.BackColor = Color.FromArgb(185, 178, 154);
			groupBoxDatosVentas.Controls.Add(dgvVentas);
			groupBoxDatosVentas.Controls.Add(txtSumaTotal);
			groupBoxDatosVentas.Controls.Add(lblSumaTotal);
			groupBoxDatosVentas.Controls.Add(btnSumaTotal);
			groupBoxDatosVentas.Controls.Add(btnEliminarDatos);
			groupBoxDatosVentas.ForeColor = Color.Black;
			groupBoxDatosVentas.Location = new Point(375, 40);
			groupBoxDatosVentas.Name = "groupBoxDatosVentas";
			groupBoxDatosVentas.Size = new Size(644, 400);
			groupBoxDatosVentas.TabIndex = 3;
			groupBoxDatosVentas.TabStop = false;
			groupBoxDatosVentas.Text = "Datos de Ventas";
			// 
			// FormVentaGallinas
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(228, 216, 195);
			ClientSize = new Size(1031, 465);
			Controls.Add(groupBoxGallinas);
			Controls.Add(groupBoxVenta);
			Controls.Add(groupBoxDatosVentas);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormVentaGallinas";
			Text = "Venta de Gallinas";
			((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
			groupBoxGallinas.ResumeLayout(false);
			groupBoxVenta.ResumeLayout(false);
			groupBoxVenta.PerformLayout();
			groupBoxDatosVentas.ResumeLayout(false);
			groupBoxDatosVentas.PerformLayout();
			ResumeLayout(false);
		}

		private ListBox listBoxGallinas;
		private TextBox txtCantidad;
		private TextBox txtPrecioUnidad;
		private TextBox txtTotal;
		private Button btnCalcularTotal;
		private Button btnConfirmarVenta;
		private Button btnSumaTotal;
		private Button btnEliminarDatos;
		private DataGridView dgvVentas;
		private TextBox txtSumaTotal;
		private Label lblSumaTotal;
		private GroupBox groupBoxGallinas;
		private GroupBox groupBoxVenta;
		private GroupBox groupBoxDatosVentas;
		private DataGridViewTextBoxColumn colTamaño;
		private DataGridViewTextBoxColumn colCantidad;
		private DataGridViewTextBoxColumn colPrecioUnidad;
		private DataGridViewTextBoxColumn colTotal;
		private Label lblCantidad;
		private Label lblPrecioUnidad;
		private Label lblTotal;
	}
}

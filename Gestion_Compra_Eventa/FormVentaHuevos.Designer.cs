using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gestion_Compra_Eventa
{
	partial class FormVentaHuevos
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
			listBoxHuevos = new ListBox();
			radioCartones = new RadioButton();
			radioDolares = new RadioButton();
			txtCantidad = new TextBox();
			txtPrecioUnidad = new TextBox();
			txtTotal = new TextBox();
			btnCalcularTotal = new Button();
			btnConfirmarVenta = new Button();
			btnCalcularSumaTotal = new Button();
			btnEliminarDatos = new Button();
			dgvVentas = new DataGridView();
			colTamaño = new DataGridViewTextBoxColumn();
			colCantidad = new DataGridViewTextBoxColumn();
			colPrecioUnidad = new DataGridViewTextBoxColumn();
			colTotal = new DataGridViewTextBoxColumn();
			colUnidadVenta = new DataGridViewTextBoxColumn();
			txtSumaTotal = new TextBox();
			lblSumaTotal = new Label();
			groupBoxHuevos = new GroupBox();
			groupBoxPrecio = new GroupBox();
			groupBoxVenta = new GroupBox();
			lblCantidad = new Label();
			lblPrecioUnidad = new Label();
			lblTotal = new Label();
			groupBoxDatosVentas = new GroupBox();
			((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
			groupBoxHuevos.SuspendLayout();
			groupBoxPrecio.SuspendLayout();
			groupBoxVenta.SuspendLayout();
			groupBoxDatosVentas.SuspendLayout();
			SuspendLayout();
			// 
			// listBoxHuevos
			// 
			listBoxHuevos.BackColor = Color.White;
			listBoxHuevos.ForeColor = Color.Black;
			listBoxHuevos.FormattingEnabled = true;
			listBoxHuevos.Items.AddRange(new object[] { "Grande", "Mediano", "Pequeño" });
			listBoxHuevos.Location = new Point(18, 40);
			listBoxHuevos.Name = "listBoxHuevos";
			listBoxHuevos.Size = new Size(143, 84);
			listBoxHuevos.TabIndex = 0;
			// 
			// radioCartones
			// 
			radioCartones.AutoSize = true;
			radioCartones.ForeColor = Color.Black;
			radioCartones.Location = new Point(19, 70);
			radioCartones.Name = "radioCartones";
			radioCartones.Size = new Size(88, 24);
			radioCartones.TabIndex = 1;
			radioCartones.TabStop = true;
			radioCartones.Text = "Cartones";
			radioCartones.UseVisualStyleBackColor = true;
			// 
			// radioDolares
			// 
			radioDolares.AutoSize = true;
			radioDolares.ForeColor = Color.Black;
			radioDolares.Location = new Point(19, 100);
			radioDolares.Name = "radioDolares";
			radioDolares.Size = new Size(81, 24);
			radioDolares.TabIndex = 2;
			radioDolares.TabStop = true;
			radioDolares.Text = "Dólares";
			radioDolares.UseVisualStyleBackColor = true;
			// 
			// txtCantidad
			// 
			txtCantidad.BackColor = Color.White;
			txtCantidad.BorderStyle = BorderStyle.FixedSingle;
			txtCantidad.ForeColor = Color.Black;
			txtCantidad.Location = new Point(134, 30);
			txtCantidad.Name = "txtCantidad";
			txtCantidad.Size = new Size(89, 27);
			txtCantidad.TabIndex = 3;
			// 
			// txtPrecioUnidad
			// 
			txtPrecioUnidad.BackColor = Color.White;
			txtPrecioUnidad.BorderStyle = BorderStyle.FixedSingle;
			txtPrecioUnidad.ForeColor = Color.Black;
			txtPrecioUnidad.Location = new Point(134, 70);
			txtPrecioUnidad.Name = "txtPrecioUnidad";
			txtPrecioUnidad.Size = new Size(89, 27);
			txtPrecioUnidad.TabIndex = 4;
			// 
			// txtTotal
			// 
			txtTotal.BackColor = Color.White;
			txtTotal.BorderStyle = BorderStyle.FixedSingle;
			txtTotal.ForeColor = Color.Black;
			txtTotal.Location = new Point(134, 110);
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
			btnCalcularTotal.Size = new Size(89, 38);
			btnCalcularTotal.TabIndex = 6;
			btnCalcularTotal.Text = "Calcular Total";
			btnCalcularTotal.UseVisualStyleBackColor = false;
			// 
			// btnConfirmarVenta
			// 
			btnConfirmarVenta.BackColor = Color.FromArgb(128, 0, 32);
			btnConfirmarVenta.ForeColor = Color.White;
			btnConfirmarVenta.Location = new Point(116, 160);
			btnConfirmarVenta.Name = "btnConfirmarVenta";
			btnConfirmarVenta.Size = new Size(107, 38);
			btnConfirmarVenta.TabIndex = 7;
			btnConfirmarVenta.Text = "Confirmar Venta";
			btnConfirmarVenta.UseVisualStyleBackColor = false;
			// 
			// btnCalcularSumaTotal
			// 
			btnCalcularSumaTotal.BackColor = Color.FromArgb(128, 0, 32);
			btnCalcularSumaTotal.ForeColor = Color.White;
			btnCalcularSumaTotal.Location = new Point(222, 270);
			btnCalcularSumaTotal.Name = "btnCalcularSumaTotal";
			btnCalcularSumaTotal.Size = new Size(160, 43);
			btnCalcularSumaTotal.TabIndex = 11;
			btnCalcularSumaTotal.Text = "Calcular Suma Total";
			btnCalcularSumaTotal.UseVisualStyleBackColor = false;
			// 
			// btnEliminarDatos
			// 
			btnEliminarDatos.BackColor = Color.FromArgb(128, 0, 32);
			btnEliminarDatos.ForeColor = Color.White;
			btnEliminarDatos.Location = new Point(25, 267);
			btnEliminarDatos.Name = "btnEliminarDatos";
			btnEliminarDatos.Size = new Size(160, 46);
			btnEliminarDatos.TabIndex = 12;
			btnEliminarDatos.Text = "Eliminar Datos";
			btnEliminarDatos.UseVisualStyleBackColor = false;
			// 
			// dgvVentas
			// 
			dgvVentas.BackgroundColor = Color.Silver;
			dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colTamaño, colCantidad, colPrecioUnidad, colTotal, colUnidadVenta });
			dgvVentas.Location = new Point(1, 40);
			dgvVentas.Name = "dgvVentas";
			dgvVentas.RowHeadersWidth = 51;
			dgvVentas.Size = new Size(712, 200);
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
			// colUnidadVenta
			// 
			colUnidadVenta.HeaderText = "Unidad Venta";
			colUnidadVenta.MinimumWidth = 6;
			colUnidadVenta.Name = "colUnidadVenta";
			colUnidadVenta.Width = 125;
			// 
			// txtSumaTotal
			// 
			txtSumaTotal.BackColor = Color.White;
			txtSumaTotal.BorderStyle = BorderStyle.FixedSingle;
			txtSumaTotal.ForeColor = Color.Black;
			txtSumaTotal.Location = new Point(578, 278);
			txtSumaTotal.Name = "txtSumaTotal";
			txtSumaTotal.Size = new Size(89, 27);
			txtSumaTotal.TabIndex = 9;
			// 
			// lblSumaTotal
			// 
			lblSumaTotal.AutoSize = true;
			lblSumaTotal.ForeColor = Color.Black;
			lblSumaTotal.Location = new Point(469, 280);
			lblSumaTotal.Name = "lblSumaTotal";
			lblSumaTotal.Size = new Size(86, 20);
			lblSumaTotal.TabIndex = 10;
			lblSumaTotal.Text = "Suma Total:";
			// 
			// groupBoxHuevos
			// 
			groupBoxHuevos.BackColor = Color.FromArgb(185, 178, 154);
			groupBoxHuevos.Controls.Add(listBoxHuevos);
			groupBoxHuevos.ForeColor = Color.Black;
			groupBoxHuevos.Location = new Point(5, 40);
			groupBoxHuevos.Name = "groupBoxHuevos";
			groupBoxHuevos.Size = new Size(178, 160);
			groupBoxHuevos.TabIndex = 0;
			groupBoxHuevos.TabStop = false;
			groupBoxHuevos.Text = "Seleccione el tamaño de huevo";
			// 
			// groupBoxPrecio
			// 
			groupBoxPrecio.BackColor = Color.FromArgb(185, 178, 154);
			groupBoxPrecio.Controls.Add(radioCartones);
			groupBoxPrecio.Controls.Add(radioDolares);
			groupBoxPrecio.ForeColor = Color.Black;
			groupBoxPrecio.Location = new Point(191, 40);
			groupBoxPrecio.Name = "groupBoxPrecio";
			groupBoxPrecio.Size = new Size(178, 160);
			groupBoxPrecio.TabIndex = 1;
			groupBoxPrecio.TabStop = false;
			groupBoxPrecio.Text = "Seleccione el tipo de precio";
			// 
			// groupBoxVenta
			// 
			groupBoxVenta.BackColor = Color.FromArgb(185, 178, 154);
			groupBoxVenta.Controls.Add(lblCantidad);
			groupBoxVenta.Controls.Add(lblPrecioUnidad);
			groupBoxVenta.Controls.Add(lblTotal);
			groupBoxVenta.Controls.Add(txtCantidad);
			groupBoxVenta.Controls.Add(txtPrecioUnidad);
			groupBoxVenta.Controls.Add(txtTotal);
			groupBoxVenta.Controls.Add(btnCalcularTotal);
			groupBoxVenta.Controls.Add(btnConfirmarVenta);
			groupBoxVenta.ForeColor = Color.Black;
			groupBoxVenta.Location = new Point(5, 213);
			groupBoxVenta.Name = "groupBoxVenta";
			groupBoxVenta.Size = new Size(356, 240);
			groupBoxVenta.TabIndex = 2;
			groupBoxVenta.TabStop = false;
			groupBoxVenta.Text = "Datos de Venta";
			// 
			// lblCantidad
			// 
			lblCantidad.AutoSize = true;
			lblCantidad.Location = new Point(47, 32);
			lblCantidad.Name = "lblCantidad";
			lblCantidad.Size = new Size(72, 20);
			lblCantidad.TabIndex = 8;
			lblCantidad.Text = "Cantidad:";
			// 
			// lblPrecioUnidad
			// 
			lblPrecioUnidad.AutoSize = true;
			lblPrecioUnidad.Location = new Point(14, 72);
			lblPrecioUnidad.Name = "lblPrecioUnidad";
			lblPrecioUnidad.Size = new Size(105, 20);
			lblPrecioUnidad.TabIndex = 9;
			lblPrecioUnidad.Text = "Precio Unidad:";
			// 
			// lblTotal
			// 
			lblTotal.AutoSize = true;
			lblTotal.Location = new Point(74, 112);
			lblTotal.Name = "lblTotal";
			lblTotal.Size = new Size(45, 20);
			lblTotal.TabIndex = 10;
			lblTotal.Text = "Total:";
			// 
			// groupBoxDatosVentas
			// 
			groupBoxDatosVentas.BackColor = Color.FromArgb(185, 178, 154);
			groupBoxDatosVentas.Controls.Add(dgvVentas);
			groupBoxDatosVentas.Controls.Add(txtSumaTotal);
			groupBoxDatosVentas.Controls.Add(lblSumaTotal);
			groupBoxDatosVentas.Controls.Add(btnCalcularSumaTotal);
			groupBoxDatosVentas.Controls.Add(btnEliminarDatos);
			groupBoxDatosVentas.ForeColor = Color.Black;
			groupBoxDatosVentas.Location = new Point(375, 40);
			groupBoxDatosVentas.Name = "groupBoxDatosVentas";
			groupBoxDatosVentas.Size = new Size(744, 400);
			groupBoxDatosVentas.TabIndex = 3;
			groupBoxDatosVentas.TabStop = false;
			groupBoxDatosVentas.Text = "Datos de Ventas";
			// 
			// FormVentaHuevos
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(228, 216, 195);
			ClientSize = new Size(1131, 465);
			Controls.Add(groupBoxHuevos);
			Controls.Add(groupBoxPrecio);
			Controls.Add(groupBoxVenta);
			Controls.Add(groupBoxDatosVentas);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Name = "FormVentaHuevos";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Venta de Huevos";
			((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
			groupBoxHuevos.ResumeLayout(false);
			groupBoxPrecio.ResumeLayout(false);
			groupBoxPrecio.PerformLayout();
			groupBoxVenta.ResumeLayout(false);
			groupBoxVenta.PerformLayout();
			groupBoxDatosVentas.ResumeLayout(false);
			groupBoxDatosVentas.PerformLayout();
			ResumeLayout(false);
		}

		private ListBox listBoxHuevos;
		private RadioButton radioCartones;
		private RadioButton radioDolares;
		private TextBox txtCantidad;
		private TextBox txtPrecioUnidad;
		private TextBox txtTotal;
		private Button btnCalcularTotal;
		private Button btnConfirmarVenta;
		private Button btnCalcularSumaTotal;
		private Button btnEliminarDatos;
		private DataGridView dgvVentas;
		private DataGridViewTextBoxColumn colTamaño;
		private DataGridViewTextBoxColumn colCantidad;
		private DataGridViewTextBoxColumn colPrecioUnidad;
		private DataGridViewTextBoxColumn colTotal;
		private DataGridViewTextBoxColumn colUnidadVenta;
		private TextBox txtSumaTotal;
		private Label lblSumaTotal;
		private GroupBox groupBoxHuevos;
		private GroupBox groupBoxPrecio;
		private GroupBox groupBoxVenta;
		private GroupBox groupBoxDatosVentas;
		private Label lblCantidad;
		private Label lblPrecioUnidad;
		private Label lblTotal;
	}
}

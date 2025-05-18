namespace Gestion_Compra_Eventa

{
	partial class FormCompraHuevos
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
			groupBoxCompraHuevos = new GroupBox();
			lblSumaTotal = new Label();
			btnCalcularSumaTotal = new Button();
			txtSumaTotal = new TextBox();
			listBoxHuevos = new ListBox();
			txtCantidad = new TextBox();
			lblCantidad = new Label();
			btnEliminarDatos = new Button();
			txtPrecioUnidad = new TextBox();
			lblPrecioUnidad = new Label();
			txtTotal = new TextBox();
			lblTotal = new Label();
			btnCalcularTotal = new Button();
			btnConfirmarCompra = new Button();
			dgvCompras = new DataGridView();
			colProducto = new DataGridViewTextBoxColumn();
			colCantidad = new DataGridViewTextBoxColumn();
			colPrecioUnidad = new DataGridViewTextBoxColumn();
			colTotal = new DataGridViewTextBoxColumn();
			groupBoxCompraHuevos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
			SuspendLayout();
			// 
			// groupBoxCompraHuevos
			// 
			groupBoxCompraHuevos.BackColor = Color.FromArgb(185, 178, 154);
			groupBoxCompraHuevos.Controls.Add(lblSumaTotal);
			groupBoxCompraHuevos.Controls.Add(btnCalcularSumaTotal);
			groupBoxCompraHuevos.Controls.Add(txtSumaTotal);
			groupBoxCompraHuevos.Controls.Add(listBoxHuevos);
			groupBoxCompraHuevos.Controls.Add(txtCantidad);
			groupBoxCompraHuevos.Controls.Add(lblCantidad);
			groupBoxCompraHuevos.Controls.Add(btnEliminarDatos);
			groupBoxCompraHuevos.Controls.Add(txtPrecioUnidad);
			groupBoxCompraHuevos.Controls.Add(lblPrecioUnidad);
			groupBoxCompraHuevos.Controls.Add(txtTotal);
			groupBoxCompraHuevos.Controls.Add(lblTotal);
			groupBoxCompraHuevos.Controls.Add(btnCalcularTotal);
			groupBoxCompraHuevos.Controls.Add(btnConfirmarCompra);
			groupBoxCompraHuevos.Location = new Point(32, 39);
			groupBoxCompraHuevos.Margin = new Padding(3, 4, 3, 4);
			groupBoxCompraHuevos.Name = "groupBoxCompraHuevos";
			groupBoxCompraHuevos.Padding = new Padding(3, 4, 3, 4);
			groupBoxCompraHuevos.Size = new Size(681, 674);
			groupBoxCompraHuevos.TabIndex = 0;
			groupBoxCompraHuevos.TabStop = false;
			groupBoxCompraHuevos.Text = "Compra de Huevos";
			groupBoxCompraHuevos.Enter += groupBoxCompraHuevos_Enter;
			// 
			// lblSumaTotal
			// 
			lblSumaTotal.AutoSize = true;
			lblSumaTotal.Location = new Point(135, 598);
			lblSumaTotal.Name = "lblSumaTotal";
			lblSumaTotal.Size = new Size(102, 20);
			lblSumaTotal.TabIndex = 4;
			lblSumaTotal.Text = "Compra Total:";
			// 
			// btnCalcularSumaTotal
			// 
			btnCalcularSumaTotal.BackColor = Color.FromArgb(128, 0, 32);
			btnCalcularSumaTotal.ForeColor = Color.FromArgb(192, 255, 192);
			btnCalcularSumaTotal.Location = new Point(495, 310);
			btnCalcularSumaTotal.Margin = new Padding(3, 4, 3, 4);
			btnCalcularSumaTotal.Name = "btnCalcularSumaTotal";
			btnCalcularSumaTotal.Size = new Size(150, 40);
			btnCalcularSumaTotal.TabIndex = 5;
			btnCalcularSumaTotal.Text = "Suma Total";
			btnCalcularSumaTotal.UseVisualStyleBackColor = false;
			// 
			// txtSumaTotal
			// 
			txtSumaTotal.Location = new Point(243, 595);
			txtSumaTotal.Margin = new Padding(3, 4, 3, 4);
			txtSumaTotal.Name = "txtSumaTotal";
			txtSumaTotal.ReadOnly = true;
			txtSumaTotal.Size = new Size(137, 27);
			txtSumaTotal.TabIndex = 3;
			// 
			// listBoxHuevos
			// 
			listBoxHuevos.FormattingEnabled = true;
			listBoxHuevos.Items.AddRange(new object[] { "Huevo Grande", "Huevo Mediano", "Huevo pequeño" });
			listBoxHuevos.Location = new Point(69, 28);
			listBoxHuevos.Margin = new Padding(3, 4, 3, 4);
			listBoxHuevos.Name = "listBoxHuevos";
			listBoxHuevos.Size = new Size(251, 84);
			listBoxHuevos.TabIndex = 0;
			// 
			// txtCantidad
			// 
			txtCantidad.Location = new Point(183, 140);
			txtCantidad.Margin = new Padding(3, 4, 3, 4);
			txtCantidad.Name = "txtCantidad";
			txtCantidad.Size = new Size(137, 27);
			txtCantidad.TabIndex = 2;
			// 
			// lblCantidad
			// 
			lblCantidad.AutoSize = true;
			lblCantidad.Location = new Point(69, 144);
			lblCantidad.Name = "lblCantidad";
			lblCantidad.Size = new Size(72, 20);
			lblCantidad.TabIndex = 3;
			lblCantidad.Text = "Cantidad:";
			// 
			// btnEliminarDatos
			// 
			btnEliminarDatos.BackColor = Color.FromArgb(128, 0, 32);
			btnEliminarDatos.ForeColor = Color.FromArgb(192, 255, 192);
			btnEliminarDatos.Location = new Point(339, 310);
			btnEliminarDatos.Margin = new Padding(3, 4, 3, 4);
			btnEliminarDatos.Name = "btnEliminarDatos";
			btnEliminarDatos.Size = new Size(150, 40);
			btnEliminarDatos.TabIndex = 2;
			btnEliminarDatos.Text = "Eliminar Datos";
			btnEliminarDatos.UseVisualStyleBackColor = false;
			// 
			// txtPrecioUnidad
			// 
			txtPrecioUnidad.Location = new Point(183, 192);
			txtPrecioUnidad.Margin = new Padding(3, 4, 3, 4);
			txtPrecioUnidad.Name = "txtPrecioUnidad";
			txtPrecioUnidad.Size = new Size(137, 27);
			txtPrecioUnidad.TabIndex = 4;
			// 
			// lblPrecioUnidad
			// 
			lblPrecioUnidad.AutoSize = true;
			lblPrecioUnidad.Location = new Point(69, 196);
			lblPrecioUnidad.Name = "lblPrecioUnidad";
			lblPrecioUnidad.Size = new Size(105, 20);
			lblPrecioUnidad.TabIndex = 5;
			lblPrecioUnidad.Text = "Precio Unidad:";
			// 
			// txtTotal
			// 
			txtTotal.Location = new Point(183, 244);
			txtTotal.Margin = new Padding(3, 4, 3, 4);
			txtTotal.Name = "txtTotal";
			txtTotal.ReadOnly = true;
			txtTotal.Size = new Size(137, 27);
			txtTotal.TabIndex = 6;
			// 
			// lblTotal
			// 
			lblTotal.AutoSize = true;
			lblTotal.Location = new Point(69, 248);
			lblTotal.Name = "lblTotal";
			lblTotal.Size = new Size(45, 20);
			lblTotal.TabIndex = 7;
			lblTotal.Text = "Total:";
			// 
			// btnCalcularTotal
			// 
			btnCalcularTotal.BackColor = Color.FromArgb(128, 0, 32);
			btnCalcularTotal.ForeColor = Color.FromArgb(192, 255, 192);
			btnCalcularTotal.Location = new Point(24, 310);
			btnCalcularTotal.Margin = new Padding(3, 4, 3, 4);
			btnCalcularTotal.Name = "btnCalcularTotal";
			btnCalcularTotal.Size = new Size(150, 40);
			btnCalcularTotal.TabIndex = 8;
			btnCalcularTotal.Text = "Calcular Total";
			btnCalcularTotal.UseVisualStyleBackColor = false;
			btnCalcularTotal.Click += btnCalcularTotal_Click_1;
			// 
			// btnConfirmarCompra
			// 
			btnConfirmarCompra.BackColor = Color.FromArgb(128, 0, 32);
			btnConfirmarCompra.ForeColor = Color.FromArgb(192, 255, 192);
			btnConfirmarCompra.Location = new Point(183, 310);
			btnConfirmarCompra.Margin = new Padding(3, 4, 3, 4);
			btnConfirmarCompra.Name = "btnConfirmarCompra";
			btnConfirmarCompra.Size = new Size(150, 40);
			btnConfirmarCompra.TabIndex = 9;
			btnConfirmarCompra.Text = "Confirmar Compra";
			btnConfirmarCompra.UseVisualStyleBackColor = false;
			// 
			// dgvCompras
			// 
			dgvCompras.AllowUserToAddRows = false;
			dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCompras.Columns.AddRange(new DataGridViewColumn[] { colProducto, colCantidad, colPrecioUnidad, colTotal });
			dgvCompras.Location = new Point(72, 397);
			dgvCompras.Margin = new Padding(3, 4, 3, 4);
			dgvCompras.Name = "dgvCompras";
			dgvCompras.ReadOnly = true;
			dgvCompras.RowHeadersWidth = 51;
			dgvCompras.RowTemplate.Height = 25;
			dgvCompras.Size = new Size(556, 200);
			dgvCompras.TabIndex = 1;
			// 
			// colProducto
			// 
			colProducto.HeaderText = "Producto";
			colProducto.MinimumWidth = 6;
			colProducto.Name = "colProducto";
			colProducto.ReadOnly = true;
			colProducto.Width = 125;
			// 
			// colCantidad
			// 
			colCantidad.HeaderText = "Cantidad";
			colCantidad.MinimumWidth = 6;
			colCantidad.Name = "colCantidad";
			colCantidad.ReadOnly = true;
			colCantidad.Width = 125;
			// 
			// colPrecioUnidad
			// 
			colPrecioUnidad.HeaderText = "Precio Unidad";
			colPrecioUnidad.MinimumWidth = 6;
			colPrecioUnidad.Name = "colPrecioUnidad";
			colPrecioUnidad.ReadOnly = true;
			colPrecioUnidad.Width = 125;
			// 
			// colTotal
			// 
			colTotal.HeaderText = "Total";
			colTotal.MinimumWidth = 6;
			colTotal.Name = "colTotal";
			colTotal.ReadOnly = true;
			colTotal.Width = 125;
			// 
			// FormCompraHuevos
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(216, 208, 200);
			ClientSize = new Size(751, 748);
			Controls.Add(dgvCompras);
			Controls.Add(groupBoxCompraHuevos);
			Margin = new Padding(3, 4, 3, 4);
			Name = "FormCompraHuevos";
			Text = "Compra de Huevos";
			Load += FormCompraHuevos_Load;
			groupBoxCompraHuevos.ResumeLayout(false);
			groupBoxCompraHuevos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
			ResumeLayout(false);
		}

		private System.Windows.Forms.GroupBox groupBoxCompraHuevos;
		private System.Windows.Forms.ListBox listBoxHuevos;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.TextBox txtPrecioUnidad;
		private System.Windows.Forms.Label lblPrecioUnidad;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button btnCalcularTotal;
		private System.Windows.Forms.Button btnConfirmarCompra;
		private System.Windows.Forms.DataGridView dgvCompras;
		private System.Windows.Forms.TextBox txtSumaTotal;
		private System.Windows.Forms.Label lblSumaTotal;
		private System.Windows.Forms.Button btnCalcularSumaTotal;
		private System.Windows.Forms.Button btnEliminarDatos;
		private DataGridViewTextBoxColumn colProducto;
		private DataGridViewTextBoxColumn colCantidad;
		private DataGridViewTextBoxColumn colPrecioUnidad;
		private DataGridViewTextBoxColumn colTotal;
	}
}

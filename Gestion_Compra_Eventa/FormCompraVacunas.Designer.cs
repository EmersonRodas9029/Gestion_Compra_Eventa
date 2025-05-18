namespace Gestion_Compra_Eventa

{
	partial class FormCompraVacunas
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
			groupBoxCompraVacunas = new GroupBox();
			lblSumaTotal = new Label();
			btnCalcularSumaTotal = new Button();
			txtSumaTotal = new TextBox();
			listBoxVacunas = new ListBox();
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
			groupBoxCompraVacunas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
			SuspendLayout();
			// 
			// groupBoxCompraVacunas
			// 
			groupBoxCompraVacunas.BackColor = Color.FromArgb(185, 178, 154);
			groupBoxCompraVacunas.Controls.Add(lblSumaTotal);
			groupBoxCompraVacunas.Controls.Add(btnCalcularSumaTotal);
			groupBoxCompraVacunas.Controls.Add(txtSumaTotal);
			groupBoxCompraVacunas.Controls.Add(listBoxVacunas);
			groupBoxCompraVacunas.Controls.Add(txtCantidad);
			groupBoxCompraVacunas.Controls.Add(lblCantidad);
			groupBoxCompraVacunas.Controls.Add(btnEliminarDatos);
			groupBoxCompraVacunas.Controls.Add(txtPrecioUnidad);
			groupBoxCompraVacunas.Controls.Add(lblPrecioUnidad);
			groupBoxCompraVacunas.Controls.Add(txtTotal);
			groupBoxCompraVacunas.Controls.Add(lblTotal);
			groupBoxCompraVacunas.Controls.Add(btnCalcularTotal);
			groupBoxCompraVacunas.Controls.Add(btnConfirmarCompra);
			groupBoxCompraVacunas.Location = new Point(32, 39);
			groupBoxCompraVacunas.Margin = new Padding(3, 4, 3, 4);
			groupBoxCompraVacunas.Name = "groupBoxCompraVacunas";
			groupBoxCompraVacunas.Padding = new Padding(3, 4, 3, 4);
			groupBoxCompraVacunas.Size = new Size(681, 674);
			groupBoxCompraVacunas.TabIndex = 0;
			groupBoxCompraVacunas.TabStop = false;
			groupBoxCompraVacunas.Text = "Compra de Vacunas";
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
			btnCalcularSumaTotal.Click += btnCalcularSumaTotal_Click;
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
			// listBoxVacunas
			// 
			listBoxVacunas.FormattingEnabled = true;
			listBoxVacunas.Items.AddRange(new object[] { "Vacuna al ojo", "Vacuna al ala", "Vacuna a la pechuga" });
			listBoxVacunas.Location = new Point(69, 28);
			listBoxVacunas.Margin = new Padding(3, 4, 3, 4);
			listBoxVacunas.Name = "listBoxVacunas";
			listBoxVacunas.Size = new Size(251, 84);
			listBoxVacunas.TabIndex = 0;
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
			btnEliminarDatos.Click += btnEliminarDatos_Click;
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
			dgvCompras.RowHeadersWidth = 51;
			dgvCompras.RowTemplate.Height = 25;
			dgvCompras.Size = new Size(556, 200);
			dgvCompras.TabIndex = 1;
			dgvCompras.CellContentClick += dgvCompras_CellContentClick;
			// 
			// colProducto
			// 
			colProducto.HeaderText = "Producto";
			colProducto.MinimumWidth = 6;
			colProducto.Name = "colProducto";
			colProducto.Width = 125;
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
			// FormCompraVacunas
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(216, 208, 200);
			ClientSize = new Size(751, 748);
			Controls.Add(dgvCompras);
			Controls.Add(groupBoxCompraVacunas);
			Margin = new Padding(3, 4, 3, 4);
			Name = "FormCompraVacunas";
			Text = "Compra de Vacunas";
			groupBoxCompraVacunas.ResumeLayout(false);
			groupBoxCompraVacunas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
			ResumeLayout(false);
		}

		private System.Windows.Forms.GroupBox groupBoxCompraVacunas;
		private System.Windows.Forms.ListBox listBoxVacunas;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.TextBox txtPrecioUnidad;
		private System.Windows.Forms.Label lblPrecioUnidad;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button btnCalcularTotal;
		private System.Windows.Forms.Button btnConfirmarCompra;
		private System.Windows.Forms.DataGridView dgvCompras;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
		private System.Windows.Forms.Button btnEliminarDatos;
		private System.Windows.Forms.TextBox txtSumaTotal;
		private System.Windows.Forms.Label lblSumaTotal;
		private System.Windows.Forms.Button btnCalcularSumaTotal;
	}
}

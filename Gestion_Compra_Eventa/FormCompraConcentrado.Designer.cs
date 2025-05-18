using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_Compra_Eventa

{
	public partial class FormCompraConcentrado : Form
	{
		private GroupBox groupBoxCompraConcentrado;
		private ListBox listBoxProductos;
		private Label lblCantidad;
		private TextBox txtCantidad;
		private Label lblPrecioUnidad;
		private TextBox txtPrecioUnidad;
		private Label lblTotal;
		private TextBox txtTotal;
		private Button btnConfirmarCompra;
		private Button btnCalcularTotal;
		private DataGridView dgvCompras;
		private Button btnEliminarDatos;
		private Button btnSumaTotal;
		private TextBox txtSumaTotal;
		private void InitializeComponent()
		{
			groupBoxCompraConcentrado = new GroupBox();
			label1 = new Label();
			listBoxProductos = new ListBox();
			lblCantidad = new Label();
			txtCantidad = new TextBox();
			lblPrecioUnidad = new Label();
			txtPrecioUnidad = new TextBox();
			lblTotal = new Label();
			txtTotal = new TextBox();
			btnConfirmarCompra = new Button();
			btnCalcularTotal = new Button();
			dgvCompras = new DataGridView();
			dataGridViewTextBoxColumnProducto = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumnCantidad = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumnPrecioUnidad = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumnTotal = new DataGridViewTextBoxColumn();
			btnEliminarDatos = new Button();
			btnSumaTotal = new Button();
			txtSumaTotal = new TextBox();
			groupBoxCompraConcentrado.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
			SuspendLayout();
			// 
			// groupBoxCompraConcentrado
			// 
			groupBoxCompraConcentrado.BackColor = Color.FromArgb(185, 178, 154);
			groupBoxCompraConcentrado.Controls.Add(label1);
			groupBoxCompraConcentrado.Controls.Add(listBoxProductos);
			groupBoxCompraConcentrado.Controls.Add(lblCantidad);
			groupBoxCompraConcentrado.Controls.Add(txtCantidad);
			groupBoxCompraConcentrado.Controls.Add(lblPrecioUnidad);
			groupBoxCompraConcentrado.Controls.Add(txtPrecioUnidad);
			groupBoxCompraConcentrado.Controls.Add(lblTotal);
			groupBoxCompraConcentrado.Controls.Add(txtTotal);
			groupBoxCompraConcentrado.Controls.Add(btnConfirmarCompra);
			groupBoxCompraConcentrado.Controls.Add(btnCalcularTotal);
			groupBoxCompraConcentrado.Controls.Add(dgvCompras);
			groupBoxCompraConcentrado.Controls.Add(btnEliminarDatos);
			groupBoxCompraConcentrado.Controls.Add(btnSumaTotal);
			groupBoxCompraConcentrado.Controls.Add(txtSumaTotal);
			groupBoxCompraConcentrado.Location = new Point(50, 50);
			groupBoxCompraConcentrado.Name = "groupBoxCompraConcentrado";
			groupBoxCompraConcentrado.Size = new Size(671, 600);
			groupBoxCompraConcentrado.TabIndex = 0;
			groupBoxCompraConcentrado.TabStop = false;
			groupBoxCompraConcentrado.Text = "Compra de Concentrado";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(119, 502);
			label1.Name = "label1";
			label1.Size = new Size(99, 20);
			label1.TabIndex = 13;
			label1.Text = "Compra Total";
			// 
			// listBoxProductos
			// 
			listBoxProductos.FormattingEnabled = true;
			listBoxProductos.Items.AddRange(new object[] { "Inicio Desarrollo", "Desarrollo Postura", "Impulsor Premium" });
			listBoxProductos.Location = new Point(20, 30);
			listBoxProductos.Name = "listBoxProductos";
			listBoxProductos.Size = new Size(350, 64);
			listBoxProductos.TabIndex = 0;
			// 
			// lblCantidad
			// 
			lblCantidad.Location = new Point(20, 140);
			lblCantidad.Name = "lblCantidad";
			lblCantidad.Size = new Size(120, 20);
			lblCantidad.TabIndex = 1;
			lblCantidad.Text = "Cantidad (unidades):";
			// 
			// txtCantidad
			// 
			txtCantidad.Location = new Point(150, 140);
			txtCantidad.Name = "txtCantidad";
			txtCantidad.Size = new Size(220, 27);
			txtCantidad.TabIndex = 2;
			// 
			// lblPrecioUnidad
			// 
			lblPrecioUnidad.Location = new Point(20, 180);
			lblPrecioUnidad.Name = "lblPrecioUnidad";
			lblPrecioUnidad.Size = new Size(120, 20);
			lblPrecioUnidad.TabIndex = 3;
			lblPrecioUnidad.Text = "Precio por Unidad:";
			// 
			// txtPrecioUnidad
			// 
			txtPrecioUnidad.Location = new Point(150, 180);
			txtPrecioUnidad.Name = "txtPrecioUnidad";
			txtPrecioUnidad.ReadOnly = false;
			txtPrecioUnidad.Size = new Size(220, 27);
			txtPrecioUnidad.TabIndex = 4;
			// 
			// lblTotal
			// 
			lblTotal.Location = new Point(20, 220);
			lblTotal.Name = "lblTotal";
			lblTotal.Size = new Size(120, 20);
			lblTotal.TabIndex = 5;
			lblTotal.Text = "Total a Pagar:";
			// 
			// txtTotal
			// 
			txtTotal.Location = new Point(150, 220);
			txtTotal.Name = "txtTotal";
			txtTotal.ReadOnly = true;
			txtTotal.Size = new Size(220, 27);
			txtTotal.TabIndex = 6;
			// 
			// btnConfirmarCompra
			// 
			btnConfirmarCompra.BackColor = Color.FromArgb(128, 0, 32);
			btnConfirmarCompra.ForeColor = Color.FromArgb(192, 255, 192);
			btnConfirmarCompra.Location = new Point(185, 260);
			btnConfirmarCompra.Name = "btnConfirmarCompra";
			btnConfirmarCompra.Size = new Size(150, 40);
			btnConfirmarCompra.TabIndex = 7;
			btnConfirmarCompra.Text = "Confirmar Compra";
			btnConfirmarCompra.UseVisualStyleBackColor = false;
			// 
			// btnCalcularTotal
			// 
			btnCalcularTotal.BackColor = Color.FromArgb(128, 0, 32);
			btnCalcularTotal.ForeColor = Color.FromArgb(192, 255, 192);
			btnCalcularTotal.Location = new Point(20, 260);
			btnCalcularTotal.Name = "btnCalcularTotal";
			btnCalcularTotal.Size = new Size(150, 40);
			btnCalcularTotal.TabIndex = 8;
			btnCalcularTotal.Text = "Calcular Total";
			btnCalcularTotal.UseVisualStyleBackColor = false;
			btnCalcularTotal.Click += btnCalcularTotal_Click_1;
			// 
			// dgvCompras
			// 
			dgvCompras.AllowUserToAddRows = false;
			dgvCompras.ColumnHeadersHeight = 29;
			dgvCompras.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumnProducto, dataGridViewTextBoxColumnCantidad, dataGridViewTextBoxColumnPrecioUnidad, dataGridViewTextBoxColumnTotal });
			dgvCompras.Location = new Point(57, 325);
			dgvCompras.Name = "dgvCompras";
			dgvCompras.RowHeadersWidth = 51;
			dgvCompras.Size = new Size(553, 150);
			dgvCompras.TabIndex = 9;
			// 
			// dataGridViewTextBoxColumnProducto
			// 
			dataGridViewTextBoxColumnProducto.HeaderText = "Producto";
			dataGridViewTextBoxColumnProducto.MinimumWidth = 6;
			dataGridViewTextBoxColumnProducto.Name = "dataGridViewTextBoxColumnProducto";
			dataGridViewTextBoxColumnProducto.Width = 125;
			// 
			// dataGridViewTextBoxColumnCantidad
			// 
			dataGridViewTextBoxColumnCantidad.HeaderText = "Cantidad";
			dataGridViewTextBoxColumnCantidad.MinimumWidth = 6;
			dataGridViewTextBoxColumnCantidad.Name = "dataGridViewTextBoxColumnCantidad";
			dataGridViewTextBoxColumnCantidad.Width = 125;
			// 
			// dataGridViewTextBoxColumnPrecioUnidad
			// 
			dataGridViewTextBoxColumnPrecioUnidad.HeaderText = "Precio por Unidad";
			dataGridViewTextBoxColumnPrecioUnidad.MinimumWidth = 6;
			dataGridViewTextBoxColumnPrecioUnidad.Name = "dataGridViewTextBoxColumnPrecioUnidad";
			dataGridViewTextBoxColumnPrecioUnidad.Width = 125;
			// 
			// dataGridViewTextBoxColumnTotal
			// 
			dataGridViewTextBoxColumnTotal.HeaderText = "Total";
			dataGridViewTextBoxColumnTotal.MinimumWidth = 6;
			dataGridViewTextBoxColumnTotal.Name = "dataGridViewTextBoxColumnTotal";
			dataGridViewTextBoxColumnTotal.Width = 125;
			// 
			// btnEliminarDatos
			// 
			btnEliminarDatos.BackColor = Color.FromArgb(128, 0, 32);
			btnEliminarDatos.ForeColor = Color.FromArgb(192, 255, 192);
			btnEliminarDatos.Location = new Point(350, 260);
			btnEliminarDatos.Name = "btnEliminarDatos";
			btnEliminarDatos.Size = new Size(150, 40);
			btnEliminarDatos.TabIndex = 10;
			btnEliminarDatos.Text = "Eliminar Datos";
			btnEliminarDatos.UseVisualStyleBackColor = false;
			btnEliminarDatos.Click += btnEliminarDatos_Click;
			// 
			// btnSumaTotal
			// 
			btnSumaTotal.BackColor = Color.FromArgb(128, 0, 32);
			btnSumaTotal.ForeColor = Color.FromArgb(192, 255, 192);
			btnSumaTotal.Location = new Point(506, 260);
			btnSumaTotal.Name = "btnSumaTotal";
			btnSumaTotal.Size = new Size(150, 40);
			btnSumaTotal.TabIndex = 11;
			btnSumaTotal.Text = "Suma Total";
			btnSumaTotal.UseVisualStyleBackColor = false;
			btnSumaTotal.Click += btnSumaTotal_Click;
			// 
			// txtSumaTotal
			// 
			txtSumaTotal.Location = new Point(224, 499);
			txtSumaTotal.Name = "txtSumaTotal";
			txtSumaTotal.ReadOnly = true;
			txtSumaTotal.Size = new Size(220, 27);
			txtSumaTotal.TabIndex = 12;
			txtSumaTotal.Text = "0.00";
			// 
			// FormCompraConcentrado
			// 
			BackColor = Color.FromArgb(216, 208, 200);
			ClientSize = new Size(747, 650);
			Controls.Add(groupBoxCompraConcentrado);
			Name = "FormCompraConcentrado";
			Text = "Compra de Concentrado";
			groupBoxCompraConcentrado.ResumeLayout(false);
			groupBoxCompraConcentrado.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
			ResumeLayout(false);
		}

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumnProducto;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumnCantidad;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumnPrecioUnidad;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumnTotal;
		private Label label1;
	}
}
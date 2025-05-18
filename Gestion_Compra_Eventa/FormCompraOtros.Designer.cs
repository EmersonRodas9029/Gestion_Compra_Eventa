using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Gestion_Compra_Eventa

{
	public partial class FormCompraOtros : Form
	{
		private const string DataFilePath = "otros.csv";  // Cambiado el nombre de archivo

		public FormCompraOtros()
		{
			InitializeComponent();
			btnCalcularTotal.Click += btnCalcularTotal_Click;
			btnConfirmarCompra.Click += btnConfirmarCompra_Click;
			btnCalcularSumaTotal.Click += btnCalcularSumaTotal_Click;
			btnEliminarDatos.Click += btnEliminarDatos_Click;
			LoadData();
			this.FormClosing += FormCompraOtros_FormClosing;
		}

		private void LoadData()
		{
			if (!File.Exists(DataFilePath)) return;

			try
			{
				string[] lines = File.ReadAllLines(DataFilePath, Encoding.UTF8);
				foreach (string line in lines)
				{
					string[] values = line.Split(',');
					if (values.Length == 4)
					{
						dgvCompras.Rows.Add(values);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SaveData()
		{
			try
			{
				using (StreamWriter writer = new StreamWriter(DataFilePath, false, Encoding.UTF8))
				{
					foreach (DataGridViewRow row in dgvCompras.Rows)
					{
						if (!row.IsNewRow)
						{
							string[] values = new string[]
							{
								row.Cells[0].Value?.ToString(),
								row.Cells[1].Value?.ToString(),
								row.Cells[2].Value?.ToString(),
								row.Cells[3].Value?.ToString()
							};
							writer.WriteLine(string.Join(",", values));
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCalcularTotal_Click(object sender, EventArgs e)
		{
			if (int.TryParse(txtCantidad.Text, out int cantidad) && decimal.TryParse(txtPrecioUnidad.Text, out decimal precioUnidad))
			{
				txtTotal.Text = (cantidad * precioUnidad).ToString("F2");
			}
			else
			{
				MessageBox.Show("Ingrese valores válidos para la cantidad y el precio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnConfirmarCompra_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtProducto.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtPrecioUnidad.Text) || string.IsNullOrWhiteSpace(txtTotal.Text))
			{
				MessageBox.Show("Complete todos los campos antes de confirmar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			dgvCompras.Rows.Add(
				txtProducto.Text,    // Producto introducido en el TextBox
				txtCantidad.Text,
				txtPrecioUnidad.Text,
				txtTotal.Text
			);

			// Limpiar campos después de la compra
			txtProducto.Clear();
			txtCantidad.Clear();
			txtPrecioUnidad.Clear();
			txtTotal.Clear();
		}

		private void btnCalcularSumaTotal_Click(object sender, EventArgs e)
		{
			try
			{
				decimal sumaTotal = 0;

				foreach (DataGridViewRow row in dgvCompras.Rows)
				{
					if (row.Cells["colTotal"].Value != null)
					{
						sumaTotal += Convert.ToDecimal(row.Cells["colTotal"].Value);
					}
				}

				txtSumaTotal.Text = sumaTotal.ToString("C");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al calcular la suma total: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnEliminarDatos_Click(object sender, EventArgs e)
		{
			dgvCompras.Rows.Clear();
			txtProducto.Clear();
			txtCantidad.Clear();
			txtPrecioUnidad.Clear();
			txtTotal.Clear();
			MessageBox.Show("Todos los datos han sido eliminados.");
		}

		private void FormCompraOtros_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveData();
		}
	}
}

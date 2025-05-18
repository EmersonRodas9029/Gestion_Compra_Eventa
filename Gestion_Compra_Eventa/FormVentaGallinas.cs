using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Gestion_Compra_Eventa

{
	public partial class FormVentaGallinas : Form
	{
		private const string DataFilePath = "ventas_gallinas.csv";

		public FormVentaGallinas()
		{
			InitializeComponent();
			//listBoxGallinas.SelectedIndexChanged += listBoxGallinas_SelectedIndexChanged;
			btnCalcularTotal.Click += btnCalcularTotal_Click;
			btnConfirmarVenta.Click += btnConfirmarVenta_Click;
			btnSumaTotal.Click += btnCalcularSumaTotal_Click;
			btnEliminarDatos.Click += btnEliminarDatos_Click;
			LoadData();
			this.FormClosing += FormVentaGallinas_FormClosing;

			// Asegurarse de que txtPrecioUnidad siempre esté habilitado
			txtPrecioUnidad.Enabled = true;
		}

		// Método que maneja la selección de un item en el listBox
		//private void listBoxGallinas_SelectedIndexChanged(object? sender, EventArgs e)
		//{
		//	// Solo cambiar el precio si hay una selección en listBoxGallinas
		//	if (listBoxGallinas.SelectedItem != null)
		//	{
		//		string seleccionado = listBoxGallinas.SelectedItem.ToString();

		//		// Asignar el precio dependiendo del tipo de gallina seleccionada
		//		switch (seleccionado)
		//		{
		//			case "Normal":
		//				txtPrecioUnidad.Text = "10.00";
		//				break;
		//			case "Aliñada":
		//				txtPrecioUnidad.Text = "12.00";
		//				break;
		//			default:
		//				txtPrecioUnidad.Clear();
		//				break;
		//		}
		//	}
		//}

		// Método para calcular el total de la venta
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

		// Método para confirmar la venta
		private void btnConfirmarVenta_Click(object sender, EventArgs e)
		{
			if (listBoxGallinas.SelectedItem == null || string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtTotal.Text))
			{
				MessageBox.Show("Complete todos los campos antes de confirmar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string tipoGallina = listBoxGallinas.SelectedItem.ToString();

			dgvVentas.Rows.Add(
				tipoGallina,
				txtCantidad.Text,
				txtPrecioUnidad.Text,
				txtTotal.Text
			);

			txtCantidad.Clear();
			txtPrecioUnidad.Clear();
			txtTotal.Clear();
			listBoxGallinas.ClearSelected();
		}

		// Método para calcular la suma total de todas las ventas
		private void btnCalcularSumaTotal_Click(object sender, EventArgs e)
		{
			try
			{
				decimal sumaTotal = 0;
				foreach (DataGridViewRow row in dgvVentas.Rows)
				{
					if (!row.IsNewRow && decimal.TryParse(row.Cells["colTotal"].Value?.ToString(), out decimal total))
					{
						sumaTotal += total;
					}
				}
				txtSumaTotal.Text = sumaTotal.ToString("C");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al calcular la suma total: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Método para eliminar todos los datos
		private void btnEliminarDatos_Click(object sender, EventArgs e)
		{
			dgvVentas.Rows.Clear();
			txtCantidad.Clear();
			txtPrecioUnidad.Clear();
			txtTotal.Clear();
			MessageBox.Show("Todos los datos han sido eliminados.");
		}

		// Método que carga los datos del archivo CSV
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
						dgvVentas.Rows.Add(values);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Método que guarda los datos en el archivo CSV
		private void SaveData()
		{
			try
			{
				using (StreamWriter writer = new StreamWriter(DataFilePath, false, Encoding.UTF8))
				{
					foreach (DataGridViewRow row in dgvVentas.Rows)
					{
						if (!row.IsNewRow)
						{
							string[] values = new string[]
							{
								row.Cells["colTamaño"].Value?.ToString(),
								row.Cells["colCantidad"].Value?.ToString(),
								row.Cells["colPrecioUnidad"].Value?.ToString(),
								row.Cells["colTotal"].Value?.ToString()
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

		// Método que guarda los datos cuando se cierra el formulario
		private void FormVentaGallinas_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveData(); // Llamar al método SaveData para guardar los datos
		}

		private void lblTotal_Click(object sender, EventArgs e)
		{

		}

		private void btnCalcularTotal_Click_1(object sender, EventArgs e)
		{

		}

		private void btnConfirmarVenta_Click_1(object sender, EventArgs e)
		{

		}
	}
}

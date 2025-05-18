using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Gestion_Compra_Eventa

{
	public partial class FormVentaHuevos : Form
	{
		private const string DataFilePath = "ventas_huevos.csv";

		public FormVentaHuevos()
		{
			InitializeComponent();
			//listBoxHuevos.SelectedIndexChanged += listBoxHuevos_SelectedIndexChanged;
			radioCartones.CheckedChanged += radioCartones_CheckedChanged;
			radioDolares.CheckedChanged += radioDolares_CheckedChanged;
			btnCalcularTotal.Click += btnCalcularTotal_Click;
			btnConfirmarVenta.Click += btnConfirmarVenta_Click;
			btnCalcularSumaTotal.Click += btnCalcularSumaTotal_Click;
			btnEliminarDatos.Click += btnEliminarDatos_Click;
			LoadData();
			this.FormClosing += FormVentaHuevos_FormClosing;

			// Asegurarse de que txtPrecioUnidad siempre esté habilitado
			txtPrecioUnidad.Enabled = true;
		}

		// Método que maneja la selección de un item en el listBox
		//private void listBoxHuevos_SelectedIndexChanged(object? sender, EventArgs e)
		//{
		//	// Solo cambiar el precio si el radio botón de Cartones está seleccionado
		//	if (radioCartones.Checked && listBoxHuevos.SelectedItem != null)
		//	{
		//		string seleccionado = listBoxHuevos.SelectedItem.ToString();

		//		// Asignar el precio dependiendo del tamaño seleccionado
		//		switch (seleccionado)
		//		{
		//			case "Grande":
		//				txtPrecioUnidad.Text = "5.00";
		//				break;
		//			case "Mediano":
		//				txtPrecioUnidad.Text = "4.50";
		//				break;
		//			case "Pequeño":
		//				txtPrecioUnidad.Text = "3.00";
		//				break;
		//			default:
		//				txtPrecioUnidad.Clear();
		//				break;
		//		}
		//	}
		//}

		// Método que activa/desactiva el cálculo de precios cuando se selecciona el radio botón "Cartones"
		private void radioCartones_CheckedChanged(object sender, EventArgs e)
		{
			if (radioCartones.Checked)
			{
				// Si el radio botón Cartones está seleccionado, actualizar el precio automáticamente
				//listBoxHuevos_SelectedIndexChanged(sender, e);
			}
			else
			{
				txtPrecioUnidad.Clear(); // Limpiar el precio si no está seleccionado "Cartones"
			}
		}

		// Método que maneja el cambio cuando se selecciona el radio botón "Dólares"
		private void radioDolares_CheckedChanged(object sender, EventArgs e)
		{
			if (radioDolares.Checked)
			{
				// Si el radio botón Dólares está seleccionado, dejar que el usuario ingrese el precio
				txtPrecioUnidad.Enabled = true;
			}
		}

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
			if (listBoxHuevos.SelectedItem == null || string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtTotal.Text) || (!radioCartones.Checked && !radioDolares.Checked))
			{
				MessageBox.Show("Complete todos los campos antes de confirmar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string unidadVenta = radioDolares.Checked ? "Dólares" : "Cartones";

			dgvVentas.Rows.Add(
				listBoxHuevos.SelectedItem.ToString(),
				txtCantidad.Text,
				txtPrecioUnidad.Text,
				txtTotal.Text,
				unidadVenta
			);

			txtCantidad.Clear();
			txtPrecioUnidad.Clear();
			txtTotal.Clear();
			listBoxHuevos.ClearSelected();
			radioDolares.Checked = false;
			radioCartones.Checked = false;
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
			radioDolares.Checked = false;
			radioCartones.Checked = false;
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
					if (values.Length == 5)
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
								row.Cells["colTotal"].Value?.ToString(),
								row.Cells["colUnidadVenta"].Value?.ToString()
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
		private void FormVentaHuevos_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveData(); // Llamar al método SaveData para guardar los datos
		}
	}
}

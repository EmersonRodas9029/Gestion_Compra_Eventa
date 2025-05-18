using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Gestion_Compra_Eventa

{
	public partial class FormCompraHuevos : Form
	{
		private const string DataFilePath = "huevos.csv";

		public FormCompraHuevos()
		{
			InitializeComponent();

			//listBoxHuevos.SelectedIndexChanged += listBoxHuevos_SelectedIndexChanged;
			btnCalcularTotal.Click += btnCalcularTotal_Click;
			btnConfirmarCompra.Click += btnConfirmarCompra_Click;
			btnCalcularSumaTotal.Click += btnCalcularSumaTotal_Click;
			btnEliminarDatos.Click += btnEliminarDatos_Click;
			LoadData();
			this.FormClosing += FormCompraHuevos_FormClosing;
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

		//private void listBoxHuevos_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//	if (listBoxHuevos.SelectedItem == null) return;

		//	switch (listBoxHuevos.SelectedItem.ToString())
		//	{
		//		case "Huevo A":
		//			txtPrecioUnidad.Text = "5.00";
		//			break;
		//		case "Huevo B":
		//			txtPrecioUnidad.Text = "7.00";
		//			break;
		//		case "Huevo C":
		//			txtPrecioUnidad.Text = "10.00";
		//			break;
		//	}
		//}

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
			if (listBoxHuevos.SelectedItem == null || string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtTotal.Text))
			{
				MessageBox.Show("Complete todos los campos antes de confirmar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			dgvCompras.Rows.Add(
				listBoxHuevos.SelectedItem.ToString(),
				txtCantidad.Text,
				txtPrecioUnidad.Text,
				txtTotal.Text
			);

			txtCantidad.Clear();
			txtPrecioUnidad.Clear();
			txtTotal.Clear();
			listBoxHuevos.ClearSelected();
		}

		private void btnCalcularSumaTotal_Click(object sender, EventArgs e)
		{
			try
			{
				decimal sumaTotal = 0;

				foreach (DataGridViewRow row in dgvCompras.Rows)
				{
					if (!row.IsNewRow && row.Cells[3].Value != null && decimal.TryParse(row.Cells[3].Value.ToString(), out decimal total))
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

		private void btnEliminarDatos_Click(object sender, EventArgs e)
		{
			dgvCompras.Rows.Clear();
			txtCantidad.Clear();
			txtPrecioUnidad.Clear();
			txtTotal.Clear();
			MessageBox.Show("Todos los datos han sido eliminados.");
		}

		private void FormCompraHuevos_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveData();
		}

		private void groupBoxCompraHuevos_Enter(object sender, EventArgs e)
		{

		}

		private void FormCompraHuevos_Load(object sender, EventArgs e)
		{

		}

		private void btnCalcularTotal_Click_1(object sender, EventArgs e)
		{

		}
	}
}

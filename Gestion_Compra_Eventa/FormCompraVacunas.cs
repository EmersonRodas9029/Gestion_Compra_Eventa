using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Gestion_Compra_Eventa
{
	public partial class FormCompraVacunas : Form
	{
		private const string DataFilePath = "vacunas.csv";

		public FormCompraVacunas()
		{
			InitializeComponent();
			//////listBoxVacunas.SelectedIndexChanged += listBoxVacunas_SelectedIndexChanged;
			btnCalcularTotal.Click += btnCalcularTotal_Click;
			btnConfirmarCompra.Click += btnConfirmarCompra_Click;
			LoadData();
			this.FormClosing += FormCompraVacunas_FormClosing;
		}

		////private void listBoxVacunas_SelectedIndexChanged(object sender, EventArgs e)
		////{
		////	if (listBoxVacunas.SelectedItem == null) return;

		////	switch (listBoxVacunas.SelectedItem.ToString())
		////	{
		////		case "Vacuna A":
		////			txtPrecioUnidad.Text = "10.00";
		////			break;
		////		case "Vacuna B":
		////			txtPrecioUnidad.Text = "15.00";
		////			break;
		////		case "Vacuna C":
		////			txtPrecioUnidad.Text = "20.00";
		////			break;
		////	}
		////}

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
			if (listBoxVacunas.SelectedItem == null || string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtTotal.Text))
			{
				MessageBox.Show("Complete todos los campos antes de confirmar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			dgvCompras.Rows.Add(
				listBoxVacunas.SelectedItem.ToString(),
				txtCantidad.Text,
				txtPrecioUnidad.Text,
				txtTotal.Text
			);

			txtCantidad.Clear();
			txtPrecioUnidad.Clear();
			txtTotal.Clear();
			listBoxVacunas.ClearSelected();
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

		private void FormCompraVacunas_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveData();
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
			txtCantidad.Clear();
			txtPrecioUnidad.Clear();
			txtTotal.Clear();
			MessageBox.Show("Todos los datos han sido eliminados.");
		}

		private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}

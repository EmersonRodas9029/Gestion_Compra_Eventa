using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace Gestion_Compra_Eventa

{
	public partial class FormCompraConcentrado : Form
	{
		private const string DataFilePath = "compras.csv";

		public FormCompraConcentrado()
		{
			InitializeComponent();
			//listBoxProductos.SelectedIndexChanged += listBoxProductos_SelectedIndexChanged;
			btnCalcularTotal.Click += btnCalcularTotal_Click;
			btnConfirmarCompra.Click += btnConfirmarCompra_Click;
			LoadData();
			this.FormClosing += FormCompraConcentrado_FormClosing;
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

		//private void listBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//	if (listBoxProductos.SelectedItem == null) return;

		//	switch (listBoxProductos.SelectedItem.ToString())
		//	{
		//		case "Inicio Desarrollo":
		//			txtPrecioUnidad.Text = "33.00";
		//			break;
		//		case "Desarrollo Postura":
		//			txtPrecioUnidad.Text = "27.50";
		//			break;
		//		case "Impulsor Premium":
		//			txtPrecioUnidad.Text = "27.75";
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
			if (listBoxProductos.SelectedItem == null || string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtTotal.Text))
			{
				MessageBox.Show("Complete todos los campos antes de confirmar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			dgvCompras.Rows.Add(
				listBoxProductos.SelectedItem.ToString(),
				txtCantidad.Text,
				txtPrecioUnidad.Text,
				txtTotal.Text
			);

			txtCantidad.Clear();
			txtPrecioUnidad.Clear();
			txtTotal.Clear();
			listBoxProductos.ClearSelected();
		}

		private void FormCompraConcentrado_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveData();
		}

		private void btnSumaTotal_Click(object sender, EventArgs e)
		{
			decimal sumaTotal = 0;

			foreach (DataGridViewRow row in dgvCompras.Rows)
			{
				if (!row.IsNewRow && decimal.TryParse(row.Cells[3].Value?.ToString(), out decimal total))
				{
					sumaTotal += total ;
				}
			}

			txtSumaTotal.Text = sumaTotal.ToString("F2");
		}

		private void btnEliminarDatos_Click(object sender, EventArgs e)
		{
			dgvCompras.Rows.Clear();
			txtCantidad.Clear();
			txtPrecioUnidad.Clear();
			txtTotal.Clear();
			MessageBox.Show("Todos los datos han sido eliminados.");
		}

		private void btnCalcularTotal_Click_1(object sender, EventArgs e)
		{

		}
	}
}

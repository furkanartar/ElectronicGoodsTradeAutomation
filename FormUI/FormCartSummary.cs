using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;

namespace FormUI
{
    public partial class FormCartSummary : Form
    {
        private ICartService _cartService;
        public FormCartSummary()
        {
            InitializeComponent();
            _cartService = new CartManager();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int selectedRow = dataGridView1.SelectedCells[0].RowIndex;

            //tbxId.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
            //tbxCategoryId.Text = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
            //tbxSupplierId.Text = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
            //tbxProductName.Text = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
            //tbxQuantityPerUnit.Text = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();
            //tbxUnitPrice.Text = dataGridView1.Rows[selectedRow].Cells[5].Value.ToString();
            //tbxUnitsInStock.Text = dataGridView1.Rows[selectedRow].Cells[6].Value.ToString();
        }

        private void FormCartSummary_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Ürün Adı";
            dataGridView1.Columns[1].Name = "Adet";

            var result = _cartService.GetCart();

            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    dataGridView1.Rows.Add(product.Product.ProductName, product.Quantity);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}

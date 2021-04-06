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
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace FormUI
{
    public partial class FormProducts : Form
    {
        private IProductService _productService;

        public FormProducts()
        {
            InitializeComponent();
            //_productManager = ServiceTool.ServiceProvider.GetService<IProductService>();
            _productService = new ProductManager(new EfProductDal());
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "CategoryId";
            dataGridView1.Columns[2].Name = "SupplierId";
            dataGridView1.Columns[3].Name = "ProductName";
            dataGridView1.Columns[4].Name = "QuantityPerUnit";
            dataGridView1.Columns[5].Name = "UnitPrice";
            dataGridView1.Columns[6].Name = "UnitsInStock";

            var result = _productService.GetAll();

            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    dataGridView1.Rows.Add(product.Id, product.CategoryId, product.SupplierId,
                        product.ProductName, product.QuantityPerUnit, product.UnitPrice, product.UnitsInStock);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                ProductName = tbxProductName.Text,
                CategoryId = Int16.Parse(tbxCategoryId.Text),
                SupplierId = Int16.Parse(tbxSupplierId.Text),
                QuantityPerUnit = Int16.Parse(tbxQuantityPerUnit.Text),
                UnitPrice = decimal.Parse(tbxUnitPrice.Text),
                UnitsInStock = Int16.Parse(tbxUnitsInStock.Text)
            };

            var result = _productService.Add(product);

            if (result.Success)
            {
                MessageBox.Show(result.Message);
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = int.Parse(tbxId.Text),
                ProductName = tbxProductName.Text,
                CategoryId = Int16.Parse(tbxCategoryId.Text),
                SupplierId = Int16.Parse(tbxSupplierId.Text),
                QuantityPerUnit = Int16.Parse(tbxQuantityPerUnit.Text),
                UnitPrice = decimal.Parse(tbxUnitPrice.Text),
                UnitsInStock = Int16.Parse(tbxUnitsInStock.Text)
            };

            var result = _productService.Delete(product);

            if (result.Success)
            {
                MessageBox.Show(result.Message);
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = int.Parse(tbxId.Text),
                ProductName = tbxProductName.Text,
                CategoryId = Int16.Parse(tbxCategoryId.Text),
                SupplierId = Int16.Parse(tbxSupplierId.Text),
                QuantityPerUnit = Int16.Parse(tbxQuantityPerUnit.Text),
                UnitPrice = decimal.Parse(tbxUnitPrice.Text),
                UnitsInStock = Int16.Parse(tbxUnitsInStock.Text)
            };

            var result = _productService.Update(product);

            if (result.Success)
            {
                MessageBox.Show(result.Message);
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;

            tbxId.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
            tbxCategoryId.Text = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
            tbxSupplierId.Text = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
            tbxProductName.Text = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
            tbxQuantityPerUnit.Text = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();
            tbxUnitPrice.Text = dataGridView1.Rows[selectedRow].Cells[5].Value.ToString();
            tbxUnitsInStock.Text = dataGridView1.Rows[selectedRow].Cells[6].Value.ToString();
        }
    }
}
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
    public partial class FormSellProduct : Form
    {
        private IProductService _productService;
        private IOrderService _orderService;

        public FormSellProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _orderService = new OrderManager(new EfOrderDal());
        }

        private void FormSellProduct_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Today;
            Order order = new Order()
            {
                CustomerId = int.Parse(tbxCustomerId.Text),
                EmployeeId = Int16.Parse(tbxEmployeeId.Text),
                OrderDate = dateTime,
                ProductId = int.Parse(tbxProductId.Text),
                Quantity = Int16.Parse(tbxQuantity.Text)
            };

            var result = _orderService.Add(order);
            if (result.Success)
            {
                MessageBox.Show("Sipariş eklendi");
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;

            tbxProductId.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
        }
    }
}

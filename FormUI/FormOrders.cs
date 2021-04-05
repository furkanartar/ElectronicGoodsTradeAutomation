using Business.Abstract;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace FormUI
{
    public partial class FormOrders : Form
    {
        private IOrderService _orderService;

        public FormOrders()
        {
            InitializeComponent();
            //_productManager = ServiceTool.ServiceProvider.GetService<IProductService>();
            _orderService = new OrderManager(new EfOrderDal());
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "EmployeeId";
            dataGridView1.Columns[2].Name = "CustomerId";
            dataGridView1.Columns[3].Name = "ProductId";
            dataGridView1.Columns[4].Name = "Quantity";
            dataGridView1.Columns[5].Name = "OrderDate";

            var result = _orderService.GetAll();

            if (result.Success == true)
            {
                foreach (var order in result.Data)
                {
                    dataGridView1.Rows.Add(order.Id, order.EmployeeId, order.CustomerId, order.ProductId, order.Quantity, order.OrderDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

















//HttpClientHandler clientHandler = new HttpClientHandler();
//clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
//HttpClient client = new HttpClient(clientHandler);
//client.BaseAddress = new Uri("https://localhost:44394/api/");
//HttpResponseMessage response = await client.GetAsync("products/getall");
//string rawResponse = await response.Content.ReadAsStringAsync();
////object items = JsonConvert.DeserializeObject<object>(rawResponse);
//var items = JsonSerializer.Deserialize<DataResult<List<Product>>>(rawResponse);

//label1.Text = "";
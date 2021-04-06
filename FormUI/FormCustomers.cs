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
    public partial class FormCustomers : Form
    {
        private ICustomerService _customerService;

        public FormCustomers()
        {
            InitializeComponent();
            //_productManager = ServiceTool.ServiceProvider.GetService<IProductService>();
            _customerService = new CustomerManager(new EfCustomerDal());
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "FirstName";
            dataGridView1.Columns[2].Name = "LastName";
            dataGridView1.Columns[3].Name = "NationalIdentity";
            dataGridView1.Columns[4].Name = "BirthDate";
            dataGridView1.Columns[5].Name = "Adress";
            dataGridView1.Columns[6].Name = "PhoneNumber";
            /*dataGridView1.Columns[8].Name = "PhotoPath";*/


            var result = _customerService.GetAll();

            if (result.Success == true)
            {
                foreach (var customer in result.Data)
                {
                    dataGridView1.Rows.Add(customer.Id, customer.FirstName, customer.LastName,customer.NationalIdentity,
                        customer.BirthDate, customer.Adress, customer.PhoneNumber /* customer.PhotoPath,*/);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;

            tbxId.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
            tbxFirstName.Text = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
            tbxLastName.Text = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
            tbxNationalIdentity.Text = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
            dtpBirthDate.Text = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();
            tbxAdress.Text = dataGridView1.Rows[selectedRow].Cells[5].Value.ToString();
            tbxPhoneNumber.Text = dataGridView1.Rows[selectedRow].Cells[6].Value.ToString();
            //tbxPhotoPath.Text = dataGridView1.Rows[selectedRow].Cells[7].Value.ToString();
        }

        private void btnImagePath_Click(object sender, EventArgs e)
        {
            ofdImagePath.ShowDialog();
            ofdImagePath.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
            tbxPhotoPath.Text = ofdImagePath.FileName;
        }


        private void btnCustomerAdd_Click_1(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                FirstName = tbxFirstName.Text,
                LastName = tbxLastName.Text,
                BirthDate = dtpBirthDate.Value,
                Adress = tbxAdress.Text,
                NationalIdentity = tbxNationalIdentity.Text, /* PhotoPath = tbxPhotoPath.Text,*/
                PhoneNumber = tbxPhoneNumber.Text
            };

            var result = _customerService.Add(customer);

            if (result.Success)
            {
                MessageBox.Show(result.Message);
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Id = Int32.Parse(tbxId.Text),
                FirstName = tbxFirstName.Text,
                LastName = tbxLastName.Text,
                BirthDate = dtpBirthDate.Value,
                Adress = tbxAdress.Text,
                NationalIdentity = tbxNationalIdentity.Text,
                PhoneNumber = tbxPhoneNumber.Text,
                /* PhotoPath = tbxPhotoPath.Text,*/
            };

            var result = _customerService.Delete(customer);

            if (result.Success)
            {
                MessageBox.Show(result.Message);
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Id = Int32.Parse(tbxId.Text),
                FirstName = tbxFirstName.Text,
                LastName = tbxLastName.Text,
                BirthDate = dtpBirthDate.Value,
                Adress = tbxAdress.Text,
                NationalIdentity = tbxNationalIdentity.Text, /* PhotoPath = tbxPhotoPath.Text,*/
                PhoneNumber = tbxPhoneNumber.Text
            };

            var result = _customerService.Update(customer);

            if (result.Success)
            {
                MessageBox.Show(result.Message);
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
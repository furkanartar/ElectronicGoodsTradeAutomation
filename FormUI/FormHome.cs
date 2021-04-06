using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FormHome : Form
    {
        private string _fullName;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
        );

        public FormHome(string fullName)
        {
            InitializeComponent();
            _fullName = fullName;
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlLeft.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Anasayfa";
            lblUserName.Text = _fullName;
            label3.Text = "Hoşgeldiniz!";
            this.pnlFormLoader.Controls.Clear();
            FormDashboard formDashboard = new FormDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formDashboard);
            formDashboard.Show();
            btnDashboard.Focus();
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlLeft.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Ana Sayfa";
            this.pnlFormLoader.Controls.Clear();
            FormDashboard formDashboard = new FormDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formDashboard);
            formDashboard.Show();
        }



        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            pnlLeft.Left = btnContactUs.Left; //gg
            btnContactUs.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Müşteriler";
            this.pnlFormLoader.Controls.Clear();
            FormCustomers formCustomers = new FormCustomers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formCustomers.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formCustomers);
            formCustomers.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProducts.Height;
            pnlNav.Top = btnProducts.Top;
            pnlLeft.Left = btnProducts.Left;
            btnProducts.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Ürünler";
            this.pnlFormLoader.Controls.Clear();
            FormProducts formProducts = new FormProducts() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formProducts.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formProducts);
            formProducts.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnOrders.Height;
            pnlNav.Top = btnOrders.Top;
            pnlLeft.Left = btnOrders.Left; //gg
            btnOrders.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Satışlar";
            this.pnlFormLoader.Controls.Clear();
            FormOrders formOrders = new FormOrders() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formOrders.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formOrders);
            formOrders.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnProducts_Leave(object sender, EventArgs e)
        {
            btnProducts.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnOrders_Leave(object sender, EventArgs e)
        {
            btnOrders.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button1.Height;
            pnlNav.Top = button1.Top;
            pnlLeft.Left = button1.Left; //gg
            button1.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Ürün sat";
            this.pnlFormLoader.Controls.Clear();
            FormSellProduct formSellProduct = new FormSellProduct() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formSellProduct.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formSellProduct);
            formSellProduct.Show();
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}

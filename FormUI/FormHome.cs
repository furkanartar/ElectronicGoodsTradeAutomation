using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FormUI
{
    public partial class FormHome : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public FormHome()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlLeft.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashbord";
            this.pnlFormLoader.Controls.Clear();
            FormDashboard formDashboard = new FormDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formDashboard);
            formDashboard.Show();
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

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            pnlLeft.Left = btnAnalytics.Left; //gg
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Analizler";
            this.pnlFormLoader.Controls.Clear();
            FormAnalytics formAnalytics = new FormAnalytics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formAnalytics.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formAnalytics);
            formAnalytics.Show();
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


        private void btnCartSummary_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnOrders.Height;
            pnlNav.Top = btnOrders.Top;
            pnlLeft.Left = btnOrders.Left; //gg
            btnOrders.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Sepet";
            this.pnlFormLoader.Controls.Clear();
            FormCartSummary formCartSummary = new FormCartSummary() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formCartSummary.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formCartSummary);
            formCartSummary.Show();
        }



        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
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

       
    }
}

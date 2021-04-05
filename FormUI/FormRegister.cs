using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormUI.Shared;
using Microsoft.AspNetCore.Http;

namespace FormUI
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            HttpRequestManager httpRequestManager = new HttpRequestManager();

            httpRequestManager.PostRequest("auth/" , "");
        }
    }
}

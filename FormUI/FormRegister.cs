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
using Core.Utilities.Security.Jwt;
using DataAccess.Concrete.EntityFramework;
using Entities.Dtos;
using FormUI.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace FormUI
{
    public partial class FormRegister : Form
    {
        private IAuthService _authService;
        public FormRegister()
        {
            InitializeComponent();
            _authService = new AuthManager(new UserManager(new EfUserDal()), new JwtHelper());
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserForRegisterDto userForRegisterDto = new UserForRegisterDto()
            {
                FirstName = tbxFirstName.Text,
                LastName = tbxLastName.Text,
                Email = tbxEmail.Text,
                Password = tbxPassword.Text
            };

            var result = _authService.Register(userForRegisterDto);

            if (result.Success)
            {
                FormLogin formLogin = new FormLogin();
                this.Hide();
                formLogin.Show();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using Core.Utilities.Security.Jwt;
using DataAccess.Concrete.EntityFramework;
using Entities.Dtos;
using System;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FormLogin : Form
    {
        private IAuthService _authService;
        private IUserService _userService;

        public FormLogin()
        {
            InitializeComponent();
            _authService = new AuthManager(new UserManager(new EfUserDal()), new JwtHelper());
            _userService = new UserManager(new EfUserDal());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserForLoginDto userForLoginDto = new UserForLoginDto()
            {
                Email = tbxEmail.Text,
                Password = tbxPassword.Text
            };

            var result = _authService.Login(userForLoginDto);

            if (result.Success)
            {
                User user = _userService.GetByMail(userForLoginDto.Email);

                FormHome formHome = new FormHome($"{user.FirstName} {user.LastName}");
                this.Hide();
                formHome.Show();
            }
            else
            {
                MessageBox.Show(result.Message, "Hata");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            this.Hide();
            formRegister.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
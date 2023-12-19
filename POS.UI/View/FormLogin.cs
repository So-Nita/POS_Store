using POSDesignDemo.Components;
using POSDesignDemo.Models.Request.UserLogin;
using POSDesignDemo.Controllers;
using Timer = System.Windows.Forms.Timer;

namespace POSDesignDemo.View
{
    public partial class FormLogin : Form
    {
        private readonly string UserName = "Admin";
        private readonly string Password = "aa";
        private bool passwordVisible = false;
        private readonly ProductController _service;
        public FormLogin()
        {
            _service = new ProductController();
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            InitBtnPasswordHide();
            Opacity = 0;
            AnimateFormIn();
            var style = new Style();
            style.AddShadowPanel(panelUserName);
            style.AddShadowPanel(panel3);
            ControlBox = false;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ItemComponent.AnimateWindow(this.Handle, 500, 0x00080000 | 0x00020000);
            this.Opacity = 1;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x00020000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                cp.ExStyle |= 0x02000000;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var userName = txtUserName.Text.Trim();
            var password = txtPassword.Text.Trim();

            Dictionary<Control, Func<string, string>> validationRules = new Dictionary<Control, Func<string, string>>
            {
                { spanUserName, _=> ValidateUsername(userName) },
                { spanPassword, _=> ValidatePassword(password) },
            };

            foreach (var rule in validationRules)
            {
                string validationMessage = rule.Value.Invoke(rule.Key.Text);
                rule.Key.Text = validationMessage;
            }

            if (validationRules.All(rule => string.IsNullOrEmpty(rule.Key.Text)))
            {
                this.Hide();
                // var form3Product = new Form3_Product();
                var mainView = new MainContainerView();
                mainView.StartPosition = FormStartPosition.CenterScreen;
                mainView.Closed += (s, args) => this.Close();
                mainView.Show();
                //AuthenticateUser(userName, password);
            }
        }

        public string GetUserRule()
        {
            try
            {
                var userLoginReq = new UserLoginReq
                {
                    Email = txtUserName.Text.Trim(),
                    Password = txtPassword.Text.Trim()
                };
                var user = _service.GetUser(userLoginReq).Result;
                if (user != null)
                {
                    this.Hide();
                    //var form3Product = new Form3_Product();
                   /* form3Product.StartPosition = FormStartPosition.CenterScreen;
                    form3Product.Closed += (s, args) => this.Close();
                    form3Product.Show();*/
                }
                else
                {
                    MessageBox.Show("Authentication failed. The email address or password is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return null!;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null!;
            }
        }
        public string ValidateUsername(string enteredUserName)
        {
            if (string.IsNullOrWhiteSpace(enteredUserName))
            {
                return "Username is required.";
            }
            else if (enteredUserName != UserName)
            {
                return "Username is incorrect.";
            }
            return string.Empty;
        }

        public string ValidatePassword(string enteredPassword)
        {
            if (string.IsNullOrWhiteSpace(enteredPassword))
            {
                return "Password is required.";
            }
            else if (enteredPassword != Password)
            {
                return "Password was not match.";
            }
            return string.Empty;
        }
        private async void AuthenticateUser(string userName, string password)
        {
            var authenticated = await AuthenticateUserAsync(userName, password);

            if (authenticated)
            {
                AnimateFormOut();
            }
            else
            {
                MessageBox.Show("Authentication failed. The email address or password is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<bool> AuthenticateUserAsync(string userName, string password)
        {
            var userLoginReq = new UserLoginReq
            {
                Email = userName,
                Password = password
            };

            var user = await _service.GetUser(userLoginReq);

            if (user != null)
            {
                this.Hide();
               /* var form3Product = new Form3_Product();
                form3Product.StartPosition = FormStartPosition.CenterScreen;
                form3Product.Closed += (s, args) => this.Close();
                form3Product.Show();*/
                return true;
            }

            return false;
        }
        private void AnimateFormOut()
        {
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += (s, e) =>
            {
                if (Opacity > 0)
                {
                    Opacity -= 0.05;
                }
                else
                {
                    timer.Stop();
                    this.Close();
                }
            };
            timer.Start();
        }
        private void AnimateFormIn()
        {
            Timer timer = new Timer();
            timer.Interval = 80;
            timer.Tick += (s, e) =>
            {
                if (Opacity < 1)
                {
                    Opacity += 0.05;
                }
                else
                {
                    timer.Stop();
                }
            };
            timer.Start();
        }

        private void InitBtnPasswordHide()
        {
            btn_Eye.Text = "👁";
            txtPassword.PasswordChar = '*';
        }
        private void BtnEye_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            if (passwordVisible)
            {
                btn_Eye.Text = "🔒";
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                btn_Eye.Text = "👁";
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        // Style Button
        private void BtnHideText_MouseHover(object sender, EventArgs e)
        {
            btn_Eye.ForeColor = Color.Blue;
            btn_Eye.BackColor = Color.White;
        }
        private void BtnShowText_MouseLeave(object sender, EventArgs e)
        {
            btn_Eye.BackColor = Color.White;
            btn_Eye.ForeColor = Color.FromArgb(128, 128, 255);
        }
        private void BtnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
            btnLogin.BackColor = Color.Blue;
        }
        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(128, 128, 255);
            btnLogin.ForeColor = Color.White;
        }
    }
}

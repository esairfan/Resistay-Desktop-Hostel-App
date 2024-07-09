using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resistay.UI
{
    public partial class LogOut : Form
    {
        public event EventHandler LoggedOut;
        public LogOut()
        {
            InitializeComponent();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LogoutBtn2_Click(object sender, EventArgs e)
        {
            Hide();
            OnLoggedOut(EventArgs.Empty);
            MainPage mainpage = new MainPage();
            mainpage.Show();
        }

        private void LogOut_Load(object sender, EventArgs e)
        {

        }
        protected virtual void OnLoggedOut(EventArgs e)
        {
            LoggedOut?.Invoke(this, e);
        }
    }
}

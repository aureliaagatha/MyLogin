using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLogin
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void btLogin_Click(object sender, EventArgs e)
        {
            var user = (from s in db.TB_M_USERs where s.username == txtUser.Text select s).First();
            if (user.password == txtPass.Text)
            {
                this.Hide();
                FormProduct a = new FormProduct();
                a.Show();
            }
            else
            {
                MessageBox.Show("Password Error");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            ResizeRedraw = true;
            dashboard_uc dashboard_Uc = new dashboard_uc();
            content_panel.Controls.Add(dashboard_Uc);
        }
        private void header_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void btn_list_Click(object sender, EventArgs e)
        {
            content_panel.Controls.Clear();
            list list = new list();
            content_panel.Controls.Add(list);
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            content_panel.Controls.Clear();
            dashboard_uc dashboard_Uc = new dashboard_uc();
            content_panel.Controls.Add(dashboard_Uc);
        }

        private void close_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

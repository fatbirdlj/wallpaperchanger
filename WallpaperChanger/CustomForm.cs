using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallpaperChanger
{
    public partial class CustomForm : Form
    {
        private Form1 formParent;
        public CustomForm()
        {
            InitializeComponent();
        }

        public CustomForm(Form1 form1)
        {
            InitializeComponent();
            this.formParent = form1;
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            int time;
            if (string.IsNullOrWhiteSpace(this.tbTime.Text))
            {
                MessageBox.Show("分钟数不能为空!");
                return;
            }
            try
            {
                time = Convert.ToInt32(this.tbTime.Text);
            }
            catch
            {
                MessageBox.Show("请输入整数！");
                return;
            }
            formParent.btnCustom.Text = time.ToString();
            this.Close();
        }
    }
}

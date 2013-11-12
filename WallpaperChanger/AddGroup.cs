using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WallPaperXmlBLL;

namespace WallpaperChanger
{
    public partial class FormAddGroup : Form
    {
        private string xmlpath = System.Configuration.ConfigurationManager.AppSettings["XmlPath"].ToString();
        public FormAddGroup()
        {
            InitializeComponent();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.tbGroup.Text))
            {
                MessageBox.Show("请填入组名！");
                return;
            }
            string groupName = this.tbGroup.Text;
            if (groupName.Contains(" ") || groupName.StartsWith("xml", true, System.Globalization.CultureInfo.CurrentCulture)
                || (int)groupName.ToCharArray()[0] < 65 || (int)groupName.ToCharArray()[0] > 122 || (int)groupName.ToCharArray()[0] > 90 && (int)groupName.ToCharArray()[0] < 97)
            {
                MessageBox.Show(@"
               名称可以含字母、数字以及其他的字符
               名称不能以数字或者标点符号开始
               名称不能以字符 xml（或者 XML、Xml）开始
               名称不能包含空格
                             ");
                return;
            }
            WallPaperBLL tempBLL = new WallPaperBLL(xmlpath);
            tempBLL.CreteGroup(this.tbGroup.Text);
            this.Close();
        }
    }
}

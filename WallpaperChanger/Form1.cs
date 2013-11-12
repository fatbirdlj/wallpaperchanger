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
    public partial class Form1 : Form
    {
        #region 参数
        private string filepath = "";
        private string xmlpath = System.Configuration.ConfigurationManager.AppSettings["XmlPath"].ToString();
        private int i = 0;
        private ListViewItem dragitem;
        #endregion

        public Form1()
        {
            InitializeComponent();
            this.lvWallPapers.View = View.LargeIcon;
            this.imglWallPapers.ImageSize = new Size(64, 64);
            this.lvWallPapers.MultiSelect = true;
            this.cmsNotify.Visible = false;
            this.nfiShow.Visible = false;
        }

        #region 事件
        #region Form事件
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshListView();
            RefreshCombox();
        } 
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.nfiShow.Visible = true;
            }
        }
        #endregion

        #region 按钮事件
        private void btnScan_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (fileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            filepath = fileDialog.FileName;
            this.pbShowSmallpic.Image = Image.FromFile(filepath);
        }

        private void btnSetasWallpaper_Click(object sender, EventArgs e)
        {
            if (this.lvWallPapers.SelectedItems.Count != 0)
            {
                string id = this.lvWallPapers.SelectedItems[0].Tag.ToString();
                WallPaperBLL tempBLL = new WallPaperBLL(xmlpath);
                WallPaper wallPaper = tempBLL.Get(id);
                if (wallPaper == null) return;
                filepath = wallPaper.Path;
                RadioButton checkedButton = this.gbStyle.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                WallPaperChangerEngine.SetWallPaper(filepath, (Style)Enum.Parse(typeof(Style), checkedButton.Text));
                MessageBox.Show("Set WallPaper Successfully!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.cmbGroup.SelectedItem == null)
            {
                MessageBox.Show("请选择组名！");
                return;
            }
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            fileDialog.Multiselect = true;
            if (fileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            WallPaperBLL tempBLL = new WallPaperBLL(xmlpath);
            foreach (var item in fileDialog.FileNames)
            {
                WallPaper temp = new WallPaper { Path = item };
                tempBLL.Create(temp, this.cmbGroup.SelectedItem.ToString());
            }
            RefreshListView();
        }  #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lvWallPapers.SelectedItems.Count != 0)
            {
                string id = this.lvWallPapers.SelectedItems[0].Tag.ToString();
                WallPaperBLL tempBLL = new WallPaperBLL(xmlpath);
                tempBLL.Delete(id);
                RefreshListView();
                //WallPaper wallPaper = tempBLL.Get(id);
                //if (wallPaper == null) return;
                //string path = wallPaper.Path;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (StartChanging())
            {
                ControlEnable(false);
            }
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm(this);
            form.ShowDialog();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            FormAddGroup form = new FormAddGroup();
            form.ShowDialog();
            RefreshCombox();
            RefreshListView();
        } 
        
        private void btnEnabled_Click(object sender, EventArgs e)
        {
            ControlEnable(true);
        }  
        
        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            if (this.cmbGroup.SelectedIndex == -1)
            {
                MessageBox.Show("请选择要删除的组！");
                return;
            }
            string groupName = this.cmbGroup.SelectedItem.ToString();
            WallPaperBLL tempBLL = new WallPaperBLL(xmlpath);
            tempBLL.DeleteGroup(groupName);
            RefreshListView();
            RefreshCombox();
        }
        #endregion

        #region ListView事件
        private void lvWallPapers_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Copy);
                dragitem = (ListViewItem)e.Item;
            }
        }

        private void lvWallPapers_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (dragitem != null)
                {
                    ListViewItem dropitem = this.lvWallPapers.GetItemAt(e.X, e.Y);
                    WallPaperBLL tempBLL = new WallPaperBLL(xmlpath);
                    if (dropitem != null)
                    {
                        tempBLL.UpdateExchange(dragitem.Tag.ToString(), dropitem.Tag.ToString());
                    }
                    else
                    {
                        dropitem = GetNearestItem(e.X, e.Y);
                        if (dropitem == null)
                        {
                            return;
                        }
                        else
                        {
                            tempBLL.InsertAfterWhileRemove(dragitem.Tag.ToString(), dropitem.Tag.ToString());
                        }
                    }

                    RefreshListView();
                    dragitem = null;
                }

            }
        }

        private void lvWallPapers_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lvWallPapers_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = e.Data.GetData(DataFormats.FileDrop) as string[];
            List<string> imagePaths = new List<string>();
            foreach (var item in filePaths)
            {
                if (IsImage(item.Split('.').Last()))
                {
                    imagePaths.Add(item);
                }
            }
            if (imagePaths.Count == 0)
            {
                return;
            }
            Point client = this.PointToClient(new Point(e.X, e.Y));
            ListViewItem dropItem = GetNearestItem(client.X - this.lvWallPapers.Left, client.Y - this.lvWallPapers.Top);
            WallPaperBLL tempBLL = new WallPaperBLL(xmlpath);
            if (dropItem == null)
            {
                tempBLL.CreteGroup("FromComputer");
                foreach (var item in imagePaths)
                {
                    WallPaper wallPaper = new WallPaper { Path = item };
                    tempBLL.Create(wallPaper, "FromComputer");
                }
                RefreshCombox();
            }
            else
            {
                imagePaths.Reverse();
                foreach (var item in imagePaths)
                {
                    WallPaper wallPaper = new WallPaper { Path = item };
                    tempBLL.InsertAfter(wallPaper, dropItem.Tag.ToString());
                }
            }

            RefreshListView();

        }  
        
        private void lvWallPapers_MouseMove(object sender, MouseEventArgs e)
        {
            this.labelX.Text = "X:" + e.X;
            this.labelY.Text = "Y:" + e.Y;
        }
        #endregion

        #region 其它事件
        private void timer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            WallPaperBLL tempBLL = new WallPaperBLL(xmlpath);
            int imageIndex = 0;

            if (this.cmbGroup.SelectedIndex != -1)
            {
                List<WallPaper> list = tempBLL.GetAll(this.cmbGroup.SelectedItem.ToString());
                int groupIndex = this.cmbGroup.SelectedIndex;
                List<string> preGroupNames = new List<string>();
                for (int j = 0; j < groupIndex; j++)
                {
                    preGroupNames.Add(this.cmbGroup.Items[j].ToString());
                }
                int originIndex = 0;
                foreach (var item in preGroupNames)
                {
                    originIndex += tempBLL.GetAll(item).Count;
                }

                imageIndex = i % (list.Count) + originIndex;
            }
            else
            {
                imageIndex = i % (this.lvWallPapers.Items.Count);
            }
            WallPaper wallPaper = tempBLL.Get(this.lvWallPapers.Items[imageIndex].Tag.ToString());
            string path = wallPaper.Path;
            RadioButton checkedButton = this.gbStyle.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            WallPaperChangerEngine.SetWallPaper(path, (Style)Enum.Parse(typeof(Style), checkedButton.Text));
            ++i;
        }

        private void nfiShow_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.nfiShow.Visible = false;
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.cmsNotify.Visible = true;
                if (this.timer.Enabled)
                {
                    this.cmsNotify.Items[1].Text = "Stop";
                }
                else
                {
                    this.cmsNotify.Items[1].Text = "Start";
                }
            }
        }

        private void tsmiShow_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.nfiShow.Visible = false;
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void tsmiStop_Click(object sender, EventArgs e)
        {
            if (!this.timer.Enabled)
            {
                if (!StartChanging())
                {
                    return;
                }
                else
                {
                    ControlEnable(false);
                };
            }
            else
            {
                this.timer.Enabled = !this.timer.Enabled;
            }
        }
        #endregion
        #endregion

        #region 辅助方法
        private void RefreshListView()
        {
            int i = 0;
            this.lvWallPapers.Clear();
            this.imglWallPapers.Images.Clear();
            WallPaperBLL tempBLL = new WallPaperBLL(xmlpath);
            List<WallPaper> allWallPapers = tempBLL.GetAll();
            foreach (var item in allWallPapers)
            {
                this.imglWallPapers.Images.Add(Image.FromFile(item.Path));
            }
            this.lvWallPapers.LargeImageList = this.imglWallPapers;
            List<string> groupNames = tempBLL.GetALLGroupName();
            foreach (var groupName in groupNames)
            {
                ListViewGroup group = new ListViewGroup(groupName);
                List<WallPaper> list = tempBLL.GetAll(groupName);
                foreach (var wallpaper in list)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = wallpaper.Id;
                    item.ImageIndex = i++;
                    item.Group = group;
                    this.lvWallPapers.Items.Add(item);
                }
                this.lvWallPapers.Groups.Add(group);
            }
        }

        private void RefreshCombox()
        {
            this.cmbGroup.Items.Clear();
            WallPaperBLL tempBLL = new WallPaperBLL(xmlpath);
            List<string> groups = tempBLL.GetALLGroupName();
            foreach (var item in groups)
            {
                this.cmbGroup.Items.Add(item);
            }
        }

        private bool StartChanging()
        {
            RadioButton checkedButton = this.gbTime.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
            {
                int minit = Convert.ToInt32(checkedButton.Tag);
                this.timer.Enabled = true;
                this.timer.Interval = minit * 5 * 1000;
                return true;
            }
            else if (!string.IsNullOrWhiteSpace(this.btnCustom.Text))
            {
                int minit = Convert.ToInt32(this.btnCustom.Text);
                this.timer.Enabled = true;
                this.timer.Interval = minit * 5 * 1000;
                return true;
            }
            MessageBox.Show("请选择时间间隔！");
            return false;
        }

        private ListViewItem GetNearestItem(int x, int y)
        {
            ListViewItem dropitem = null;
            if (this.lvWallPapers.Items.Count == 0)
            {
                return dragitem;
            }
            for (int i = 1; i < x; i++)
            {
                dropitem = this.lvWallPapers.GetItemAt(x - i, y);
                if (dropitem != null)
                {
                    return dropitem;
                }
            }
            for (int i = 1; i < y / this.lvWallPapers.Items[0].Bounds.Height; i++)
            {
                for (int j = 0; j < this.lvWallPapers.Width; j++)
                {
                    dropitem = this.lvWallPapers.GetItemAt(this.lvWallPapers.Width - j, y - this.lvWallPapers.Items[0].Bounds.Height * i);
                    if (dropitem != null)
                    {
                        return dropitem;
                    }
                }
            }
            return dropitem;
        }

        private void ControlEnable(bool b)
        {
            List<Control> controlLists = this.Controls.OfType<Control>().Except(new List<Control> { this.btnEnabled, this.cmsNotify }).ToList();
            foreach (var item in controlLists)
            {
                item.Enabled = b;
            }
        }

        private bool IsImage(string fileextension)
        {
            List<string> imageExtensions = new List<string> { 
              "JPG", "JPE", "BMP", "GIF", "PNG"
            };
            if (imageExtensions.Contains(fileextension.ToUpperInvariant()))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}

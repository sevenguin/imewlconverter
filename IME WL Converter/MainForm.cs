using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Studyzy.IMEWLConverter
{
    public partial class MainiForm : Form
    {
        public MainiForm()
        {
            InitializeComponent();
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txbWLPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                string wlTxt = ReadFile(txbWLPath.Text);
                IWordLibraryImport wl1 = GetImportInterface(cbxFrom.Text);

                var wlList = wl1.Import(wlTxt);
                IWordLibraryExport qq = GetExportInterface(cbxTo.Text);

                richTextBox1.Clear();
                richTextBox1.AppendText(qq.Export(wlList));
                if (MessageBox.Show("是否将导入的" + wlList.Count + "条词库保存到本地硬盘上？", "是否保存", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    saveFileDialog1.DefaultExt = ".txt";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (WriteFile(saveFileDialog1.FileName, qq.Encoding, richTextBox1.Text))
                        {
                            MessageBox.Show("保存成功，词库路径：" + saveFileDialog1.FileName);
                        }
                        else
                        {
                            MessageBox.Show("保存失败");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string ReadFile(string path)
        {
            using (StreamReader sr = new StreamReader(path,Encoding.Default))
            {
                return sr.ReadToEnd();
            }
        }
        private bool WriteFile(string path,Encoding coding, string content)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true, coding))
                {
                    sw.Write(content);
                    sw.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void MainiForm_Load(object sender, EventArgs e)
        {
            this.cbxFrom.Items.Add("百度手机");
            this.cbxFrom.Items.Add("QQ手机");
            this.cbxFrom.Items.Add("搜狗拼音");
            this.cbxFrom.Items.Add("搜狗五笔");
            this.cbxFrom.Items.Add("QQ拼音");
            this.cbxFrom.Items.Add("谷歌拼音");
            this.cbxFrom.Items.Add("搜狗细胞词库Txt");


            this.cbxTo.Items.Add("百度手机");
            this.cbxTo.Items.Add("QQ手机");
            this.cbxTo.Items.Add("搜狗拼音");
            this.cbxTo.Items.Add("搜狗五笔");
            this.cbxTo.Items.Add("QQ拼音");
            this.cbxTo.Items.Add("谷歌拼音");
        }
        private IWordLibraryExport GetExportInterface(string str)
        {
             switch (str)
            {
                case "百度手机": return new BaiduShouji();
                case "QQ手机": return new QQShouji();
                case "搜狗拼音": return new SougouPinyin();
                case "搜狗五笔": return new SougouWubi();
                case "QQ拼音": return new QQPinyin();
                case "谷歌拼音": return new GooglePinyin();
                default: throw new ArgumentException("导出词库的输入法错误");
            }
        }
        private IWordLibraryImport GetImportInterface(string str)
        {
            switch (str)
            {
                case "百度手机": return new BaiduShouji();
                case "QQ手机": return new QQShouji();
                case "搜狗拼音": return new SougouPinyin();
                case "搜狗五笔": return new SougouWubi();
                case "QQ拼音": return new QQPinyin();
                case "谷歌拼音": return new GooglePinyin();
                case "搜狗细胞词库Txt": return new SougouPinyinWL();
                default: throw new ArgumentException("导入词库的输入法错误");
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.Show();
        }
    }
}

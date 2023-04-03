using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace Background_countdown
{
    public partial class Form1 : Form
    {
        //ini配置文件读取

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        //壁纸更改和备份的前置
#if __STRING_BUILDER__
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SystemParametersInfo(int uAction, int uParam, StringBuilder lpvParam, int fuWinIni);
#else
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]

        public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
#endif
        private const int SPI_GETDESKWALLPAPER = 0x0073;

        string run_pathway = @System.IO.Directory.GetCurrentDirectory();
        public string INIPath = @System.IO.Directory.GetCurrentDirectory() + @"\config.ini";
        //Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public Form1()
        {
            if (File.Exists(INIPath))
            {
                try
                {
                    //WriteINI("User", "Self-starting", "on", INIPath);
                    string After_Day = ReadINI("User", "After-Day", INIPath);
                    string Meaning = ReadINI("User", "Meaning", INIPath);
                    string Self_starting = ReadINI("User", "Self-starting", INIPath);
                    string Differ = DifferenceTime(DateTime.Now.Date, Convert.ToDateTime(After_Day));
                    TxtImg(Meaning, Differ);
                    if (Self_starting == "on")
                    {
                        //应用壁纸
                        ChangeWallPaper(run_pathway + @"\base\base2.png");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("读取配置文件错误！请删除当前目录下config.ini并重新设置！");
                }

            }

            InitializeComponent();
        }
        //复制文件函数
        /// <summary>
        /// 复制文件，包括子目录：{地址}，{目标地址}
        /// </summary>
        /// <returns></returns>
        private static void CopyFile(string srcPath, string aimPath)
        {
            try
            {
                // 检查目标目录是否以目录分割字符结束如果不是则添加
                if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
                {
                    aimPath += Path.DirectorySeparatorChar;
                }
                // 判断目标目录是否存在如果不存在则新建
                if (!Directory.Exists(aimPath))
                {
                    Directory.CreateDirectory(aimPath);
                }
                // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                // 如果你指向copy目标文件下面的文件而不包含目录请使用下面的方法
                // string[] fileList = Directory.GetFiles（srcPath）；
                string[] fileList = Directory.GetFileSystemEntries(srcPath);
                // 遍历所有的文件和目录
                foreach (string file in fileList)
                {
                    // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                    if (Directory.Exists(file))
                    {
                        CopyFile(file, aimPath + Path.GetFileName(file));
                    }
                    // 否则直接Copy文件
                    else
                    {
                        File.Copy(file, aimPath + Path.GetFileName(file), true);
                    }
                }
            }
            catch (Exception e)
            {
                File.Copy(srcPath, aimPath);
            }
        }
        public void WriteINI(string name, string key, string value, string path)
        {
            WritePrivateProfileString(name, key, value, path);
        }
        public string ReadINI(string name, string key, string path)
        {
            StringBuilder sb = new StringBuilder(255);
            int ini = GetPrivateProfileString(name, key, "", sb, 255, path);
            return sb.ToString();
        }
        public static string DifferenceTime(DateTime TimeA, DateTime TimeB)
        {
            //timeA 表示需要计算
            TimeSpan ts = TimeB - TimeA;	//计算时间差
            string time = ts.TotalDays.ToString();	//将时间差转换为秒
            return time;
        }
        //时间差函数

        /// <summary>
        /// 获取Windows背景图片（地址）
        /// </summary>
        /// <returns></returns>
        public string GetWindowsBackgroundImage()
        {
#if __STRING_BUILDER__
            StringBuilder sb = new StringBuilder(300);
            SystemParametersInfo(SPI_GETDESKWALLPAPER, 300, sb, 0);
            return sb.ToString();
#else
            char[] sc = new char[300];
            string ss = new string(sc);
            SystemParametersInfo(SPI_GETDESKWALLPAPER, 300, ss, 0);
            return ss;
#endif
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        public static string[] AddTextToImg(string imgPath, string sImgPath, string text, float X, float Y, int alpha, int fontsize)
        {
            string[] resMsg = new[] { "成功", sImgPath };
            using (Image image = Image.FromFile(imgPath))
            {
                try
                {
                    Bitmap bitmap = new Bitmap(image);

                    int width = bitmap.Width, height = bitmap.Height;
                    Graphics g = Graphics.FromImage(bitmap);

                    g.DrawImage(bitmap, 0, 0);

                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;

                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                    g.DrawImage(image, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel);

                    Font crFont = new Font("微软雅黑", fontsize, FontStyle.Bold);
                    SizeF crSize = new SizeF();
                    crSize = g.MeasureString(text, crFont);

                    //背景位置(去掉了. 如果想用可以自己调一调 位置.)
                    //graphics.FillRectangle(new SolidBrush(Color.FromArgb(200, 255, 255, 255)), (width - crSize.Width) / 2, (height - crSize.Height) / 2, crSize.Width, crSize.Height);

                    SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(alpha, 0, 0, 0));

                    //将原点移动 到图片中点
                    g.TranslateTransform(width / 2 - X, height / 2 - Y);
                    //以原点为中心 转 -45度
                    //g.RotateTransform(-45);
                    // if (X != null,Y != null)
                    //{
                    //
                    //}

                    g.DrawString(text, crFont, semiTransBrush, new PointF(0, 0));

                    //保存文件
                    bitmap.Save(sImgPath, System.Drawing.Imaging.ImageFormat.Jpeg);

                }
                catch (Exception e)
                {

                    resMsg[0] = "失败";
                    resMsg[1] = e.Message;
                }
            }

            return resMsg;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public static bool ChangeWallPaper(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return false;
            }
            if (File.Exists(fileName) == false)
            {
                return false;
            }

            fileName = Path.GetFullPath(fileName);
            var nResult = SystemParametersInfo(20, 1, fileName, 0x1 | 0x2); //更换壁纸
            if (nResult == 0)
            {
                return false;
            }
            else
            {
                RegistryKey hk = Registry.CurrentUser;
                RegistryKey run = hk.CreateSubKey(@"Control Panel\Desktop\");
                run.SetValue("Wallpaper", fileName);

                return true;
            }
        }
        private static void TxtImg(string TXT, string days)
        {
            string run_pathway = @System.IO.Directory.GetCurrentDirectory();
            AddTextToImg(run_pathway + @"\base\base.png", run_pathway + @"\base\base1.png", days, 150, 65, 255, 120);
            AddTextToImg(run_pathway + @"\base\base1.png", run_pathway + @"\base\base2.png", TXT, 250, 310, 255, 70);
            File.Delete(run_pathway + @"\base\base1.png");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
        private void label6_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            this.键入1.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime Nowtime = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime Aftertime = Convert.ToDateTime(dateTimePicker2.Text);
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            string Background_File = run_pathway + @"\Background_Backup";
            if (!Directory.Exists(Background_File))
            {
                DialogResult d = MessageBox.Show("是否要备份当前壁纸?", "tips", MessageBoxButtons.OKCancel);
                if (d == DialogResult.OK)
                {
                    Directory.CreateDirectory(Background_File);
                    string NowBackground_way = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\Microsoft\Windows\Themes\CachedFiles";
                    CopyFile(NowBackground_way, Background_File);
                    MessageBox.Show("已备份在当前目录的Background_Backup中.");
                }
            }
            TxtImg(this.意义.Text, DifferenceTime(Nowtime, Aftertime));
            MessageBox.Show("已在当前目录下生成倒计时壁纸!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Background_File = run_pathway + @"\Background_Backup";
            if (!Directory.Exists(Background_File))
            {
                Directory.CreateDirectory(Background_File);
            }
            string NowBackground_way = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\Microsoft\Windows\Themes\CachedFiles";
            CopyFile(NowBackground_way, Background_File);
            MessageBox.Show("已备份在当前目录的Background_Backup中.");
        }

        private void 开启开机替换_Click(object sender, EventArgs e)
        {

            if (Convert.ToString(DateTime.Now.Date) != Convert.ToString(dateTimePicker2.Text) && 意义.Text != "")
            {
                WriteINI("User", "Self-starting", "on", INIPath);
                WriteINI("User", "Meaning", 意义.Text, INIPath);
                //After_Day = ReadINI("User", "After-Day", INIPath);
                WriteINI("User", "After-Day", dateTimePicker2.Text, INIPath);
                MessageBox.Show("请自行创建快捷方式指“启动”文件夹");
                //被火绒强杀了，加不了（悲
                //%USERPROFILE%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup
                //System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup");
                MessageBox.Show("已开启每日更新");
            }
            else
            {
                MessageBox.Show("未添加有效日期和字符串!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteINI("User", "Self-starting", "off", INIPath);
            WriteINI("User", "After-Day", "114514", INIPath);
        }
        private void 关闭开机替换_Click(object sender, EventArgs e)
        {

            WriteINI("User", "Self-starting", "off", INIPath);
            MessageBox.Show("已关闭每日更新");
        }
    }
}

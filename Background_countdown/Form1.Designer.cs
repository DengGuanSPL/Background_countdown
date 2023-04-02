namespace Background_countdown
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BY = new System.Windows.Forms.Label();
            this.生成背景图片 = new System.Windows.Forms.Button();
            this.开启开机替换 = new System.Windows.Forms.Button();
            this.备份当前壁纸 = new System.Windows.Forms.Button();
            this.关闭开机替换 = new System.Windows.Forms.Button();
            this.意义 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.键入1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 21);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(111, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(131, 21);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nowtime:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Aftertime:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BY
            // 
            this.BY.AutoSize = true;
            this.BY.Location = new System.Drawing.Point(477, 143);
            this.BY.Name = "BY";
            this.BY.Size = new System.Drawing.Size(113, 12);
            this.BY.TabIndex = 13;
            this.BY.Text = "Power by Deng_guan";
            this.BY.Click += new System.EventHandler(this.label7_Click);
            // 
            // 生成背景图片
            // 
            this.生成背景图片.Location = new System.Drawing.Point(315, 35);
            this.生成背景图片.Name = "生成背景图片";
            this.生成背景图片.Size = new System.Drawing.Size(118, 23);
            this.生成背景图片.TabIndex = 14;
            this.生成背景图片.Text = "生成背景图";
            this.生成背景图片.UseVisualStyleBackColor = true;
            this.生成背景图片.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // 开启开机替换
            // 
            this.开启开机替换.Location = new System.Drawing.Point(315, 74);
            this.开启开机替换.Name = "开启开机替换";
            this.开启开机替换.Size = new System.Drawing.Size(118, 23);
            this.开启开机替换.TabIndex = 15;
            this.开启开机替换.Text = "开启开机替换";
            this.开启开机替换.UseVisualStyleBackColor = true;
            this.开启开机替换.Click += new System.EventHandler(this.开启开机替换_Click);
            // 
            // 备份当前壁纸
            // 
            this.备份当前壁纸.Location = new System.Drawing.Point(462, 35);
            this.备份当前壁纸.Name = "备份当前壁纸";
            this.备份当前壁纸.Size = new System.Drawing.Size(118, 23);
            this.备份当前壁纸.TabIndex = 16;
            this.备份当前壁纸.Text = "备份当前壁纸";
            this.备份当前壁纸.UseVisualStyleBackColor = true;
            this.备份当前壁纸.Click += new System.EventHandler(this.button3_Click);
            // 
            // 关闭开机替换
            // 
            this.关闭开机替换.Location = new System.Drawing.Point(462, 74);
            this.关闭开机替换.Name = "关闭开机替换";
            this.关闭开机替换.Size = new System.Drawing.Size(118, 23);
            this.关闭开机替换.TabIndex = 17;
            this.关闭开机替换.Text = "关闭开机替换";
            this.关闭开机替换.UseVisualStyleBackColor = true;
            this.关闭开机替换.Click += new System.EventHandler(this.关闭开机替换_Click);
            // 
            // 意义
            // 
            this.意义.Location = new System.Drawing.Point(110, 89);
            this.意义.Name = "意义";
            this.意义.Size = new System.Drawing.Size(131, 21);
            this.意义.TabIndex = 18;
            this.意义.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "日期意义:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // 键入1
            // 
            this.键入1.AutoSize = true;
            this.键入1.Location = new System.Drawing.Point(114, 93);
            this.键入1.Name = "键入1";
            this.键入1.Size = new System.Drawing.Size(77, 12);
            this.键入1.TabIndex = 24;
            this.键入1.Text = "在此处键入..";
            this.键入1.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "ver:0.1.1.4514α";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 164);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.键入1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.意义);
            this.Controls.Add(this.关闭开机替换);
            this.Controls.Add(this.备份当前壁纸);
            this.Controls.Add(this.开启开机替换);
            this.Controls.Add(this.生成背景图片);
            this.Controls.Add(this.BY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BackgroundCountdownMaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BY;
        private System.Windows.Forms.Button 生成背景图片;
        private System.Windows.Forms.Button 开启开机替换;
        private System.Windows.Forms.Button 备份当前壁纸;
        private System.Windows.Forms.Button 关闭开机替换;
        private System.Windows.Forms.TextBox 意义;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label 键入1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}


namespace CG内效工具_量产程序测试上位机
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
            this.打开串口_button = new System.Windows.Forms.Button();
            this.串口号_comboBox = new System.Windows.Forms.ComboBox();
            this.刷新串口_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.命令字段_textBox = new System.Windows.Forms.TextBox();
            this.使能命令字段_checkBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.使能数据字段_checkBox = new System.Windows.Forms.CheckBox();
            this.数据字段_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.发送_button = new System.Windows.Forms.Button();
            this.数据字段HEX_checkBox = new System.Windows.Forms.CheckBox();
            this.命令字段HEX_checkBox = new System.Windows.Forms.CheckBox();
            this.接收数据_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HEX显示_checkBox = new System.Windows.Forms.CheckBox();
            this.波特率_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.清空接收内容_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 打开串口_button
            // 
            this.打开串口_button.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.打开串口_button.Location = new System.Drawing.Point(448, 21);
            this.打开串口_button.Name = "打开串口_button";
            this.打开串口_button.Size = new System.Drawing.Size(109, 28);
            this.打开串口_button.TabIndex = 0;
            this.打开串口_button.Text = "打开串口";
            this.打开串口_button.UseVisualStyleBackColor = true;
            this.打开串口_button.Click += new System.EventHandler(this.打开串口_button_Click);
            // 
            // 串口号_comboBox
            // 
            this.串口号_comboBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.串口号_comboBox.FormattingEnabled = true;
            this.串口号_comboBox.Location = new System.Drawing.Point(97, 20);
            this.串口号_comboBox.Name = "串口号_comboBox";
            this.串口号_comboBox.Size = new System.Drawing.Size(121, 28);
            this.串口号_comboBox.TabIndex = 1;
            // 
            // 刷新串口_button
            // 
            this.刷新串口_button.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.刷新串口_button.Location = new System.Drawing.Point(563, 21);
            this.刷新串口_button.Name = "刷新串口_button";
            this.刷新串口_button.Size = new System.Drawing.Size(115, 28);
            this.刷新串口_button.TabIndex = 2;
            this.刷新串口_button.Text = "刷新串口";
            this.刷新串口_button.UseVisualStyleBackColor = true;
            this.刷新串口_button.Click += new System.EventHandler(this.刷新串口_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "串口号:";
            // 
            // 命令字段_textBox
            // 
            this.命令字段_textBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.命令字段_textBox.Location = new System.Drawing.Point(121, 72);
            this.命令字段_textBox.Name = "命令字段_textBox";
            this.命令字段_textBox.Size = new System.Drawing.Size(420, 30);
            this.命令字段_textBox.TabIndex = 4;
            // 
            // 使能命令字段_checkBox
            // 
            this.使能命令字段_checkBox.AutoSize = true;
            this.使能命令字段_checkBox.Checked = true;
            this.使能命令字段_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.使能命令字段_checkBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.使能命令字段_checkBox.Location = new System.Drawing.Point(557, 77);
            this.使能命令字段_checkBox.Name = "使能命令字段_checkBox";
            this.使能命令字段_checkBox.Size = new System.Drawing.Size(128, 24);
            this.使能命令字段_checkBox.TabIndex = 5;
            this.使能命令字段_checkBox.Text = "使能本字段";
            this.使能命令字段_checkBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "命令字段:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "数据字段:";
            // 
            // 使能数据字段_checkBox
            // 
            this.使能数据字段_checkBox.AutoSize = true;
            this.使能数据字段_checkBox.Checked = true;
            this.使能数据字段_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.使能数据字段_checkBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.使能数据字段_checkBox.Location = new System.Drawing.Point(557, 113);
            this.使能数据字段_checkBox.Name = "使能数据字段_checkBox";
            this.使能数据字段_checkBox.Size = new System.Drawing.Size(128, 24);
            this.使能数据字段_checkBox.TabIndex = 8;
            this.使能数据字段_checkBox.Text = "使能本字段";
            this.使能数据字段_checkBox.UseVisualStyleBackColor = true;
            // 
            // 数据字段_textBox
            // 
            this.数据字段_textBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.数据字段_textBox.Location = new System.Drawing.Point(121, 108);
            this.数据字段_textBox.Name = "数据字段_textBox";
            this.数据字段_textBox.Size = new System.Drawing.Size(420, 30);
            this.数据字段_textBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 60);
            this.label4.TabIndex = 10;
            this.label4.Text = "注:本工具生成的串口数据包格式为:\r\n\r\n\"CG\"+命令长度(1byte)+命令内容+数据内容+校验和(2byte)\r\n\r\n程序中十六进制表达格式举例:01 02" +
    " 03 0A 0B 0C\r\n";
            // 
            // 发送_button
            // 
            this.发送_button.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.发送_button.Location = new System.Drawing.Point(774, 72);
            this.发送_button.Name = "发送_button";
            this.发送_button.Size = new System.Drawing.Size(82, 74);
            this.发送_button.TabIndex = 11;
            this.发送_button.Text = "发送";
            this.发送_button.UseVisualStyleBackColor = true;
            this.发送_button.Click += new System.EventHandler(this.发送_button_Click);
            // 
            // 数据字段HEX_checkBox
            // 
            this.数据字段HEX_checkBox.AutoSize = true;
            this.数据字段HEX_checkBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.数据字段HEX_checkBox.Location = new System.Drawing.Point(691, 114);
            this.数据字段HEX_checkBox.Name = "数据字段HEX_checkBox";
            this.数据字段HEX_checkBox.Size = new System.Drawing.Size(58, 24);
            this.数据字段HEX_checkBox.TabIndex = 13;
            this.数据字段HEX_checkBox.Text = "HEX";
            this.数据字段HEX_checkBox.UseVisualStyleBackColor = true;
            // 
            // 命令字段HEX_checkBox
            // 
            this.命令字段HEX_checkBox.AutoSize = true;
            this.命令字段HEX_checkBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.命令字段HEX_checkBox.Location = new System.Drawing.Point(691, 78);
            this.命令字段HEX_checkBox.Name = "命令字段HEX_checkBox";
            this.命令字段HEX_checkBox.Size = new System.Drawing.Size(58, 24);
            this.命令字段HEX_checkBox.TabIndex = 12;
            this.命令字段HEX_checkBox.Text = "HEX";
            this.命令字段HEX_checkBox.UseVisualStyleBackColor = true;
            // 
            // 接收数据_textBox
            // 
            this.接收数据_textBox.AcceptsReturn = true;
            this.接收数据_textBox.AcceptsTab = true;
            this.接收数据_textBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.接收数据_textBox.Location = new System.Drawing.Point(12, 244);
            this.接收数据_textBox.Multiline = true;
            this.接收数据_textBox.Name = "接收数据_textBox";
            this.接收数据_textBox.Size = new System.Drawing.Size(842, 178);
            this.接收数据_textBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(8, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "接收到的数据:";
            // 
            // HEX显示_checkBox
            // 
            this.HEX显示_checkBox.AutoSize = true;
            this.HEX显示_checkBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HEX显示_checkBox.Location = new System.Drawing.Point(758, 208);
            this.HEX显示_checkBox.Name = "HEX显示_checkBox";
            this.HEX显示_checkBox.Size = new System.Drawing.Size(98, 24);
            this.HEX显示_checkBox.TabIndex = 16;
            this.HEX显示_checkBox.Text = "HEX显示";
            this.HEX显示_checkBox.UseVisualStyleBackColor = true;
            // 
            // 波特率_comboBox
            // 
            this.波特率_comboBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.波特率_comboBox.FormattingEnabled = true;
            this.波特率_comboBox.Location = new System.Drawing.Point(307, 20);
            this.波特率_comboBox.Name = "波特率_comboBox";
            this.波特率_comboBox.Size = new System.Drawing.Size(135, 28);
            this.波特率_comboBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(222, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "波特率:";
            // 
            // 清空接收内容_button
            // 
            this.清空接收内容_button.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.清空接收内容_button.Location = new System.Drawing.Point(588, 201);
            this.清空接收内容_button.Name = "清空接收内容_button";
            this.清空接收内容_button.Size = new System.Drawing.Size(164, 37);
            this.清空接收内容_button.TabIndex = 19;
            this.清空接收内容_button.Text = "清空已接收内容";
            this.清空接收内容_button.UseVisualStyleBackColor = true;
            this.清空接收内容_button.Click += new System.EventHandler(this.清空接收内容_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 435);
            this.Controls.Add(this.清空接收内容_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.波特率_comboBox);
            this.Controls.Add(this.HEX显示_checkBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.接收数据_textBox);
            this.Controls.Add(this.数据字段HEX_checkBox);
            this.Controls.Add(this.命令字段HEX_checkBox);
            this.Controls.Add(this.发送_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.使能数据字段_checkBox);
            this.Controls.Add(this.数据字段_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.使能命令字段_checkBox);
            this.Controls.Add(this.命令字段_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.刷新串口_button);
            this.Controls.Add(this.串口号_comboBox);
            this.Controls.Add(this.打开串口_button);
            this.Name = "Form1";
            this.Text = "量产测试程序上位机";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 打开串口_button;
        private System.Windows.Forms.ComboBox 串口号_comboBox;
        private System.Windows.Forms.Button 刷新串口_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 命令字段_textBox;
        private System.Windows.Forms.CheckBox 使能命令字段_checkBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox 使能数据字段_checkBox;
        private System.Windows.Forms.TextBox 数据字段_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button 发送_button;
        private System.Windows.Forms.CheckBox 数据字段HEX_checkBox;
        private System.Windows.Forms.CheckBox 命令字段HEX_checkBox;
        private System.Windows.Forms.TextBox 接收数据_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox HEX显示_checkBox;
        private System.Windows.Forms.ComboBox 波特率_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button 清空接收内容_button;
    }
}


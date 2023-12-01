
namespace MultiAlarm
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelAlarm1 = new System.Windows.Forms.Label();
            this.labelAlarm2 = new System.Windows.Forms.Label();
            this.labelAlarm3 = new System.Windows.Forms.Label();
            this.checkBoxAlarm1 = new System.Windows.Forms.CheckBox();
            this.checkBoxAlarm3 = new System.Windows.Forms.CheckBox();
            this.checkBoxAlarm2 = new System.Windows.Forms.CheckBox();
            this.buttonSet1 = new System.Windows.Forms.Button();
            this.buttonSet2 = new System.Windows.Forms.Button();
            this.buttonSet3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(34, 35);
            this.labelTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(192, 48);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "12:59:59";
            // 
            // labelAlarm1
            // 
            this.labelAlarm1.AutoSize = true;
            this.labelAlarm1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAlarm1.Location = new System.Drawing.Point(57, 111);
            this.labelAlarm1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAlarm1.Name = "labelAlarm1";
            this.labelAlarm1.Size = new System.Drawing.Size(0, 28);
            this.labelAlarm1.TabIndex = 1;
            // 
            // labelAlarm2
            // 
            this.labelAlarm2.AutoSize = true;
            this.labelAlarm2.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAlarm2.Location = new System.Drawing.Point(57, 174);
            this.labelAlarm2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAlarm2.Name = "labelAlarm2";
            this.labelAlarm2.Size = new System.Drawing.Size(0, 28);
            this.labelAlarm2.TabIndex = 2;
            // 
            // labelAlarm3
            // 
            this.labelAlarm3.AutoSize = true;
            this.labelAlarm3.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAlarm3.Location = new System.Drawing.Point(57, 235);
            this.labelAlarm3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAlarm3.Name = "labelAlarm3";
            this.labelAlarm3.Size = new System.Drawing.Size(0, 28);
            this.labelAlarm3.TabIndex = 3;
            // 
            // checkBoxAlarm1
            // 
            this.checkBoxAlarm1.AutoSize = true;
            this.checkBoxAlarm1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxAlarm1.ForeColor = System.Drawing.Color.White;
            this.checkBoxAlarm1.Location = new System.Drawing.Point(12, 107);
            this.checkBoxAlarm1.Name = "checkBoxAlarm1";
            this.checkBoxAlarm1.Size = new System.Drawing.Size(112, 38);
            this.checkBoxAlarm1.TabIndex = 4;
            this.checkBoxAlarm1.Text = "00:00";
            this.checkBoxAlarm1.UseVisualStyleBackColor = true;
            this.checkBoxAlarm1.TextChanged += new System.EventHandler(this.checBoxAlarm1_TextChenged);
            // 
            // checkBoxAlarm3
            // 
            this.checkBoxAlarm3.AutoSize = true;
            this.checkBoxAlarm3.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxAlarm3.ForeColor = System.Drawing.Color.White;
            this.checkBoxAlarm3.Location = new System.Drawing.Point(12, 216);
            this.checkBoxAlarm3.Name = "checkBoxAlarm3";
            this.checkBoxAlarm3.Size = new System.Drawing.Size(112, 38);
            this.checkBoxAlarm3.TabIndex = 5;
            this.checkBoxAlarm3.Text = "00:00";
            this.checkBoxAlarm3.UseVisualStyleBackColor = true;
            this.checkBoxAlarm3.TextChanged += new System.EventHandler(this.checBoxAlarm3_TextChenged);
            // 
            // checkBoxAlarm2
            // 
            this.checkBoxAlarm2.AutoSize = true;
            this.checkBoxAlarm2.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxAlarm2.ForeColor = System.Drawing.Color.White;
            this.checkBoxAlarm2.Location = new System.Drawing.Point(12, 159);
            this.checkBoxAlarm2.Name = "checkBoxAlarm2";
            this.checkBoxAlarm2.Size = new System.Drawing.Size(112, 38);
            this.checkBoxAlarm2.TabIndex = 6;
            this.checkBoxAlarm2.Text = "00:00";
            this.checkBoxAlarm2.UseVisualStyleBackColor = true;
            this.checkBoxAlarm2.TextChanged += new System.EventHandler(this.checBoxAlarm2_TextChenged);
            // 
            // buttonSet1
            // 
            this.buttonSet1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSet1.Location = new System.Drawing.Point(126, 107);
            this.buttonSet1.Name = "buttonSet1";
            this.buttonSet1.Size = new System.Drawing.Size(120, 32);
            this.buttonSet1.TabIndex = 7;
            this.buttonSet1.Text = "設定";
            this.buttonSet1.UseVisualStyleBackColor = true;
            this.buttonSet1.Click += new System.EventHandler(this.buttonSet1_Click);
            // 
            // buttonSet2
            // 
            this.buttonSet2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSet2.Location = new System.Drawing.Point(126, 159);
            this.buttonSet2.Name = "buttonSet2";
            this.buttonSet2.Size = new System.Drawing.Size(120, 32);
            this.buttonSet2.TabIndex = 8;
            this.buttonSet2.Text = "設定";
            this.buttonSet2.UseVisualStyleBackColor = true;
            this.buttonSet2.Click += new System.EventHandler(this.buttonSet2_Click);
            // 
            // buttonSet3
            // 
            this.buttonSet3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSet3.Location = new System.Drawing.Point(126, 216);
            this.buttonSet3.Name = "buttonSet3";
            this.buttonSet3.Size = new System.Drawing.Size(120, 32);
            this.buttonSet3.TabIndex = 9;
            this.buttonSet3.Text = "設定";
            this.buttonSet3.UseVisualStyleBackColor = true;
            this.buttonSet3.Click += new System.EventHandler(this.buttonSet3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(267, 270);
            this.Controls.Add(this.buttonSet3);
            this.Controls.Add(this.buttonSet2);
            this.Controls.Add(this.buttonSet1);
            this.Controls.Add(this.checkBoxAlarm2);
            this.Controls.Add(this.checkBoxAlarm3);
            this.Controls.Add(this.checkBoxAlarm1);
            this.Controls.Add(this.labelAlarm3);
            this.Controls.Add(this.labelAlarm2);
            this.Controls.Add(this.labelAlarm1);
            this.Controls.Add(this.labelTime);
            this.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "アラーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelAlarm1;
        private System.Windows.Forms.Label labelAlarm2;
        private System.Windows.Forms.Label labelAlarm3;
        private System.Windows.Forms.CheckBox checkBoxAlarm1;
        private System.Windows.Forms.CheckBox checkBoxAlarm3;
        private System.Windows.Forms.CheckBox checkBoxAlarm2;
        private System.Windows.Forms.Button buttonSet1;
        private System.Windows.Forms.Button buttonSet2;
        private System.Windows.Forms.Button buttonSet3;
        private System.Windows.Forms.Timer timer1;
    }
}


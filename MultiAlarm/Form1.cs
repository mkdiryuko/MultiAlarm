using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiAlarm
{
    public partial class Form1 : Form
    {
        private bool alarmSetFlag1 = false; // アラームセット中フラグ
        private int  alarmHour1 = 0;         // アラーム時
        private int  alarmMinute1 = 0;       // アラーム分

        private bool alarmSetFlag2 = false; // アラームセット中フラグ
        private int alarmHour2 = 0;         // アラーム時
        private int alarmMinute2 = 0;       // アラーム分

        private bool alarmSetFlag3 = false; // アラームセット中フラグ
        private int alarmHour3 = 0;         // アラーム時
        private int alarmMinute3 = 0;       // アラーム分

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString(); // 長い形式の時刻の文字列形式に変換する（00:00:00）
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToLongTimeString();

            // アラーム1設定中
            if (alarmSetFlag1 == true)
            {
                // 設定時間になった
                if (alarmHour1 == now.Hour &&
                    alarmMinute1 == now.Minute)
                {
                    alarmSetFlag1 = false;
                    MessageBox.Show("時間ですよ!", "アラーム1",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBoxAlarm1.Checked = false;
                }
            }
            // アラーム2設定中
            if (alarmSetFlag2 == true)
            {
                // 設定時間になった
                if (alarmHour2 == now.Hour &&
                    alarmMinute2 == now.Minute)
                {
                    alarmSetFlag2 = false;
                    MessageBox.Show("時間ですよ!", "アラーム2",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBoxAlarm2.Checked = false;
                }
            }

            // アラーム3設定中
            if (alarmSetFlag3 == true)
            {
                // 設定時間になった
                if (alarmHour3 == now.Hour &&
                    alarmMinute3 == now.Minute)
                {
                    alarmSetFlag3 = false;
                    MessageBox.Show("時間ですよ!", "アラーム3",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBoxAlarm3.Checked = false;
                }
            }
        }

        private void buttonSet1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Form2のインスタンスを生成
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // アラームの設定
                alarmSetFlag1 = true;
                alarmHour1 = form2.alarmHour;
                alarmMinute1 = form2.alarmMinute;
                checkBoxAlarm1.Text = alarmHour1.ToString("00") + ":" + alarmMinute1.ToString("00");
            }
            form2.Dispose();
        }

        private void buttonSet2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Form2のインスタンスを生成
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // アラームの設定
                alarmSetFlag2 = true;
                alarmHour2 = form2.alarmHour;
                alarmMinute2 = form2.alarmMinute;
                checkBoxAlarm2.Text = alarmHour2.ToString("00") + ":" + alarmMinute2.ToString("00");
            }
            form2.Dispose();
        }

        private void buttonSet3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Form2のインスタンスを生成
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // アラームの設定
                alarmSetFlag3 = true;
                alarmHour3 = form2.alarmHour;
                alarmMinute3 = form2.alarmMinute;
                checkBoxAlarm3.Text = alarmHour3.ToString("00") + ":" + alarmMinute3.ToString("00");
            }
            form2.Dispose();
        }

        private void checBoxAlarm1_TextChenged(object sender, EventArgs e)
        {
            checkBoxAlarm1.Checked = true;
        }

        private void checBoxAlarm2_TextChenged(object sender, EventArgs e)
        {
            checkBoxAlarm2.Checked = true;
        }

        private void checBoxAlarm3_TextChenged(object sender, EventArgs e)
        {
            checkBoxAlarm3.Checked = true;
        }
    }
}

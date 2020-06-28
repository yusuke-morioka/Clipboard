using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fukidashi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //生成ボタン
        private void button1_Click(object sender, EventArgs e)
        {
            string Moji = textBox1.Text;
            int size = Encoding.GetEncoding("Shift_JIS").GetByteCount(Moji);
            //吹き出し上部
            var Fuki = new StringBuilder();
            Fuki.Append("_");
            Fuki.Insert(Fuki.Length, "人_", size / 2);
            Fuki.AppendLine();
            //吹き出し中部
            Fuki.Append(">　");
            Fuki.Append(Moji);
            Fuki.Append("　<");
            Fuki.AppendLine();
            //吹き出し下部
            Fuki.Append("¯");
            Fuki.Insert(Fuki.Length, "Y^", size / 2);
            Fuki.Append("¯");
            textBox2.Text = Fuki.ToString();
        }

        //スペースon/offボタン
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox Space = (CheckBox)sender;
            if (Space.Checked)　//オン
            {
                string Moji = textBox1.Text;
                int size = Encoding.GetEncoding("Shift_JIS").GetByteCount(Moji);
                //吹き出し上部
                var Fuki = new StringBuilder();
                Fuki.Append("_");
                Fuki.Insert(Fuki.Length, "人_", size / 2);
                Fuki.AppendLine();
                //吹き出し中部
                Fuki.Append(">　");
                Fuki.Insert(Fuki.Length, "　" , size  / 1);
                Fuki.Append("　<");
                Fuki.AppendLine();
                Fuki.Append(">　　");
                Fuki.Append(Moji);
                Fuki.Append("　　<");
                Fuki.AppendLine(); 
                Fuki.Append(">　");
                Fuki.Insert(Fuki.Length, "　", size / 1);
                Fuki.Append("　<");
                //吹き出し下部
                Fuki.AppendLine();
                Fuki.Append("¯");
                Fuki.Insert(Fuki.Length, "Y^", size / 2);
                Fuki.Append("¯");
                textBox2.Text = Fuki.ToString();
            }
            else　//オフ
            {
                string Moji = textBox1.Text;
                int size = Encoding.GetEncoding("Shift_JIS").GetByteCount(Moji);
                //吹き出し上部
                var Fuki = new StringBuilder();
                Fuki.Append("_");
                Fuki.Insert(Fuki.Length, "人_", size / 2);
                //Fuki.Append("＿");
                Fuki.AppendLine();
                //吹き出し中部
                Fuki.Append(">　");
                Fuki.Append(Moji);
                Fuki.Append("　<");
                Fuki.AppendLine();
                //吹き出し下部
                Fuki.Append("¯");
                Fuki.Insert(Fuki.Length, "Y^", size / 2);
                Fuki.Append("¯");
                textBox2.Text = Fuki.ToString();
            }
        }

        //コピーボタン
        private void button3_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text; // テキストボックスに入力されている値を取得する。
            if (text != "")
            {
                Clipboard.SetData(DataFormats.Text, text);
                MessageBox.Show("クリップボードにコピーしました。");
            }
        }
    }
}

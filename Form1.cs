using System.Security.Policy;
using System.IO;
using System.Text;
using Microsoft.VisualBasic.FileIO;

namespace tetsuota_marumasign_generator
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string X1 = (Convert.ToString(URL.Text));
            string X2 = (Convert.ToString(posX.Text));
            string X3 = (Convert.ToString(posY.Text));
            string X4 = (Convert.ToString(posZ.Text));
            string X5 = (Convert.ToString(sizeX.Text));
            string X6 = (Convert.ToString(sizeY.Text));
            string X7 = (Convert.ToString(rotationX.Text));
            string X8 = (Convert.ToString(rotationY.Text));
            string X9 = (Convert.ToString(rotationZ.Text));
            string output1 = ("|" + X2 + "|" + X3 + "|" + X4 + "|" + X5);
            string output2 = ("|" + X6 + "|" + X7 + "|" + X8 + "|" + X9);

            if ((output1 != null) && (output1.Length != 0))
            {
                Clipboard.SetText("/give @p minecraft:oak_sign{BlockEntityTag:{front_text:{messages:['[\"" + X1 + "\"]','[\"" + output1 + "\"]','[\"" + output2 + "\"]','[\"\"]']}}}");
                output_label.Text = (X1 + output1 + output2);
            }
            else
            {
                output_label.Text = ("空白が含まれています。すべて入力する必要があります。");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string X1 = (Convert.ToString(URL.Text));
            string X2 = (Convert.ToString(posX.Text));
            string X3 = (Convert.ToString(posY.Text));
            string X4 = (Convert.ToString(posZ.Text));
            string X5 = (Convert.ToString(sizeX.Text));
            string X6 = (Convert.ToString(sizeY.Text));
            string X7 = (Convert.ToString(rotationX.Text));
            string X8 = (Convert.ToString(rotationY.Text));
            string X9 = (Convert.ToString(rotationZ.Text));
            string output1 = ("|" + X2 + "|" + X3 + "|" + X4 + "|" + X5);
            string output2 = ("|" + X6 + "|" + X7 + "|" + X8 + "|" + X9);

            if ((output1 != null) && (output1.Length != 0))
            {
                Clipboard.SetText("/give @p oak_sign[block_entity_data={id:sign,front_text:{messages:['[\"" + X1 + "\"]','[\"" + output1 + "\"]','[\"" + output2 + "\"]','[\"\"]']}}]");
                output_label.Text = (X1 + output1 + output2);
            }
            else
            {
                output_label.Text = ("空白が含まれています。すべて入力する必要があります。");
            }
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            string X1 = (Convert.ToString(URL.Text));
            string X2 = (Convert.ToString(posX.Text));
            string X3 = (Convert.ToString(posY.Text));
            string X4 = (Convert.ToString(posZ.Text));
            string X5 = (Convert.ToString(sizeX.Text));
            string X6 = (Convert.ToString(sizeY.Text));
            string X7 = (Convert.ToString(rotationX.Text));
            string X8 = (Convert.ToString(rotationY.Text));
            string X9 = (Convert.ToString(rotationZ.Text));
            string output1 = ("|" + X2 + "|" + X3 + "|" + X4 + "|" + X5);
            string output2 = ("|" + X6 + "|" + X7 + "|" + X8 + "|" + X9);
            DialogResult result = MessageBox.Show("同じファイル名の場合、上書きされます。" +
                "よろしいですか？",
                "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                string file_name = (Convert.ToString(@filename_Textbox.Text));
                FileStream fs = File.Create(file_name + ".txt");
                fs.Close();
                string path = file_name + @".txt";
                using (StreamWriter writer = new StreamWriter(path, append: true))
                {
                    writer.WriteLine(X1);
                    writer.WriteLine(X2);
                    writer.WriteLine(X3);
                    writer.WriteLine(X4);
                    writer.WriteLine(X5);
                    writer.WriteLine(X6);
                    writer.WriteLine(X7);
                    writer.WriteLine(X8);
                    writer.WriteLine(X9);
                }

                MessageBox.Show("ファイルの保存に成功しました。",
                "情報",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string X1 = (Convert.ToString(URL.Text));
            string X2 = (Convert.ToString(posX.Text));
            string X3 = (Convert.ToString(posY.Text));
            string X4 = (Convert.ToString(posZ.Text));
            string X5 = (Convert.ToString(sizeX.Text));
            string X6 = (Convert.ToString(sizeY.Text));
            string X7 = (Convert.ToString(rotationX.Text));
            string X8 = (Convert.ToString(rotationY.Text));
            string X9 = (Convert.ToString(rotationZ.Text));
            string output1 = ("|" + X2 + "|" + X3 + "|" + X4 + "|" + X5);
            string output2 = ("|" + X6 + "|" + X7 + "|" + X8 + "|" + X9);
            string file_name = (Convert.ToString(@filename_Textbox.Text));
            if (!File.Exists(@file_name + ".txt"))
            {
                MessageBox.Show("指定されたファイルは存在しません。", "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                


                
                    // skipのパラメーターをいじると任意の行を指定できる
                string text_URL = File.ReadLines(@file_name + ".txt").Skip(0).First();
                URL.Text = (text_URL);
                string text_posX = File.ReadLines(@file_name + ".txt").Skip(1).First();
                posX.Text = (text_posX);
                string text_posY = File.ReadLines(@file_name + ".txt").Skip(2).First();
                posY.Text = (text_posY);
                string text_posZ = File.ReadLines(@file_name + ".txt").Skip(3).First();
                posZ.Text = (text_posZ);
                string text_sizeX = File.ReadLines(@file_name + ".txt").Skip(4).First();
                sizeX.Text = (text_sizeX);
                string text_sizeY = File.ReadLines(@file_name + ".txt").Skip(5).First();
                sizeY.Text = (text_sizeY);
                string text_rotationX = File.ReadLines(@file_name + ".txt").Skip(6).First();
                rotationX.Text = (text_rotationX);
                string text_rotationY = File.ReadLines(@file_name + ".txt").Skip(7).First();
                rotationY.Text = (text_rotationY);
                string text_rotationZ = File.ReadLines(@file_name + ".txt").Skip(8).First();
                rotationZ.Text = (text_rotationZ);



            }
        }
    }
}

namespace 加密器
{
    public partial class Form1 : Form
    {
        int key;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("先输入密钥，再进行转换。\n密钥为0~65535的数字。", "使用说明", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            key = ran.Next(65535);
            textkey.Text = Convert.ToString(key);
        }

        private void textkey_TextChanged(object sender, EventArgs e)
        {
            bool k = int.TryParse(textkey.Text, out key);
            if (k == true)
            {
                if (key < 0 || key > 65535)
                {
                    buttonconvert.Enabled = false;
                }
                else
                {
                    buttonconvert.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("请输入0~65535的数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textkey.Text = "0";
            }
        }

        private void buttonconvert_Click(object sender, EventArgs e)
        {
            key = Convert.ToInt32(textkey.Text);
            if (radioencrypt.Checked == true)
            {
                textBox2.Text = "";
                string text = textBox1.Text;
                foreach (int i in text)
                {
                    int asc = i + key;
                    if (asc > 65535)
                    {
                        asc -= 65536;
                    }
                    textBox2.Text += ((char)asc).ToString();
                }
            }
            else if (radiodecrypt.Checked == true)
            {
                textBox1.Text = "";
                string text = textBox2.Text;
                foreach (int i in text)
                {
                    int asc = i - key;
                    if (asc < 0)
                    {
                        asc += 65536;
                    }
                    textBox1.Text += ((char)asc).ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "明文";
            textBox2.Text = "密文";
            radioencrypt.Checked = true;
        }
    }
}
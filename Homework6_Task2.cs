using System;
using System.Windows.Forms;

namespace CSharpExercises
{
    // 任务2: 只允许英文字母输入的文本框
    public class Homework6_Task2 : Form
    {
        private TextBox txtLettersOnly;
        private Label lblHint;
        private Label lblTitle;

        public Homework6_Task2()
        {
            this.Text = "只允许英文字母输入";
            this.Width = 400;
            this.Height = 220;
            this.StartPosition = FormStartPosition.CenterScreen;

            // 标题标签
            lblTitle = new Label();
            lblTitle.Text = "请在下方文本框中输入（仅限英文字母）：";
            lblTitle.Width = 360;
            lblTitle.Height = 30;
            lblTitle.Left = 20;
            lblTitle.Top = 20;

            // 只允许英文字母的文本框
            txtLettersOnly = new TextBox();
            txtLettersOnly.Width = 340;
            txtLettersOnly.Height = 30;
            txtLettersOnly.Left = 20;
            txtLettersOnly.Top = 60;
            txtLettersOnly.Font = new System.Drawing.Font("Consolas", 12f);
            // 核心：注册 KeyPress 事件来过滤非英文字母输入
            txtLettersOnly.KeyPress += TxtLettersOnly_KeyPress;

            // 提示标签
            lblHint = new Label();
            lblHint.Text = "提示：数字、中文、标点等均不可输入";
            lblHint.Width = 360;
            lblHint.Height = 30;
            lblHint.Left = 20;
            lblHint.Top = 105;
            lblHint.ForeColor = System.Drawing.Color.Gray;

            this.Controls.Add(lblTitle);
            this.Controls.Add(txtLettersOnly);
            this.Controls.Add(lblHint);
        }

        private void TxtLettersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 核心逻辑：
            // 允许：英文字母 (a-z, A-Z) 和退格键（Backspace）
            // 其余一律拦截（设置 Handled = true 阻止字符进入文本框）
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;  // 阻止该字符输入
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Homework6_Task2());
        }
    }
}

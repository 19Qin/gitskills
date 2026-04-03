using System;
using System.Windows.Forms;

namespace CSharpExercises
{
    // 任务1: 点击按钮显示 Hello World + 姓名 + 学号
    public class Homework6_Task1 : Form
    {
        private Button btnHello;
        private Label lblResult;

        public Homework6_Task1()
        {
            // 窗体基本设置
            this.Text = "Hello World 程序";
            this.Width = 400;
            this.Height = 250;
            this.StartPosition = FormStartPosition.CenterScreen;

            // 创建按钮
            btnHello = new Button();
            btnHello.Text = "点击显示";
            btnHello.Width = 120;
            btnHello.Height = 40;
            btnHello.Left = 140;
            btnHello.Top = 60;
            btnHello.Click += BtnHello_Click;

            // 创建标签（用于显示结果）
            lblResult = new Label();
            lblResult.Text = "";
            lblResult.Width = 340;
            lblResult.Height = 60;
            lblResult.Left = 20;
            lblResult.Top = 130;
            lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblResult.Font = new System.Drawing.Font("Microsoft YaHei", 12f);

            // 将控件添加到窗体
            this.Controls.Add(btnHello);
            this.Controls.Add(lblResult);
        }

        private void BtnHello_Click(object sender, EventArgs e)
        {
            string name = "覃国晋";
            string studentId = "2204010315";
            lblResult.Text = $"Hello, World! {name} {studentId}";
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Homework6_Task1());
        }
    }
}

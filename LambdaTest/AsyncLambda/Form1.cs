using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// 异步 lambda
/// https://msdn.microsoft.com/zh-cn/library/bb397687.aspx#Anchor_2
/// </summary>
namespace AsyncLambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Submit.Click += async (sender, e) =>
            {
                await ExampleMethodAsync();
                textBox1.Text += "\r\nControl returned to Click event handler.\r\n";
            };
        }

        private void Submit_Click(object sender, EventArgs e)
        {

        }

        //private async void Submit_Click(object sender, EventArgs e)
        //{
            // ExampleMethodAsync returns a Task.
            //await ExampleMethodAsync();
            //textBox1.Text += "\r\nControl returned to Click event handler.\r\n";
        //}

        async Task ExampleMethodAsync()
        {
            // The following line simulates a task-returning asynchronous process.
            await Task.Delay(1000);
        }
    }
}

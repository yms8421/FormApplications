using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.FormControls
{
    public partial class frmControls : Form
    {
        public frmControls()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void frmControls_Load(object sender, EventArgs e)
        {
            var rowIndex = -1;
            var columnIndex = 0;

            for (int i = 0; i < 25; i++)
            {
                if (i % 5 == 0)
                {
                    rowIndex++;
                    columnIndex = 0;
                }
                var btn = new Button();
                btn.Name = $"btn{i}";
                btn.Text = rnd.Next(0,99).ToString();
                btn.Width = 50;
                btn.Height = 50;
                btn.Left = 100 + (columnIndex * 50);
                btn.Top = 10 + (rowIndex * 60);
                btn.Click += OnClick;
                this.Controls.Add(btn);
                columnIndex++;
            }
            
        }

        private void OnClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var number = int.Parse(btn.Text);
            if (number % 2 == 0)
            {
                btn.Visible = false;
                //btn.Dispose();//Ramden kaldır
            }
            else
            {
                btn.Enabled = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    var btn = ctrl as Button;
                    if (btn.Name != "btnRefresh")
                    {
                        btn.Enabled = true;
                        btn.Visible = true;
                        btn.Text = rnd.Next(0, 99).ToString();
                    }
                }
            }
        }
    }
}

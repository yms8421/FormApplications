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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Şehirler";
            cmbCities.Items.AddRange(new string[]
            {
                "Adana", "Balıkesir", "Adıyaman",
                "Afyon", "Ağrı", "Amasya", "Bursa"
            });

            cmbCities.Items.Add("Burdur");
            cmbCities.Items.Add("Bolu");
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            //this.Text = "Şehir Bilgisi X: " + this.Left + ", Y:" + this.Top; ==> aşağıdaki ile aynı
            this.Text = $"Şehir Bilgisi X: {this.Left} , Y: {this.Top}";
        }
        //sender: Event'i çağıran kontrol
        //e     : Event'e ait özel bilgiler
        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Form)//sender'ın tipi Form'un tipiyle aynı mı
            {
                ChangeColor();
                lblPointerLocation.Text = $"Pointer Location X: {e.X}, Y: {e.Y}";
            }
            else
            {
                var ctrl = sender as Control;//object tipinden control tipine dönüştür.
                lblPointerLocation.Text = $"Pointer Location X: {e.X + ctrl.Left}, Y: {e.Y + ctrl.Top}, Control : {ctrl.Name}";
            }
        }

        private void ChangeColor()
        {
            //HAP:
            //RGB: Red - Green - Blue
            //     255 -  255  - 255
            //     (255,50,255)

            var rnd = new Random();
            var red = rnd.Next(0, 255);
            var green = rnd.Next(0, 255);
            var blue = rnd.Next(0, 255);
            this.BackColor = Color.FromArgb(red, green, blue);
            stsMenu.BackColor = this.BackColor;
        }
    }   
}

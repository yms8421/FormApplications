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
    public partial class frmLottery : Form
    {
        public frmLottery()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            var numbers = new int[6];
            lstNumbers.Items.Clear();
            var r = new Random();
            #region Yöntem 1 : Keko Yöntem
            //for (int i = 0; i < 6; i++)
            //{
            //    var randomNumber = r.Next(1, 49);
            //    var check = false;
            //    for (int ik = 0; ik < i; ik++)
            //    {
            //        if (numbers[ik] == randomNumber)
            //        {
            //            check = true;
            //            i--;
            //            break;
            //        }
            //    }
            //    if (!check)
            //    {
            //        numbers[i] = randomNumber;
            //    }
            //} 
            #endregion

            #region Yöntem 2 : Cool Yöntem
            var count = 0;
            while (count < 6)
            {
                var randomNumber = r.Next(1, 49);
                var index = Array.IndexOf(numbers, randomNumber);
                if (index == -1)
                {
                    numbers[count] = randomNumber;
                    count++;
                }
            } 
            #endregion
            Array.Sort(numbers);
            foreach (int number in numbers)
            {
                lstNumbers.Items.Add(number);
            }
        }
    }
}

//KISS : Keep It Simple & Stupid

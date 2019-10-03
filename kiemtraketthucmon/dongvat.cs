using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace kiemtraketthucmon
{
    class dongvat
    {
        private string Keu;

        public string tiengkeu
        {
            get { return Keu; }
            set { Keu = value; }
        }

        public dongvat(string stKeu)
        {
            this.Keu = stKeu;
        }

        public dongvat()
        {
        }

        private string MauLong;

        public string DongvatMauLong
        {
            get
            {
                return MauLong;
            }
            set
            {
                MauLong = value;
            }
        }

        public string Dongvat { get; private set; }

        public virtual void Talk()
        {
            if (tiengkeu.Equals("Gâu gâu") && (DongvatMauLong.Equals("Trắng")))
                MessageBox.Show(this.Dongvat + " Tôi là Chó lông màu: " + this.DongvatMauLong);
            else if (tiengkeu.Equals("Meo meo") && (DongvatMauLong.Equals("Đen")))
                MessageBox.Show(this.Dongvat + " Tôi là Mèo lông màu: " + this.DongvatMauLong);
        }
    }
}

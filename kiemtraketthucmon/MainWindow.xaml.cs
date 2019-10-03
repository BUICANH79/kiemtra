using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kiemtraketthucmon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btncho_Click(object sender, RoutedEventArgs e)
        {
            cho cho = new cho();
            cho.tiengkeu = "Gâu gâu";
            cho.DongvatMauLong = "Trắng";
            cho.Talk();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            meo meo = new meo();
            meo.tiengkeu = "Meo meo";
            meo.DongvatMauLong = "Đen";
            meo.Talk();
        }
    }
}

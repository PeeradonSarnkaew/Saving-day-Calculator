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

namespace test01
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


        private void wantText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Cal(object sender, RoutedEventArgs e)
        {
            float income = float.Parse(incomeText.Text);
            float pay = float.Parse(payText.Text);
            float want = float.Parse(wantText.Text);
            int day = (int)(Math.Ceiling(want / (income - pay)));
            MessageBox.Show("การคำนวณเสร็จสิ้น");
            displayText.Text = day.ToString();
        }
    }
}

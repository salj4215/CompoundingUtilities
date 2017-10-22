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

namespace CompoundingUtilities
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

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double dblInitQuan;
                double dblAssay;
                double dblWater;
                double dblResult;

                dblInitQuan = double.Parse(tboxInitialAmount.Text);
                dblAssay = double.Parse(tboxPurity.Text);
                dblWater = double.Parse(tboxWater.Text);

                dblResult = dblInitQuan * (100 / dblAssay) * (100 / (100 - dblWater));
                txtOutcome.Text = dblResult.ToString("0.0000") + " grams";
            }
            catch (Exception caught)
            {
                txtOutcome.Text = "Please enter valid numbers for the values above";

            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tboxInitialAmount.Text = String.Empty;
            tboxPurity.Text = String.Empty;
            tboxWater.Text = String.Empty;
            txtOutcome.Text = String.Empty;
        }
    }
}

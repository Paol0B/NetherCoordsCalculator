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

namespace NetherCoordsCalculator
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
        private void txtOverWorldX_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtOverWorldX.Text != string.Empty && txtOverWorldX.Text != string.Empty)
            {
                txtNetherX.TextChanged -= txtNetherX_TextChanged;
                int.TryParse(txtOverWorldX.Text, out int coord);
                txtNetherX.Text = ConvertTo.ConvertToNether(coord).ToString();
                txtNetherX.TextChanged += txtNetherX_TextChanged;
            }
            else
            {
                txtNetherX.Text = string.Empty;
            }
            
        }

        private void txtOverWorldY_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtOverWorldY.Text != null && txtOverWorldY.Text != string.Empty)
            {
                txtNetherY.TextChanged -= txtNetherY_TextChanged;
                txtNetherY.Text = txtOverWorldY.Text;
                txtNetherY.TextChanged += txtNetherY_TextChanged;
            }
            else
                txtNetherY.Text = string.Empty;
        }

        private void txtOverWorldZ_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (txtOverWorldZ.Text != null && txtOverWorldZ.Text != string.Empty)
            {
                txtNetherZ.TextChanged -= txtNetherZ_TextChanged;
                int.TryParse (txtOverWorldZ.Text, out int coord);
                txtNetherZ.Text = ConvertTo.ConvertToNether(coord).ToString();
                txtNetherZ.TextChanged += txtNetherZ_TextChanged;
            }
            else
                txtNetherZ.Text = string.Empty;
        }

        private void txtNetherX_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNetherX.Text != null && txtNetherX.Text != string.Empty)
            {
                txtOverWorldX.TextChanged -= txtOverWorldX_TextChanged;
                int.TryParse (txtNetherX.Text, out int coord);
                txtOverWorldX.Text = ConvertTo.ConvertToNether(coord).ToString();
                txtOverWorldX.TextChanged += txtOverWorldX_TextChanged;
            }
            else
                txtOverWorldX.Text= string.Empty;
        }

        private void txtNetherY_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNetherY.Text != null && txtNetherY.Text != string.Empty)
            {
                txtOverWorldY.TextChanged -= txtOverWorldY_TextChanged;
                txtOverWorldY.Text = txtNetherY.Text;
                txtOverWorldY.TextChanged += txtOverWorldY_TextChanged;
            }
            else
                txtOverWorldY.Text= string.Empty;
        }

        private void txtNetherZ_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNetherZ.Text != null && txtNetherZ.Text != string.Empty)
            {
                txtOverWorldZ.TextChanged -= txtOverWorldZ_TextChanged;
                int.TryParse(txtNetherZ.Text, out int coord);
                txtOverWorldZ.Text = ConvertTo.ConvertToNether(coord).ToString();
                txtOverWorldZ.TextChanged += txtOverWorldZ_TextChanged;
            }
            else
                txtOverWorldZ.Text= string.Empty;
        }
    }
}

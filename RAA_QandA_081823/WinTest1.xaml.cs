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

namespace RAA_QandA_081823
{
    /// <summary>
    /// Interaction logic for WinTest1.xaml
    /// </summary>
    public partial class WinTest1 : Window
    {
        public WinTest1()
        {
            InitializeComponent();

            cmbItems2.SelectedIndex = 0;
            cmbItems.SelectedIndex = 0;
            
        }

        private void cmbItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox myCombo = sender as ComboBox;
            ComboBoxItem selectedItem = myCombo.SelectedItem as ComboBoxItem;
            string myString = selectedItem.Content as string;

            ComboBoxItem selectedItem2 = cmbItems2.SelectedItem as ComboBoxItem;
            string myString2 = selectedItem2.Content as string;

            if (myString == "Item 1" && myString2 == "Item A")
            {
                gbxItem1.Visibility = Visibility.Visible;
                gbxItem2.Visibility = Visibility.Collapsed;
                gbxItem3.Visibility = Visibility.Collapsed;
            }
            else if (myString == "Item 2")
            {
                gbxItem1.Visibility = Visibility.Collapsed;
                gbxItem2.Visibility = Visibility.Visible;
                gbxItem3.Visibility = Visibility.Collapsed;
            }
            else
            {
                gbxItem1.Visibility = Visibility.Collapsed;
                gbxItem2.Visibility = Visibility.Collapsed;
                gbxItem3.Visibility = Visibility.Visible;
            }


        }
    } 
}

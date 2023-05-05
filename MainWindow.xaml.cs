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

namespace ExperimentWitchControls
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

        private void numberTextBox_Text_Changed(object sender, TextChangedEventArgs e)
        {
            number.Text = numberTextBox.Text;

        }

        private void numberTextBox_PreviewTextImput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton a = (RadioButton)sender;//Inizjalizacja zmiennej i przypisanie jej obiektu wywołujacego
            
            number.Text = (string)a.Content;
        }

        private void smalSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number.Text = smalSlider.Value.ToString("0");
        }

        private void bigSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number.Text = bigSlider.Value.ToString("000-000-000");
        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(myListBox.SelectedItems is ListBoxItem listBoxItem)
            {
                number.Text = listBoxItem.Content.ToString();
            }
        }

        private void readOnlyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(readOnlyComboBox.SelectedItem is ListBoxItem listBoxItem)
            {
                number.Text = listBoxItem.Content.ToString();
            }
        }

        private void editableComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(sender is ComboBox comboBox)
            {
                number.Text = comboBox.Text;
            }
        }
    }
}

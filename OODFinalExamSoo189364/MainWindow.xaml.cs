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

namespace OODFinalExamSoo189364
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Phone.PhoneData db = new Phone.PhoneData();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Phoneslbx_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Phones
                        select p.Name;

            var phones = query.ToList();

            Phoneslbx.ItemsSource = query.ToList();
        }

        private void Phoneslbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone selected = Phoneslbx.SelectedItem as Phone;

            if (selected != null)
            {
                //take action

                Pricetxtblk.Text = selected.Price.ToString();
                var uri = new Uri("pack://application:,,,/images/" + selected.PhoneImage);
                Phoneimg.Source = new BitmapImage(uri);
            }
        }
    }
}

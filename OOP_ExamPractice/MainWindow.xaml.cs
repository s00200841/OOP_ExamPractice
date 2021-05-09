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

// https://github.com/s00200841/OOP_ExamPractice

namespace OOP_ExamPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Phone> AllPhones;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PhoneData db = new PhoneData();

            var query = from p in db.Phones
                        select p;
            AllPhones = query.ToList();

            lbxPhones.ItemsSource = AllPhones;
            
        }
        private void lbxPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone selectedPhone = lbxPhones.SelectedItem as Phone;

            if(selectedPhone != null)
            {
                img_Phone.Source = new BitmapImage(new Uri(selectedPhone.Phone_Image, UriKind.Relative));
                tblk_PhoneDetails.Text = $"{selectedPhone.Price:C}";
            }
        }

      
    }
}

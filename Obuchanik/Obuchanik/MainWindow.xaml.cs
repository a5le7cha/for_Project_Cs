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

namespace Obuchanik
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void Btn_clic_plus(object sender, RoutedEventArgs e)
        {
            Button btnAddNewTest = new Button();
            btnAddNewTest.Content = "Новый тест";
            StPnTests.Children.Add(btnAddNewTest);
=======
        //надо сделать, чтоб кнопки добавлялись в коде и имели общий дезайн
        //сделать общие настройки 
        private void Btn_clic_plus(object sender, RoutedEventArgs e)
        {

            Button btn1 = new Button();
            btn1.Content = "Test1";
            StPnTests.Children.Add(btn1);
>>>>>>> e8a8d4d9881c422c215a8b3b087e850373989abd
        }
    }
}

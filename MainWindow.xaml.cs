using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MaterialDesignColors;
using MaterialDesignThemes;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace WPF_Program
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

       


        //////////////
        /////////////////
        /////////////////

      
        private void ButtonClose_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
        /////////////////
        ////////////////////
        ////////////////////

        private void ButtonMin_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
       

        private void TopPanel_MouseMove(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        /////////////////
        /////////////////
        /////////////////
       
    }
}

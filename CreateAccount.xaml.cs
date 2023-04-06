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
using System.Windows.Shapes;

namespace WPF_Program
{
    /// <summary>
    /// Логика взаимодействия для CreateAccount.xaml
    /// </summary>
    
    public partial class CreateAccount : Window
    {
        public CreateAccount()
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
        private void Title_Copy3_MouseMove(object sender, MouseEventArgs e)
        {
            var b = Color.FromRgb(212, 212, 212);
            Title_Copy3.Foreground = new SolidColorBrush(b);
        }

        private void Title_Copy3_MouseLeave(object sender, MouseEventArgs e)
        {
            var b = Color.FromRgb(152, 152, 152);
            Title_Copy3.Foreground = new SolidColorBrush(b);
        }
        /////////////////
        /////////////////
        /////////////////
        private void PassField_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var b = Color.FromRgb(28, 30, 35);
            PassField.Background = new SolidColorBrush(b);
        }

        private void PassField_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var b = Color.FromRgb(57, 60, 68);
            PassField.Background = new SolidColorBrush(b);
        }
        /////////////////
        /////////////////
        /////////////////
        private void LoginField_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var b = Color.FromRgb(28, 30, 35);
            LoginField.Background = new SolidColorBrush(b);
        }

        private void LoginField_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var b = Color.FromRgb(57, 60, 68);
            LoginField.Background = new SolidColorBrush(b);
        }
        /////////////////
        /////////////////
        /////////////////
    }
}

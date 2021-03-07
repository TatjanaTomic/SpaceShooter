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

namespace SpaceShooter
{
    /// <summary>
    /// Interaction logic for FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        private readonly Thickness noBorder = new Thickness(0);
        private readonly Thickness border = new Thickness(3);
        private static int selectedTheme = 1;
        private static int selectedPlayer = 1;

        public FirstWindow()
        {
            InitializeComponent();
            LblTheme1.BorderThickness = border;
            LblPlayer1.BorderThickness = border;
        }

        private void BtnTheme1_Click(object sender, RoutedEventArgs e)
        {
            selectedTheme = 1;
            LblTheme1.BorderThickness = border;
            LblTheme2.BorderThickness = noBorder;
            LblTheme3.BorderThickness = noBorder;
        }

        private void BtnTheme2_Click(object sender, RoutedEventArgs e)
        {
            selectedTheme = 2;
            LblTheme1.BorderThickness = noBorder;
            LblTheme2.BorderThickness = border;
            LblTheme3.BorderThickness = noBorder;
        }

        private void BtnTheme3_Click(object sender, RoutedEventArgs e)
        {
            selectedTheme = 3;
            LblTheme1.BorderThickness = noBorder;
            LblTheme2.BorderThickness = noBorder;
            LblTheme3.BorderThickness = border;
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow(selectedTheme, selectedPlayer).ShowDialog();
        }

        private void BtnPlayer1_Click(object sender, RoutedEventArgs e)
        {
            selectedPlayer = 1;
            LblPlayer1.BorderThickness = border;
            LblPlayer2.BorderThickness = noBorder;
            LblPlayer3.BorderThickness = noBorder;
        }

        private void BtnPlayer2_Click(object sender, RoutedEventArgs e)
        {
            selectedPlayer = 2;
            LblPlayer1.BorderThickness = noBorder;
            LblPlayer2.BorderThickness = border;
            LblPlayer3.BorderThickness = noBorder;
        }

        private void Player3_Click(object sender, RoutedEventArgs e)
        {
            selectedPlayer = 3;
            LblPlayer1.BorderThickness = noBorder;
            LblPlayer2.BorderThickness = noBorder;
            LblPlayer3.BorderThickness = border;
        }
    }
}

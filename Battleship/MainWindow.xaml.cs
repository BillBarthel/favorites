﻿using System;
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

namespace Battleship
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

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            
            //TODO add user to database 
            Window battleship = new BattleshipWindow();
            battleship.Show();
            this.Close();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            //TODO check database if user exists
            Window battleship = new BattleshipWindow();
            battleship.Show();
            this.Close();
        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {
            //TODO get username from textbox
        }
    }
}

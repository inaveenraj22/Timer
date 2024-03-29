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
using System.Windows.Threading;

namespace Timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DispatcherTimer Timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

            Clock_lebel.Content = DateTime.Now;
            Date_lebel.Content = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            Timer.Tick +=new EventHandler(Timer_Tick);
            Timer.Interval = TimeSpan.FromSeconds(1);
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime dateController =  DateTime.Now;
            Clock_lebel.Content = dateController.Hour + " : " + dateController.Minute + " : " + dateController.Second;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}

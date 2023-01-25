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

namespace GrandOS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Application.Current.Resources["settingFontFamilyContent"] = new FontFamily("Segoe UI");

            InitializeComponent();

            _ = new Clock(clockLabel, "HH:mm", dateLabel, "D");

            _ = new ProgramGrid(appGird, 60, 10, 10);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AprioriAlgorithm;

namespace WPFClient.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var apriori = ContainerProvider.Container.GetExportedValue<IApriori>();
            IResult resultWindow = ContainerProvider.Container.GetExportedValue<IResult>();

            this.DataContext = new MainViewModel(apriori, resultWindow);
        }
    }
}

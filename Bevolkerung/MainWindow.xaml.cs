﻿using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bevolkerung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            List<Allampolgar> Lakossag = new();
        public MainWindow()
        {
            InitializeComponent();
            using StreamReader sr = new(
                    path: @"../../../src/bevölkerung.txt",
                    encoding: UTF8Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream) Lakossag.Add(new(sr.ReadLine()));

            for (int i = 1; i <= 40; i++) comboBox.Items.Add(i + ".");
            foreach (var lakos in Lakossag) MegoldasTeljes.Items.Add(lakos);
        }



       
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedItem is ComboBoxItem selectedItem)
            {
               
            }
        }


    }
}
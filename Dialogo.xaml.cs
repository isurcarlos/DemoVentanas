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

namespace DemoVentanas
{
    /// <summary>
    /// Interaction logic for Dialogo.xaml
    /// </summary>
    public partial class Dialogo : Window
    {
        public String respuesta = "";

        public Dialogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.respuesta = "Hola";
            //DialogResult = true;
            this.Close();
        }
    }
}

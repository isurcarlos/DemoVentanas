using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoVentanas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /* centrar en función a la pantalla 
            double screenHeight = SystemParameters.FullPrimaryScreenHeight;
            double screenWidth = SystemParameters.FullPrimaryScreenWidth;
            this.Top = (screenHeight - this.Height) / 2;
            this.Left = (screenWidth - this.Width) / 2; */

            /* centrar en función al área de trabajo 
            double workHeight = SystemParameters.WorkArea.Height;
            double workWidth = SystemParameters.WorkArea.Width;
            this.Top = (workHeight - this.Height) / 2;
            this.Left = (workWidth - this.Width) / 2; */

            /* posición utilizando settings */
            try
            {
                Rect bounds = Properties.Settings.Default.WindowPosition;
                this.Top = bounds.Top;
                this.Left = bounds.Left;
                // Restore the size only for a manually sized
                // window.
                if (this.SizeToContent == SizeToContent.Manual)
                {
                    this.Width = bounds.Width;
                    this.Height = bounds.Height;
                }
            }
            catch
            {
                MessageBox.Show("No settings stored.");
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.WindowPosition = this.RestoreBounds;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Ventana2 V2 = new Ventana2();
            V2.Owner = this;
            V2.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Dialogo Dialog = new Dialogo();
            Dialog.Owner = this;
            //Dialog.ShowDialog();

            /* esperando resultado */
            if (Dialog.ShowDialog() == true)
            {
                label1.Content = "Resultado: Se ingresaron opciones," + Dialog.respuesta;
            }
            else
            {
                label1.Content = "Resultado: No se ingresaron opciones";
            }
        }
    }
}

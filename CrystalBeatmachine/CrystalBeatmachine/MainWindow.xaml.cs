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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CrystalBeatmachine
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Sequencer moffugga;
        public MainWindow()
        {
            InitializeComponent();
<<<<<<< HEAD
            moffugga = new Sequencer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            moffugga.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            moffugga.Stop();
=======

            this.DataContext = new MainViewModel();

>>>>>>> 3e3804e26879c9bef03f725e6e59d1bc06429942
        }
    }
}

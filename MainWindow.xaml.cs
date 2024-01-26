using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace FileConcept
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

       
       
        private void saveas_Click(object sender, RoutedEventArgs e)
        {
           SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "text files|*.txt|document file|*.doc|all files|*.*";
            saveFileDialog.Title = "shamili";
            saveFileDialog.ShowDialog();
            File.WriteAllText(saveFileDialog.FileName,txtContent.Text);
        }

        private void new_Click(object sender, RoutedEventArgs e)
        {
            if (txtContent.Text!="")
            {
                MessageBoxResult msg = MessageBox.Show("Do You Want To Save This?", "Info", MessageBoxButton.YesNo);
                if (msg == MessageBoxResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "text files|*.txt|document file|*.doc|all files|*.*";
                    saveFileDialog.Title = "shamili";
                    saveFileDialog.ShowDialog();
                    File.WriteAllText(saveFileDialog.FileName, txtContent.Text);
                    txtContent.Clear();
                }
                else
                {
                    if (msg == MessageBoxResult.No)
                    {
                        txtContent.Clear();
                    }
                }
            }
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text files|*.txt|document file|*.doc|all files|*.*";
            openFileDialog.Title = "shamili";
            openFileDialog.ShowDialog();
            txtContent.Text = File.ReadAllText(openFileDialog.FileName);

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

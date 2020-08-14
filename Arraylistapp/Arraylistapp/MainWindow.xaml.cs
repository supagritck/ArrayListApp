using System;
using System.Collections;
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

namespace Arraylistapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList memberlist;
        public MainWindow()
        {
            InitializeComponent();
            memberlist = new ArrayList();
        }
        private void Addtxt_Click(object sender, RoutedEventArgs e)
        {
            memberlist.Add(Membertxt.Text);
            MessageBox.Show("Success add member name: " + Membertxt.Text);
            Membertxt.Text = "";
        }
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            memberlist.Remove(Membertxt.Text);
            MessageBox.Show("Success remove member name: " + Membertxt.Text);
            Membertxt.Text = "";
        }
        private void Showalltxt_Click(object sender, RoutedEventArgs e)
        {
            foreach (string datamember in memberlist)
            {
                MessageBox.Show("Name: " + datamember.ToString());
            }
            MessageBox.Show("Total members =  " + memberlist.Count.ToString());
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Lesson_7
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
        TreeView tree_sample2;

        private void ComboBox_IsKeyboardFocusWithinChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void cb_firstItem_Click(object sender, RoutedEventArgs e)
        {
            tree_sample.Items.Add(((ListBoxItem)lb_sample.Items[1]).Content);
        }

        private void cb_secondItem_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItem tree_sample2 = new TreeViewItem { Header = "Дерево 2 уровня" };
            tree_sample2.Items.Add(((ListBoxItem)lb_sample.Items[1]).Content);
            tree_sample2.Items.Add(((ListBoxItem)lb_sample.Items[2]).Content);
            tree_sample.Items.Add(tree_sample2);
        }

        private void cb_thirdItem_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItem tree_sample3 = new TreeViewItem { Header = "Дерево 3 уровня" };
            tree_sample3.Items.Add(((ListBoxItem)lb_sample.Items[3]).Content);
            tree_sample3.Items.Add(((ListBoxItem)lb_sample.Items[4]).Content);
            ((TreeViewItem)tree_sample.Items[1]).Items.Add(tree_sample3);
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            for (double i = pb.Minimum; i < pb.Maximum; i++)
            {
                forma.Height = i;
                pb.Value = i;

                //Thread.Sleep(20);

            }
        }

        private void sli_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            groupB.Height = e.NewValue * 50;
        }
        private void sli2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            groupB.Height = e.NewValue * 50;
        }
        private void sli_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            groupB.Height = e.NewValue * 50;
        }
    }
}

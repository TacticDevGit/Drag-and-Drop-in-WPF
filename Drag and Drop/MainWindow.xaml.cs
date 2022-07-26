using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Drag_and_Drop
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

        private void TargetPanel_Drop(object sender, DragEventArgs e)
        {
            var obj = e.Data.GetData(typeof(DisplayTile)) as DisplayTile;

            ((WrapPanel)(obj.Parent)).Children.Remove(obj);
            TargetPanel.Children.Add(obj);

        }
    }
}
  
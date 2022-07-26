using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Drag_and_Drop
{
    /// <summary>
    /// Interaction logic for DisplayTile.xaml
    /// </summary>
    public partial class DisplayTile : UserControl
    {


        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public static readonly DependencyProperty TextProperty =DependencyProperty.Register("Text", typeof(string), typeof(DisplayTile), new PropertyMetadata(null));


        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }
        public static readonly DependencyProperty ImageProperty =DependencyProperty.Register("Image", typeof(ImageSource), typeof(DisplayTile), new PropertyMetadata(null));



        public DisplayTile()
        {
            InitializeComponent();
            DataContext = this;           
        }




        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.LeftButton == MouseButtonState.Pressed)
            {

                DragDrop.DoDragDrop(this, this, DragDropEffects.Move);

            }
        }




    }
}

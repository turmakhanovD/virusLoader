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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnimationHW
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DoubleAnimation animation = new DoubleAnimation
            {
                From = rectangle.Width,
                To = rectangleOut.Width,
                Duration = new Duration(TimeSpan.FromSeconds(3))
                      
            };
            animation.Completed += new EventHandler(AnimCompleted);
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            Storyboard.SetTargetName(animation, rectangle.Name);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Rectangle.WidthProperty));
            storyboard.Begin(this);

            
        }

        private void AnimCompleted(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully downloaded!", "Success!");
        }
    }
}

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

namespace ControlLibrary
{
    /// <summary>
    /// Логика взаимодействия для AgeControl.xaml
    /// </summary>
    public partial class AgeControl : UserControl
    {
        public AgeControl()
        {
            InitializeComponent();
        }

        public int Age
        {
            get { return (int)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        public static readonly DependencyProperty AgeProperty =
            DependencyProperty.Register("Age", typeof(int), typeof(AgeControl), new PropertyMetadata(0, OnAgeChanged));

        private static void OnAgeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as AgeControl;
            if (control != null)
            {
                control.AgeTextBlock.Text = e.NewValue.ToString();
            }
        }
    }
}

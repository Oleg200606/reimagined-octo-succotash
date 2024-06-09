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
    /// Логика взаимодействия для PersonControl.xaml
    /// </summary>
    public partial class PersonControl : UserControl
    {
        public PersonControl()
        {
            InitializeComponent();

        }

        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        public static readonly DependencyProperty NameProperty =
            DependencyProperty.Register("Name", typeof(string), typeof(PersonControl), new PropertyMetadata(string.Empty, OnNameChanged));

        private static void OnNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as PersonControl;
            if (control != null)
            {
                control.NameTextBlock.Text = (string)e.NewValue;
            }
        }
    }
}
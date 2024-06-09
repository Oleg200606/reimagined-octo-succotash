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
using ControlLibrary;
using SerializationLibrary;

namespace pract8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PersonControl.Visibility = Visibility.Collapsed;
            AgeControl.Visibility = Visibility.Collapsed;
        }

        private const string FilePath = "data.json";

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var data = new Person
                {
                    Name = NameTextBox.Text,
                    Age = int.Parse(AgeTextBox.Text)
                };
                SerializeDeserialize.Serialize(data, FilePath);
                MessageBox.Show("Успешно сериализировано!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var deserializedData = SerializeDeserialize.Deserialize<Person>(FilePath);
                PersonControl.Name = deserializedData.Name;
                AgeControl.Age = deserializedData.Age;

                PersonControl.Visibility = Visibility.Visible;
                AgeControl.Visibility = Visibility.Visible;

                MessageBox.Show("Успешно десериализировано!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
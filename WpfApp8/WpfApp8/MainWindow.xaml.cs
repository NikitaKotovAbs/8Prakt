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
using SerializationLibrary;
namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Пример использования библиотеки сериализации/десериализации
            DataSerializer serializer = new DataSerializer();
            string filePath = "data.xml";

            // Сериализация
            MyData data = new MyData { Name = "John Doe", Age = 30 };
            serializer.Serialize(data, filePath);

            // Десериализация
            MyData deserializedData = serializer.Deserialize<MyData>(filePath);

            MessageBox.Show($"Name: {deserializedData.Name}, Age: {deserializedData.Age}");
        }
    }
    public class MyData
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

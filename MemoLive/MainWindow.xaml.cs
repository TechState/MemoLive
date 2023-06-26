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

namespace MemoLive
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string leftop = ""; // Левый операнд
        string operation = ""; // Знак операции
        string rightop = ""; // Правый операнд
        public MainWindow()
        {
            InitializeComponent();
            // Добавляем обработчик для всех кнопок на гриде
            foreach (UIElement c in LayoutRoot.Children)
            {
                if (c is Button)
                {
                    ((Button)c).Click += Button_Connect_Click;
                }
            }
        }

        private void Button_Connect_Click(object sender, RoutedEventArgs e)
        {
            ApplicationContext db = new ApplicationContext();

            Person person1 = new Person{ id = 12, Name = "Алексей" };
            Person person2= new Person{ id = 13, Name = "Киса" };

            db.Persons.AddRange(person1, person2);
            db.SaveChanges();


        }

        private void Query_Text_Changed(object sender, TextChangedEventArgs e)
        {
            //stack
        }

    }

    public class Phone
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Смартфон {this.Name}; цена: {this.Price}";
        }
    }
}

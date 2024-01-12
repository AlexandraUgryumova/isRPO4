using Item_Source.Model;
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
using System.IO;

namespace Item_Source
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow :Window
    {
        private List<Valute> valutes;
        public MainWindow ()
        {
            InitializeComponent();
            string xmlText = File.ReadAllText("data/Valute.xml");
            valutes = Data.ValuteLoader.LoadValutes(xmlText);

            valutes.Insert(0, new Valute ("RUB", "Российский Рубль", 1 ));
            // удалили DisplayMemberPath
            // ItemSource - источник элементов
            FromComboBox.ItemsSource = valutes;
            // DisplayMemberPath - свойство элемента, которое необходимо выводить
            FromComboBox.DisplayMemberPath = "Name";
            ToComboBox.ItemsSource = valutes;
            ToComboBox.DisplayMemberPath = "Name";
        }

        private void InputBox_PreviewTextInput (object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int x))
            {
                e.Handled = true;
            }
        }

        private void InputBox_TextChanged (object sender, TextChangedEventArgs e)
        {

        }
    }
}

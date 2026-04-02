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

namespace TK
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Вычислить".
        /// Считывает три числа из текстовых полей, проверяет корректность ввода,
        /// в зависимости от выбранного RadioButton вычисляет максимум или минимум
        /// и выводит результат в текстовый блок.
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие (кнопка).</param>
        /// <param name="e">Аргументы события.</param>
        public void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(Number1TextBox.Text, out double num1) ||
                !double.TryParse(Number2TextBox.Text, out double num2) ||
                !double.TryParse(Number3TextBox.Text, out double num3))
            {
                ResultTextBlock.Text = "Ошибка: введите корректные вещественные числа";
                return;
            }

            double result;

            if (MaxRadio.IsChecked == true)
            {
                result = Max(num1, num2, num3);
                ResultTextBlock.Text = $"Максимум: {result}";
            }
            else if (MinRadio.IsChecked == true)
            {
                result = Min(num1, num2, num3);
                ResultTextBlock.Text = $"Минимум: {result}";
            }
            else
            {
                ResultTextBlock.Text = "Ошибка: выберите операцию";
            }
        }

        /// <summary>
        /// Возвращает максимальное значение среди трёх вещественных чисел.
        /// </summary>
        /// <param name="num1">Первое вещественное число.</param>
        /// <param name="num2">Второе вещественное число.</param>
        /// <param name="num3">Третье вещественное число.</param>
        /// <returns>Максимальное из трёх переданных чисел.</returns>
        public double Max(double num1, double num2, double num3)
        {
            return Math.Max(Math.Max(num1, num2), num3);
        }

        /// <summary>
        /// Возвращает минимальное значение среди трёх вещественных чисел.
        /// </summary>
        /// <param name="num1">Первое вещественное число.</param>
        /// <param name="num2">Второе вещественное число.</param>
        /// <param name="num3">Третье вещественное число.</param>
        /// <returns>Минимальное из трёх переданных чисел.</returns>
        public double Min(double num1, double num2, double num3)
        {
            return Math.Min(Math.Min(num1, num2), num3);
        }
    }
}

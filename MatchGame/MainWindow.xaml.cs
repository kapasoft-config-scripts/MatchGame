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

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmodji = new List<string>()
                {
                "❤","❤",
                "😎","😎",
                "😂","😂",
                "🤷‍♂️","🤷‍♂️",
                "🎶","🎶",
                "🎂","🎂",
                "✨","✨",
                "🌹","🌹"

            };

            Random random= new Random();

            foreach (TextBlock textBox in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(animalEmodji.Count);
                string nextEmodji = animalEmodji[index];
                textBox.Text= nextEmodji;
                animalEmodji.RemoveAt(index);
            }
        }
    }
}

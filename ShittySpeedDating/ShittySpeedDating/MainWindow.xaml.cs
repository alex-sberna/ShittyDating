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
using ShittySpeedDating.Types;

namespace ShittySpeedDating
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddDateObject()
        {
            DateObject dateObject = new DateObject
            {
                Name = "Marvin",
                Personality = "Outgoing",
                Rating = 0,
                QuestionObject1 = new QuestionObject
                {
                    Question = "What is your favorite color?",
                    Answer1 = "Blue, like the ocean.",
                    Answer1Score = 1,
                    Answer2 = "Green, like grass.",
                    Answer2Score = 3,
                    Answer3 = "Yellow, like barf",
                    Answer3Score = -2,
                    Answer4 = "Red, like heart's blood.",
                    Answer4Score = 5
                },
                QuestionObject2 = new QuestionObject
                {

                },
            };
            
        }
    }
}

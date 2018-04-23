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
using System.Net;

namespace COMPLETE_HANGMAN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] goals = new string[9];
        string[] guessed = new string[9];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateLabel(int i, string content)
        {
            Label myLabel = new Label();
            myLabel.Content = content;
            Canvas.SetTop(myLabel, 85);
            Canvas.SetLeft(myLabel, (235 + (i * 10)));
            myCanvas.Children.Add(myLabel);
        }

        private void btnSetWord_Click(object sender, RoutedEventArgs e)
        {
            string tempWord = "Jesse"; 

           
            for (int i = 0; i < tempWord.Length; i++)
            {
                goals[i] = tempWord.Substring(i, 1);

            }

           
            
        
            MessageBox.Show("WORD HAS BEEN SET");
        }

        private void btnGuessLetter_Click(object sender, RoutedEventArgs e)
        {
            string tempLetter = txtLetterInput.Text;
            MessageBox.Show("Letter: " + tempLetter);
            for (int i = 0; i < 9; i++)
            {
                if (tempLetter == goals[i])
                {
                    guessed[i] = tempLetter;
                    CreateLabel(i, tempLetter);
                }
            }
        }
    }
}

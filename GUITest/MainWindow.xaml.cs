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

namespace GUITest
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

        private void PigLatinButton_Click(object sender, RoutedEventArgs e)
        {
            // ---Variables---
            String first, last;
            String firstPigLatin, lastPigLatin;

            this.FullNameLabel.Content =
                this.FirstNameTextBox.Text + " " + this.LastNameTextBox.Text;

            first = this.FirstNameTextBox.Text.ToLower();
            last = this.LastNameTextBox.Text.ToLower();

            // ---Process---
            // Substring index starts @ 0
            // Substring(1) = 2nd char to end of word
            // Substring(0, 1) = 1st char only
            firstPigLatin = first.Substring(1) + first.Substring(0, 1) + "ay";
            lastPigLatin = last.Substring(1) + last.Substring(0, 1) + "ay";
            // ToUpper method to capitalize 1st letter of each name
            firstPigLatin = char.ToUpper(firstPigLatin[0]) + firstPigLatin.Substring(1);
            lastPigLatin = char.ToUpper(lastPigLatin[0]) + lastPigLatin.Substring(1);

            this.FullPigLatinNameLabel.Content = firstPigLatin + " " + lastPigLatin;

            this.NameEnteredLabel.Visibility
                = this.FullNameLabel.Visibility
                = this.PigLatinLabel.Visibility
                = this.FullPigLatinNameLabel.Visibility
                = Visibility.Visible;
        }

    }
}

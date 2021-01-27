using System;
using System.Collections.Generic;
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
using naNote.Logic;
using naNote.Logic.Data;

namespace naNoteGUI
{
    /// <summary>
    /// Interaction logic for naNoteHome.xaml
    /// </summary>
    public partial class naNoteHome : Page
    {
        public naNoteHome()
        {
            InitializeComponent();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                var parsedText = new Parser(textBox1.Text, ((App)Application.Current).Catalog);
                textBlock1.Text = $"Action: {parsedText.Action} \n" +
                    $"Payload: {parsedText.Payload} \n" +
                    $"Categories: {String.Join(", ",parsedText.Categories)}";
                    
            }
        }
    }
}

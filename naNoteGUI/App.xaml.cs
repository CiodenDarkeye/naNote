using naNote.Logic.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace naNoteGUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Catalog Catalog;
        public App()
        {
            
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Catalog = new Catalog();
        }
    }
}

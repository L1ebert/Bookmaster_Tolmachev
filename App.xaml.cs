using Bookmaster_Tolmachev.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Bookmaster_Tolmachev
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Bookmaster_ТолмачевEntities context = new Bookmaster_ТолмачевEntities();
    }
}

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

namespace BuildingMaterials.Autorizatoins
{
    /// <summary>
    /// авторизация, если обычный пользователь, то попадает в магазин. если админ - в магазин с админ панелью
    /// 
    /// </summary>
    public partial class Autorizations : Page
    {
        public Autorizations()
        {
            InitializeComponent();
        }
    }
}

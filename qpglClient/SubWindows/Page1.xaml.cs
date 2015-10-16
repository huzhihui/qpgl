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

namespace qpglClient.SubWindows
{
    /// <summary>
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class Page1 : Page
    {
        public static  Page1 page;
        private Page1()
        {

            InitializeComponent();
        }
        public static Page1 getIndexPage()
        {
            if (page == null)
            {
                page = new Page1();
            }
            return page;
        }
    }
}

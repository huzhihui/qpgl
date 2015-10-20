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
using qpglClient.SubWindows;
using Xceed.Wpf.AvalonDock;
using Xceed.Wpf.AvalonDock.Layout;
namespace qpglClient
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            Frame _frame = new Frame();
            _frame.Content = Page1.getIndexPage();
            LayoutDocument layoutDoc = new LayoutDocument() { Title="测试而已"};
            layoutDoc.Content = _frame;
            if (!isActive(layoutDoc))
            {
                mainShowSpace.Children.Add(layoutDoc);
            }
        }

        private Boolean isActive(LayoutDocument layoutDoc)
        {
            Boolean flg = false;
            foreach (var i in mainShowSpace.Children)
            {
                ((LayoutDocument)i).IsActive = false;
                if (layoutDoc.Title== ((LayoutDocument)i).Title)
                {
                  if (!((LayoutDocument)i).IsActive)
                  {
                      ((LayoutDocument)i).IsActive = true;
                  }
                  flg = true;
                }
            }
            return flg;
        }

        private void PageTypeBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame _frame = new Frame();
            _frame.Content = new PartsTypePage();
            LayoutDocument layoutDoc = new LayoutDocument() { Title = "配件类型管理" };
            layoutDoc.Content = _frame;
            layoutDoc.IsActive = true;
            if (!isActive(layoutDoc))
            {
                mainShowSpace.Children.Add(layoutDoc);
            }
        }

        private void PartstypeEditorBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame _frame = new Frame();
            _frame.Content = new PartstypeEditor();
            LayoutDocument layoutDoc = new LayoutDocument() { Title = "配件详情管理" };
            layoutDoc.Content = _frame;
            layoutDoc.IsActive = true;
            if (!isActive(layoutDoc))
            {
                mainShowSpace.Children.Add(layoutDoc);
            }
        }
    }
}

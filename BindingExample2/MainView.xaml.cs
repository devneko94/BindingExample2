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

namespace BindingExample2
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainView : Window
    {
        private MainViewModel _viewModel = new MainViewModel();
        private int cnt = 6;

        public MainView()
        {
            InitializeComponent();
            DataContext = _viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Tag)
            {
                case "1":
                    _viewModel.名簿.Add(new MainModel { 番号 = cnt, 氏名 = $"新入社員{cnt}", 生年月日 = DateTime.Now.AddYears(-30 + cnt) });
                    cnt++;
                    break;
                case "3":
                    string msg = string.Empty;

                    foreach (var メンバー in _viewModel.名簿)
                    {
                        msg += $"番号: {メンバー.番号}, 氏名: {メンバー.氏名}, 生年月日: {メンバー.生年月日.ToString("d")}" + Environment.NewLine;
                    }

                    MessageBox.Show(msg);
                    break;
                default:
                    break;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingExample2
{
    public class MainViewModel
        : INotifyPropertyChanged
    {
        //public List<MainModel> 名簿
        public ObservableCollection<MainModel> 名簿 { get; set; } = new ObservableCollection<MainModel>();

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            for (int i = 1; i <= 5; i++)
            {
                名簿.Add(new MainModel { 番号 = i, 氏名 = $"新入社員{i}", 生年月日 = DateTime.Now.AddYears(-30 + i) });
            }
        }

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

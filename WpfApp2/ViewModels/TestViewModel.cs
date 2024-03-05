using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.ViewModels
{
    public partial class TestViewModel:ObservableObject
    {
        [ObservableProperty]
        private string title = "默认title";
        public TestViewModel() { }
    }
}

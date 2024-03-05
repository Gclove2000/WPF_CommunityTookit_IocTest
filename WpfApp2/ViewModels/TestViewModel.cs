using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.ViewModels
{
    public partial class TestViewModel : ObservableObject
    {
        [ObservableProperty]
        private string singletonTitle = "默认singleton";

        [ObservableProperty]
        private string transientTitle = "默认transient";

        public TestViewModel() { }
    }
}

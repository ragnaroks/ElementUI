using Prism.Mvvm;

namespace ElementDemo.ViewModels{
    public class MainWindowViewModel : BindableBase{
        private string _title = "ElementUI DEMO";
        /// <summary>
        /// 窗口标题
        /// </summary>
        public string Title{
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(){
        }
    }
}

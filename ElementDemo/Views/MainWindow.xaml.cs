using Prism.Regions;
using System.Windows;

namespace ElementDemo.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window{
        private IRegionManager RegionManager { get;set;}
        private ButtonView ButtonView { get;set;}

        public MainWindow(IRegionManager _RegionManager){
            InitializeComponent();
            this.Loaded += this.MainWindow_Loaded;
            RegionManager =_RegionManager;
            ButtonView=new ButtonView();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e){
            IRegion Region = RegionManager.Regions["Region_Button"];
            Region.Add(ButtonView, "ButtonView");
            //Region.Deactivate(Region.GetView("ButtonView"));
        }
    }
}

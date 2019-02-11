using System;
using System.Windows;
using System.Windows.Controls;

namespace ElementDemo.Views {
    /// <summary>
    /// Button.xaml 的交互逻辑
    /// </summary>
    public partial class ButtonView : UserControl{
        public ButtonView(){
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e) {
            if (!(Boolean)this.CheckBox_OnEvent_Button.IsChecked) { return;}
            ElementUI.Button _this =sender as ElementUI.Button;
            MessageBox.Show(_this.Text+"\n"+_this.ToolTip?.ToString(),"标准按钮 Button",MessageBoxButton.OK,MessageBoxImage.Information,MessageBoxResult.OK);
        }

        private void PlainButton_Click(object sender, EventArgs e) {
            if (!(Boolean)this.CheckBox_OnEvent_PlainButton.IsChecked) { return;}
            ElementUI.PlainButton _this =sender as ElementUI.PlainButton;
            MessageBox.Show(_this.Text+"\n"+_this.ToolTip?.ToString(),"朴素按钮 PlainButton",MessageBoxButton.OK,MessageBoxImage.Information,MessageBoxResult.OK);
        }

        private void CircleButton_Click(object sender, EventArgs e) {
            if (!(Boolean)this.CheckBox_OnEvent_CircleButton.IsChecked) { return;}
            ElementUI.CircleButton _this =sender as ElementUI.CircleButton;
            MessageBox.Show(_this.Text+"\n"+_this.ToolTip?.ToString(),"圆形按钮 CircleButton",MessageBoxButton.OK,MessageBoxImage.Information,MessageBoxResult.OK);
        }
    }
}

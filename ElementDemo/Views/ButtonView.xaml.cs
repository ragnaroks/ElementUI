﻿using System;
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
using ElementUI;

namespace ElementDemo.Views
{
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
            MessageBox.Show(_this.Text+"\n"+_this.ToolTip?.ToString(),"标准按钮",MessageBoxButton.OK,MessageBoxImage.Information,MessageBoxResult.OK);
        }

        private void PlainButton_Click(object sender, EventArgs e) {
            if (!(Boolean)this.CheckBox_OnEvent_PlainButton.IsChecked) { return;}
            ElementUI.PlainButton _this =sender as ElementUI.PlainButton;
            MessageBox.Show(_this.Text+"\n"+_this.ToolTip?.ToString(),"朴素按钮",MessageBoxButton.OK,MessageBoxImage.Information,MessageBoxResult.OK);
        }
    }
}

﻿using System;
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

        private void TextButton_Click(object sender,EventArgs e) {
            if (!(Boolean)this.CheckBox_OnEvent_TextButton.IsChecked) { return;}
            ElementUI.TextButton _this =sender as ElementUI.TextButton;
            MessageBox.Show(_this.Text,"文本按钮 TextButton",MessageBoxButton.OK,MessageBoxImage.Information,MessageBoxResult.OK);
        }

        private void ImageButton_Click(object sender,EventArgs e) {
            if (!(Boolean)this.CheckBox_OnEvent_ImageButton.IsChecked) { return;}
            ElementUI.ImageButton _this =sender as ElementUI.ImageButton;
            MessageBox.Show(_this.Text,"图片按钮 ImageButton",MessageBoxButton.OK,MessageBoxImage.Information,MessageBoxResult.OK);
        }
    }
}

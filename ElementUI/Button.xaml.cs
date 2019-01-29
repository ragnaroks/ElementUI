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

namespace ElementUI{
    /// <summary>
    /// Button.xaml 的交互逻辑
    /// </summary>
    public partial class Button : UserControl{
        /// <summary>
        /// 按钮文本
        /// </summary>
        public String Text {
            get { return (String)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        private static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(String), typeof(Button), new PropertyMetadata("按钮"));
        /// <summary>
        /// 按钮类型
        /// </summary>
        public String Type {
            get { return (String)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }
        private static readonly DependencyProperty TypeProperty =DependencyProperty.Register("Type", typeof(String), typeof(Button), new PropertyMetadata(String.Empty));
        /// <summary>
        /// 文本颜色
        /// </summary>
        public Color TextColor {
            get { return (Color)GetValue(TextColorProperty); }
            private set { SetValue(TextColorProperty, value); }
        }
        private static readonly DependencyProperty TextColorProperty =DependencyProperty.Register("TextColor", typeof(Color), typeof(Button), new PropertyMetadata(new Color(){R=96,G=98,B=102,A=255}));
        /// <summary>
        /// 文本颜色,悬浮
        /// </summary>
        public Color TextColorHover {
            get { return (Color)GetValue(TextColorHoverProperty); }
            private set { SetValue(TextColorHoverProperty, value); }
        }
        private static readonly DependencyProperty TextColorHoverProperty = DependencyProperty.Register("TextColorHover", typeof(Color), typeof(Button), new PropertyMetadata(new Color() { R = 64, G =158, B =255, A = 255 }));
        /// <summary>
        /// 背景色
        /// </summary>
        public Color BackgroundColor {
            get { return (Color)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }
        public static readonly DependencyProperty BackgroundColorProperty =DependencyProperty.Register("BackgroundColor", typeof(Color), typeof(Button), new PropertyMetadata(new Color(){R=255,G=255,B=255,A=255}));
        /// <summary>
        /// 背景色,悬浮
        /// </summary>
        public Color BackgroundColorHover {
            get { return (Color)GetValue(BackgroundColorHoverProperty); }
            set { SetValue(BackgroundColorHoverProperty, value); }
        }
        public static readonly DependencyProperty BackgroundColorHoverProperty =DependencyProperty.Register("BackgroundColorHover", typeof(Color), typeof(Button), new PropertyMetadata(new Color(){R=236,G=245,B=255,A=255}));
        /// <summary>
        /// 边框颜色
        /// </summary>
        public Color BorderColor {
            get { return (Color)GetValue(BorderColorProperty); }
            private set { SetValue(BorderColorProperty, value); }
        }
        private static readonly DependencyProperty BorderColorProperty = DependencyProperty.Register("BorderColor", typeof(Color), typeof(Button), new PropertyMetadata(new Color() { R = 220, G = 223, B = 230, A = 255 }));
        /// <summary>
        /// 边框颜色,悬浮
        /// </summary>
        public Color BorderColorHover {
            get { return (Color)GetValue(BorderColorHoverProperty); }
            private set { SetValue(BorderColorHoverProperty, value); }
        }
        private static readonly DependencyProperty BorderColorHoverProperty = DependencyProperty.Register("BorderColorHover", typeof(Color), typeof(Button), new PropertyMetadata(new Color() { R = 198, G = 226, B = 255, A = 255 }));


        /// <summary>
        /// 构造
        /// </summary>
        public Button(){
            InitializeComponent();
            this.Loaded += this.Button_Loaded;
        }
        /// <summary>
        /// 加载完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Loaded(object sender, RoutedEventArgs e){
            this.TextColor=ApplyTextColor();
            this.TextColorHover=ApplyTextColorHover();
            this.BorderColor = ApplyBorderColor();
            this.BorderColorHover = ApplyBorderColorHover();
            this.BackgroundColor= ApplyBackgroundColor();
            this.BackgroundColorHover= ApplyBackgroundColorHover();
        }

        /// <summary>
        /// 应用边框颜色
        /// </summary>
        /// <returns></returns>
        private Color ApplyBorderColor(){
            Color c = new Color();
            c.A = 255;
            switch (this.Type){
                case "primary": c.R = 64; c.G = 158; c.B = 255; break;
                case "success": c.R = 103; c.G = 194; c.B = 58; break;
                case "info": c.R = 144; c.G = 147; c.B = 153; break;
                case "warning": c.R = 230; c.G = 162; c.B = 60;break;
                case "danger": c.R = 245; c.G = 108; c.B = 108; break;
                case "defualt":
                default: c.R = 220; c.G = 223; c.B = 230; break;
            }
            return c;
        }
        /// <summary>
        /// 应用边框颜色,悬浮
        /// </summary>
        /// <returns></returns>
        private Color ApplyBorderColorHover(){
            Color c = new Color();
            c.A = 255;
            switch (this.Type){
                case "primary": c.R = 102; c.G = 177; c.B = 255; break;
                case "success": c.R = 133; c.G = 206; c.B = 97; break;
                case "info": c.R = 166; c.G = 169; c.B = 173; break;
                case "warning": c.R = 235; c.G = 181; c.B = 99;break;
                case "danger": c.R = 247; c.G = 137; c.B = 137; break;
                case "defualt":
                default: c.R = 198; c.G = 226; c.B = 255; break;
            }
            return c;
        }
        /// <summary>
        /// 应用文本颜色
        /// </summary>
        /// <returns></returns>
        private Color ApplyTextColor(){
            Color c = new Color();
            c.A = 255;
            switch (this.Type){
                case "primary":
                case "success":
                case "info":
                case "warning":
                case "danger": c.R = 255; c.G = 255; c.B = 255; break;
                case "defualt":
                default: c.R = 96; c.G = 98; c.B = 102; break;
            }
            return c;
        }
        /// <summary>
        /// 应用文本颜色,悬浮
        /// </summary>
        /// <returns></returns>
        private Color ApplyTextColorHover(){
            Color c = new Color();
            c.A = 255;
            switch (this.Type){
                case "primary":
                case "success":
                case "info":
                case "warning":
                case "danger": c.R = 255; c.G = 255; c.B = 255; break;
                case "defualt":
                default: c.R = 64; c.G = 158; c.B = 255; break;
            }
            return c;
        }
        /// <summary>
        /// 应用背景色
        /// </summary>
        /// <returns></returns>
        private Color ApplyBackgroundColor(){
            Color c = new Color();
            c.A = 255;
            switch (this.Type){
                case "primary":c.R=64;c.G=158;c.B=255;break;
                case "success": c.R = 103; c.G = 194; c.B = 58; break;
                case "info": c.R = 144; c.G = 147; c.B = 153; break;
                case "warning": c.R = 230; c.G = 162; c.B = 60; break;
                case "danger": c.R = 245; c.G = 108; c.B = 108;break;
                case "defualt":
                default: c.R = 255; c.G = 255; c.B = 255; break;
            }
            return c;
        }
        /// <summary>
        /// 应用背景色,悬浮
        /// </summary>
        /// <returns></returns>
        private Color ApplyBackgroundColorHover(){
            Color c = new Color();
            c.A = 255;
            switch (this.Type){
                case "primary": c.R = 102; c.G = 177; c.B = 255; break;
                case "success": c.R = 133; c.G = 206; c.B = 97; break;
                case "info": c.R = 166; c.G = 169; c.B = 173; break;
                case "warning": c.R = 235; c.G = 181; c.B = 99; break;
                case "danger": c.R = 247; c.G = 137; c.B = 137;break;
                case "defualt":
                default: c.R = 236; c.G =245; c.B = 255;break;
            }
            return c;
        }
    }
}

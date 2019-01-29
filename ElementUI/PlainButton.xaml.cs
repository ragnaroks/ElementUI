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

namespace ElementUI {
    /// <summary>
    /// PlainButton.xaml 的交互逻辑
    /// </summary>
    public partial class PlainButton:UserControl {
        /// <summary>
        /// 按钮文本
        /// </summary>
        public String Text {
            get { return (String)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public static readonly DependencyProperty TextProperty =DependencyProperty.Register("Text", typeof(String), typeof(PlainButton), new PropertyMetadata("朴素按钮"));
        /// <summary>
        /// 按钮类型
        /// </summary>
        public String Type {
            get { return (String)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }
        private static readonly DependencyProperty TypeProperty =DependencyProperty.Register("Type", typeof(String), typeof(PlainButton), new PropertyMetadata(String.Empty));
        /// <summary>
        /// 文本颜色
        /// </summary>
        public Color TextColor {
            get { return (Color)GetValue(TextColorProperty); }
            private set { SetValue(TextColorProperty, value); }
        }
        private static readonly DependencyProperty TextColorProperty =DependencyProperty.Register("TextColor", typeof(Color), typeof(PlainButton), new PropertyMetadata(new Color(){R=96,G=98,B=102,A=255}));
        /// <summary>
        /// 文本颜色,悬浮
        /// </summary>
        public Color TextColorHover {
            get { return (Color)GetValue(TextColorHoverProperty); }
            private set { SetValue(TextColorHoverProperty, value); }
        }
        private static readonly DependencyProperty TextColorHoverProperty = DependencyProperty.Register("TextColorHover", typeof(Color), typeof(PlainButton), new PropertyMetadata(new Color() { R = 64, G =158, B =255, A = 255 }));
        /// <summary>
        /// 文本颜色,激活
        /// </summary>
        public Color TextColorActive {
            get { return (Color)GetValue(TextColorActiveProperty); }
            private set { SetValue(TextColorActiveProperty, value); }
        }
        private static readonly DependencyProperty TextColorActiveProperty = DependencyProperty.Register("TextColorActive", typeof(Color), typeof(PlainButton), new PropertyMetadata(new Color() { R = 58, G =142, B =230, A = 255 }));
        /// <summary>
        /// 背景色
        /// </summary>
        public Color BackgroundColor {
            get { return (Color)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }
        public static readonly DependencyProperty BackgroundColorProperty =DependencyProperty.Register("BackgroundColor", typeof(Color), typeof(PlainButton), new PropertyMetadata(new Color(){R=255,G=255,B=255,A=255}));
        /// <summary>
        /// 背景色,悬浮
        /// </summary>
        public Color BackgroundColorHover {
            get { return (Color)GetValue(BackgroundColorHoverProperty); }
            set { SetValue(BackgroundColorHoverProperty, value); }
        }
        public static readonly DependencyProperty BackgroundColorHoverProperty =DependencyProperty.Register("BackgroundColorHover", typeof(Color), typeof(PlainButton), new PropertyMetadata(new Color(){R=255,G=255,B=255,A=255}));
        /// <summary>
        /// 背景色,激活
        /// </summary>
        public Color BackgroundColorActive {
            get { return (Color)GetValue(BackgroundColorActiveProperty); }
            set { SetValue(BackgroundColorActiveProperty, value); }
        }
        public static readonly DependencyProperty BackgroundColorActiveProperty =DependencyProperty.Register("BackgroundColorActive", typeof(Color), typeof(PlainButton), new PropertyMetadata(new Color(){R=255,G=255,B=255,A=255}));
        /// <summary>
        /// 边框颜色
        /// </summary>
        public Color BorderColor {
            get { return (Color)GetValue(BorderColorProperty); }
            private set { SetValue(BorderColorProperty, value); }
        }
        private static readonly DependencyProperty BorderColorProperty = DependencyProperty.Register("BorderColor", typeof(Color), typeof(PlainButton), new PropertyMetadata(new Color() { R = 220, G = 223, B = 230, A = 255 }));
        /// <summary>
        /// 边框颜色,悬浮
        /// </summary>
        public Color BorderColorHover {
            get { return (Color)GetValue(BorderColorHoverProperty); }
            private set { SetValue(BorderColorHoverProperty, value); }
        }
        private static readonly DependencyProperty BorderColorHoverProperty = DependencyProperty.Register("BorderColorHover", typeof(Color), typeof(PlainButton), new PropertyMetadata(new Color() { R = 64, G = 158, B = 255, A = 255 }));
        /// <summary>
        /// 边框颜色,激活
        /// </summary>
        public Color BorderColorActive {
            get { return (Color)GetValue(BorderColorActiveProperty); }
            set { SetValue(BorderColorActiveProperty, value); }
        }
        public static readonly DependencyProperty BorderColorActiveProperty =DependencyProperty.Register("BorderColorActive", typeof(Color), typeof(PlainButton), new PropertyMetadata(new Color(){R=58,G=142,B=230,A=255}));
        /// <summary>
        /// 是否按下
        /// </summary>
        public Boolean Press {
            get { return (Boolean)GetValue(PressProperty); }
            set { SetValue(PressProperty, value); }
        }
        public static readonly DependencyProperty PressProperty =DependencyProperty.Register("Press", typeof(Boolean), typeof(PlainButton), new PropertyMetadata(false));

        /// <summary>
        /// 构造
        /// </summary>
        public PlainButton() {
            InitializeComponent();
            this.Loaded += this.PlainButton_Loaded;
        }
        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlainButton_Loaded(object sender, RoutedEventArgs e) {
            this.TextColor=ApplyTextColor();
            this.TextColorHover=ApplyTextColorHover();
            this.TextColorActive=ApplyTextColorActive();
            this.BackgroundColor=ApplyBackgroundColor();
            this.BackgroundColorHover=ApplyBackgroundColorHover();
            this.BackgroundColorActive=ApplyBackgroundColorActive();
            this.BorderColor=ApplyBorderColor();
            this.BorderColorHover=ApplyBorderColorHover();
            this.BorderColorActive=ApplyBorderColorActive();
        }

        #region 应用文本颜色
        /// <summary>
        /// 应用文本颜色
        /// </summary>
        /// <returns></returns>
        private Color ApplyTextColor(){
            Color c = new Color { A = 255 };
            switch (this.Type){
                case "primary":c.R=64;c.G=158;c.B=255;break;
                case "success":c.R=103;c.G=194;c.B=58;break;
                case "info":c.R=144;c.G=147;c.B=153;break;
                case "warning":c.R=230;c.G=162;c.B=60;break;
                case "danger": c.R = 245; c.G =108; c.B =108; break;
                default: c.R = 96; c.G = 98; c.B = 102; break;
            }
            return c;
        }
        /// <summary>
        /// 应用文本颜色,悬浮
        /// </summary>
        /// <returns></returns>
        private Color ApplyTextColorHover(){
            Color c = new Color { A = 255 };
            switch (this.Type){
                case "primary":
                case "success":
                case "info":
                case "warning":
                case "danger": c.R = 255; c.G =255; c.B =255; break;
                default: c.R = 64; c.G =158; c.B = 255; break;
            }
            return c;
        }
        /// <summary>
        /// 应用文本颜色,激活
        /// </summary>
        /// <returns></returns>
        private Color ApplyTextColorActive(){
            Color c = new Color { A = 255 };
            switch (this.Type){
                case "primary":
                case "success":
                case "info":
                case "warning":
                case "danger": c.R = 255; c.G =255; c.B =255; break;
                default: c.R = 58; c.G = 142; c.B = 230; break;
            }
            return c;
        }
        #endregion
        #region 应用背景颜色
        /// <summary>
        /// 应用背景颜色
        /// </summary>
        /// <returns></returns>
        private Color ApplyBackgroundColor(){
            Color c = new Color { A = 255 };
            switch (this.Type){
                case "primary":c.R=236;c.G=245;c.B=255;break;
                case "success":c.R=240;c.G=249;c.B=235;break;
                case "info":c.R=244;c.G=244;c.B=245;break;
                case "warning":c.R=253;c.G=246;c.B=236;break;
                case "danger": c.R = 254; c.G =240; c.B =240; break;
                default: c.R = 255; c.G = 255; c.B =255; break;
            }
            return c;
        }
        /// <summary>
        /// 应用背景颜色,悬浮
        /// </summary>
        /// <returns></returns>
        private Color ApplyBackgroundColorHover(){
            Color c = new Color { A = 255 };
            switch (this.Type){
                case "primary":c.R=64;c.G=158;c.B=255;break;
                case "success":c.R=103;c.G=194;c.B=58;break;
                case "info":c.R=144;c.G=147;c.B=153;break;
                case "warning":c.R=230;c.G=162;c.B=60;break;
                case "danger": c.R = 245; c.G =108; c.B =108; break;
                default: c.R = 255; c.G = 255; c.B =255; break;
            }
            return c;
        }
        /// <summary>
        /// 应用背景颜色,激活
        /// </summary>
        /// <returns></returns>
        private Color ApplyBackgroundColorActive(){
            Color c = new Color { A = 255 };
            switch (this.Type){
                case "primary":c.R=58;c.G=142;c.B=230;break;
                case "success":c.R=93;c.G=175;c.B=52;break;
                case "info":c.R=130;c.G=132;c.B=138;break;
                case "warning":c.R=207;c.G=146;c.B=54;break;
                case "danger": c.R = 221; c.G =97; c.B =97; break;
                default: c.R = 255; c.G = 255; c.B =255; break;
            }
            return c;
        }
        #endregion
        #region 应用边框颜色
        /// <summary>
        /// 应用边框颜色
        /// </summary>
        /// <returns></returns>
        private Color ApplyBorderColor(){
            Color c = new Color { A = 255 };
            switch (this.Type){
                case "primary":c.R=179;c.G=216;c.B=255;break;
                case "success":c.R=194;c.G=231;c.B=176;break;
                case "info":c.R=211;c.G=212;c.B=214;break;
                case "warning":c.R=245;c.G=218;c.B=177;break;
                case "danger": c.R = 251; c.G =196; c.B =196; break;
                default: c.R = 220; c.G = 223; c.B =230; break;
            }
            return c;
        }
        /// <summary>
        /// 应用背景颜色,悬浮
        /// </summary>
        /// <returns></returns>
        private Color ApplyBorderColorHover(){
            Color c = new Color { A = 255 };
            switch (this.Type){
                case "primary":c.R=64;c.G=158;c.B=255;break;
                case "success":c.R=103;c.G=194;c.B=58;break;
                case "info":c.R=144;c.G=147;c.B=153;break;
                case "warning":c.R=230;c.G=162;c.B=60;break;
                case "danger": c.R = 245; c.G =108; c.B =180; break;
                default: c.R = 64; c.G = 158; c.B =255; break;
            }
            return c;
        }
        /// <summary>
        /// 应用背景颜色,激活
        /// </summary>
        /// <returns></returns>
        private Color ApplyBorderColorActive(){
            Color c = new Color { A = 255 };
            switch (this.Type){
                case "primary":c.R=58;c.G=142;c.B=230;break;
                case "success":c.R=93;c.G=175;c.B=52;break;
                case "info":c.R=130;c.G=132;c.B=138;break;
                case "warning":c.R=207;c.G=146;c.B=54;break;
                case "danger": c.R = 221; c.G =97; c.B =97; break;
                default: c.R = 58; c.G = 142; c.B =230; break;
            }
            return c;
        }
        #endregion
    }
}

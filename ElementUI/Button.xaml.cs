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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ElementUI{
    /// <summary>
    /// Button.xaml 的交互逻辑
    /// </summary>
    public partial class Button : UserControl{
        #region 公开属性
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
        /// 尺寸
        /// </summary>
        public String Size {
            get { return (String)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }
        private static readonly DependencyProperty SizeProperty =DependencyProperty.Register("Size", typeof(String), typeof(Button), new PropertyMetadata(String.Empty));
        #endregion
        #region 私有属性
        /// <summary>
        /// 文本颜色
        /// </summary>
        private Color TextColor {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }
        private static readonly DependencyProperty TextColorProperty =DependencyProperty.Register("TextColor", typeof(Color), typeof(Button), new PropertyMetadata(new Color(){R=96,G=98,B=102,A=255}));
        /// <summary>
        /// 文本颜色,悬浮
        /// </summary>
        private Color TextColorHover {
            get { return (Color)GetValue(TextColorHoverProperty); }
            set { SetValue(TextColorHoverProperty, value); }
        }
        private static readonly DependencyProperty TextColorHoverProperty = DependencyProperty.Register("TextColorHover", typeof(Color), typeof(Button), new PropertyMetadata(new Color() { R = 64, G =158, B =255, A = 255 }));
        /// <summary>
        /// 文本颜色,禁用
        /// </summary>
        private Color TextColorDisabled {
            get { return (Color)GetValue(TextColorDisabledProperty); }
            set { SetValue(TextColorDisabledProperty, value); }
        }
        private static readonly DependencyProperty TextColorDisabledProperty = DependencyProperty.Register("TextColorDisabled", typeof(Color), typeof(Button), new PropertyMetadata(new Color() { R = 192, G =196, B =204, A = 255 }));
        /// <summary>
        /// 背景色
        /// </summary>
        private Color BackgroundColor {
            get { return (Color)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }
        private static readonly DependencyProperty BackgroundColorProperty =DependencyProperty.Register("BackgroundColor", typeof(Color), typeof(Button), new PropertyMetadata(new Color(){R=255,G=255,B=255,A=255}));
        /// <summary>
        /// 背景色,悬浮
        /// </summary>
        private Color BackgroundColorHover {
            get { return (Color)GetValue(BackgroundColorHoverProperty); }
            set { SetValue(BackgroundColorHoverProperty, value); }
        }
        private static readonly DependencyProperty BackgroundColorHoverProperty =DependencyProperty.Register("BackgroundColorHover", typeof(Color), typeof(Button), new PropertyMetadata(new Color(){R=236,G=245,B=255,A=255}));
        /// <summary>
        /// 背景色,激活
        /// </summary>
        private Color BackgroundColorActive {
            get { return (Color)GetValue(BackgroundColorActiveProperty); }
            set { SetValue(BackgroundColorActiveProperty, value); }
        }
        private static readonly DependencyProperty BackgroundColorActiveProperty =DependencyProperty.Register("BackgroundColorActive", typeof(Color), typeof(Button), new PropertyMetadata(new Color(){R=198,G=226,B=255,A=255}));
        /// <summary>
        /// 背景色,禁用
        /// </summary>
        private Color BackgroundColorDisabled {
            get { return (Color)GetValue(BackgroundColorDisabledProperty); }
            set { SetValue(BackgroundColorDisabledProperty, value); }
        }
        private static readonly DependencyProperty BackgroundColorDisabledProperty = DependencyProperty.Register("BackgroundColorDisabled", typeof(Color), typeof(Button), new PropertyMetadata(new Color() { R = 255, G = 255, B = 255, A = 255 }));
        /// <summary>
        /// 边框颜色
        /// </summary>
        private Color BorderColor {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }
        private static readonly DependencyProperty BorderColorProperty = DependencyProperty.Register("BorderColor", typeof(Color), typeof(Button), new PropertyMetadata(new Color() { R = 220, G = 223, B = 230, A = 255 }));
        /// <summary>
        /// 边框颜色,悬浮
        /// </summary>
        private Color BorderColorHover {
            get { return (Color)GetValue(BorderColorHoverProperty); }
            set { SetValue(BorderColorHoverProperty, value); }
        }
        private static readonly DependencyProperty BorderColorHoverProperty = DependencyProperty.Register("BorderColorHover", typeof(Color), typeof(Button), new PropertyMetadata(new Color() { R = 198, G = 226, B = 255, A = 255 }));
        /// <summary>
        /// 边框颜色,激活
        /// </summary>
        private Color BorderColorActive {
            get { return (Color)GetValue(BorderColorActiveProperty); }
            set { SetValue(BorderColorActiveProperty, value); }
        }
        private static readonly DependencyProperty BorderColorActiveProperty =DependencyProperty.Register("BorderColorActive", typeof(Color), typeof(Button), new PropertyMetadata(new Color(){R=58,G=142,B=230,A=255}));
        /// <summary>
        /// 边框颜色,禁用
        /// </summary>
        private Color BorderColorDisabled {
            get { return (Color)GetValue(BorderColorDisabledProperty); }
            set { SetValue(BorderColorDisabledProperty, value); }
        }
        private static readonly DependencyProperty BorderColorDisabledProperty = DependencyProperty.Register("BorderColorDisabled", typeof(Color), typeof(Button), new PropertyMetadata(new Color() { R = 235, G = 238, B = 245, A = 255 }));
        /// <summary>
        /// 是否按下
        /// </summary>
        private Boolean IsPress {
            get { return (Boolean)GetValue(IsPressProperty); }
            set { SetValue(IsPressProperty, value); }
        }
        private static readonly DependencyProperty IsPressProperty =DependencyProperty.Register("IsPress", typeof(Boolean), typeof(Button), new PropertyMetadata(false));
        #endregion

        /// <summary>
        /// 点击事件
        /// </summary>
        public event EventHandler Click;

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
            this.TextColorDisabled=ApplyTextColorDisabled();

            this.BorderColor = ApplyBorderColor();
            this.BorderColorHover = ApplyBorderColorHover();
            this.BorderColorActive=ApplyBorderColorActive();
            this.BorderColorDisabled=ApplyBorderColorDisabled();
            
            this.BackgroundColor= ApplyBackgroundColor();
            this.BackgroundColorHover= ApplyBackgroundColorHover();
            this.BackgroundColorActive = ApplyBackgroundColorActive();
            this.BackgroundColorDisabled=ApplyBackgroundColorDisabled();

            this.MinWidth=ApplyMinWidth();
            this.Height=ApplyHeight();

            this.TextBlock_Text.FontSize=ApplyFontSize();
        }

        #region 应用边框颜色
        /// <summary>
        /// 应用边框颜色
        /// </summary>
        /// <returns></returns>
        private Color ApplyBorderColor(){
            Color c = new Color { A = 255 };
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
            Color c = new Color { A = 255 };
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
        /// 应用边框颜色,激活
        /// </summary>
        /// <returns></returns>
        private Color ApplyBorderColorActive(){
            Color c = new Color { A = 255 };
            switch (this.Type){
                case "primary": c.R = 58; c.G = 142; c.B = 230; break;
                case "success": c.R = 93; c.G = 175; c.B = 52; break;
                case "info": c.R = 130; c.G = 132; c.B = 138; break;
                case "warning": c.R = 207; c.G = 146; c.B = 54;break;
                case "danger": c.R = 221; c.G = 97; c.B = 97; break;
                case "defualt":
                default: c.R = 58; c.G = 142; c.B = 230; break;
            }
            return c;
        }
        /// <summary>
        /// 应用边框颜色,禁用
        /// </summary>
        /// <returns></returns>
        private Color ApplyBorderColorDisabled(){
            Color c = new Color { A = 255 };
            switch (this.Type){
                case "primary": c.R = 160; c.G = 207; c.B = 255; break;
                case "success": c.R = 179; c.G =225; c.B =157; break;
                case "info": c.R = 200; c.G = 201; c.B = 204; break;
                case "warning": c.R = 243; c.G = 209; c.B = 158; break;
                case "danger": c.R = 250; c.G = 182; c.B = 182; break;
                default: c.R = 235; c.G = 238; c.B =245; break;
            }
            return c;
        }
        #endregion
        #region 应用文本颜色
        /// <summary>
        /// 应用文本颜色
        /// </summary>
        /// <returns></returns>
        private Color ApplyTextColor(){
            Color c = new Color { A = 255 };
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
            Color c = new Color { A = 255 };
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
        /// 应用文本颜色,禁用
        /// </summary>
        /// <returns></returns>
        private Color ApplyTextColorDisabled(){
            Color c = new Color { A = 255 };
            switch (this.Type){
                case "primary":
                case "success":
                case "info":
                case "warning":
                case "danger": c.R = 255; c.G = 255; c.B = 255; break;
                default: c.R = 192; c.G = 196; c.B = 204; break;
            }
            return c;
        }
        #endregion
        #region 应用背景色
        /// <summary>
        /// 应用背景色
        /// </summary>
        /// <returns></returns>
        private Color ApplyBackgroundColor(){
            Color c = new Color { A = 255 };
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
            Color c = new Color { A = 255 };
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
        /// <summary>
        /// 应用背景色,激活
        /// </summary>
        /// <returns></returns>
        private Color ApplyBackgroundColorActive(){
            Color c = new Color{A = 255};
            switch (this.Type){
                case "primary": c.R = 58; c.G = 142; c.B = 230; break;
                case "success": c.R = 93; c.G = 175; c.B = 52; break;
                case "info": c.R = 130; c.G = 132; c.B = 138; break;
                case "warning": c.R = 207; c.G = 146; c.B = 54; break;
                case "danger": c.R = 221; c.G = 97; c.B = 97; break;
                case "defualt":
                default: c.R = 236; c.G = 245; c.B = 255; break;
            }
            return c;
        }
        /// <summary>
        /// 应用背景色,禁用
        /// </summary>
        /// <returns></returns>
        private Color ApplyBackgroundColorDisabled(){
            Color c = new Color { A = 255 };
            switch (this.Type){
                case "primary": c.R = 160; c.G = 207; c.B = 255; break;
                case "success": c.R = 179; c.G =225; c.B =157; break;
                case "info": c.R = 200; c.G = 201; c.B = 204; break;
                case "warning": c.R = 243; c.G = 209; c.B = 158; break;
                case "danger": c.R = 250; c.G = 182; c.B = 182; break;
                default: c.R = 255; c.G = 255; c.B =255; break;
            }
            return c;
        }
        #endregion
        #region 应用按钮宽高
        /// <summary>
        /// 应用按钮宽
        /// </summary>
        private Double ApplyMinWidth(){
            switch(this.Size){
                case "medium":return 98;
                case "small":return 80;
                case "mini":return 80;
                default:return 98;
            }
        }
        /// <summary>
        /// 应用按钮高
        /// </summary>
        /// <returns></returns>
        private Double ApplyHeight(){
            switch(this.Size){
                case "medium":return 36;
                case "small":return 32;
                case "mini":return 28;
                default:return 40;
            }
        }
        #endregion
        #region 应用文本大小
        /// <summary>
        /// 应用文本大小
        /// </summary>
        /// <returns></returns>
        private Double ApplyFontSize() {
            switch (this.Size) {
                case "medium":return 14;
                case "small":return 12;
                case "mini":return 12;
                default:return 14;
            }
        }
        #endregion
        #region 事件
        /// <summary>
        /// 左键按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if (!this.Border_Wrap.IsMouseOver){return;}
                this.IsPress=true;
        }
        /// <summary>
        /// 左键弹起
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            if(!this.Border_Wrap.IsMouseOver||!this.IsPress){return;}
            this.IsPress=false;
            if (this.Click == null) { return;}
            this.Click(sender,e);
            e.Handled=false;
        }
        /// <summary>
        /// 可用状态改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e){
            if(this.IsEnabled){
                Object o=TryFindResource("sb_bgc_tn");
                if(o == null || !(o is Storyboard)) { return;}
                (o as Storyboard).Begin();
            } else {
                Object o=TryFindResource("sb_bgc_td");
                if(o == null || !(o is Storyboard)) { return;}
                (o as Storyboard).Begin();
            }
        }
        #endregion
    }
}

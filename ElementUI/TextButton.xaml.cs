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

namespace ElementUI {
    /// <summary>
    /// TextButton.xaml 的交互逻辑
    /// </summary>
    public partial class TextButton:UserControl {
        #region 公开属性
        /// <summary>
        /// 按钮文本
        /// </summary>
        public String Text {
            get {return (String)GetValue(TextProperty);}
            set {SetValue(TextProperty, value);}
        }
        private static readonly DependencyProperty TextProperty=DependencyProperty.Register("Text", typeof(String), typeof(TextButton), new PropertyMetadata("按钮"));
        #endregion
        #region 私有属性
        /// <summary>
        /// 文本颜色
        /// </summary>
        private Color TextColor {
            get {return (Color)GetValue(TextColorProperty);}
            set {SetValue(TextColorProperty, value);}
        }
        private static readonly DependencyProperty TextColorProperty =DependencyProperty.Register("TextColor", typeof(Color), typeof(TextButton), new PropertyMetadata(new Color(){R=64,G=158,B=255,A=255}));
        /// <summary>
        /// 文本颜色,悬浮
        /// </summary>
        private Color TextColorHover {
            get {return (Color)GetValue(TextColorHoverProperty);}
            set {SetValue(TextColorHoverProperty, value);}
        }
        private static readonly DependencyProperty TextColorHoverProperty=DependencyProperty.Register("TextColorHover", typeof(Color), typeof(TextButton), new PropertyMetadata(new Color(){R=102, G =177, B =255, A=255 }));
        /// <summary>
        /// 文本颜色,悬浮
        /// </summary>
        private Color TextColorActive {
            get {return (Color)GetValue(TextColorActiveProperty);}
            set {SetValue(TextColorActiveProperty, value);}
        }
        private static readonly DependencyProperty TextColorActiveProperty=DependencyProperty.Register("TextColorActive", typeof(Color), typeof(TextButton), new PropertyMetadata(new Color(){R=58, G =142, B =230, A=255 }));
        /// <summary>
        /// 文本颜色,禁用
        /// </summary>
        private Color TextColorDisabled {
            get {return (Color)GetValue(TextColorDisabledProperty);}
            set {SetValue(TextColorDisabledProperty, value);}
        }
        private static readonly DependencyProperty TextColorDisabledProperty=DependencyProperty.Register("TextColorDisabled", typeof(Color), typeof(TextButton), new PropertyMetadata(new Color(){R=192, G =196, B =204, A=255 }));
        /// <summary>
        /// 是否按下
        /// </summary>
        private Boolean IsPress {
            get { return (Boolean)GetValue(IsPressProperty); }
            set { SetValue(IsPressProperty, value); }
        }
        private static readonly DependencyProperty IsPressProperty =DependencyProperty.Register("IsPress", typeof(Boolean), typeof(TextButton), new PropertyMetadata(false));
        #endregion

        /// <summary>
        /// 点击事件
        /// </summary>
        public event EventHandler Click;

        /// <summary>
        /// 构造
        /// </summary>
        public TextButton(){
            InitializeComponent();
            this.Loaded += this.Button_Loaded;
        }

        private void Button_Loaded(object sender,RoutedEventArgs e) {
            
        }

        #region 事件
        /// <summary>
        /// 左键按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            this.IsPress=true;
        }
        /// <summary>
        /// 左键弹起
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            if(!this.IsPress){return;}
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

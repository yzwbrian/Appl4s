using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appl4s.Properties;
using CefSharp.WinForms;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Toolkit.Values;

namespace Appl4s.controls
{
    public sealed partial class BrowserControl : UserControl
    {
        #region 常量

        public static readonly int SettingsContextMenuWidth = 120;

        public static readonly string AboutBlank = "about:blank";
        #endregion
        
        #region 私有变量

        private UrlItemLabel _lastUrlItemLabel = null;

        #endregion

        #region 属性
        //浏览器控件
        public ChromiumWebBrowser WebBrowser { get; set; }
        //地址
        public string Address { get; set; } = AboutBlank;

        
        #endregion
        #region 构造函数

        public BrowserControl()
        {
            InitializeComponent();

            BackColor = Color.FromArgb(239,246,253);
            _centerPanel.BackColor = BackColor;
            
            #region 测试例子

            UrlItemLabel urlItem = new UrlItemLabel
            {
                Url = "https://www.bing.com/",
                Title = "必应搜索",
                
            };

            UrlItemLabel urlItem1 = new UrlItemLabel
            {
                Url = "https://www.baidu.com/",
                Title = "百度一下，你就知道"
            };

            UrlItemLabel urlItem2 = new UrlItemLabel
            {
                Url =  "https://www.cnblogs.com/qq1223558/p/3651573.html",
                Title = "C#Image和Icon的相互转化"
            };

            UrlItemLabel urlItem3 = new UrlItemLabel
            {
                Url = null,
                Title = "这是一个空链接"
            };
            
            #endregion
            
            _initialToolbar();
            _initialAddressbar();
            _initialWebBrowser();
            
            loadAddressbar(new List<UrlItemLabel>
            {
                urlItem, urlItem1, urlItem2, urlItem3
            });
        }
        
        #endregion

        #region 初始化工具栏
        private void _initialToolbar()
        {
            _toolbar.SizeChanged += _toolbar_SizeChanged;
        }
        #endregion
        
        #region 工具栏事件

        private void _toolbar_SizeChanged(object sender, EventArgs e)
        {
            _kcmbAddress.Size = new Size(_toolbar.Width - 9 * 24 - 16, _kcmbAddress.Height);
        }
        private void _toolbtn_Click(object sender, EventArgs e)
        {
            var btn = sender as ToolStripButton;
            if (btn == null)
                return;
            var name = btn.Name;
            switch (name)
            {
                case "_toolbtnBack":
                    break;
                case "_toolbtnForward":
                    break;
                case "_toolbtnHome":
                    break;
                case "_toolbtnReload": 
                    break;
                case "_toolbtnCancel":
                    break;
                case "_toolbtnRecover":
                    break;
                case "_toolbtnStar":
                    break;
                case "_toolbtnFullStar":
                    break;
                case "_toolbtnApps": 
                    break;
                case "_toolbtnDownloads":
                    break;
                case "_toolbtnSettings":
                    int left = _toolbar.Width - SettingsContextMenuWidth;
                    int top = _toolbar.Top + _toolbar.Height;
                    var p = PointToScreen(new Point(left, top));
                    _kctxmnSettings.Show(this, p);
                    break;
            }
        }
        #endregion

        #region 初始化地址栏
        private void _initialAddressbar()
        {
            _kcmbAddress.KryptonComboBoxControl.DisplayMember = "Url";
            _kcmbAddress.KryptonComboBoxControl.ValueMember = "Url";
            _kcmbAddress.KryptonComboBoxControl.ToolTipValues.Image = Resources.Analysis_32;
            _kcmbAddress.KryptonComboBoxControl.HoveredSelectionChanged += _kcmbAddress_HoveredSelectionChanged;
            _kcmbAddress.KryptonComboBoxControl.SelectionChangeCommitted += kryptonComboBoxControlOnSelectionChangeCommitted;
            _kcmbAddress.KryptonComboBoxControl.DropDownClosed += kryptonComboBoxControlOnDropDownClosed;
            _kcmbAddress.KryptonComboBoxControl.KeyDown += kryptonComboBoxControlOnKeyDown;
        }
        #endregion
        
        #region 地址栏事件

        private void kryptonComboBoxControlOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WebBrowser.Load(_kcmbAddress.Text);
            }
        }
        
        private void kryptonComboBoxControlOnDropDownClosed(object sender, EventArgs e)
        {
            _lastUrlItemLabel?.performMouseLeave(null);
            _lastUrlItemLabel = null;
        }

        private void _kcmbAddress_HoveredSelectionChanged(object sender, HoveredSelectionChangedEventArgs e)
        {
            var pc = _kcmbAddress.KryptonComboBoxControl.PointToScreen(e.Bounds.Location);
            _lastUrlItemLabel?.performMouseLeave(null);
            var label = e.Item as UrlItemLabel;
            if (label == null)
                return;
            label.Location = new Point(pc.X, pc.Y + label.Height / 2);
            _lastUrlItemLabel = label;
            
            _lastUrlItemLabel.performMouseEnter(null);
            
        }
        
        private void kryptonComboBoxControlOnSelectionChangeCommitted(object sender,  EventArgs e)
        {
            _lastUrlItemLabel?.performMouseLeave(null);
            _lastUrlItemLabel = null;
        }
        
        private void _kcmbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            _lastUrlItemLabel?.performMouseLeave(null);
            _lastUrlItemLabel = null;
            
            _toolbar.Focus();
            _kcmbAddress.Focus();
            _kcmbAddress.PerformClick();
        }

        #endregion

        #region 初始化浏览器
        private void _initialWebBrowser()
        {
            WebBrowser = new ChromiumWebBrowser(Address)
            {
                Dock = DockStyle.Fill,
            };
            _centerPanel.Controls.Add(WebBrowser);
        }
        #endregion

        #region 浏览器事件

        #endregion
        
        #region 私有方法

        //清空地址栏列表
        private void clearAddressbar()
        {
            _kcmbAddress.KryptonComboBoxControl.Items.Clear();
        }
        //加载地址栏列表
        private void loadAddressbar(List<UrlItemLabel> list)
        {
            if (list == null)
                return;
            _kcmbAddress.KryptonComboBoxControl.Items.AddRange(list.ToArray());
        }

        
        #endregion

        #region 公共方法

        

        #endregion
        
    }
}

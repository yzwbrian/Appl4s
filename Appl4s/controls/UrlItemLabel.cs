using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appl4s.Properties;

namespace Appl4s.controls
{
    public partial class UrlItemLabel : KryptonLabel
    {
        #region 常量

        public static readonly int IconWidth = 24;
        public static readonly int IconHeight = 24;

        #endregion
        
        #region 私有变量

        private Image _icon = null;
        private string _url = null;
        private string _title = null;
        #endregion

        #region 属性

        public Image Icon
        {
            get => _icon;

            set
            {
                if (value == null)
                    value = Resources.document_edit_24;

                _icon = value.GetThumbnailImage(IconWidth, IconHeight, () => false, IntPtr.Zero);
                Values.Image = _icon;
                ToolTipValues.Image = _icon;
            }
        } 
        public string Url {
            get => _url;
            set
            {
                _url = value ?? "";
                ToolTipValues.Description = _url;
                Values.Text = _url;
            }
        }
        public string Title
        {
            get => _title;
            set
            {
                _title = value ?? "";
                ToolTipValues.Heading = _title;
                Values.ExtraText = _title;
            }
        }
        
        #endregion

        #region 构造函数

        public UrlItemLabel():base()
        {
            ToolTipValues.ToolTipStyle = LabelStyle.SuperTip;
            ToolTipValues.EnableToolTips = true;
            Icon = null;
            Title = null;
            Url = null;
        }

        #endregion

        #region 公共方法

        //pos为屏幕坐标
        public void performMouseEnter(Point? pos)
        {
            var po = pos ?? MousePosition;
            //var p = PointToClient(po);
            OnMouseEnter(new MouseEventArgs(MouseButtons.None, 0, po.X, po.Y, 0));
            
        }

        //pos为屏幕坐标
        public void performMouseLeave(Point? pos)
        {
            var po = pos ?? MousePosition;
            //var p = PointToClient(po);
            OnMouseLeave(new MouseEventArgs(MouseButtons.None, 0, po.X, po.Y, 0));
        }

        #endregion
        
        
        
    }
}

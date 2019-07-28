using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appl4s.controls;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;

namespace Appl4s
{
    public partial class MainForm : KryptonForm
    {
        #region 私有变量
        private int _tabCount = 0;
        #endregion

        #region 构造函数
        public MainForm()
        {
            InitializeComponent();
            
        }
        #endregion

        #region 窗体事件
        private void MainForm_Load(object sender, EventArgs e)
        {
            _initialTab();

            _kpageStart.Controls.Add(new BrowserControl() { Dock = DockStyle.Fill });

        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            TabOperator.adjustTab(_knavTab);
        }
        #endregion


        #region 初始化选项卡
        private void _initialTab()
        {
            _knavTab.ToolTips.AllowButtonSpecToolTips = true;
            _knavTab.ToolTips.AllowPageToolTips = true;
            _knavTab.Paint += _knavTab_Paint;
            _knavTab.MouseWheel += _knavTab_MouseWheel;

            btnspecRightSplit.Enabled = ButtonEnabled.False;
            btnspecAdd.Click += BtnspecAdd_Click;
            TabOperator.setTabItemContextMenu(_kctxmenuTabItem);
            _handleTabItemContextMenuClick();
        }
        private void _handleTabItemContextMenuClick()
        {
            KryptonContextMenuCollection items = _kctxmenuTabItem.Items;
            foreach(KryptonContextMenuItemBase item in items)
            {
                var cms = item as KryptonContextMenuItems;
                if (cms == null)
                    continue;
                foreach(var cmi in cms.Items)
                {
                    var cm = cmi as KryptonContextMenuItem;
                    if (cm == null)
                        continue;
                    cm.Click += Cm_Click;
                }
            }
        }
        #endregion

        #region 选项卡相关事件
        private void _knavTab_ShowContextMenu(object sender, ShowContextMenuArgs e)
        {
            if(e.KryptonContextMenu != null)
                e.KryptonContextMenu.Tag = e.Item;
            
        }
        private void _knavTab_MouseWheel(object sender, MouseEventArgs e)
        {
            Point p = _knavTab.PointToClient(MousePosition);
            if (p.Y >= 32)
                return;
            bool left = e.Delta > 0;
            if (left)
                _knavTab.PerformPreviousAction();
            else
                _knavTab.PerformNextAction();
        }
        private void _knavTab_Paint(object sender, PaintEventArgs e)
        {
            TabOperator.adjustTab(_knavTab);
        }
        private void BtnspecAdd_Click(object sender, EventArgs e)
        {
            KryptonPage page = TabOperator.insert(newModel(), _knavTab);
            _knavTab.SelectedPage = page;
        }
        private TabItemModel newModel()
        {
            TabItemModel model = TabItemModel.createEmpty();
            model.Title = "新建标签" + (++_tabCount);
            model.Icon = Properties.Resources.document_edit_24;
            model.Closeable = true;
            model.TooltipTitle = "新建标签" + _tabCount;
            model.TooltipBody = "暂无描述";
            model.TooltipImage = Properties.Resources.document_edit_24;
            return model;
        }
        #endregion
        
        #region 选项卡右键菜单事件
        private void Cm_Click(object sender, EventArgs e)
        {
            var page = _kctxmenuTabItem.Tag as KryptonPage;
            _kctxmenuTabItem.Tag = null;
            if (page == null)
                return;

            var index = TabOperator.getPageIndex(page, _knavTab);
            if (index == -1)
                return;
            var model = TabOperator.getTabItemModel(page);

            var cm = sender as KryptonContextMenuItem;
            var tag = cm.Tag + "";
            switch (tag)
            {
                case "reload":

                    break;

                case "collection":

                    break;

                case "insertBefore":
                    TabOperator.insert(newModel(), _knavTab, index);
                    break;

                case "insertAfter":
                    index = index + 1 >= _knavTab.Pages.Count ? -1 : index + 1;
                    TabOperator.insert(newModel(), _knavTab, index);
                    break;

                case "close":
                    TabOperator.remove(model, _knavTab);
                    break;

                case "closeOther":
                    TabOperator.removeOther(page.UniqueName, _knavTab);
                    break;

                case "closeLeft":
                    TabOperator.removeLeft(page.UniqueName, _knavTab);
                    break;

                case "closeRight":
                    TabOperator.removeRight(page.UniqueName, _knavTab);
                    break;

                case "closeAll":
                    TabOperator.removeAll(_knavTab);
                    break;

                case "exit":
                    Application.Exit();
                    break;
            }
        }
        #endregion


    }



}

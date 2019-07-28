using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appl4s
{
    #region 选项页数据模型
    public class TabItemModel
    {
        public string Id { get; protected set; }
        public string Title { get; set; }
        public Image Icon { get; set; }
        public bool? Closeable { get; set; }
        public string TooltipTitle { get; set; }
        public string TooltipBody { get; set; }
        public Image TooltipImage { get; set; }

        private TabItemModel()
        {
            Id = "0";
        }
        private TabItemModel(string Id)
        {
            if (string.IsNullOrWhiteSpace(Id))
                throw new ArgumentNullException("Id");

            this.Id = Id;
        }

        /// <summary>
        /// 使用指定的id创建一个新的数据模型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static TabItemModel create(string id)
        {
            return new TabItemModel(id);
        }

        /// <summary>
        /// 创建一个空数据的数据模型
        /// </summary>
        /// <returns></returns>
        public static TabItemModel createEmpty()
        {
            return new TabItemModel("0");
        }
    }
    #endregion

    #region 地址栏条目数据模型
    public class UrlItemModel
    {
        public string Id { get; protected set; }
        public string Title { get; set; }
        public Image Icon { get; set; }
        public string Url { get; set; }
        public bool? collect { get; set; }
        public bool? history { get; set; }
    }
    #endregion

    #region 选项卡相关枚举

    /// <summary>
    /// 更新方式
    /// </summary>
    public enum UpdateType
    {
        /// <summary>
        /// 根据id更新其他所有属性
        /// </summary>
        UpdateAllById,
        /// <summary>
        /// 根据id更新其他不为空的属性
        /// </summary>
        UpdateNotNullById
    }
    #endregion

    #region 选项卡常用操作
    public static class TabOperator
    {
        #region 私有变量
        private static KryptonContextMenu _tabItemMenu;
        #endregion

        #region 常量
        public static readonly int Tab_Bar_Left_Split_Width = 20;
        public static readonly int Tab_Bar_Width = 132;
        public static readonly int Tab_Bar_Add_Width = 32;
        public static readonly int Tab_Bar_Of_BtnSpec_Width = 60;

        public static readonly int Tab_Bar_Scroll_Once_Width = 120;

        public static readonly string Tab_Bar_Btn_Spec_Split_Unique_Name = "c16dfc4bb1044ebfa2655d3bf68eddb8";
        #endregion

        #region 设置选项卡条目右键菜单
        public static void setTabItemContextMenu(KryptonContextMenu menu)
        {
            _tabItemMenu = menu;
            _tabItemMenu.Opening += _tabItemMenu_Opening;
        }

        private static void _tabItemMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            KryptonNavigator tab = _tabItemMenu.Caller as KryptonNavigator;

            if (tab == null)
            {
                e.Cancel = true;
                return;
            }

            Point p = tab.PointToClient(KryptonNavigator.MousePosition);
            if (p.Y >= 32)
                e.Cancel = true;
        }
        #endregion

        #region 获取用于调整选项卡的新增按钮位置的ButtonSpec
        private static ButtonSpecNavigator getSplitBtnSpec(KryptonNavigator tab)
        {
            if (tab == null)
                throw new ArgumentNullException("tab");
            foreach(var b in tab.Button.ButtonSpecs)
            {
                if (b.UniqueName == Tab_Bar_Btn_Spec_Split_Unique_Name)
                    return b;
            }
            return null;
        }
        #endregion

        #region 调整选项卡
        public static void adjustTab(KryptonNavigator tab)
        {
            var btnspecRightSplit = getSplitBtnSpec(tab);

            int minLeftW = Tab_Bar_Add_Width + Tab_Bar_Of_BtnSpec_Width + Tab_Bar_Left_Split_Width;
            int TabBarW = tab.Pages.Count * Tab_Bar_Width;

            var img = btnspecRightSplit.Image;
            if (img != null)
                img.Dispose();

            if (TabBarW >= tab.Width - minLeftW)
            {
                btnspecRightSplit.Image = null;

            }
            else
            {
                int iw = tab.Width - TabBarW - minLeftW - 5;
                if (iw < 1)
                    btnspecRightSplit.Image = null;
                else
                    btnspecRightSplit.Image = new Bitmap(iw, 1);
            }
        }
        #endregion

        #region 根据id查找选项页
        public static KryptonPage findPageById(string id, KryptonNavigator tab)
        {
            if (tab == null)
                throw new ArgumentNullException("tab");

            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentOutOfRangeException("id");

            foreach(KryptonPage page in tab.Pages){
                if (page.UniqueName == id)
                    return page;
            }
            return null;
        }
        #endregion

        #region 根据位置查找选项页
        public static KryptonPage findPageByIndex(int index, KryptonNavigator tab)
        {
            if (tab == null)
                throw new ArgumentNullException("tab");

            if (index < 0 || index >= tab.Pages.Count)
                throw new ArgumentOutOfRangeException("index");
            
            return tab.Pages[index];
        }
        #endregion

        #region 返回选项页id
        public static string getPageId(KryptonPage page)
        {
            if (page == null)
                throw new ArgumentNullException("page");
            return page.UniqueName;
        }
        #endregion

        #region 返回选项页所在位置
        public static int getPageIndex(KryptonPage page, KryptonNavigator tab)
        {
            if (tab == null)
                throw new ArgumentNullException("tab");

            if (page == null)
                throw new ArgumentNullException("page");

            for (int i = 0; i < tab.Pages.Count; i++)
            {
                if (tab.Pages[i] == page)
                    return i;
            }
            return -1;
        }
        #endregion

        #region 获取选项页数据模型
        public static TabItemModel getTabItemModel(KryptonPage page)
        {
            if (page == null)
                throw new ArgumentNullException("page");

            TabItemModel model = TabItemModel.create(page.UniqueName);

            model.Title = page.Text;
            model.Icon = page.ButtonSpecs.Count > 0 ? page.ButtonSpecs[0].Image : null;
            model.Closeable = page.ButtonSpecs.Count > 0;
            model.TooltipTitle = page.ToolTipTitle;
            model.TooltipBody = page.ToolTipBody;
            model.TooltipImage = page.ToolTipImage;

            return model;
        }
        #endregion

        #region 设置选项页数据模型
        public static void setTabItemModel(TabItemModel model, UpdateType type, KryptonPage page)
        {
            if (model == null)
                throw new ArgumentNullException("model");

            if (string.IsNullOrWhiteSpace(model.Id))
                throw new ArgumentNullException("model[Id]");

            if (page == null)
                throw new ArgumentNullException("page");

            setPageCloseable(model.Closeable, page);

            if(type == UpdateType.UpdateAllById )
            {
                page.Text = model.Title;
                page.ImageSmall = model.Icon;
                page.ToolTipTitle = model.TooltipTitle;
                page.ToolTipBody = model.TooltipBody;
                page.ToolTipImage = model.TooltipImage;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(model.Title))
                    page.Text = model.Title;

                if (model.Icon != null)
                    page.ImageSmall = model.Icon;

                if(!string.IsNullOrWhiteSpace(model.TooltipTitle))
                    page.ToolTipTitle = model.TooltipTitle;

                if(!string.IsNullOrWhiteSpace(model.TooltipBody))
                    page.ToolTipBody = model.TooltipBody;

                if(model.TooltipImage != null)
                    page.ToolTipImage = model.TooltipImage;
            }
        }
        #endregion

        #region 设置选项卡是否可以关闭
        public static void setPageCloseable(bool? closeable, KryptonPage page)
        {
            if (page == null)
                throw new ArgumentNullException("page");

            if(closeable == null || !closeable.Value)
            {
                if(page.ButtonSpecs.Count > 0)
                {
                    var close = page.ButtonSpecs[0];
                    close.Click -= Close_Click;
                    page.ButtonSpecs.Remove(close);
                }
            }
            else
            {
                ButtonSpecAny close = new ButtonSpecAny()
                {
                    Type = PaletteButtonSpecStyle.Close,
                    ToolTipTitle = "关闭",
                    ToolTipStyle = LabelStyle.ToolTip
                };
                close.Click += Close_Click;
                page.ButtonSpecs.Add(close);
            }
        }

        private static void Close_Click(object sender, EventArgs e)
        {
            ButtonSpecAny close = sender as ButtonSpecAny;
            KryptonPage page = close.Owner as KryptonPage;
            KryptonNavigator tab = page.KryptonParentContainer as KryptonNavigator;
            remove(getTabItemModel(page), tab);
        }
        #endregion

        #region 插入
        public static KryptonPage insert(TabItemModel model, KryptonNavigator tab, int index = -1)
        {
            if (model == null)
                throw new ArgumentNullException("model");

            if (tab == null)
                throw new ArgumentNullException("tab");

            if (index >= tab.Pages.Count)
                throw new ArgumentOutOfRangeException("index");

            string id = new Guid().ToString();
            KryptonPage page = new KryptonPage(model.Title, id)
            {
                ToolTipStyle = LabelStyle.SuperTip
            };
            setTabItemModel(model, UpdateType.UpdateAllById, page);
            
            if(index == -1)
            {
                tab.Pages.Add(page);
            }else
            {
                tab.Pages.Insert(index, page);
            }

            if(tab.Button.ButtonSpecs.Count > 1)
            {
                var btnspecSplit = tab.Button.ButtonSpecs[1];
                adjustTab(tab);
            }

            if (_tabItemMenu != null)
                page.KryptonContextMenu = _tabItemMenu;
            return page;
        }
        #endregion

        #region 修改
        public static void update(TabItemModel model, KryptonNavigator tab, UpdateType type = UpdateType.UpdateNotNullById)
        {
            if (model == null)
                throw new ArgumentNullException("model");
            if (tab == null)
                throw new ArgumentNullException("tab");
            if (string.IsNullOrWhiteSpace(model.Id))
                throw new ArgumentNullException("model[Id]");

            KryptonPage page = findPageById(model.Id, tab);
            if (page == null)
                throw new Exception(string.Format("TabItem[id={0}] is not found.", model.Id));

            setTabItemModel(model, type, page);

            if (tab.Button.ButtonSpecs.Count > 1)
            {
                var btnspecSplit = tab.Button.ButtonSpecs[1];
                adjustTab(tab);
            }
        }
        #endregion

        #region 移除单个
        public static void remove(TabItemModel model, KryptonNavigator tab)
        {
            if (tab == null)
                throw new ArgumentNullException("tab");
            if (model == null)
                throw new ArgumentNullException("model");
            if (string.IsNullOrWhiteSpace(model.Id))
                throw new ArgumentNullException("model[Id]");

            KryptonPage page = findPageById(model.Id, tab);

            if (page == null)
                throw new Exception(string.Format("TabPage[id={0}] is not found.", model.Id));

            tab.Pages.Remove(page);
            if (tab.Button.ButtonSpecs.Count > 1)
            {
                var btnspecSplit = tab.Button.ButtonSpecs[1];
                adjustTab(tab);
            }
        }
        #endregion

        #region 移除左边
        public static void removeLeft(string id, KryptonNavigator tab)
        {
            for (int i = 0; i < tab.Pages.Count; i++)
            {
                var page = tab.Pages[i];
                if (page.UniqueName == id)
                    break;
                if(getTabItemModel(page).Closeable == false)
                    tab.Pages.Remove(page);
                i--;
            }
            adjustTab(tab);
        }
        #endregion

        #region 移除右边
        public static void removeRight(string id, KryptonNavigator tab)
        {
            bool flag = false;
            for (int i = 0; i < tab.Pages.Count; i++)
            {
                var page = tab.Pages[i];
                if (page.UniqueName == id)
                {
                    flag = true;
                    continue;
                }
                if (flag && getTabItemModel(page).Closeable == false)
                {
                    tab.Pages.Remove(page);
                    i--;
                }
            }
            adjustTab(tab);
        }
        #endregion

        #region 移除其他
        public static void removeOther(string id, KryptonNavigator tab)
        {
            for (int i = 0; i < tab.Pages.Count; i++)
            {
                var page = tab.Pages[i];
                if (page.UniqueName == id || getTabItemModel(page).Closeable == false)
                    continue;
                tab.Pages.Remove(page);
                i--;
            }
            adjustTab(tab);
        }
        #endregion

        #region 移除全部
        public static void removeAll(KryptonNavigator tab)
        {
            for (int i = 0; i < tab.Pages.Count; i++)
            {
                var page = tab.Pages[i];
                if (getTabItemModel(page).Closeable == false)
                    continue;
                tab.Pages.Remove(page);
                i--;
            }
            adjustTab(tab);
        }
        #endregion
    }
    #endregion
}

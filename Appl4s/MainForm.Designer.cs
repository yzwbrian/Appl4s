namespace Appl4s
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._knavTab = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.btnspecAdd = new ComponentFactory.Krypton.Navigator.ButtonSpecNavigator();
            this.btnspecRightSplit = new ComponentFactory.Krypton.Navigator.ButtonSpecNavigator();
            this._kpageStart = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.btnspecAccount = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this._kctxmenuTabItem = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuHeading1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem8 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem9 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem10 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuHeading2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuItems2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem4 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem5 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem6 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuHeading4 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuItems3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem7 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuHeading3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize) (this._knavTab)).BeginInit();
            this._knavTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this._kpageStart)).BeginInit();
            this.SuspendLayout();
            // 
            // _knavTab
            // 
            this._knavTab.Bar.BarLastItemInset = 20;
            this._knavTab.Bar.BarMinimumHeight = 32;
            this._knavTab.Bar.CheckButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this._knavTab.Bar.ItemMaximumSize = new System.Drawing.Size(130, 32);
            this._knavTab.Bar.ItemMinimumSize = new System.Drawing.Size(130, 32);
            this._knavTab.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.SameWidthAndHeight;
            this._knavTab.Bar.TabStyle = ComponentFactory.Krypton.Toolkit.TabStyle.LowProfile;
            this._knavTab.Button.ButtonDisplayLogic =
                ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.ContextNextPrevious;
            this._knavTab.Button.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Navigator.ButtonSpecNavigator[]
                {this.btnspecAdd, this.btnspecRightSplit});
            this._knavTab.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this._knavTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this._knavTab.Location = new System.Drawing.Point(0, 0);
            this._knavTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._knavTab.Name = "_knavTab";
            this._knavTab.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup;
            this._knavTab.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this._knavTab.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {this._kpageStart});
            this._knavTab.SelectedIndex = 0;
            this._knavTab.Size = new System.Drawing.Size(933, 638);
            this._knavTab.TabIndex = 0;
            this._knavTab.Text = "kryptonNavigator1";
            this._knavTab.ShowContextMenu +=
                new System.EventHandler<ComponentFactory.Krypton.Navigator.ShowContextMenuArgs>(
                    this._knavTab_ShowContextMenu);
            // 
            // btnspecAdd
            // 
            this.btnspecAdd.Image = global::Appl4s.Properties.Resources.new_file_24;
            this.btnspecAdd.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ButtonSpec;
            this.btnspecAdd.UniqueName = "1c1a69dcb4774ceea47b3f3062246567";
            // 
            // btnspecRightSplit
            // 
            this.btnspecRightSplit.UniqueName = "c16dfc4bb1044ebfa2655d3bf68eddb8";
            // 
            // _kpageStart
            // 
            this._kpageStart.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this._kpageStart.Flags = 65534;
            this._kpageStart.ImageSmall = global::Appl4s.Properties.Resources.goog_bullet_24;
            this._kpageStart.LastVisibleSet = true;
            this._kpageStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._kpageStart.MinimumSize = new System.Drawing.Size(58, 71);
            this._kpageStart.Name = "_kpageStart";
            this._kpageStart.Size = new System.Drawing.Size(931, 602);
            this._kpageStart.Text = "起始页";
            this._kpageStart.TextDescription = "";
            this._kpageStart.TextTitle = "";
            this._kpageStart.ToolTipBody = "Appl4s是基于chrome浏览器内核开发的小工具...";
            this._kpageStart.ToolTipImage = global::Appl4s.Properties.Resources.goog_bullet_24;
            this._kpageStart.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this._kpageStart.ToolTipTitle = "开始使用...";
            this._kpageStart.UniqueName = "a729654bfdb1467ca86f7a3b8ac0b5de";
            // 
            // btnspecAccount
            // 
            this.btnspecAccount.Image = global::Appl4s.Properties.Resources.user_blue_16;
            this.btnspecAccount.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form;
            this.btnspecAccount.UniqueName = "8a807ea9f1a74f94bc12b2ca0e195dab";
            // 
            // _kctxmenuTabItem
            // 
            this._kctxmenuTabItem.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[]
            {
                this.kryptonContextMenuHeading1, this.kryptonContextMenuItems1, this.kryptonContextMenuHeading2,
                this.kryptonContextMenuItems2, this.kryptonContextMenuHeading4, this.kryptonContextMenuItems3
            });
            // 
            // kryptonContextMenuHeading1
            // 
            this.kryptonContextMenuHeading1.ExtraText = "";
            this.kryptonContextMenuHeading1.Text = "常用";
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(
                new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[]
                {
                    this.kryptonContextMenuItem1, this.kryptonContextMenuItem8, this.kryptonContextMenuItem9,
                    this.kryptonContextMenuItem10
                });
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Tag = "reload";
            this.kryptonContextMenuItem1.Text = "重新加载";
            // 
            // kryptonContextMenuItem8
            // 
            this.kryptonContextMenuItem8.Tag = "collection";
            this.kryptonContextMenuItem8.Text = "收藏";
            // 
            // kryptonContextMenuItem9
            // 
            this.kryptonContextMenuItem9.Tag = "insertBefore";
            this.kryptonContextMenuItem9.Text = "在此之前插入";
            // 
            // kryptonContextMenuItem10
            // 
            this.kryptonContextMenuItem10.Tag = "insertAfter";
            this.kryptonContextMenuItem10.Text = "在此之后插入";
            // 
            // kryptonContextMenuHeading2
            // 
            this.kryptonContextMenuHeading2.ExtraText = "";
            this.kryptonContextMenuHeading2.Text = "关闭";
            // 
            // kryptonContextMenuItems2
            // 
            this.kryptonContextMenuItems2.Items.AddRange(
                new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[]
                {
                    this.kryptonContextMenuItem2, this.kryptonContextMenuItem3, this.kryptonContextMenuItem4,
                    this.kryptonContextMenuItem5, this.kryptonContextMenuItem6
                });
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.Tag = "close";
            this.kryptonContextMenuItem2.Text = "关闭";
            // 
            // kryptonContextMenuItem3
            // 
            this.kryptonContextMenuItem3.Tag = "closeOther";
            this.kryptonContextMenuItem3.Text = "关闭其他";
            // 
            // kryptonContextMenuItem4
            // 
            this.kryptonContextMenuItem4.Tag = "closeLeft";
            this.kryptonContextMenuItem4.Text = "关闭左边";
            // 
            // kryptonContextMenuItem5
            // 
            this.kryptonContextMenuItem5.Tag = "closeRight";
            this.kryptonContextMenuItem5.Text = "关闭右边";
            // 
            // kryptonContextMenuItem6
            // 
            this.kryptonContextMenuItem6.Tag = "closeAll";
            this.kryptonContextMenuItem6.Text = "关闭全部";
            // 
            // kryptonContextMenuHeading4
            // 
            this.kryptonContextMenuHeading4.ExtraText = "";
            this.kryptonContextMenuHeading4.Text = "退出";
            // 
            // kryptonContextMenuItems3
            // 
            this.kryptonContextMenuItems3.Items.AddRange(
                new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {this.kryptonContextMenuItem7});
            // 
            // kryptonContextMenuItem7
            // 
            this.kryptonContextMenuItem7.Tag = "exit";
            this.kryptonContextMenuItem7.Text = "退出";
            // 
            // kryptonContextMenuHeading3
            // 
            this.kryptonContextMenuHeading3.ExtraText = "";
            // 
            // MainForm
            // 
            this.AllowButtonSpecToolTips = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {this.btnspecAccount});
            this.ClientSize = new System.Drawing.Size(933, 638);
            this.Controls.Add(this._knavTab);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Appl4s";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize) (this._knavTab)).EndInit();
            this._knavTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this._kpageStart)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnspecAccount;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator _knavTab;
        private ComponentFactory.Krypton.Navigator.ButtonSpecNavigator btnspecAdd;
        private ComponentFactory.Krypton.Navigator.KryptonPage _kpageStart;
        private ComponentFactory.Krypton.Navigator.ButtonSpecNavigator btnspecRightSplit;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu _kctxmenuTabItem;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem8;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem9;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem10;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem3;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem4;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem5;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem6;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading4;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems3;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem7;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


namespace Appl4s.controls
{
    sealed partial class BrowserControl
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

        #region 组件设计器生成的代码

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._toolbar = new System.Windows.Forms.ToolStrip();
            this._toolbtnBack = new System.Windows.Forms.ToolStripButton();
            this._toolbtnForward = new System.Windows.Forms.ToolStripButton();
            this._toolbtnHome = new System.Windows.Forms.ToolStripButton();
            this._toolbtnReload = new System.Windows.Forms.ToolStripButton();
            this._toolbtnCancel = new System.Windows.Forms.ToolStripButton();
            this._toolbtnRecover = new System.Windows.Forms.ToolStripButton();
            this._toolbtnSettings = new System.Windows.Forms.ToolStripButton();
            this._toolbtnDownloads = new System.Windows.Forms.ToolStripButton();
            this._toolbtnApps = new System.Windows.Forms.ToolStripButton();
            this._toolbtnFullStar = new System.Windows.Forms.ToolStripButton();
            this._toolbtnStar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._kcmbAddress =
                new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonComboBoxToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._kctxmnSettings = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuHeading1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuHeading2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuItems2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuHeading3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuItems3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this._toolStatusBar = new ExtendedControls.ExtendedToolkit.FloatingFramework.Controls.FloatableToolStrip();
            this._toolprogressLoad = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._toollblStatus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this._toollblZoom = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this._centerPanel = new System.Windows.Forms.Panel();
            this._toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this._kcmbAddress.KryptonComboBoxControl)).BeginInit();
            this._toolStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // _toolbar
            // 
            this._toolbar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._toolbar.GripMargin = new System.Windows.Forms.Padding(0);
            this._toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._toolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this._toolbtnBack, this._toolbtnForward, this._toolbtnHome, this._toolbtnReload, this._toolbtnCancel,
                this._toolbtnRecover, this._toolbtnSettings, this._toolbtnDownloads, this._toolbtnApps,
                this._toolbtnFullStar, this._toolbtnStar, this.toolStripSeparator1, this._kcmbAddress,
                this.toolStripSeparator2
            });
            this._toolbar.Location = new System.Drawing.Point(0, 0);
            this._toolbar.Name = "_toolbar";
            this._toolbar.Size = new System.Drawing.Size(1063, 27);
            this._toolbar.TabIndex = 2;
            this._toolbar.Text = "_toolbar";
            // 
            // _toolbtnBack
            // 
            this._toolbtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolbtnBack.Image = global::Appl4s.Properties.Resources.back_24p;
            this._toolbtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolbtnBack.Name = "_toolbtnBack";
            this._toolbtnBack.Size = new System.Drawing.Size(24, 24);
            this._toolbtnBack.Text = "toolStripButton12";
            this._toolbtnBack.ToolTipText = "后退";
            // 
            // _toolbtnForward
            // 
            this._toolbtnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolbtnForward.Image = global::Appl4s.Properties.Resources.forward_24;
            this._toolbtnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolbtnForward.Name = "_toolbtnForward";
            this._toolbtnForward.Size = new System.Drawing.Size(24, 24);
            this._toolbtnForward.Text = "toolStripButton13";
            this._toolbtnForward.ToolTipText = "前进";
            // 
            // _toolbtnHome
            // 
            this._toolbtnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolbtnHome.Image = global::Appl4s.Properties.Resources.Home_24;
            this._toolbtnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolbtnHome.Name = "_toolbtnHome";
            this._toolbtnHome.Size = new System.Drawing.Size(24, 24);
            this._toolbtnHome.Text = "toolStripButton14";
            this._toolbtnHome.ToolTipText = "主页";
            // 
            // _toolbtnReload
            // 
            this._toolbtnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolbtnReload.Image = global::Appl4s.Properties.Resources.Refresh_24;
            this._toolbtnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolbtnReload.Name = "_toolbtnReload";
            this._toolbtnReload.Size = new System.Drawing.Size(24, 24);
            this._toolbtnReload.Text = "toolStripButton15";
            this._toolbtnReload.ToolTipText = "刷新";
            // 
            // _toolbtnCancel
            // 
            this._toolbtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolbtnCancel.Image = global::Appl4s.Properties.Resources.cancel_24;
            this._toolbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolbtnCancel.Name = "_toolbtnCancel";
            this._toolbtnCancel.Size = new System.Drawing.Size(24, 24);
            this._toolbtnCancel.Text = "toolStripButton16";
            this._toolbtnCancel.ToolTipText = "停止加载";
            this._toolbtnCancel.Visible = false;
            // 
            // _toolbtnRecover
            // 
            this._toolbtnRecover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolbtnRecover.Image = global::Appl4s.Properties.Resources.Go_into_24;
            this._toolbtnRecover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolbtnRecover.Name = "_toolbtnRecover";
            this._toolbtnRecover.Size = new System.Drawing.Size(24, 24);
            this._toolbtnRecover.Text = "toolStripButton17";
            this._toolbtnRecover.ToolTipText = "恢复上个页面";
            // 
            // _toolbtnSettings
            // 
            this._toolbtnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._toolbtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolbtnSettings.Image = global::Appl4s.Properties.Resources.config_24;
            this._toolbtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolbtnSettings.Name = "_toolbtnSettings";
            this._toolbtnSettings.Size = new System.Drawing.Size(24, 24);
            this._toolbtnSettings.Text = "toolStripButton18";
            this._toolbtnSettings.ToolTipText = "设置";
            this._toolbtnSettings.Click += new System.EventHandler(this._toolbtn_Click);
            // 
            // _toolbtnDownloads
            // 
            this._toolbtnDownloads.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._toolbtnDownloads.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolbtnDownloads.Image = global::Appl4s.Properties.Resources.download_24;
            this._toolbtnDownloads.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolbtnDownloads.Name = "_toolbtnDownloads";
            this._toolbtnDownloads.Size = new System.Drawing.Size(24, 24);
            this._toolbtnDownloads.Text = "toolStripButton19";
            this._toolbtnDownloads.ToolTipText = "下载列表";
            // 
            // _toolbtnApps
            // 
            this._toolbtnApps.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._toolbtnApps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolbtnApps.Image = global::Appl4s.Properties.Resources.application_x_z_compressed_24;
            this._toolbtnApps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolbtnApps.Name = "_toolbtnApps";
            this._toolbtnApps.Size = new System.Drawing.Size(24, 24);
            this._toolbtnApps.Text = "toolStripButton20";
            this._toolbtnApps.ToolTipText = "应用列表";
            // 
            // _toolbtnFullStar
            // 
            this._toolbtnFullStar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._toolbtnFullStar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolbtnFullStar.Image = global::Appl4s.Properties.Resources.star_full_24;
            this._toolbtnFullStar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolbtnFullStar.Name = "_toolbtnFullStar";
            this._toolbtnFullStar.Size = new System.Drawing.Size(24, 24);
            this._toolbtnFullStar.Text = "toolStripButton21";
            this._toolbtnFullStar.ToolTipText = "取消收藏";
            this._toolbtnFullStar.Visible = false;
            // 
            // _toolbtnStar
            // 
            this._toolbtnStar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._toolbtnStar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolbtnStar.Image = global::Appl4s.Properties.Resources.star_empty_24;
            this._toolbtnStar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolbtnStar.Name = "_toolbtnStar";
            this._toolbtnStar.Size = new System.Drawing.Size(24, 24);
            this._toolbtnStar.Text = "toolStripButton22";
            this._toolbtnStar.ToolTipText = "收藏";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // _kcmbAddress
            // 
            this._kcmbAddress.AutoSize = false;
            this._kcmbAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            // 
            // _kcmbAddress
            // 
            this._kcmbAddress.KryptonComboBoxControl.AccessibleName = "_kcmbAddress";
            this._kcmbAddress.KryptonComboBoxControl.DropDownHeight = 300;
            this._kcmbAddress.KryptonComboBoxControl.DropDownWidth = 121;
            this._kcmbAddress.KryptonComboBoxControl.Font = new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._kcmbAddress.KryptonComboBoxControl.Location = new System.Drawing.Point(126, 3);
            this._kcmbAddress.KryptonComboBoxControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._kcmbAddress.KryptonComboBoxControl.MaxDropDownItems = 10;
            this._kcmbAddress.KryptonComboBoxControl.Name = "_kcmbAddress";
            this._kcmbAddress.KryptonComboBoxControl.Size = new System.Drawing.Size(187, 21);
            this._kcmbAddress.KryptonComboBoxControl.StateCommon.ComboBox.Content.TextH =
                ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this._kcmbAddress.KryptonComboBoxControl.TabIndex = 2;
            this._kcmbAddress.KryptonComboBoxControl.ToolTipValues.Description = "输入链接地址或关键词查找内容";
            this._kcmbAddress.KryptonComboBoxControl.ToolTipValues.EnableToolTips = true;
            this._kcmbAddress.KryptonComboBoxControl.ToolTipValues.Heading = "地址框";
            this._kcmbAddress.Name = "_kcmbAddress";
            this._kcmbAddress.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this._kcmbAddress.SelectedIndex = -1;
            this._kcmbAddress.SelectedText = "";
            this._kcmbAddress.SelectedValue = null;
            this._kcmbAddress.Size = new System.Drawing.Size(187, 21);
            this._kcmbAddress.SelectedIndexChanged += new System.EventHandler(this._kcmbAddress_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // _kctxmnSettings
            // 
            this._kctxmnSettings.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[]
            {
                this.kryptonContextMenuHeading1, this.kryptonContextMenuItems1, this.kryptonContextMenuHeading2,
                this.kryptonContextMenuItems2, this.kryptonContextMenuHeading3, this.kryptonContextMenuItems3
            });
            // 
            // kryptonContextMenuHeading1
            // 
            this.kryptonContextMenuHeading1.ExtraText = "";
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(
                new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {this.kryptonContextMenuItem1});
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Text = "Menu Item";
            // 
            // kryptonContextMenuHeading2
            // 
            this.kryptonContextMenuHeading2.ExtraText = "";
            // 
            // kryptonContextMenuItems2
            // 
            this.kryptonContextMenuItems2.Items.AddRange(
                new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {this.kryptonContextMenuItem2});
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.Text = "Menu Item";
            // 
            // kryptonContextMenuHeading3
            // 
            this.kryptonContextMenuHeading3.ExtraText = "";
            // 
            // kryptonContextMenuItems3
            // 
            this.kryptonContextMenuItems3.Items.AddRange(
                new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {this.kryptonContextMenuItem3});
            // 
            // kryptonContextMenuItem3
            // 
            this.kryptonContextMenuItem3.Text = "Menu Item";
            // 
            // _toolStatusBar
            // 
            this._toolStatusBar.BackColor = System.Drawing.SystemColors.Control;
            this._toolStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._toolStatusBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._toolStatusBar.GripMargin = new System.Windows.Forms.Padding(0);
            this._toolStatusBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._toolStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._toolStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this._toolprogressLoad, this.toolStripSeparator3, this._toollblStatus, this.toolStripSeparator4,
                this._toollblZoom, this.toolStripSeparator6, this.toolStripButton1, this.toolStripSeparator7,
                this.toolStripButton2, this.toolStripSeparator8, this.toolStripButton3, this.toolStripSeparator9,
                this.toolStripLabel2
            });
            this._toolStatusBar.Location = new System.Drawing.Point(0, 720);
            this._toolStatusBar.Name = "_toolStatusBar";
            this._toolStatusBar.Size = new System.Drawing.Size(1063, 27);
            this._toolStatusBar.TabIndex = 3;
            this._toolStatusBar.Text = "statusbar";
            // 
            // _toolprogressLoad
            // 
            this._toolprogressLoad.AutoSize = false;
            this._toolprogressLoad.Name = "_toolprogressLoad";
            this._toolprogressLoad.Size = new System.Drawing.Size(100, 16);
            this._toolprogressLoad.ToolTipText = "加载进度";
            this._toolprogressLoad.Value = 30;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // _toollblStatus
            // 
            this._toollblStatus.Name = "_toollblStatus";
            this._toollblStatus.Size = new System.Drawing.Size(33, 24);
            this._toollblStatus.Text = "就绪";
            this._toollblStatus.ToolTipText = "状态";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // _toollblZoom
            // 
            this._toollblZoom.Name = "_toollblZoom";
            this._toollblZoom.Size = new System.Drawing.Size(67, 24);
            this._toollblZoom.Text = "缩放: 100%";
            this._toollblZoom.ToolTipText = "Ctrl键+鼠标上下滚动进行缩放";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Appl4s.Properties.Resources.folder_24;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "收藏夹";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Appl4s.Properties.Resources.Tests_24;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "历史记录";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Appl4s.Properties.Resources.Comment_24;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "消息通知";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(91, 24);
            this.toolStripLabel2.Text = "https://www..../";
            // 
            // _centerPanel
            // 
            this._centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._centerPanel.Location = new System.Drawing.Point(0, 27);
            this._centerPanel.Name = "_centerPanel";
            this._centerPanel.Size = new System.Drawing.Size(1063, 693);
            this._centerPanel.TabIndex = 4;
            // 
            // BrowserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this._centerPanel);
            this.Controls.Add(this._toolStatusBar);
            this.Controls.Add(this._toolbar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BrowserControl";
            this.Size = new System.Drawing.Size(1063, 747);
            this._toolbar.ResumeLayout(false);
            this._toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this._kcmbAddress.KryptonComboBoxControl)).EndInit();
            this._toolStatusBar.ResumeLayout(false);
            this._toolStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip _toolbar;
        private System.Windows.Forms.ToolStripButton _toolbtnBack;
        private System.Windows.Forms.ToolStripButton _toolbtnForward;
        private System.Windows.Forms.ToolStripButton _toolbtnHome;
        private System.Windows.Forms.ToolStripButton _toolbtnReload;
        private System.Windows.Forms.ToolStripButton _toolbtnCancel;
        private System.Windows.Forms.ToolStripButton _toolbtnRecover;
        private System.Windows.Forms.ToolStripButton _toolbtnSettings;
        private System.Windows.Forms.ToolStripButton _toolbtnDownloads;
        private System.Windows.Forms.ToolStripButton _toolbtnApps;
        private System.Windows.Forms.ToolStripButton _toolbtnFullStar;
        private System.Windows.Forms.ToolStripButton _toolbtnStar;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonComboBoxToolStripMenuItem _kcmbAddress;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu _kctxmnSettings;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading3;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems3;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem3;
        private ExtendedControls.ExtendedToolkit.FloatingFramework.Controls.FloatableToolStrip _toolStatusBar;
        private System.Windows.Forms.ToolStripProgressBar _toolprogressLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel _toollblStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel _toollblZoom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.Panel _centerPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

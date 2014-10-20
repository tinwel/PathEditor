namespace PathEditor
{
    partial class frmPathEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPath = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBrowse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTooltips = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxPathComponents = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShowErrors = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPathInput = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Snow;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPath,
            this.menuEdit,
            this.menuOptions,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPath
            // 
            this.menuPath.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLoad,
            this.menuItemSave,
            this.toolStripSeparator2,
            this.menuItemExit});
            this.menuPath.Name = "menuPath";
            this.menuPath.Size = new System.Drawing.Size(43, 20);
            this.menuPath.Text = "&Path";
            // 
            // menuItemLoad
            // 
            this.menuItemLoad.Name = "menuItemLoad";
            this.menuItemLoad.Size = new System.Drawing.Size(100, 22);
            this.menuItemLoad.Text = "&Load";
            this.menuItemLoad.Click += new System.EventHandler(this.menuItemLoad_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.Size = new System.Drawing.Size(100, 22);
            this.menuItemSave.Text = "&Save";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(97, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(100, 22);
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemBrowse,
            this.toolStripSeparator1,
            this.menuItemAdd,
            this.menuItemDelete});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "&Edit";
            // 
            // menuItemBrowse
            // 
            this.menuItemBrowse.Name = "menuItemBrowse";
            this.menuItemBrowse.Size = new System.Drawing.Size(112, 22);
            this.menuItemBrowse.Text = "&Browse";
            this.menuItemBrowse.Click += new System.EventHandler(this.menuItemBrowse_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // menuItemAdd
            // 
            this.menuItemAdd.Name = "menuItemAdd";
            this.menuItemAdd.Size = new System.Drawing.Size(112, 22);
            this.menuItemAdd.Text = "&Add";
            this.menuItemAdd.Click += new System.EventHandler(this.menuItemAdd_Click);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.Size = new System.Drawing.Size(112, 22);
            this.menuItemDelete.Text = "&Delete";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // menuOptions
            // 
            this.menuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTooltips});
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(61, 20);
            this.menuOptions.Text = "&Options";
            // 
            // menuItemTooltips
            // 
            this.menuItemTooltips.Checked = true;
            this.menuItemTooltips.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemTooltips.Name = "menuItemTooltips";
            this.menuItemTooltips.Size = new System.Drawing.Size(117, 22);
            this.menuItemTooltips.Text = "&Tooltips";
            this.menuItemTooltips.Click += new System.EventHandler(this.menuItemTooltips_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHelp,
            this.menuItemAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(107, 22);
            this.menuItemHelp.Text = "&Help";
            this.menuItemHelp.Click += new System.EventHandler(this.menuItemHelp_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(107, 22);
            this.menuItemAbout.Text = "&About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // listBoxPathComponents
            // 
            this.listBoxPathComponents.BackColor = System.Drawing.Color.Snow;
            this.listBoxPathComponents.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPathComponents.FormattingEnabled = true;
            this.listBoxPathComponents.Location = new System.Drawing.Point(4, 2);
            this.listBoxPathComponents.Name = "listBoxPathComponents";
            this.listBoxPathComponents.Size = new System.Drawing.Size(578, 277);
            this.listBoxPathComponents.TabIndex = 0;
            this.listBoxPathComponents.DoubleClick += new System.EventHandler(this.listBoxPathComponents_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.btnMoveDown);
            this.panel1.Controls.Add(this.btnMoveUp);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnShowErrors);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.txtPathInput);
            this.panel1.Controls.Add(this.listBoxPathComponents);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 362);
            this.panel1.TabIndex = 1;
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.BackColor = System.Drawing.Color.Azure;
            this.btnMoveDown.Image = global::PathEditor.Properties.Resources.down_28x28;
            this.btnMoveDown.Location = new System.Drawing.Point(588, 45);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(36, 36);
            this.btnMoveDown.TabIndex = 3;
            this.btnMoveDown.UseVisualStyleBackColor = false;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            this.btnMoveDown.MouseEnter += new System.EventHandler(this.MouseOver);
            this.btnMoveDown.MouseLeave += new System.EventHandler(this.MouseOut);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.BackColor = System.Drawing.Color.Azure;
            this.btnMoveUp.Image = global::PathEditor.Properties.Resources.up_28x28;
            this.btnMoveUp.Location = new System.Drawing.Point(588, 3);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(36, 36);
            this.btnMoveUp.TabIndex = 3;
            this.btnMoveUp.UseVisualStyleBackColor = false;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            this.btnMoveUp.MouseEnter += new System.EventHandler(this.MouseOver);
            this.btnMoveUp.MouseLeave += new System.EventHandler(this.MouseOut);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Azure;
            this.btnLoad.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Green;
            this.btnLoad.Image = global::PathEditor.Properties.Resources.refresh_28x28;
            this.btnLoad.Location = new System.Drawing.Point(490, 315);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(36, 36);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            this.btnLoad.MouseEnter += new System.EventHandler(this.MouseOver);
            this.btnLoad.MouseLeave += new System.EventHandler(this.MouseOut);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Azure;
            this.btnSave.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Green;
            this.btnSave.Image = global::PathEditor.Properties.Resources.save_28x28;
            this.btnSave.Location = new System.Drawing.Point(532, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.MouseOver);
            this.btnSave.MouseLeave += new System.EventHandler(this.MouseOut);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::PathEditor.Properties.Resources.portal_28x28;
            this.btnExit.Location = new System.Drawing.Point(574, 315);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.MouseOver);
            this.btnExit.MouseLeave += new System.EventHandler(this.MouseOut);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Azure;
            this.btnDelete.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Green;
            this.btnDelete.Image = global::PathEditor.Properties.Resources.minus_28x28;
            this.btnDelete.Location = new System.Drawing.Point(135, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 36);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.MouseOver);
            this.btnDelete.MouseLeave += new System.EventHandler(this.MouseOut);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Azure;
            this.btnAdd.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Green;
            this.btnAdd.Image = global::PathEditor.Properties.Resources.plus_28x28;
            this.btnAdd.Location = new System.Drawing.Point(93, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.MouseOver);
            this.btnAdd.MouseLeave += new System.EventHandler(this.MouseOut);
            // 
            // btnShowErrors
            // 
            this.btnShowErrors.Enabled = false;
            this.btnShowErrors.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowErrors.Location = new System.Drawing.Point(260, 315);
            this.btnShowErrors.Name = "btnShowErrors";
            this.btnShowErrors.Size = new System.Drawing.Size(120, 36);
            this.btnShowErrors.TabIndex = 2;
            this.btnShowErrors.Text = "Show Errors";
            this.btnShowErrors.UseVisualStyleBackColor = true;
            this.btnShowErrors.Visible = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Azure;
            this.btnBrowse.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Green;
            this.btnBrowse.Location = new System.Drawing.Point(4, 315);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(83, 36);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            this.btnBrowse.MouseEnter += new System.EventHandler(this.MouseOver);
            this.btnBrowse.MouseLeave += new System.EventHandler(this.MouseOut);
            // 
            // txtPathInput
            // 
            this.txtPathInput.BackColor = System.Drawing.Color.Snow;
            this.txtPathInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathInput.Location = new System.Drawing.Point(3, 283);
            this.txtPathInput.Name = "txtPathInput";
            this.txtPathInput.Size = new System.Drawing.Size(621, 26);
            this.txtPathInput.TabIndex = 1;
            this.txtPathInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPathInput_KeyPress);
            this.txtPathInput.MouseEnter += new System.EventHandler(this.MouseOver);
            this.txtPathInput.MouseLeave += new System.EventHandler(this.MouseOut);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.Snow;
            this.txtStatus.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.Black;
            this.txtStatus.Location = new System.Drawing.Point(0, 357);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(627, 91);
            this.txtStatus.TabIndex = 2;
            this.txtStatus.Text = "This area will display the path string that is built from the current list.\r\n";
            this.txtStatus.MouseEnter += new System.EventHandler(this.MouseOver);
            this.txtStatus.MouseLeave += new System.EventHandler(this.MouseOut);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtStatus);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(627, 448);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(627, 472);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // frmPathEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(627, 472);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPathEditor";
            this.Text = "Path Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPathEditor_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPath;
        private System.Windows.Forms.ToolStripMenuItem menuItemLoad;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuOptions;
        private System.Windows.Forms.ToolStripMenuItem menuItemTooltips;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.ListBox listBoxPathComponents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShowErrors;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPathInput;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuItemBrowse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}


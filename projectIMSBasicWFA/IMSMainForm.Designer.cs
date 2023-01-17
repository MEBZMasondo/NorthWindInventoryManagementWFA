namespace projectIMSBasicWFA
{
    partial class IMSMainForm
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
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.reorderCheckBox = new System.Windows.Forms.CheckBox();
            this.dynamicSearchCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchByNameRadioButton = new System.Windows.Forms.RadioButton();
            this.searchByIDRadioButton = new System.Windows.Forms.RadioButton();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateQuantitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acivateDeactivateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowStockButton = new System.Windows.Forms.Button();
            this.lowStockCheckBox = new System.Windows.Forms.CheckBox();
            this.lowLimitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateQuantButton = new System.Windows.Forms.Button();
            this.actReactButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.gridGroupBox = new System.Windows.Forms.GroupBox();
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.gridGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.reorderCheckBox);
            this.searchGroupBox.Controls.Add(this.dynamicSearchCheckBox);
            this.searchGroupBox.Controls.Add(this.clearButton);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Controls.Add(this.searchByNameRadioButton);
            this.searchGroupBox.Controls.Add(this.searchByIDRadioButton);
            this.searchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGroupBox.Location = new System.Drawing.Point(12, 27);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(1315, 115);
            this.searchGroupBox.TabIndex = 0;
            this.searchGroupBox.TabStop = false;
            // 
            // reorderCheckBox
            // 
            this.reorderCheckBox.AutoSize = true;
            this.reorderCheckBox.Location = new System.Drawing.Point(831, 66);
            this.reorderCheckBox.Name = "reorderCheckBox";
            this.reorderCheckBox.Size = new System.Drawing.Size(309, 28);
            this.reorderCheckBox.TabIndex = 8;
            this.reorderCheckBox.Text = "Colour Code Products to Reorder";
            this.reorderCheckBox.UseVisualStyleBackColor = true;
            this.reorderCheckBox.CheckedChanged += new System.EventHandler(this.reorderCheckBox_CheckedChanged);
            // 
            // dynamicSearchCheckBox
            // 
            this.dynamicSearchCheckBox.AutoSize = true;
            this.dynamicSearchCheckBox.Location = new System.Drawing.Point(831, 32);
            this.dynamicSearchCheckBox.Name = "dynamicSearchCheckBox";
            this.dynamicSearchCheckBox.Size = new System.Drawing.Size(205, 28);
            this.dynamicSearchCheckBox.TabIndex = 7;
            this.dynamicSearchCheckBox.Text = "Use Dynamic Search";
            this.dynamicSearchCheckBox.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(526, 71);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(252, 35);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(526, 28);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(252, 35);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(16, 68);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(407, 29);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchByNameRadioButton
            // 
            this.searchByNameRadioButton.AutoSize = true;
            this.searchByNameRadioButton.Checked = true;
            this.searchByNameRadioButton.Location = new System.Drawing.Point(16, 25);
            this.searchByNameRadioButton.Name = "searchByNameRadioButton";
            this.searchByNameRadioButton.Size = new System.Drawing.Size(170, 28);
            this.searchByNameRadioButton.TabIndex = 3;
            this.searchByNameRadioButton.TabStop = true;
            this.searchByNameRadioButton.Text = "Search By Name";
            this.searchByNameRadioButton.UseVisualStyleBackColor = true;
            this.searchByNameRadioButton.CheckedChanged += new System.EventHandler(this.searchByNameRadioButton_CheckedChanged);
            // 
            // searchByIDRadioButton
            // 
            this.searchByIDRadioButton.AutoSize = true;
            this.searchByIDRadioButton.Location = new System.Drawing.Point(224, 25);
            this.searchByIDRadioButton.Name = "searchByIDRadioButton";
            this.searchByIDRadioButton.Size = new System.Drawing.Size(136, 28);
            this.searchByIDRadioButton.TabIndex = 2;
            this.searchByIDRadioButton.Text = "Search By ID";
            this.searchByIDRadioButton.UseVisualStyleBackColor = true;
            this.searchByIDRadioButton.CheckedChanged += new System.EventHandler(this.searchByIDRadioButton_CheckedChanged);
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(6, 14);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(1303, 373);
            this.productDataGridView.TabIndex = 1;
            this.productDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellClick);
            this.productDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.productDataGridView_CellFormatting);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.functionsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1339, 29);
            this.mainMenuStrip.TabIndex = 2;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::projectIMSBasicWFA.Properties.Resources.file;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::projectIMSBasicWFA.Properties.Resources.sign_out;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewItemToolStripMenuItem,
            this.updateItemToolStripMenuItem,
            this.updateQuantitiesToolStripMenuItem,
            this.acivateDeactivateProductToolStripMenuItem});
            this.functionsToolStripMenuItem.Image = global::projectIMSBasicWFA.Properties.Resources.function;
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(112, 25);
            this.functionsToolStripMenuItem.Text = "&Functions";
            // 
            // addNewItemToolStripMenuItem
            // 
            this.addNewItemToolStripMenuItem.Image = global::projectIMSBasicWFA.Properties.Resources.plus_circle;
            this.addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
            this.addNewItemToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.addNewItemToolStripMenuItem.Text = "Add Product";
            // 
            // updateItemToolStripMenuItem
            // 
            this.updateItemToolStripMenuItem.Image = global::projectIMSBasicWFA.Properties.Resources.note;
            this.updateItemToolStripMenuItem.Name = "updateItemToolStripMenuItem";
            this.updateItemToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.updateItemToolStripMenuItem.Text = "Update Product";
            // 
            // updateQuantitiesToolStripMenuItem
            // 
            this.updateQuantitiesToolStripMenuItem.Image = global::projectIMSBasicWFA.Properties.Resources.note;
            this.updateQuantitiesToolStripMenuItem.Name = "updateQuantitiesToolStripMenuItem";
            this.updateQuantitiesToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.updateQuantitiesToolStripMenuItem.Text = "Update Product Quantities";
            // 
            // acivateDeactivateProductToolStripMenuItem
            // 
            this.acivateDeactivateProductToolStripMenuItem.Image = global::projectIMSBasicWFA.Properties.Resources.swap;
            this.acivateDeactivateProductToolStripMenuItem.Name = "acivateDeactivateProductToolStripMenuItem";
            this.acivateDeactivateProductToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.acivateDeactivateProductToolStripMenuItem.Text = "Acivate/Deactivate Product";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::projectIMSBasicWFA.Properties.Resources.info;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(74, 25);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::projectIMSBasicWFA.Properties.Resources.info;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::projectIMSBasicWFA.Properties.Resources.sign_out;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.logOutToolStripMenuItem.Text = "&Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // lowStockButton
            // 
            this.lowStockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowStockButton.Location = new System.Drawing.Point(1107, 545);
            this.lowStockButton.Name = "lowStockButton";
            this.lowStockButton.Size = new System.Drawing.Size(208, 52);
            this.lowStockButton.TabIndex = 3;
            this.lowStockButton.Text = "View Low Stock";
            this.lowStockButton.UseVisualStyleBackColor = true;
            this.lowStockButton.Click += new System.EventHandler(this.lowStockButton_Click);
            // 
            // lowStockCheckBox
            // 
            this.lowStockCheckBox.AutoSize = true;
            this.lowStockCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowStockCheckBox.Location = new System.Drawing.Point(1107, 603);
            this.lowStockCheckBox.Name = "lowStockCheckBox";
            this.lowStockCheckBox.Size = new System.Drawing.Size(208, 28);
            this.lowStockCheckBox.TabIndex = 4;
            this.lowStockCheckBox.Text = "Set Custom Low Limit";
            this.lowStockCheckBox.UseVisualStyleBackColor = true;
            this.lowStockCheckBox.CheckedChanged += new System.EventHandler(this.lowStockCheckBox_CheckedChanged);
            // 
            // lowLimitTextBox
            // 
            this.lowLimitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowLimitTextBox.Location = new System.Drawing.Point(1210, 646);
            this.lowLimitTextBox.Name = "lowLimitTextBox";
            this.lowLimitTextBox.ReadOnly = true;
            this.lowLimitTextBox.Size = new System.Drawing.Size(105, 29);
            this.lowLimitTextBox.TabIndex = 5;
            this.lowLimitTextBox.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1103, 651);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Low Limit";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(12, 565);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(263, 52);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add Product";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(12, 623);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(263, 52);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update Product";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateQuantButton
            // 
            this.updateQuantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateQuantButton.Location = new System.Drawing.Point(331, 565);
            this.updateQuantButton.Name = "updateQuantButton";
            this.updateQuantButton.Size = new System.Drawing.Size(263, 52);
            this.updateQuantButton.TabIndex = 9;
            this.updateQuantButton.Text = "Update Stock Quantity";
            this.updateQuantButton.UseVisualStyleBackColor = true;
            this.updateQuantButton.Click += new System.EventHandler(this.updateQuantButton_Click);
            // 
            // actReactButton
            // 
            this.actReactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actReactButton.Location = new System.Drawing.Point(331, 623);
            this.actReactButton.Name = "actReactButton";
            this.actReactButton.Size = new System.Drawing.Size(263, 52);
            this.actReactButton.TabIndex = 10;
            this.actReactButton.Text = "Activate/Deactivate Product";
            this.actReactButton.UseVisualStyleBackColor = true;
            this.actReactButton.Click += new System.EventHandler(this.actReactButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(640, 565);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(263, 52);
            this.refreshButton.TabIndex = 11;
            this.refreshButton.Text = "Reset/refresh Data";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // gridGroupBox
            // 
            this.gridGroupBox.Controls.Add(this.productDataGridView);
            this.gridGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupBox.Location = new System.Drawing.Point(12, 148);
            this.gridGroupBox.Name = "gridGroupBox";
            this.gridGroupBox.Size = new System.Drawing.Size(1315, 393);
            this.gridGroupBox.TabIndex = 12;
            this.gridGroupBox.TabStop = false;
            // 
            // IMSMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 687);
            this.Controls.Add(this.gridGroupBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.actReactButton);
            this.Controls.Add(this.updateQuantButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lowLimitTextBox);
            this.Controls.Add(this.lowStockCheckBox);
            this.Controls.Add(this.lowStockButton);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "IMSMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMSMainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IMSMainForm_FormClosed);
            this.Load += new System.EventHandler(this.IMSMainForm_Load);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.gridGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.RadioButton searchByNameRadioButton;
        private System.Windows.Forms.RadioButton searchByIDRadioButton;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateQuantitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button lowStockButton;
        private System.Windows.Forms.CheckBox lowStockCheckBox;
        private System.Windows.Forms.TextBox lowLimitTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button updateQuantButton;
        private System.Windows.Forms.Button actReactButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.CheckBox reorderCheckBox;
        private System.Windows.Forms.CheckBox dynamicSearchCheckBox;
        private System.Windows.Forms.ToolStripMenuItem acivateDeactivateProductToolStripMenuItem;
        private System.Windows.Forms.GroupBox gridGroupBox;
    }
}
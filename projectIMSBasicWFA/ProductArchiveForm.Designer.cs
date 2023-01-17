namespace projectIMSBasicWFA
{
    partial class ProductArchiveForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.applyActiveButton = new System.Windows.Forms.Button();
            this.prodActiveDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.applyInactiveButton = new System.Windows.Forms.Button();
            this.prodInactiveDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodActiveDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodInactiveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(4, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(697, 428);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.applyActiveButton);
            this.tabPage1.Controls.Add(this.prodActiveDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(689, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Active Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // applyActiveButton
            // 
            this.applyActiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyActiveButton.Location = new System.Drawing.Point(489, 345);
            this.applyActiveButton.Name = "applyActiveButton";
            this.applyActiveButton.Size = new System.Drawing.Size(186, 44);
            this.applyActiveButton.TabIndex = 1;
            this.applyActiveButton.Text = "Deactivate Product";
            this.applyActiveButton.UseVisualStyleBackColor = true;
            this.applyActiveButton.Click += new System.EventHandler(this.applyActiveButton_Click);
            // 
            // prodActiveDataGridView
            // 
            this.prodActiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodActiveDataGridView.Location = new System.Drawing.Point(8, 70);
            this.prodActiveDataGridView.Name = "prodActiveDataGridView";
            this.prodActiveDataGridView.Size = new System.Drawing.Size(667, 269);
            this.prodActiveDataGridView.TabIndex = 0;
            this.prodActiveDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.prodActiveDataGridView_CellFormatting);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.applyInactiveButton);
            this.tabPage2.Controls.Add(this.prodInactiveDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(689, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inactive Products";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // applyInactiveButton
            // 
            this.applyInactiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyInactiveButton.Location = new System.Drawing.Point(489, 345);
            this.applyInactiveButton.Name = "applyInactiveButton";
            this.applyInactiveButton.Size = new System.Drawing.Size(186, 44);
            this.applyInactiveButton.TabIndex = 3;
            this.applyInactiveButton.Text = "Activate Product";
            this.applyInactiveButton.UseVisualStyleBackColor = true;
            this.applyInactiveButton.Click += new System.EventHandler(this.applyInactiveButton_Click);
            // 
            // prodInactiveDataGridView
            // 
            this.prodInactiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodInactiveDataGridView.Location = new System.Drawing.Point(8, 70);
            this.prodInactiveDataGridView.Name = "prodInactiveDataGridView";
            this.prodInactiveDataGridView.Size = new System.Drawing.Size(667, 269);
            this.prodInactiveDataGridView.TabIndex = 2;
            this.prodInactiveDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.prodInactiveDataGridView_CellFormatting);
            // 
            // ProductArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 451);
            this.Controls.Add(this.tabControl);
            this.Name = "ProductArchiveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductArchiveForm";
            this.Load += new System.EventHandler(this.ProductArchiveForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prodActiveDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prodInactiveDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button applyActiveButton;
        private System.Windows.Forms.DataGridView prodActiveDataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button applyInactiveButton;
        private System.Windows.Forms.DataGridView prodInactiveDataGridView;
    }
}
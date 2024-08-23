﻿namespace DoctorERP_v2_00.Dialogs
{
    partial class FlyoutAddCarOrDriver
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.ExitButton = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.saveButton = new Telerik.WinControls.UI.RadButton();
            this.editPanel = new Telerik.WinControls.UI.RadPanel();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.idTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.idLabel = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPanel)).BeginInit();
            this.editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.ForeColor = System.Drawing.Color.Snow;
            this.ExitButton.Location = new System.Drawing.Point(15, 388);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(77, 36);
            this.ExitButton.TabIndex = 44;
            this.ExitButton.Text = "خروج";
            this.ExitButton.ThemeName = "Material";
            this.ExitButton.Click += new System.EventHandler(this.RadButtonCancel_Click);
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(115, 388);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(100, 36);
            this.radButton3.TabIndex = 43;
            this.radButton3.Text = "إلغاء";
            this.radButton3.ThemeName = "Material";
            this.radButton3.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(221, 388);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 36);
            this.saveButton.TabIndex = 41;
            this.saveButton.Text = "حفظ";
            this.saveButton.ThemeName = "Material";
            this.saveButton.Click += new System.EventHandler(this.RadButtonOK_Click);
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.radTextBox2);
            this.editPanel.Controls.Add(this.idTextBox);
            this.editPanel.Controls.Add(this.radLabel2);
            this.editPanel.Controls.Add(this.radTextBox1);
            this.editPanel.Controls.Add(this.radLabel3);
            this.editPanel.Controls.Add(this.radDropDownList1);
            this.editPanel.Controls.Add(this.radLabel1);
            this.editPanel.Controls.Add(this.idLabel);
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editPanel.Location = new System.Drawing.Point(0, 0);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(338, 363);
            this.editPanel.TabIndex = 42;
            this.editPanel.ThemeName = "Material";
            // 
            // radTextBox2
            // 
            this.radTextBox2.AutoSize = false;
            this.radTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox2.Location = new System.Drawing.Point(19, 108);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.NullText = "ادخل اسم السائق";
            this.radTextBox2.ShowNullText = true;
            this.radTextBox2.Size = new System.Drawing.Size(302, 40);
            this.radTextBox2.TabIndex = 34;
            this.radTextBox2.TextChanged += new System.EventHandler(this.radTextBox2_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.AutoSize = false;
            this.idTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(19, 188);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.NullText = "ادخل رقم البطاقة";
            this.idTextBox.ShowNullText = true;
            this.idTextBox.Size = new System.Drawing.Size(302, 40);
            this.idTextBox.TabIndex = 33;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(29, 244);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(285, 40);
            this.radLabel2.TabIndex = 32;
            this.radLabel2.Text = "ملاحظات";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.radLabel2.ThemeName = "Material";
            this.radLabel2.Click += new System.EventHandler(this.radLabel2_Click);
            // 
            // radTextBox1
            // 
            this.radTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox1.Location = new System.Drawing.Point(16, 284);
            this.radTextBox1.Multiline = true;
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.NullText = "ادخل الملاحظات أن وجدت";
            // 
            // 
            // 
            this.radTextBox1.RootElement.StretchVertically = true;
            this.radTextBox1.ShowNullText = true;
            this.radTextBox1.Size = new System.Drawing.Size(305, 69);
            this.radTextBox1.TabIndex = 31;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(237, 22);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(85, 25);
            this.radLabel3.TabIndex = 30;
            this.radLabel3.Text = "نوع البيان : ";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel3.Click += new System.EventHandler(this.radLabel3_Click);
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.DropDownAnimationEnabled = true;
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Text = "سائق";
            radListDataItem2.Text = "سيارة";
            this.radDropDownList1.Items.Add(radListDataItem1);
            this.radDropDownList1.Items.Add(radListDataItem2);
            this.radDropDownList1.Location = new System.Drawing.Point(67, 16);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(167, 36);
            this.radDropDownList1.TabIndex = 28;
            this.radDropDownList1.ThemeName = "Material";
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList1_SelectedIndexChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(29, 148);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(285, 40);
            this.radLabel1.TabIndex = 25;
            this.radLabel1.Text = "رقم البطاقة";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.radLabel1.ThemeName = "Material";
            this.radLabel1.Click += new System.EventHandler(this.radLabel1_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = false;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(29, 67);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(285, 40);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "أسم السائق";
            this.idLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.idLabel.ThemeName = "Material";
            this.idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // FlyoutAddCarOrDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editPanel);
            this.Name = "FlyoutAddCarOrDriver";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(338, 442);
            this.Load += new System.EventHandler(this.FlyoutAddCarOrDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPanel)).EndInit();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idLabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton ExitButton;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton saveButton;
        private Telerik.WinControls.UI.RadPanel editPanel;
        private Telerik.WinControls.UI.RadTextBox idTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel idLabel;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
    }
}

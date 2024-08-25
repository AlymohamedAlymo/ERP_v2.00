﻿namespace DoctorERP_v2_00.FlyoutDialogs
{
    partial class FlyoutAddCar
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
            this.ExitButton = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.saveButton = new Telerik.WinControls.UI.RadButton();
            this.editPanel = new Telerik.WinControls.UI.RadPanel();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.idLabel = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPanel)).BeginInit();
            this.editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.ForeColor = System.Drawing.Color.Snow;
            this.ExitButton.Location = new System.Drawing.Point(15, 302);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(77, 36);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "خروج";
            this.ExitButton.ThemeName = "Material";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(115, 302);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(100, 36);
            this.radButton3.TabIndex = 3;
            this.radButton3.Text = "إلغاء";
            this.radButton3.ThemeName = "Material";
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(221, 302);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 36);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "حفظ";
            this.saveButton.ThemeName = "Material";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.radTextBox2);
            this.editPanel.Controls.Add(this.radLabel2);
            this.editPanel.Controls.Add(this.radTextBox1);
            this.editPanel.Controls.Add(this.radLabel3);
            this.editPanel.Controls.Add(this.idLabel);
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editPanel.Location = new System.Drawing.Point(0, 0);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(338, 278);
            this.editPanel.TabIndex = 46;
            this.editPanel.ThemeName = "Material";
            // 
            // radTextBox2
            // 
            this.radTextBox2.AutoSize = false;
            this.radTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox2.Location = new System.Drawing.Point(19, 108);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.NullText = "ادخل رقم الصهريج";
            this.radTextBox2.ShowNullText = true;
            this.radTextBox2.Size = new System.Drawing.Size(302, 40);
            this.radTextBox2.TabIndex = 0;
            this.radTextBox2.TextChanged += new System.EventHandler(this.radTextBox2_TextChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(251, 170);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(70, 25);
            this.radLabel2.TabIndex = 32;
            this.radLabel2.Text = "ملاحظات";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel2.ThemeName = "Material";
            this.radLabel2.Click += new System.EventHandler(this.radLabel2_Click);
            // 
            // radTextBox1
            // 
            this.radTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox1.Location = new System.Drawing.Point(16, 200);
            this.radTextBox1.Multiline = true;
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.NullText = "ادخل الملاحظات أن وجدت";
            // 
            // 
            // 
            this.radTextBox1.RootElement.StretchVertically = true;
            this.radTextBox1.ShowNullText = true;
            this.radTextBox1.Size = new System.Drawing.Size(305, 69);
            this.radTextBox1.TabIndex = 1;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(196, 3);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(139, 25);
            this.radLabel3.TabIndex = 30;
            this.radLabel3.Text = "تسجيل سيارة جديدة";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(227, 77);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(94, 25);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "رقم الصهريج";
            this.idLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.idLabel.ThemeName = "Material";
            this.idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // FlyoutAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editPanel);
            this.Name = "FlyoutAddCar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(338, 355);
            this.Load += new System.EventHandler(this.FlyoutAddCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPanel)).EndInit();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idLabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton ExitButton;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton saveButton;
        private Telerik.WinControls.UI.RadPanel editPanel;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel idLabel;
    }
}

﻿namespace OcrHelper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel_Image = new System.Windows.Forms.Panel();
            this.button_StartOcr = new System.Windows.Forms.Button();
            this.checkBox_Auto = new System.Windows.Forms.CheckBox();
            this.richTextBox_Result = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel_Image);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.button_StartOcr);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_Auto);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox_Result);
            this.splitContainer1.Size = new System.Drawing.Size(534, 156);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel_Image
            // 
            this.panel_Image.BackColor = System.Drawing.Color.Transparent;
            this.panel_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Image.Location = new System.Drawing.Point(0, 0);
            this.panel_Image.Name = "panel_Image";
            this.panel_Image.Size = new System.Drawing.Size(283, 156);
            this.panel_Image.TabIndex = 0;
            // 
            // button_StartOcr
            // 
            this.button_StartOcr.Enabled = false;
            this.button_StartOcr.Location = new System.Drawing.Point(18, 6);
            this.button_StartOcr.Name = "button_StartOcr";
            this.button_StartOcr.Size = new System.Drawing.Size(75, 23);
            this.button_StartOcr.TabIndex = 2;
            this.button_StartOcr.Text = "识别";
            this.button_StartOcr.UseVisualStyleBackColor = true;
            this.button_StartOcr.Click += new System.EventHandler(this.button_StartOcr_Click);
            // 
            // checkBox_Auto
            // 
            this.checkBox_Auto.AutoSize = true;
            this.checkBox_Auto.Checked = true;
            this.checkBox_Auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Auto.Location = new System.Drawing.Point(193, 8);
            this.checkBox_Auto.Name = "checkBox_Auto";
            this.checkBox_Auto.Size = new System.Drawing.Size(51, 21);
            this.checkBox_Auto.TabIndex = 1;
            this.checkBox_Auto.Text = "自动";
            this.checkBox_Auto.UseVisualStyleBackColor = true;
            this.checkBox_Auto.CheckedChanged += new System.EventHandler(this.checkBox_Auto_CheckedChanged);
            // 
            // richTextBox_Result
            // 
            this.richTextBox_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_Result.Location = new System.Drawing.Point(0, 35);
            this.richTextBox_Result.Name = "richTextBox_Result";
            this.richTextBox_Result.Size = new System.Drawing.Size(247, 121);
            this.richTextBox_Result.TabIndex = 0;
            this.richTextBox_Result.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 156);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文字识别助手";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel_Image;
        private RichTextBox richTextBox_Result;
        private Button button_StartOcr;
        private CheckBox checkBox_Auto;
    }
}
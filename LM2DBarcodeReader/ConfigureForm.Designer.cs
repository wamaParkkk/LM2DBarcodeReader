﻿
namespace LM2DBarcodeReader
{
    partial class ConfigureForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnParameterSave = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.txtBoxConfigItem1 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnParameterSave);
            this.groupBox1.Controls.Add(this.txtBoxConfigItem1);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(323, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(538, 241);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "< Time >";
            // 
            // btnParameterSave
            // 
            this.btnParameterSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnParameterSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParameterSave.FlatAppearance.BorderSize = 0;
            this.btnParameterSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParameterSave.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParameterSave.ForeColor = System.Drawing.Color.Navy;
            this.btnParameterSave.ImageIndex = 0;
            this.btnParameterSave.ImageList = this.imageList;
            this.btnParameterSave.Location = new System.Drawing.Point(402, 178);
            this.btnParameterSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnParameterSave.Name = "btnParameterSave";
            this.btnParameterSave.Size = new System.Drawing.Size(126, 51);
            this.btnParameterSave.TabIndex = 41;
            this.btnParameterSave.Text = "Save";
            this.btnParameterSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParameterSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParameterSave.UseVisualStyleBackColor = true;
            this.btnParameterSave.Click += new System.EventHandler(this.btnParameterSave_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Save.png");
            // 
            // txtBoxConfigItem1
            // 
            this.txtBoxConfigItem1.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxConfigItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxConfigItem1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfigItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxConfigItem1.Location = new System.Drawing.Point(236, 47);
            this.txtBoxConfigItem1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxConfigItem1.Name = "txtBoxConfigItem1";
            this.txtBoxConfigItem1.ReadOnly = true;
            this.txtBoxConfigItem1.Size = new System.Drawing.Size(152, 30);
            this.txtBoxConfigItem1.TabIndex = 30;
            this.txtBoxConfigItem1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxConfigItem1.Click += new System.EventHandler(this.txtBoxDoorOpenCloseTimeout_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Navy;
            this.label27.Location = new System.Drawing.Point(21, 49);
            this.label27.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(205, 25);
            this.label27.TabIndex = 22;
            this.label27.Text = "Barcode read timeout";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Navy;
            this.label26.Location = new System.Drawing.Point(398, 56);
            this.label26.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 21);
            this.label26.TabIndex = 24;
            this.label26.Text = "sec";
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 824);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ConfigureForm";
            this.Text = "Configure";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigureForm_FormClosing);
            this.Load += new System.EventHandler(this.ConfigureForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnParameterSave;
        private System.Windows.Forms.TextBox txtBoxConfigItem1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ImageList imageList;
    }
}
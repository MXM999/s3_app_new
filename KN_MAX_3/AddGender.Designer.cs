﻿namespace KN_MAX_3
{
    partial class AddGender
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
            this.name_gr = new System.Windows.Forms.TextBox();
            this.ADD_bt = new System.Windows.Forms.Button();
            this.BACK_BT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_gr
            // 
            this.name_gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.name_gr.ForeColor = System.Drawing.Color.Green;
            this.name_gr.Location = new System.Drawing.Point(183, 114);
            this.name_gr.Name = "name_gr";
            this.name_gr.Size = new System.Drawing.Size(162, 30);
            this.name_gr.TabIndex = 0;
            // 
            // ADD_bt
            // 
            this.ADD_bt.BackColor = System.Drawing.Color.Transparent;
            this.ADD_bt.BackgroundImage = global::KN_MAX_3.Properties.Resources.Picsart_25_05_17_21_27_45_063;
            this.ADD_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ADD_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADD_bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ADD_bt.FlatAppearance.BorderSize = 0;
            this.ADD_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ADD_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ADD_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADD_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ADD_bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ADD_bt.Location = new System.Drawing.Point(190, 180);
            this.ADD_bt.Name = "ADD_bt";
            this.ADD_bt.Size = new System.Drawing.Size(149, 63);
            this.ADD_bt.TabIndex = 5;
            this.ADD_bt.Text = "ADD";
            this.ADD_bt.UseVisualStyleBackColor = false;
            this.ADD_bt.Click += new System.EventHandler(this.ADD_bt_Click);
            // 
            // BACK_BT
            // 
            this.BACK_BT.BackColor = System.Drawing.Color.Transparent;
            this.BACK_BT.BackgroundImage = global::KN_MAX_3.Properties.Resources.Picsart_25_05_17_21_26_18_371___Copy;
            this.BACK_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BACK_BT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BACK_BT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BACK_BT.FlatAppearance.BorderSize = 0;
            this.BACK_BT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BACK_BT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BACK_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BACK_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BACK_BT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BACK_BT.Location = new System.Drawing.Point(12, 235);
            this.BACK_BT.Name = "BACK_BT";
            this.BACK_BT.Size = new System.Drawing.Size(149, 63);
            this.BACK_BT.TabIndex = 6;
            this.BACK_BT.Text = "BACK";
            this.BACK_BT.UseVisualStyleBackColor = false;
            this.BACK_BT.Click += new System.EventHandler(this.BACK_BT_Click);
            // 
            // AddGender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KN_MAX_3.Properties.Resources.dark_purple_oppo_r15_stock;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 310);
            this.Controls.Add(this.BACK_BT);
            this.Controls.Add(this.ADD_bt);
            this.Controls.Add(this.name_gr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddGender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD Gender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_gr;
        private System.Windows.Forms.Button ADD_bt;
        private System.Windows.Forms.Button BACK_BT;
    }
}
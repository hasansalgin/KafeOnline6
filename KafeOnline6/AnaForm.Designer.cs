﻿namespace KafeOnline6
{
    partial class AnaForm
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
            menuStrip1 = new MenuStrip();
            lvwMasalar = new ListView();
            tsmiUrunler = new ToolStripMenuItem();
            tsmiGecmisSiparisler = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.MistyRose;
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiUrunler, tsmiGecmisSiparisler });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // lvwMasalar
            // 
            lvwMasalar.Dock = DockStyle.Fill;
            lvwMasalar.Location = new Point(0, 24);
            lvwMasalar.Name = "lvwMasalar";
            lvwMasalar.Size = new Size(800, 426);
            lvwMasalar.TabIndex = 1;
            lvwMasalar.UseCompatibleStateImageBehavior = false;
            // 
            // tsmiUrunler
            // 
            tsmiUrunler.Name = "tsmiUrunler";
            tsmiUrunler.Size = new Size(58, 20);
            tsmiUrunler.Text = "Ürünler";
            // 
            // tsmiGecmisSiparisler
            // 
            tsmiGecmisSiparisler.Name = "tsmiGecmisSiparisler";
            tsmiGecmisSiparisler.Size = new Size(108, 20);
            tsmiGecmisSiparisler.Text = "Geçmiş Siparişler";
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvwMasalar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KAFE ONLİNE 6";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiUrunler;
        private ToolStripMenuItem tsmiGecmisSiparisler;
        private ListView lvwMasalar;
    }
}
﻿using WinFormsApp1.Model;

namespace WinFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            textBinance = new Label();
            outModelBindingSource = new BindingSource(components);
            textBybit = new Label();
            textkucoin = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)outModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBinance
            // 
            textBinance.AccessibleName = "";
            textBinance.AutoSize = true;
            textBinance.DataBindings.Add(new Binding("Text", outModelBindingSource, "Binance", true, DataSourceUpdateMode.OnPropertyChanged));
            textBinance.Location = new Point(12, 35);
            textBinance.Name = "textBinance";
            textBinance.Size = new Size(86, 20);
            textBinance.TabIndex = 0;
            textBinance.Text = "textBinance";
            // 
            // outModelBindingSource
            // 
            outModelBindingSource.DataSource = typeof(OutModel);
            // 
            // textBybit
            // 
            textBybit.AutoSize = true;
            textBybit.DataBindings.Add(new Binding("Text", outModelBindingSource, "ByBit", true, DataSourceUpdateMode.OnPropertyChanged));
            textBybit.Location = new Point(12, 64);
            textBybit.Name = "textBybit";
            textBybit.Size = new Size(68, 20);
            textBybit.TabIndex = 1;
            textBybit.Text = "textBybit";
            // 
            // textkucoin
            // 
            textkucoin.AutoSize = true;
            textkucoin.DataBindings.Add(new Binding("Text", outModelBindingSource, "Kucoin", true, DataSourceUpdateMode.OnPropertyChanged));
            textkucoin.Location = new Point(12, 93);
            textkucoin.Name = "textkucoin";
            textkucoin.Size = new Size(77, 20);
            textkucoin.TabIndex = 2;
            textkucoin.Text = "textkucoin";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(471, 61);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "BTCUSDT";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            textBox1.MouseLeave += textBox1_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(textkucoin);
            Controls.Add(textBybit);
            Controls.Add(textBinance);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)outModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textBinance;
        private Label textBybit;
        private Label textkucoin;
        private BindingSource outModelBindingSource;
        private TextBox textBox1;
    }
}
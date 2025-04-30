namespace Flipaint
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
            btnFile = new Button();
            btnHelp = new Button();
            groupHeader = new GroupBox();
            groupHUD = new GroupBox();
            groupPenTool = new GroupBox();
            btnPenColor = new Button();
            comboBox1 = new ComboBox();
            groupHeader.SuspendLayout();
            groupHUD.SuspendLayout();
            groupPenTool.SuspendLayout();
            SuspendLayout();
            // 
            // btnFile
            // 
            btnFile.Cursor = Cursors.Hand;
            btnFile.Location = new Point(6, 14);
            btnFile.Name = "btnFile";
            btnFile.Size = new Size(75, 23);
            btnFile.TabIndex = 0;
            btnFile.Text = "File";
            btnFile.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            btnHelp.Cursor = Cursors.Hand;
            btnHelp.Location = new Point(87, 14);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(75, 23);
            btnHelp.TabIndex = 1;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            // 
            // groupHeader
            // 
            groupHeader.Controls.Add(btnFile);
            groupHeader.Controls.Add(btnHelp);
            groupHeader.Location = new Point(12, 6);
            groupHeader.Name = "groupHeader";
            groupHeader.Size = new Size(206, 43);
            groupHeader.TabIndex = 3;
            groupHeader.TabStop = false;
            // 
            // groupHUD
            // 
            groupHUD.Controls.Add(groupPenTool);
            groupHUD.Location = new Point(12, 55);
            groupHUD.Name = "groupHUD";
            groupHUD.Size = new Size(206, 383);
            groupHUD.TabIndex = 4;
            groupHUD.TabStop = false;
            // 
            // groupPenTool
            // 
            groupPenTool.Controls.Add(btnPenColor);
            groupPenTool.Controls.Add(comboBox1);
            groupPenTool.Location = new Point(6, 22);
            groupPenTool.Name = "groupPenTool";
            groupPenTool.Size = new Size(194, 118);
            groupPenTool.TabIndex = 5;
            groupPenTool.TabStop = false;
            groupPenTool.Text = "Pen Tool";
            // 
            // btnPenColor
            // 
            btnPenColor.BackColor = SystemColors.ActiveCaptionText;
            btnPenColor.Cursor = Cursors.Hand;
            btnPenColor.Location = new Point(6, 66);
            btnPenColor.Name = "btnPenColor";
            btnPenColor.Size = new Size(182, 38);
            btnPenColor.TabIndex = 4;
            btnPenColor.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 23);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupHUD);
            Controls.Add(groupHeader);
            Name = "Form1";
            Text = "Flipaint";
            groupHeader.ResumeLayout(false);
            groupHUD.ResumeLayout(false);
            groupPenTool.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnFile;
        private Button btnHelp;
        private GroupBox groupHeader;
        private GroupBox groupHUD;
        private GroupBox groupPenTool;
        private ComboBox comboBox1;
        private Button btnPenColor;
    }
}

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
            groupBox1 = new GroupBox();
            groupPenTool = new GroupBox();
            btnPenColor = new Button();
            cmbPenSize = new ComboBox();
            pnl_Draw = new Panel();
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
            groupHUD.Controls.Add(groupBox1);
            groupHUD.Controls.Add(groupPenTool);
            groupHUD.Location = new Point(12, 55);
            groupHUD.Name = "groupHUD";
            groupHUD.Size = new Size(206, 383);
            groupHUD.TabIndex = 4;
            groupHUD.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(6, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(188, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupPenTool
            // 
            groupPenTool.Controls.Add(btnPenColor);
            groupPenTool.Controls.Add(cmbPenSize);
            groupPenTool.Location = new Point(6, 22);
            groupPenTool.Name = "groupPenTool";
            groupPenTool.Size = new Size(194, 98);
            groupPenTool.TabIndex = 5;
            groupPenTool.TabStop = false;
            groupPenTool.Text = "Pen Tool";
            // 
            // btnPenColor
            // 
            btnPenColor.BackColor = SystemColors.ActiveCaptionText;
            btnPenColor.Cursor = Cursors.Hand;
            btnPenColor.Location = new Point(6, 51);
            btnPenColor.Name = "btnPenColor";
            btnPenColor.Size = new Size(182, 38);
            btnPenColor.TabIndex = 4;
            btnPenColor.UseVisualStyleBackColor = false;
            // 
            // cmbPenSize
            // 
            cmbPenSize.Cursor = Cursors.Hand;
            cmbPenSize.FormattingEnabled = true;
            cmbPenSize.Location = new Point(6, 22);
            cmbPenSize.Name = "cmbPenSize";
            cmbPenSize.Size = new Size(182, 23);
            cmbPenSize.TabIndex = 3;
            cmbPenSize.Text = "1";
            // 
            // pnl_Draw
            // 
            pnl_Draw.BackColor = SystemColors.ControlLightLight;
            pnl_Draw.Location = new Point(224, 12);
            pnl_Draw.Name = "pnl_Draw";
            pnl_Draw.Size = new Size(564, 426);
            pnl_Draw.TabIndex = 5;
            pnl_Draw.MouseMove += pnl_Draw_MouseMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_Draw);
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
        private ComboBox cmbPenSize;
        private Button btnPenColor;
        private GroupBox groupBox1;
        private Panel pnl_Draw;
    }
}

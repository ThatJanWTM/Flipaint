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
            label1 = new Label();
            btnShapeSize = new Button();
            btn_Circle = new Button();
            btn_Rectangle = new Button();
            btn_Square = new Button();
            groupPenTool = new GroupBox();
            btnPenColor = new Button();
            pnl_Draw = new Panel();
            cmbPenSize = new TextBox();
            groupHeader.SuspendLayout();
            groupHUD.SuspendLayout();
            groupBox1.SuspendLayout();
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
            groupHeader.Font = new Font("Arial Rounded MT Bold", 9.75F);
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
            groupHUD.Font = new Font("Arial Rounded MT Bold", 9.75F);
            groupHUD.Location = new Point(12, 55);
            groupHUD.Name = "groupHUD";
            groupHUD.Size = new Size(206, 383);
            groupHUD.TabIndex = 4;
            groupHUD.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnShapeSize);
            groupBox1.Controls.Add(btn_Circle);
            groupBox1.Controls.Add(btn_Rectangle);
            groupBox1.Controls.Add(btn_Square);
            groupBox1.Location = new Point(6, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(188, 251);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Draw Shapes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 199);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 4;
            label1.Text = "Shape Size";
            // 
            // btnShapeSize
            // 
            btnShapeSize.Location = new Point(6, 217);
            btnShapeSize.Name = "btnShapeSize";
            btnShapeSize.Size = new Size(176, 28);
            btnShapeSize.TabIndex = 3;
            btnShapeSize.Text = "10";
            btnShapeSize.UseVisualStyleBackColor = true;
            // 
            // btn_Circle
            // 
            btn_Circle.Location = new Point(6, 136);
            btn_Circle.Name = "btn_Circle";
            btn_Circle.Size = new Size(176, 51);
            btn_Circle.TabIndex = 2;
            btn_Circle.Text = "Circle";
            btn_Circle.UseVisualStyleBackColor = true;
            // 
            // btn_Rectangle
            // 
            btn_Rectangle.Location = new Point(6, 79);
            btn_Rectangle.Name = "btn_Rectangle";
            btn_Rectangle.Size = new Size(176, 51);
            btn_Rectangle.TabIndex = 1;
            btn_Rectangle.Text = "Rectangle";
            btn_Rectangle.UseVisualStyleBackColor = true;
            // 
            // btn_Square
            // 
            btn_Square.Location = new Point(6, 22);
            btn_Square.Name = "btn_Square";
            btn_Square.Size = new Size(176, 51);
            btn_Square.TabIndex = 0;
            btn_Square.Text = "Square";
            btn_Square.UseVisualStyleBackColor = true;
            // 
            // groupPenTool
            // 
            groupPenTool.Controls.Add(cmbPenSize);
            groupPenTool.Controls.Add(btnPenColor);
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
            btnPenColor.Click += button1_Click;
            // 
            // pnl_Draw
            // 
            pnl_Draw.BackColor = SystemColors.ControlLightLight;
            pnl_Draw.Location = new Point(224, 12);
            pnl_Draw.Name = "pnl_Draw";
            pnl_Draw.Size = new Size(564, 426);
            pnl_Draw.TabIndex = 5;
            pnl_Draw.MouseDown += pnl_Draw_MouseDown;
            pnl_Draw.MouseMove += pnl_Draw_MouseMove;
            pnl_Draw.MouseUp += pnl_DrawMouseUp;
            // 
            // cmbPenSize
            // 
            cmbPenSize.Location = new Point(6, 22);
            cmbPenSize.Name = "cmbPenSize";
            cmbPenSize.Size = new Size(182, 23);
            cmbPenSize.TabIndex = 5;
            cmbPenSize.Text = "2";
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupPenTool.ResumeLayout(false);
            groupPenTool.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFile;
        private Button btnHelp;
        private GroupBox groupHeader;
        private GroupBox groupHUD;
        private GroupBox groupPenTool;
        private Button btnPenColor;
        private GroupBox groupBox1;
        private Panel pnl_Draw;
        private Button btn_Circle;
        private Button btn_Rectangle;
        private Button btn_Square;
        private Label label1;
        private Button btnShapeSize;
        private TextBox cmbPenSize;
    }
}

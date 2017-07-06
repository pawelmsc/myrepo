namespace TicTacToe
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rect22 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rect21 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rect20 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rect10 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rect11 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rect12 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rect02 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rect01 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rect00 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pbx00 = new System.Windows.Forms.PictureBox();
            this.pbx10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx10)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rect22,
            this.rect21,
            this.rect20,
            this.rect10,
            this.rect11,
            this.rect12,
            this.rect02,
            this.rect01,
            this.rect00});
            this.shapeContainer1.Size = new System.Drawing.Size(284, 261);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rect22
            // 
            this.rect22.Location = new System.Drawing.Point(177, 156);
            this.rect22.Name = "rect22";
            this.rect22.Size = new System.Drawing.Size(70, 70);
            // 
            // rect21
            // 
            this.rect21.Location = new System.Drawing.Point(107, 156);
            this.rect21.Name = "rect21";
            this.rect21.Size = new System.Drawing.Size(70, 70);
            // 
            // rect20
            // 
            this.rect20.Location = new System.Drawing.Point(37, 156);
            this.rect20.Name = "rect20";
            this.rect20.Size = new System.Drawing.Size(70, 70);
            // 
            // rect10
            // 
            this.rect10.Location = new System.Drawing.Point(37, 86);
            this.rect10.Name = "rect10";
            this.rect10.Size = new System.Drawing.Size(70, 70);
            // 
            // rect11
            // 
            this.rect11.Location = new System.Drawing.Point(107, 86);
            this.rect11.Name = "rect11";
            this.rect11.Size = new System.Drawing.Size(70, 70);
            // 
            // rect12
            // 
            this.rect12.Location = new System.Drawing.Point(177, 86);
            this.rect12.Name = "rect12";
            this.rect12.Size = new System.Drawing.Size(70, 70);
            // 
            // rect02
            // 
            this.rect02.Location = new System.Drawing.Point(177, 16);
            this.rect02.Name = "rect02";
            this.rect02.Size = new System.Drawing.Size(70, 70);
            // 
            // rect01
            // 
            this.rect01.Location = new System.Drawing.Point(107, 16);
            this.rect01.Name = "rect01";
            this.rect01.Size = new System.Drawing.Size(70, 70);
            // 
            // rect00
            // 
            this.rect00.Location = new System.Drawing.Point(37, 16);
            this.rect00.Name = "rect00";
            this.rect00.Size = new System.Drawing.Size(70, 70);
            // 
            // pbx00
            // 
            this.pbx00.Location = new System.Drawing.Point(37, 16);
            this.pbx00.Name = "pbx00";
            this.pbx00.Size = new System.Drawing.Size(70, 70);
            this.pbx00.TabIndex = 1;
            this.pbx00.TabStop = false;
            this.pbx00.Click += new System.EventHandler(this.pbx00_Click);
            // 
            // pbx10
            // 
            this.pbx10.Location = new System.Drawing.Point(37, 87);
            this.pbx10.Name = "pbx10";
            this.pbx10.Size = new System.Drawing.Size(70, 70);
            this.pbx10.TabIndex = 2;
            this.pbx10.TabStop = false;
            this.pbx10.Click += new System.EventHandler(this.pbx10_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pbx10);
            this.Controls.Add(this.pbx00);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Tic-Tac-Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pbx00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rect22;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rect21;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rect20;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rect10;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rect11;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rect12;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rect02;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rect01;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rect00;
        private System.Windows.Forms.PictureBox pbx00;
        private System.Windows.Forms.PictureBox pbx10;
    }
}


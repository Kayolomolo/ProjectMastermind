namespace ProjectMastermind
{
    partial class Form1
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
            this.btnUndo = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnGeel = new System.Windows.Forms.Button();
            this.btnRood = new System.Windows.Forms.Button();
            this.btnGroen = new System.Windows.Forms.Button();
            this.btnBlauw = new System.Windows.Forms.Button();
            this.btnOranje = new System.Windows.Forms.Button();
            this.btnPaars = new System.Windows.Forms.Button();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.txtArray2 = new System.Windows.Forms.TextBox();
            this.txtArray3 = new System.Windows.Forms.TextBox();
            this.txtArray4 = new System.Windows.Forms.TextBox();
            this.lbWinnaar = new System.Windows.Forms.Label();
            this.knipperen = new System.Windows.Forms.Timer(this.components);
            this.picZichtbaar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZichtbaar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Red;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(20, 370);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(127, 39);
            this.btnUndo.TabIndex = 1;
            this.btnUndo.Text = "Play Again";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(9, 11);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(328, 353);
            this.picCanvas.TabIndex = 3;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateGraficsPicturebox);
            // 
            // btnGeel
            // 
            this.btnGeel.BackColor = System.Drawing.Color.Yellow;
            this.btnGeel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeel.Location = new System.Drawing.Point(354, 11);
            this.btnGeel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGeel.Name = "btnGeel";
            this.btnGeel.Size = new System.Drawing.Size(77, 34);
            this.btnGeel.TabIndex = 4;
            this.btnGeel.Tag = "geel";
            this.btnGeel.Text = "Geel";
            this.btnGeel.UseVisualStyleBackColor = false;
            this.btnGeel.Click += new System.EventHandler(this.btnGeel_Click);
            // 
            // btnRood
            // 
            this.btnRood.BackColor = System.Drawing.Color.Red;
            this.btnRood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRood.Location = new System.Drawing.Point(354, 50);
            this.btnRood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRood.Name = "btnRood";
            this.btnRood.Size = new System.Drawing.Size(77, 37);
            this.btnRood.TabIndex = 5;
            this.btnRood.Tag = "rood";
            this.btnRood.Text = "Rood";
            this.btnRood.UseVisualStyleBackColor = false;
            this.btnRood.Click += new System.EventHandler(this.btnRood_Click);
            // 
            // btnGroen
            // 
            this.btnGroen.BackColor = System.Drawing.Color.Lime;
            this.btnGroen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroen.Location = new System.Drawing.Point(354, 91);
            this.btnGroen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGroen.Name = "btnGroen";
            this.btnGroen.Size = new System.Drawing.Size(77, 34);
            this.btnGroen.TabIndex = 6;
            this.btnGroen.Tag = "groen";
            this.btnGroen.Text = "Groen";
            this.btnGroen.UseVisualStyleBackColor = false;
            this.btnGroen.Click += new System.EventHandler(this.btnGroen_Click);
            // 
            // btnBlauw
            // 
            this.btnBlauw.BackColor = System.Drawing.Color.Blue;
            this.btnBlauw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlauw.Location = new System.Drawing.Point(354, 130);
            this.btnBlauw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBlauw.Name = "btnBlauw";
            this.btnBlauw.Size = new System.Drawing.Size(77, 35);
            this.btnBlauw.TabIndex = 7;
            this.btnBlauw.Tag = "blauw";
            this.btnBlauw.Text = "Blauw";
            this.btnBlauw.UseVisualStyleBackColor = false;
            this.btnBlauw.Click += new System.EventHandler(this.btnBlauw_Click);
            // 
            // btnOranje
            // 
            this.btnOranje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOranje.Location = new System.Drawing.Point(354, 170);
            this.btnOranje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOranje.Name = "btnOranje";
            this.btnOranje.Size = new System.Drawing.Size(77, 32);
            this.btnOranje.TabIndex = 8;
            this.btnOranje.Tag = "oranje";
            this.btnOranje.Text = "Oranje";
            this.btnOranje.UseVisualStyleBackColor = false;
            this.btnOranje.Click += new System.EventHandler(this.btnOranje_Click);
            // 
            // btnPaars
            // 
            this.btnPaars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPaars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaars.Location = new System.Drawing.Point(354, 206);
            this.btnPaars.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPaars.Name = "btnPaars";
            this.btnPaars.Size = new System.Drawing.Size(77, 31);
            this.btnPaars.TabIndex = 9;
            this.btnPaars.Tag = "paars";
            this.btnPaars.Text = "Paars";
            this.btnPaars.UseVisualStyleBackColor = false;
            this.btnPaars.Click += new System.EventHandler(this.btnPaars_Click);
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(152, 384);
            this.txtArray.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(20, 20);
            this.txtArray.TabIndex = 10;
            // 
            // txtArray2
            // 
            this.txtArray2.Location = new System.Drawing.Point(175, 384);
            this.txtArray2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArray2.Name = "txtArray2";
            this.txtArray2.Size = new System.Drawing.Size(18, 20);
            this.txtArray2.TabIndex = 11;
            // 
            // txtArray3
            // 
            this.txtArray3.Location = new System.Drawing.Point(196, 384);
            this.txtArray3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArray3.Name = "txtArray3";
            this.txtArray3.Size = new System.Drawing.Size(19, 20);
            this.txtArray3.TabIndex = 12;
            // 
            // txtArray4
            // 
            this.txtArray4.Location = new System.Drawing.Point(219, 384);
            this.txtArray4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArray4.Name = "txtArray4";
            this.txtArray4.Size = new System.Drawing.Size(18, 20);
            this.txtArray4.TabIndex = 13;
            // 
            // lbWinnaar
            // 
            this.lbWinnaar.AutoSize = true;
            this.lbWinnaar.BackColor = System.Drawing.Color.Transparent;
            this.lbWinnaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinnaar.Location = new System.Drawing.Point(37, 150);
            this.lbWinnaar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWinnaar.Name = "lbWinnaar";
            this.lbWinnaar.Size = new System.Drawing.Size(293, 37);
            this.lbWinnaar.TabIndex = 14;
            this.lbWinnaar.Text = "Je hebt gewonnen";
            this.lbWinnaar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbWinnaar.Visible = false;
            // 
            // knipperen
            // 
            this.knipperen.Interval = 500;
            this.knipperen.Tick += new System.EventHandler(this.knipperen_Tick);
            // 
            // picZichtbaar
            // 
            this.picZichtbaar.Location = new System.Drawing.Point(153, 370);
            this.picZichtbaar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picZichtbaar.Name = "picZichtbaar";
            this.picZichtbaar.Size = new System.Drawing.Size(84, 41);
            this.picZichtbaar.TabIndex = 15;
            this.picZichtbaar.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(341, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 86);
            this.button1.TabIndex = 16;
            this.button1.Text = "Goede Code Bekijken";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picZichtbaar);
            this.Controls.Add(this.lbWinnaar);
            this.Controls.Add(this.txtArray4);
            this.Controls.Add(this.txtArray3);
            this.Controls.Add(this.txtArray2);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.btnPaars);
            this.Controls.Add(this.btnOranje);
            this.Controls.Add(this.btnBlauw);
            this.Controls.Add(this.btnGroen);
            this.Controls.Add(this.btnRood);
            this.Controls.Add(this.btnGeel);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.picCanvas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZichtbaar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnGeel;
        private System.Windows.Forms.Button btnRood;
        private System.Windows.Forms.Button btnGroen;
        private System.Windows.Forms.Button btnBlauw;
        private System.Windows.Forms.Button btnOranje;
        private System.Windows.Forms.Button btnPaars;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.TextBox txtArray2;
        private System.Windows.Forms.TextBox txtArray3;
        private System.Windows.Forms.TextBox txtArray4;
        private System.Windows.Forms.Label lbWinnaar;
        private System.Windows.Forms.Timer knipperen;
        private System.Windows.Forms.PictureBox picZichtbaar;
        private System.Windows.Forms.Button button1;
    }
}


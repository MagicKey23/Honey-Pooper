namespace Game
{
    partial class Linear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Linear));
            this.author_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.score_hold = new System.Windows.Forms.Label();
            this.win_lbl = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.ammunition_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // author_lbl
            // 
            this.author_lbl.AutoSize = true;
            this.author_lbl.BackColor = System.Drawing.Color.Transparent;
            this.author_lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_lbl.Location = new System.Drawing.Point(277, 274);
            this.author_lbl.Name = "author_lbl";
            this.author_lbl.Size = new System.Drawing.Size(159, 30);
            this.author_lbl.TabIndex = 0;
            this.author_lbl.Text = "Made by Hoang Anh Nguyen\r\n\r\n";
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.BackColor = System.Drawing.Color.Transparent;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.Location = new System.Drawing.Point(12, 274);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(61, 20);
            this.score_lbl.TabIndex = 1;
            this.score_lbl.Text = "Score:";
            this.score_lbl.Visible = false;
            // 
            // score_hold
            // 
            this.score_hold.AutoSize = true;
            this.score_hold.BackColor = System.Drawing.Color.Transparent;
            this.score_hold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_hold.Location = new System.Drawing.Point(79, 274);
            this.score_hold.Name = "score_hold";
            this.score_hold.Size = new System.Drawing.Size(0, 20);
            this.score_hold.TabIndex = 2;
            this.score_hold.Visible = false;
            // 
            // win_lbl
            // 
            this.win_lbl.AutoSize = true;
            this.win_lbl.BackColor = System.Drawing.Color.Transparent;
            this.win_lbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win_lbl.Location = new System.Drawing.Point(121, 88);
            this.win_lbl.Name = "win_lbl";
            this.win_lbl.Size = new System.Drawing.Size(187, 26);
            this.win_lbl.TabIndex = 3;
            this.win_lbl.Text = "You Won! Good job";
            this.win_lbl.Visible = false;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("Castellar", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(27, 22);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(376, 42);
            this.title_label.TabIndex = 4;
            this.title_label.Text = " Angry Machine\r\n";
            // 
            // ammunition_lbl
            // 
            this.ammunition_lbl.AutoSize = true;
            this.ammunition_lbl.BackColor = System.Drawing.Color.Transparent;
            this.ammunition_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammunition_lbl.Location = new System.Drawing.Point(346, 280);
            this.ammunition_lbl.Name = "ammunition_lbl";
            this.ammunition_lbl.Size = new System.Drawing.Size(34, 20);
            this.ammunition_lbl.TabIndex = 5;
            this.ammunition_lbl.Text = "1/3";
            this.ammunition_lbl.Visible = false;
            // 
            // Linear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Game.Properties.Resources.sjhit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 309);
            this.Controls.Add(this.ammunition_lbl);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.win_lbl);
            this.Controls.Add(this.score_hold);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.author_lbl);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Linear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linear";
            this.Load += new System.EventHandler(this.Linear_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Linear_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Linear_keyDown);
            this.Validated += new System.EventHandler(this.Update);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label author_lbl;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label score_hold;
        private System.Windows.Forms.Label win_lbl;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label ammunition_lbl;
    }
}


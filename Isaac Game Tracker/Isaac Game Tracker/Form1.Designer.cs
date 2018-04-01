namespace IGGnis_Game_Tracker
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
            this.cmb_Character = new System.Windows.Forms.ComboBox();
            this.btn_Victory = new System.Windows.Forms.Button();
            this.btn_Defeat = new System.Windows.Forms.Button();
            this.dgv_Record = new System.Windows.Forms.DataGridView();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Wins = new System.Windows.Forms.Label();
            this.lbl_WinCount = new System.Windows.Forms.Label();
            this.lbl_Losses = new System.Windows.Forms.Label();
            this.lbl_LossCount = new System.Windows.Forms.Label();
            this.lbl_MostWins = new System.Windows.Forms.Label();
            this.lbl_MostWinsText = new System.Windows.Forms.Label();
            this.lbl_FewestWins = new System.Windows.Forms.Label();
            this.lbl_FewestWinsText = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Record)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Character
            // 
            this.cmb_Character.FormattingEnabled = true;
            this.cmb_Character.Location = new System.Drawing.Point(13, 13);
            this.cmb_Character.Name = "cmb_Character";
            this.cmb_Character.Size = new System.Drawing.Size(151, 21);
            this.cmb_Character.TabIndex = 0;
            this.cmb_Character.Text = "Eden";
            // 
            // btn_Victory
            // 
            this.btn_Victory.Location = new System.Drawing.Point(171, 13);
            this.btn_Victory.Name = "btn_Victory";
            this.btn_Victory.Size = new System.Drawing.Size(75, 23);
            this.btn_Victory.TabIndex = 1;
            this.btn_Victory.Text = "VICTORY!";
            this.btn_Victory.UseVisualStyleBackColor = true;
            this.btn_Victory.Click += new System.EventHandler(this.btn_Victory_Click);
            // 
            // btn_Defeat
            // 
            this.btn_Defeat.Location = new System.Drawing.Point(253, 13);
            this.btn_Defeat.Name = "btn_Defeat";
            this.btn_Defeat.Size = new System.Drawing.Size(75, 23);
            this.btn_Defeat.TabIndex = 2;
            this.btn_Defeat.Text = "Defeat";
            this.btn_Defeat.UseVisualStyleBackColor = true;
            this.btn_Defeat.Click += new System.EventHandler(this.btn_Defeat_Click);
            // 
            // dgv_Record
            // 
            this.dgv_Record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Record.Location = new System.Drawing.Point(13, 41);
            this.dgv_Record.Name = "dgv_Record";
            this.dgv_Record.Size = new System.Drawing.Size(315, 179);
            this.dgv_Record.TabIndex = 3;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(334, 13);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(85, 23);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Clear All";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_Wins
            // 
            this.lbl_Wins.AutoSize = true;
            this.lbl_Wins.Location = new System.Drawing.Point(347, 43);
            this.lbl_Wins.Name = "lbl_Wins";
            this.lbl_Wins.Size = new System.Drawing.Size(31, 13);
            this.lbl_Wins.TabIndex = 5;
            this.lbl_Wins.Text = "Wins";
            // 
            // lbl_WinCount
            // 
            this.lbl_WinCount.AutoSize = true;
            this.lbl_WinCount.Location = new System.Drawing.Point(384, 43);
            this.lbl_WinCount.Name = "lbl_WinCount";
            this.lbl_WinCount.Size = new System.Drawing.Size(35, 13);
            this.lbl_WinCount.TabIndex = 6;
            this.lbl_WinCount.Text = "label1";
            // 
            // lbl_Losses
            // 
            this.lbl_Losses.AutoSize = true;
            this.lbl_Losses.Location = new System.Drawing.Point(338, 60);
            this.lbl_Losses.Name = "lbl_Losses";
            this.lbl_Losses.Size = new System.Drawing.Size(40, 13);
            this.lbl_Losses.TabIndex = 7;
            this.lbl_Losses.Text = "Losses";
            // 
            // lbl_LossCount
            // 
            this.lbl_LossCount.AutoSize = true;
            this.lbl_LossCount.Location = new System.Drawing.Point(384, 60);
            this.lbl_LossCount.Name = "lbl_LossCount";
            this.lbl_LossCount.Size = new System.Drawing.Size(35, 13);
            this.lbl_LossCount.TabIndex = 8;
            this.lbl_LossCount.Text = "label1";
            // 
            // lbl_MostWins
            // 
            this.lbl_MostWins.AutoSize = true;
            this.lbl_MostWins.Location = new System.Drawing.Point(331, 85);
            this.lbl_MostWins.Name = "lbl_MostWins";
            this.lbl_MostWins.Size = new System.Drawing.Size(82, 13);
            this.lbl_MostWins.TabIndex = 9;
            this.lbl_MostWins.Text = "Most Wins With";
            // 
            // lbl_MostWinsText
            // 
            this.lbl_MostWinsText.AutoSize = true;
            this.lbl_MostWinsText.Location = new System.Drawing.Point(384, 100);
            this.lbl_MostWinsText.Name = "lbl_MostWinsText";
            this.lbl_MostWinsText.Size = new System.Drawing.Size(35, 13);
            this.lbl_MostWinsText.TabIndex = 10;
            this.lbl_MostWinsText.Text = "label1";
            this.lbl_MostWinsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_FewestWins
            // 
            this.lbl_FewestWins.AutoSize = true;
            this.lbl_FewestWins.Location = new System.Drawing.Point(331, 117);
            this.lbl_FewestWins.Name = "lbl_FewestWins";
            this.lbl_FewestWins.Size = new System.Drawing.Size(93, 13);
            this.lbl_FewestWins.TabIndex = 11;
            this.lbl_FewestWins.Text = "Fewest Wins With";
            // 
            // lbl_FewestWinsText
            // 
            this.lbl_FewestWinsText.AutoSize = true;
            this.lbl_FewestWinsText.Location = new System.Drawing.Point(384, 133);
            this.lbl_FewestWinsText.Name = "lbl_FewestWinsText";
            this.lbl_FewestWinsText.Size = new System.Drawing.Size(35, 13);
            this.lbl_FewestWinsText.TabIndex = 12;
            this.lbl_FewestWinsText.Text = "label1";
            this.lbl_FewestWinsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(IGGnis_Game_Tracker.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 265);
            this.Controls.Add(this.lbl_FewestWinsText);
            this.Controls.Add(this.lbl_FewestWins);
            this.Controls.Add(this.lbl_MostWinsText);
            this.Controls.Add(this.lbl_MostWins);
            this.Controls.Add(this.lbl_LossCount);
            this.Controls.Add(this.lbl_Losses);
            this.Controls.Add(this.lbl_WinCount);
            this.Controls.Add(this.lbl_Wins);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.dgv_Record);
            this.Controls.Add(this.btn_Defeat);
            this.Controls.Add(this.btn_Victory);
            this.Controls.Add(this.cmb_Character);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Record)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Character;
        private System.Windows.Forms.Button btn_Victory;
        private System.Windows.Forms.Button btn_Defeat;
        private System.Windows.Forms.DataGridView dgv_Record;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_Wins;
        private System.Windows.Forms.Label lbl_WinCount;
        private System.Windows.Forms.Label lbl_Losses;
        private System.Windows.Forms.Label lbl_LossCount;
        private System.Windows.Forms.Label lbl_MostWins;
        private System.Windows.Forms.Label lbl_MostWinsText;
        private System.Windows.Forms.Label lbl_FewestWins;
        private System.Windows.Forms.Label lbl_FewestWinsText;
    }
}


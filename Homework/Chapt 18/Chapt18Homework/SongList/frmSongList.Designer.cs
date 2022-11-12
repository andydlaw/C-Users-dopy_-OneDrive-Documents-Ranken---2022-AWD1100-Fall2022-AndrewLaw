namespace SongList
{
    partial class frmSongList
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.ddlLinqQueries = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lvwSongList = new System.Windows.Forms.ListView();
            this.songTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(396, 30);
            this.lblTitle.TabIndex = 4;
            // 
            // ddlLinqQueries
            // 
            this.ddlLinqQueries.FormattingEnabled = true;
            this.ddlLinqQueries.Location = new System.Drawing.Point(479, 15);
            this.ddlLinqQueries.Name = "ddlLinqQueries";
            this.ddlLinqQueries.Size = new System.Drawing.Size(309, 24);
            this.ddlLinqQueries.TabIndex = 0;
            this.ddlLinqQueries.SelectedIndexChanged += new System.EventHandler(this.ddlLinqQueries_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(564, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(164, 52);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(564, 206);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 52);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(564, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 52);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // lvwSongList
            // 
            this.lvwSongList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.songTitle,
            this.songArtist,
            this.songGenre});
            this.lvwSongList.HideSelection = false;
            this.lvwSongList.Location = new System.Drawing.Point(15, 60);
            this.lvwSongList.Name = "lvwSongList";
            this.lvwSongList.Size = new System.Drawing.Size(515, 309);
            this.lvwSongList.TabIndex = 5;
            this.lvwSongList.UseCompatibleStateImageBehavior = false;
            this.lvwSongList.View = System.Windows.Forms.View.Details;
            // 
            // songTitle
            // 
            this.songTitle.Text = "Title";
            this.songTitle.Width = 175;
            // 
            // songArtist
            // 
            this.songArtist.Text = "Artist";
            this.songArtist.Width = 100;
            // 
            // songGenre
            // 
            this.songGenre.Text = "Genre";
            this.songGenre.Width = 108;
            // 
            // frmSongList
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.lvwSongList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ddlLinqQueries);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmSongList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Song List Chapt 18";
            this.Load += new System.EventHandler(this.frmSongList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox ddlLinqQueries;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView lvwSongList;
        private System.Windows.Forms.ColumnHeader songTitle;
        private System.Windows.Forms.ColumnHeader songArtist;
        private System.Windows.Forms.ColumnHeader songGenre;
    }
}



namespace Shahid
{
    partial class topRatedShow
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
            this.rating_lbl = new System.Windows.Forms.Label();
            this.shownamelbl = new System.Windows.Forms.Label();
            this.episodes_count_lbl = new System.Windows.Forms.Label();
            this.top_rated_show_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rating_lbl
            // 
            this.rating_lbl.AutoSize = true;
            this.rating_lbl.BackColor = System.Drawing.Color.Transparent;
            this.rating_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating_lbl.Location = new System.Drawing.Point(191, 292);
            this.rating_lbl.Name = "rating_lbl";
            this.rating_lbl.Size = new System.Drawing.Size(82, 31);
            this.rating_lbl.TabIndex = 0;
            this.rating_lbl.Text = "rating";
            // 
            // shownamelbl
            // 
            this.shownamelbl.AutoSize = true;
            this.shownamelbl.BackColor = System.Drawing.Color.Transparent;
            this.shownamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shownamelbl.Location = new System.Drawing.Point(191, 248);
            this.shownamelbl.Name = "shownamelbl";
            this.shownamelbl.Size = new System.Drawing.Size(160, 31);
            this.shownamelbl.TabIndex = 1;
            this.shownamelbl.Text = "Movie name";
            // 
            // episodes_count_lbl
            // 
            this.episodes_count_lbl.AutoSize = true;
            this.episodes_count_lbl.BackColor = System.Drawing.Color.Transparent;
            this.episodes_count_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodes_count_lbl.Location = new System.Drawing.Point(191, 337);
            this.episodes_count_lbl.Name = "episodes_count_lbl";
            this.episodes_count_lbl.Size = new System.Drawing.Size(197, 31);
            this.episodes_count_lbl.TabIndex = 2;
            this.episodes_count_lbl.Text = "episodes count";
            // 
            // top_rated_show_lbl
            // 
            this.top_rated_show_lbl.AutoSize = true;
            this.top_rated_show_lbl.BackColor = System.Drawing.Color.Transparent;
            this.top_rated_show_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_rated_show_lbl.Location = new System.Drawing.Point(184, 150);
            this.top_rated_show_lbl.Name = "top_rated_show_lbl";
            this.top_rated_show_lbl.Size = new System.Drawing.Size(614, 73);
            this.top_rated_show_lbl.TabIndex = 3;
            this.top_rated_show_lbl.Text = "TOP RATED SHOW";
            // 
            // topRatedShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shahid.Properties.Resources.top_show_bg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.top_rated_show_lbl);
            this.Controls.Add(this.episodes_count_lbl);
            this.Controls.Add(this.shownamelbl);
            this.Controls.Add(this.rating_lbl);
            this.Name = "topRatedShow";
            this.Text = "topRatedShow";
            this.Load += new System.EventHandler(this.topRatedShow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rating_lbl;
        private System.Windows.Forms.Label shownamelbl;
        private System.Windows.Forms.Label episodes_count_lbl;
        private System.Windows.Forms.Label top_rated_show_lbl;
    }
}
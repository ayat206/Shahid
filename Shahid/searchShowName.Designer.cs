
namespace Shahid
{
    partial class searchShowName
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
            this.genre_lbl = new System.Windows.Forms.Label();
            this.show_name_txtBox = new System.Windows.Forms.TextBox();
            this.dgv_show = new System.Windows.Forms.DataGridView();
            this.search_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).BeginInit();
            this.SuspendLayout();
            // 
            // genre_lbl
            // 
            this.genre_lbl.AutoSize = true;
            this.genre_lbl.BackColor = System.Drawing.Color.Transparent;
            this.genre_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.genre_lbl.Location = new System.Drawing.Point(574, 207);
            this.genre_lbl.Name = "genre_lbl";
            this.genre_lbl.Size = new System.Drawing.Size(136, 25);
            this.genre_lbl.TabIndex = 0;
            this.genre_lbl.Text = "Genre name:";
            // 
            // show_name_txtBox
            // 
            this.show_name_txtBox.BackColor = System.Drawing.Color.White;
            this.show_name_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_name_txtBox.Location = new System.Drawing.Point(710, 205);
            this.show_name_txtBox.Name = "show_name_txtBox";
            this.show_name_txtBox.Size = new System.Drawing.Size(208, 29);
            this.show_name_txtBox.TabIndex = 1;
            // 
            // dgv_show
            // 
            this.dgv_show.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_show.Location = new System.Drawing.Point(556, 309);
            this.dgv_show.Name = "dgv_show";
            this.dgv_show.Size = new System.Drawing.Size(404, 150);
            this.dgv_show.TabIndex = 2;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.search_btn.BackgroundImage = global::Shahid.Properties.Resources.btn_color;
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(750, 240);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(133, 32);
            this.search_btn.TabIndex = 3;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.save_btn.BackgroundImage = global::Shahid.Properties.Resources.btn_color;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(670, 477);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(175, 44);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // searchShowName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shahid.Properties.Resources.seach_show2;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.dgv_show);
            this.Controls.Add(this.show_name_txtBox);
            this.Controls.Add(this.genre_lbl);
            this.Name = "searchShowName";
            this.Text = "searchShowName";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genre_lbl;
        private System.Windows.Forms.TextBox show_name_txtBox;
        private System.Windows.Forms.DataGridView dgv_show;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button save_btn;
    }
}
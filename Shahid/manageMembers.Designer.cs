
namespace Shahid
{
    partial class manageMembers
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
            this.selectMemberCB = new System.Windows.Forms.ComboBox();
            this.memberIDlbl = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_plan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.memberNamelbl = new System.Windows.Forms.Label();
            this.sign_up_date_picker = new System.Windows.Forms.DateTimePicker();
            this.insertBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectMemberCB
            // 
            this.selectMemberCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectMemberCB.FormattingEnabled = true;
            this.selectMemberCB.ItemHeight = 20;
            this.selectMemberCB.Location = new System.Drawing.Point(197, 139);
            this.selectMemberCB.Name = "selectMemberCB";
            this.selectMemberCB.Size = new System.Drawing.Size(200, 28);
            this.selectMemberCB.TabIndex = 1;
            this.selectMemberCB.SelectedIndexChanged += new System.EventHandler(this.selectMemberCB_SelectedIndexChanged);
            // 
            // memberIDlbl
            // 
            this.memberIDlbl.AutoSize = true;
            this.memberIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.memberIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDlbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.memberIDlbl.Location = new System.Drawing.Point(64, 139);
            this.memberIDlbl.Name = "memberIDlbl";
            this.memberIDlbl.Size = new System.Drawing.Size(128, 25);
            this.memberIDlbl.TabIndex = 2;
            this.memberIDlbl.Text = "Member ID: ";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_name.Location = new System.Drawing.Point(197, 180);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(200, 26);
            this.txt_name.TabIndex = 3;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_address.Location = new System.Drawing.Point(197, 219);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(200, 26);
            this.txt_address.TabIndex = 4;
            // 
            // txt_number
            // 
            this.txt_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_number.Location = new System.Drawing.Point(197, 257);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(200, 26);
            this.txt_number.TabIndex = 5;
            // 
            // txt_plan
            // 
            this.txt_plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_plan.Location = new System.Drawing.Point(197, 333);
            this.txt_plan.Name = "txt_plan";
            this.txt_plan.Size = new System.Drawing.Size(200, 26);
            this.txt_plan.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(88, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Address: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(27, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Phone number: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(46, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sign up date: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(124, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Plan: ";
            // 
            // memberNamelbl
            // 
            this.memberNamelbl.AutoSize = true;
            this.memberNamelbl.BackColor = System.Drawing.Color.Transparent;
            this.memberNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNamelbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.memberNamelbl.Location = new System.Drawing.Point(111, 180);
            this.memberNamelbl.Name = "memberNamelbl";
            this.memberNamelbl.Size = new System.Drawing.Size(80, 25);
            this.memberNamelbl.TabIndex = 12;
            this.memberNamelbl.Text = "Name: ";
            // 
            // sign_up_date_picker
            // 
            this.sign_up_date_picker.Location = new System.Drawing.Point(197, 295);
            this.sign_up_date_picker.Name = "sign_up_date_picker";
            this.sign_up_date_picker.Size = new System.Drawing.Size(200, 20);
            this.sign_up_date_picker.TabIndex = 13;
            // 
            // insertBTN
            // 
            this.insertBTN.BackColor = System.Drawing.SystemColors.GrayText;
            this.insertBTN.Font = new System.Drawing.Font("Georgia", 18F);
            this.insertBTN.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.insertBTN.Location = new System.Drawing.Point(52, 452);
            this.insertBTN.Name = "insertBTN";
            this.insertBTN.Size = new System.Drawing.Size(175, 44);
            this.insertBTN.TabIndex = 14;
            this.insertBTN.Text = "Insert";
            this.insertBTN.UseVisualStyleBackColor = false;
            this.insertBTN.Click += new System.EventHandler(this.insertBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.SystemColors.GrayText;
            this.deleteBTN.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBTN.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteBTN.Location = new System.Drawing.Point(258, 452);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(175, 44);
            this.deleteBTN.TabIndex = 16;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(31, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(492, 56);
            this.label5.TabIndex = 17;
            this.label5.Text = "Members Managment";
            // 
            // manageMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shahid.Properties.Resources.subs_plan;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.insertBTN);
            this.Controls.Add(this.sign_up_date_picker);
            this.Controls.Add(this.memberNamelbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_plan);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.memberIDlbl);
            this.Controls.Add(this.selectMemberCB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "manageMembers";
            this.Text = "manageMembers";
            this.Load += new System.EventHandler(this.manageMembers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectMemberCB;
        private System.Windows.Forms.Label memberIDlbl;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_plan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label memberNamelbl;
        private System.Windows.Forms.DateTimePicker sign_up_date_picker;
        private System.Windows.Forms.Button insertBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Label label5;
    }
}
namespace Lab04
{
    partial class BT5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstB = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstA = new System.Windows.Forms.ListBox();
            this.btnLtR = new System.Windows.Forms.Button();
            this.btnRtL = new System.Windows.Forms.Button();
            this.btnAllLtR = new System.Windows.Forms.Button();
            this.btnAllRtL = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(257, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(439, 65);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstB);
            this.groupBox1.Location = new System.Drawing.Point(389, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 289);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp B:";
            // 
            // lstB
            // 
            this.lstB.FormattingEnabled = true;
            this.lstB.Location = new System.Drawing.Point(6, 30);
            this.lstB.Name = "lstB";
            this.lstB.Size = new System.Drawing.Size(222, 251);
            this.lstB.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstA);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 289);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp A:";
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.Location = new System.Drawing.Point(6, 30);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(222, 251);
            this.lstA.TabIndex = 0;
            // 
            // btnLtR
            // 
            this.btnLtR.Location = new System.Drawing.Point(259, 202);
            this.btnLtR.Name = "btnLtR";
            this.btnLtR.Size = new System.Drawing.Size(56, 23);
            this.btnLtR.TabIndex = 2;
            this.btnLtR.Text = ">";
            this.btnLtR.UseVisualStyleBackColor = true;
            this.btnLtR.Click += new System.EventHandler(this.BtnLtR_Click);
            // 
            // btnRtL
            // 
            this.btnRtL.Location = new System.Drawing.Point(327, 202);
            this.btnRtL.Name = "btnRtL";
            this.btnRtL.Size = new System.Drawing.Size(56, 23);
            this.btnRtL.TabIndex = 2;
            this.btnRtL.Text = "<";
            this.btnRtL.UseVisualStyleBackColor = true;
            this.btnRtL.Click += new System.EventHandler(this.BtnRtL_Click);
            // 
            // btnAllLtR
            // 
            this.btnAllLtR.Location = new System.Drawing.Point(259, 286);
            this.btnAllLtR.Name = "btnAllLtR";
            this.btnAllLtR.Size = new System.Drawing.Size(56, 23);
            this.btnAllLtR.TabIndex = 2;
            this.btnAllLtR.Text = ">>";
            this.btnAllLtR.UseVisualStyleBackColor = true;
            this.btnAllLtR.Click += new System.EventHandler(this.BtnAllLtR_Click);
            // 
            // btnAllRtL
            // 
            this.btnAllRtL.Location = new System.Drawing.Point(327, 286);
            this.btnAllRtL.Name = "btnAllRtL";
            this.btnAllRtL.Size = new System.Drawing.Size(56, 23);
            this.btnAllRtL.TabIndex = 2;
            this.btnAllRtL.Text = "<<";
            this.btnAllRtL.UseVisualStyleBackColor = true;
            this.btnAllRtL.Click += new System.EventHandler(this.BtnAllRtL_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(95, 412);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(485, 412);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Kết thúc";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BT5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAllRtL);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAllLtR);
            this.Controls.Add(this.btnRtL);
            this.Controls.Add(this.btnLtR);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BT5";
            this.Text = "Quản lý sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BT5_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.Button btnLtR;
        private System.Windows.Forms.Button btnRtL;
        private System.Windows.Forms.Button btnAllLtR;
        private System.Windows.Forms.Button btnAllRtL;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}
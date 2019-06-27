namespace Lab04
{
    partial class BT4
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
            this.lblNhap = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grbFunction = new System.Windows.Forms.GroupBox();
            this.btnDeleLast = new System.Windows.Forms.Button();
            this.btnDeleFirst = new System.Windows.Forms.Button();
            this.btnDeleHere = new System.Windows.Forms.Button();
            this.btnSelLastOdd = new System.Windows.Forms.Button();
            this.btnSelFirstEven = new System.Windows.Forms.Button();
            this.btnIncre2 = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grbFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new System.Drawing.Point(12, 30);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(85, 13);
            this.lblNhap.TabIndex = 0;
            this.lblNhap.Text = "Nhập số nguyên";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(118, 26);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(246, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInput_KeyPress);
            // 
            // grbFunction
            // 
            this.grbFunction.Controls.Add(this.btnDeleLast);
            this.grbFunction.Controls.Add(this.btnDeleFirst);
            this.grbFunction.Controls.Add(this.btnDeleHere);
            this.grbFunction.Controls.Add(this.btnSelLastOdd);
            this.grbFunction.Controls.Add(this.btnSelFirstEven);
            this.grbFunction.Controls.Add(this.btnIncre2);
            this.grbFunction.Location = new System.Drawing.Point(252, 74);
            this.grbFunction.Name = "grbFunction";
            this.grbFunction.Size = new System.Drawing.Size(200, 303);
            this.grbFunction.TabIndex = 2;
            this.grbFunction.TabStop = false;
            this.grbFunction.Text = "Chức năng";
            // 
            // btnDeleLast
            // 
            this.btnDeleLast.Location = new System.Drawing.Point(19, 258);
            this.btnDeleLast.Name = "btnDeleLast";
            this.btnDeleLast.Size = new System.Drawing.Size(166, 23);
            this.btnDeleLast.TabIndex = 0;
            this.btnDeleLast.Text = "xấu phần tử cuối";
            this.btnDeleLast.UseVisualStyleBackColor = true;
            this.btnDeleLast.Click += new System.EventHandler(this.BtnDeleLast_Click);
            // 
            // btnDeleFirst
            // 
            this.btnDeleFirst.Location = new System.Drawing.Point(19, 212);
            this.btnDeleFirst.Name = "btnDeleFirst";
            this.btnDeleFirst.Size = new System.Drawing.Size(166, 23);
            this.btnDeleFirst.TabIndex = 0;
            this.btnDeleFirst.Text = "xóa phần tử đầu";
            this.btnDeleFirst.UseVisualStyleBackColor = true;
            this.btnDeleFirst.Click += new System.EventHandler(this.BtnDeleFirst_Click);
            // 
            // btnDeleHere
            // 
            this.btnDeleHere.Location = new System.Drawing.Point(19, 166);
            this.btnDeleHere.Name = "btnDeleHere";
            this.btnDeleHere.Size = new System.Drawing.Size(166, 23);
            this.btnDeleHere.TabIndex = 0;
            this.btnDeleHere.Text = "xóa phần tử đang chọn";
            this.btnDeleHere.UseVisualStyleBackColor = true;
            this.btnDeleHere.Click += new System.EventHandler(this.BtnDeleHere_Click);
            // 
            // btnSelLastOdd
            // 
            this.btnSelLastOdd.Location = new System.Drawing.Point(19, 120);
            this.btnSelLastOdd.Name = "btnSelLastOdd";
            this.btnSelLastOdd.Size = new System.Drawing.Size(166, 23);
            this.btnSelLastOdd.TabIndex = 0;
            this.btnSelLastOdd.Text = "chọn số lẻ cuối";
            this.btnSelLastOdd.UseVisualStyleBackColor = true;
            this.btnSelLastOdd.Click += new System.EventHandler(this.BtnSelLastOdd_Click);
            // 
            // btnSelFirstEven
            // 
            this.btnSelFirstEven.Location = new System.Drawing.Point(19, 74);
            this.btnSelFirstEven.Name = "btnSelFirstEven";
            this.btnSelFirstEven.Size = new System.Drawing.Size(166, 23);
            this.btnSelFirstEven.TabIndex = 0;
            this.btnSelFirstEven.Text = "chọn số chẵn đầu";
            this.btnSelFirstEven.UseVisualStyleBackColor = true;
            this.btnSelFirstEven.Click += new System.EventHandler(this.BtnSelFirstEven_Click);
            // 
            // btnIncre2
            // 
            this.btnIncre2.Location = new System.Drawing.Point(19, 28);
            this.btnIncre2.Name = "btnIncre2";
            this.btnIncre2.Size = new System.Drawing.Size(166, 23);
            this.btnIncre2.TabIndex = 0;
            this.btnIncre2.Text = "tăng mỗi phần tử lên 2";
            this.btnIncre2.UseVisualStyleBackColor = true;
            this.btnIncre2.Click += new System.EventHandler(this.BtnIncre2_Click);
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(16, 81);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(210, 303);
            this.lstResult.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(16, 399);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(436, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Kết thúc";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(370, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BT4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 434);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.grbFunction);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblNhap);
            this.Name = "BT4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thao tác trên số nguyên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai4_FormClosing);
            this.grbFunction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox grbFunction;
        private System.Windows.Forms.Button btnDeleLast;
        private System.Windows.Forms.Button btnDeleFirst;
        private System.Windows.Forms.Button btnDeleHere;
        private System.Windows.Forms.Button btnSelLastOdd;
        private System.Windows.Forms.Button btnSelFirstEven;
        private System.Windows.Forms.Button btnIncre2;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
    }
}
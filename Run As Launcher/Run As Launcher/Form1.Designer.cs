namespace Run_As_Launcher
{
    partial class _mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_mainForm));
            this._userLoginLabel = new System.Windows.Forms.Label();
            this._userPassLabel = new System.Windows.Forms.Label();
            this._userLoginTxtBx = new System.Windows.Forms.TextBox();
            this._userPassTxtBx = new System.Windows.Forms.TextBox();
            this._filePathTxtBx = new System.Windows.Forms.TextBox();
            this._runBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _userLoginLabel
            // 
            this._userLoginLabel.AutoSize = true;
            this._userLoginLabel.Location = new System.Drawing.Point(26, 16);
            this._userLoginLabel.Name = "_userLoginLabel";
            this._userLoginLabel.Size = new System.Drawing.Size(35, 13);
            this._userLoginLabel.TabIndex = 0;
            this._userLoginLabel.Text = "User: ";
            // 
            // _userPassLabel
            // 
            this._userPassLabel.AutoSize = true;
            this._userPassLabel.Location = new System.Drawing.Point(191, 16);
            this._userPassLabel.Name = "_userPassLabel";
            this._userPassLabel.Size = new System.Drawing.Size(56, 13);
            this._userPassLabel.TabIndex = 1;
            this._userPassLabel.Text = "Password:";
            // 
            // _userLoginTxtBx
            // 
            this._userLoginTxtBx.Location = new System.Drawing.Point(63, 9);
            this._userLoginTxtBx.Name = "_userLoginTxtBx";
            this._userLoginTxtBx.Size = new System.Drawing.Size(100, 20);
            this._userLoginTxtBx.TabIndex = 2;
            // 
            // _userPassTxtBx
            // 
            this._userPassTxtBx.Location = new System.Drawing.Point(253, 9);
            this._userPassTxtBx.Name = "_userPassTxtBx";
            this._userPassTxtBx.Size = new System.Drawing.Size(100, 20);
            this._userPassTxtBx.TabIndex = 3;
            this._userPassTxtBx.UseSystemPasswordChar = true;
            // 
            // _filePathTxtBx
            // 
            this._filePathTxtBx.Location = new System.Drawing.Point(12, 35);
            this._filePathTxtBx.Multiline = true;
            this._filePathTxtBx.Name = "_filePathTxtBx";
            this._filePathTxtBx.Size = new System.Drawing.Size(370, 25);
            this._filePathTxtBx.TabIndex = 4;
            // 
            // _runBtn
            // 
            this._runBtn.Location = new System.Drawing.Point(307, 66);
            this._runBtn.Name = "_runBtn";
            this._runBtn.Size = new System.Drawing.Size(75, 23);
            this._runBtn.TabIndex = 5;
            this._runBtn.Text = "Start";
            this._runBtn.UseVisualStyleBackColor = true;
            this._runBtn.Click += new System.EventHandler(this._runBtn_Click);
            // 
            // _mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 95);
            this.Controls.Add(this._runBtn);
            this.Controls.Add(this._filePathTxtBx);
            this.Controls.Add(this._userPassTxtBx);
            this.Controls.Add(this._userLoginTxtBx);
            this.Controls.Add(this._userPassLabel);
            this.Controls.Add(this._userLoginLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_mainForm";
            this.Text = "Run As Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _userLoginLabel;
        private System.Windows.Forms.Label _userPassLabel;
        private System.Windows.Forms.TextBox _userLoginTxtBx;
        private System.Windows.Forms.TextBox _userPassTxtBx;
        private System.Windows.Forms.TextBox _filePathTxtBx;
        private System.Windows.Forms.Button _runBtn;
    }
}


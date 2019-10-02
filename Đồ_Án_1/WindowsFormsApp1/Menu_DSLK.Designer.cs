namespace WindowsFormsApp1
{
    partial class Menu_DSLK
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
            this.BtnXem = new System.Windows.Forms.Button();
            this.BtnAddFirst = new System.Windows.Forms.Button();
            this.TextBoxReview = new System.Windows.Forms.TextBox();
            this.BtnAddBefore = new System.Windows.Forms.Button();
            this.BtnAddLast = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnRemoveFirst = new System.Windows.Forms.Button();
            this.BtnRemoveLast = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.BtnResetReview = new System.Windows.Forms.Button();
            this.BtnAddAfter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnXem
            // 
            this.BtnXem.Location = new System.Drawing.Point(25, 33);
            this.BtnXem.Name = "BtnXem";
            this.BtnXem.Size = new System.Drawing.Size(160, 42);
            this.BtnXem.TabIndex = 5;
            this.BtnXem.Text = "Mở file và xem";
            this.BtnXem.UseVisualStyleBackColor = true;
            this.BtnXem.Click += new System.EventHandler(this.BtnXem_Click);
            // 
            // BtnAddFirst
            // 
            this.BtnAddFirst.Location = new System.Drawing.Point(229, 33);
            this.BtnAddFirst.Name = "BtnAddFirst";
            this.BtnAddFirst.Size = new System.Drawing.Size(118, 42);
            this.BtnAddFirst.TabIndex = 6;
            this.BtnAddFirst.Text = "Add First";
            this.BtnAddFirst.UseVisualStyleBackColor = true;
            this.BtnAddFirst.Click += new System.EventHandler(this.BtnAddFirst_Click);
            // 
            // TextBoxReview
            // 
            this.TextBoxReview.Location = new System.Drawing.Point(25, 109);
            this.TextBoxReview.Multiline = true;
            this.TextBoxReview.Name = "TextBoxReview";
            this.TextBoxReview.Size = new System.Drawing.Size(622, 429);
            this.TextBoxReview.TabIndex = 7;
            // 
            // BtnAddBefore
            // 
            this.BtnAddBefore.Location = new System.Drawing.Point(387, 33);
            this.BtnAddBefore.Name = "BtnAddBefore";
            this.BtnAddBefore.Size = new System.Drawing.Size(110, 41);
            this.BtnAddBefore.TabIndex = 8;
            this.BtnAddBefore.Text = "Add Before";
            this.BtnAddBefore.UseVisualStyleBackColor = true;
            this.BtnAddBefore.Click += new System.EventHandler(this.BtnAddBefore_Click);
            // 
            // BtnAddLast
            // 
            this.BtnAddLast.Location = new System.Drawing.Point(690, 33);
            this.BtnAddLast.Name = "BtnAddLast";
            this.BtnAddLast.Size = new System.Drawing.Size(115, 39);
            this.BtnAddLast.TabIndex = 10;
            this.BtnAddLast.Text = "Add Last";
            this.BtnAddLast.UseVisualStyleBackColor = true;
            this.BtnAddLast.Click += new System.EventHandler(this.BtnAddLast_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(690, 102);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(114, 35);
            this.BtnRemove.TabIndex = 11;
            this.BtnRemove.Text = "Remove Node";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnRemoveFirst
            // 
            this.BtnRemoveFirst.Location = new System.Drawing.Point(690, 172);
            this.BtnRemoveFirst.Name = "BtnRemoveFirst";
            this.BtnRemoveFirst.Size = new System.Drawing.Size(114, 34);
            this.BtnRemoveFirst.TabIndex = 12;
            this.BtnRemoveFirst.Text = "Remove First";
            this.BtnRemoveFirst.UseVisualStyleBackColor = true;
            this.BtnRemoveFirst.Click += new System.EventHandler(this.BtnRemoveFirst_Click);
            // 
            // BtnRemoveLast
            // 
            this.BtnRemoveLast.Location = new System.Drawing.Point(690, 246);
            this.BtnRemoveLast.Name = "BtnRemoveLast";
            this.BtnRemoveLast.Size = new System.Drawing.Size(113, 36);
            this.BtnRemoveLast.TabIndex = 13;
            this.BtnRemoveLast.Text = "Remove Last";
            this.BtnRemoveLast.UseVisualStyleBackColor = true;
            this.BtnRemoveLast.Click += new System.EventHandler(this.BtnRemoveLast_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(852, 33);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(109, 38);
            this.BtnFind.TabIndex = 14;
            this.BtnFind.Text = "Find Node";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // BtnResetReview
            // 
            this.BtnResetReview.Location = new System.Drawing.Point(690, 401);
            this.BtnResetReview.Name = "BtnResetReview";
            this.BtnResetReview.Size = new System.Drawing.Size(121, 137);
            this.BtnResetReview.TabIndex = 15;
            this.BtnResetReview.Text = "Reset Review";
            this.BtnResetReview.UseVisualStyleBackColor = true;
            this.BtnResetReview.Click += new System.EventHandler(this.BtnResetReview_Click);
            // 
            // BtnAddAfter
            // 
            this.BtnAddAfter.Location = new System.Drawing.Point(542, 33);
            this.BtnAddAfter.Name = "BtnAddAfter";
            this.BtnAddAfter.Size = new System.Drawing.Size(105, 41);
            this.BtnAddAfter.TabIndex = 16;
            this.BtnAddAfter.Text = "Add After";
            this.BtnAddAfter.UseVisualStyleBackColor = true;
            this.BtnAddAfter.Click += new System.EventHandler(this.BtnAddAfter_Click);
            // 
            // Menu_DSLK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 562);
            this.Controls.Add(this.BtnAddAfter);
            this.Controls.Add(this.BtnResetReview);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnRemoveLast);
            this.Controls.Add(this.BtnRemoveFirst);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAddLast);
            this.Controls.Add(this.BtnAddBefore);
            this.Controls.Add(this.TextBoxReview);
            this.Controls.Add(this.BtnAddFirst);
            this.Controls.Add(this.BtnXem);
            this.Name = "Menu_DSLK";
            this.Text = "Menu DSLK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnXem;
        private System.Windows.Forms.Button BtnAddFirst;
        private System.Windows.Forms.TextBox TextBoxReview;
        private System.Windows.Forms.Button BtnAddBefore;
        private System.Windows.Forms.Button BtnAddLast;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnRemoveFirst;
        private System.Windows.Forms.Button BtnRemoveLast;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.Button BtnResetReview;
        private System.Windows.Forms.Button BtnAddAfter;
    }
}


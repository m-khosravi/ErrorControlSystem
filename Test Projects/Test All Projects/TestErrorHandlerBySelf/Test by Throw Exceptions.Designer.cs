﻿namespace TestErrorHandlerBySelf
{
    partial class FormTest
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnTestHandledFirstExp = new System.Windows.Forms.Button();
            this.btnTestUnHandledUIExp = new System.Windows.Forms.Button();
            this.btnTestUnHandledThreadExp = new System.Windows.Forms.Button();
            this.btnTestUnhandledTaskExp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(51, 222);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(238, 38);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnTestHandledFirstExp
            // 
            this.btnTestHandledFirstExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestHandledFirstExp.Location = new System.Drawing.Point(51, 12);
            this.btnTestHandledFirstExp.Name = "btnTestHandledFirstExp";
            this.btnTestHandledFirstExp.Size = new System.Drawing.Size(238, 42);
            this.btnTestHandledFirstExp.TabIndex = 6;
            this.btnTestHandledFirstExp.Text = "ThrowTry/Catch Exception";
            this.btnTestHandledFirstExp.UseVisualStyleBackColor = true;
            this.btnTestHandledFirstExp.Click += new System.EventHandler(this.btnTestHandledFirstExp_Click);
            // 
            // btnTestUnHandledUIExp
            // 
            this.btnTestUnHandledUIExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestUnHandledUIExp.Location = new System.Drawing.Point(51, 60);
            this.btnTestUnHandledUIExp.Name = "btnTestUnHandledUIExp";
            this.btnTestUnHandledUIExp.Size = new System.Drawing.Size(238, 42);
            this.btnTestUnHandledUIExp.TabIndex = 6;
            this.btnTestUnHandledUIExp.Text = "Throw UnHandled UI Exception";
            this.btnTestUnHandledUIExp.UseVisualStyleBackColor = true;
            this.btnTestUnHandledUIExp.Click += new System.EventHandler(this.btnTestUnHandledUIExp_Click);
            // 
            // btnTestUnHandledThreadExp
            // 
            this.btnTestUnHandledThreadExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestUnHandledThreadExp.Location = new System.Drawing.Point(51, 108);
            this.btnTestUnHandledThreadExp.Name = "btnTestUnHandledThreadExp";
            this.btnTestUnHandledThreadExp.Size = new System.Drawing.Size(238, 42);
            this.btnTestUnHandledThreadExp.TabIndex = 7;
            this.btnTestUnHandledThreadExp.Text = "Throw UnHandled Thread Exception";
            this.btnTestUnHandledThreadExp.UseVisualStyleBackColor = true;
            this.btnTestUnHandledThreadExp.Click += new System.EventHandler(this.btnTestUnHandledThreadExp_Click);
            // 
            // btnTestUnhandledTaskExp
            // 
            this.btnTestUnhandledTaskExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestUnhandledTaskExp.Location = new System.Drawing.Point(51, 156);
            this.btnTestUnhandledTaskExp.Name = "btnTestUnhandledTaskExp";
            this.btnTestUnhandledTaskExp.Size = new System.Drawing.Size(238, 42);
            this.btnTestUnhandledTaskExp.TabIndex = 8;
            this.btnTestUnhandledTaskExp.Text = "Throw UnHandled Task Exception";
            this.btnTestUnhandledTaskExp.UseVisualStyleBackColor = true;
            this.btnTestUnhandledTaskExp.Click += new System.EventHandler(this.btnTestUnhandledTaskExp_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 272);
            this.Controls.Add(this.btnTestUnhandledTaskExp);
            this.Controls.Add(this.btnTestUnHandledThreadExp);
            this.Controls.Add(this.btnTestUnHandledUIExp);
            this.Controls.Add(this.btnTestHandledFirstExp);
            this.Controls.Add(this.btnQuit);
            this.Name = "FormTest";
            this.Text = "Test by Throw Exceptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnTestHandledFirstExp;
        private System.Windows.Forms.Button btnTestUnHandledUIExp;
        private System.Windows.Forms.Button btnTestUnHandledThreadExp;
        private System.Windows.Forms.Button btnTestUnhandledTaskExp;
    }
}


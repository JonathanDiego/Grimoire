namespace Grimorie
{
    partial class ChangeAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeAll));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pgChangeAll = new System.Windows.Forms.PropertyGrid();
            this.bRun = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pgChangeAll);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 301);
            this.panel1.TabIndex = 12;
            // 
            // pgChangeAll
            // 
            this.pgChangeAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgChangeAll.Location = new System.Drawing.Point(0, 0);
            this.pgChangeAll.Name = "pgChangeAll";
            this.pgChangeAll.Size = new System.Drawing.Size(458, 301);
            this.pgChangeAll.TabIndex = 13;
            // 
            // bRun
            // 
            this.bRun.BackgroundImage = global::Grimorie.Properties.Resources.play;
            this.bRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bRun.ImageKey = "(none)";
            this.bRun.Location = new System.Drawing.Point(415, 312);
            this.bRun.Margin = new System.Windows.Forms.Padding(0);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(40, 40);
            this.bRun.TabIndex = 11;
            this.bRun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click);
            // 
            // bClose
            // 
            this.bClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bClose.BackgroundImage")));
            this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bClose.ImageKey = "(none)";
            this.bClose.Location = new System.Drawing.Point(370, 312);
            this.bClose.Margin = new System.Windows.Forms.Padding(0);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(40, 40);
            this.bClose.TabIndex = 10;
            this.bClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "NOTE: This routine will not change values you left blank";
            // 
            // ChangeAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bRun);
            this.Controls.Add(this.bClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change All";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRun;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PropertyGrid pgChangeAll;
        private System.Windows.Forms.Label label1;
    }
}
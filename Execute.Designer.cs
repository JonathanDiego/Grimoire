namespace Grimorie
{
    partial class Execute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Execute));
            this.data = new System.Windows.Forms.DataGridView();
            this.bClose = new System.Windows.Forms.Button();
            this.bRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(12, 12);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(733, 293);
            this.data.TabIndex = 0;
            // 
            // bClose
            // 
            this.bClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bClose.BackgroundImage")));
            this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bClose.ImageKey = "(none)";
            this.bClose.Location = new System.Drawing.Point(660, 308);
            this.bClose.Margin = new System.Windows.Forms.Padding(0);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(40, 40);
            this.bClose.TabIndex = 8;
            this.bClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bRun
            // 
            this.bRun.BackgroundImage = global::Grimorie.Properties.Resources.play;
            this.bRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bRun.ImageKey = "(none)";
            this.bRun.Location = new System.Drawing.Point(705, 308);
            this.bRun.Margin = new System.Windows.Forms.Padding(0);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(40, 40);
            this.bRun.TabIndex = 9;
            this.bRun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // Execute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 357);
            this.Controls.Add(this.bRun);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Execute";
            this.Text = "Execute";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bRun;
    }
}
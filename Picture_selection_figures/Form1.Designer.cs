namespace Picture_selection_figures
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_open = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_run = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_open
            // 
            this.bt_open.Font = new System.Drawing.Font("新細明體", 20F);
            this.bt_open.Location = new System.Drawing.Point(423, 12);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(177, 59);
            this.bt_open.TabIndex = 0;
            this.bt_open.Text = "開啟";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bt_run
            // 
            this.bt_run.Font = new System.Drawing.Font("新細明體", 20F);
            this.bt_run.Location = new System.Drawing.Point(423, 280);
            this.bt_run.Name = "bt_run";
            this.bt_run.Size = new System.Drawing.Size(177, 59);
            this.bt_run.TabIndex = 2;
            this.bt_run.TabStop = false;
            this.bt_run.Text = "框選";
            this.bt_run.UseVisualStyleBackColor = true;
            this.bt_run.Click += new System.EventHandler(this.bt_run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 351);
            this.Controls.Add(this.bt_run);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_open);
            this.Name = "Form1";
            this.Text = "Picture Selection Figures";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_run;
    }
}


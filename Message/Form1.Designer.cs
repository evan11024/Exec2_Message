namespace Message
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
			this.messageButton = new System.Windows.Forms.Button();
			this.messageLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// messageButton
			// 
			this.messageButton.Location = new System.Drawing.Point(209, 66);
			this.messageButton.Name = "messageButton";
			this.messageButton.Size = new System.Drawing.Size(75, 23);
			this.messageButton.TabIndex = 0;
			this.messageButton.Text = "問候";
			this.messageButton.UseVisualStyleBackColor = true;
			this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
			// 
			// messageLabel
			// 
			this.messageLabel.Location = new System.Drawing.Point(147, 116);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(243, 118);
			this.messageLabel.TabIndex = 1;
			this.messageLabel.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 311);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.messageButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button messageButton;
		private System.Windows.Forms.Label messageLabel;
	}
}


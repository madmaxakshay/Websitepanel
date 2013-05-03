namespace WebsitePanel.Setup
{
	partial class ConfirmUninstallPage
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtActions = new System.Windows.Forms.RichTextBox();
			this.lblIntro = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtActions
			// 
			this.txtActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtActions.BackColor = System.Drawing.SystemColors.Window;
			this.txtActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtActions.Location = new System.Drawing.Point(0, 23);
			this.txtActions.Name = "txtActions";
			this.txtActions.ReadOnly = true;
			this.txtActions.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.txtActions.Size = new System.Drawing.Size(457, 181);
			this.txtActions.TabIndex = 4;
			this.txtActions.Text = "";
			// 
			// lblIntro
			// 
			this.lblIntro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblIntro.Location = new System.Drawing.Point(0, 0);
			this.lblIntro.Name = "lblIntro";
			this.lblIntro.Size = new System.Drawing.Size(457, 20);
			this.lblIntro.TabIndex = 5;
			this.lblIntro.Text = "Setup Wizard is ready to:";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(0, 207);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(457, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Click \"Next\" to continue.";
			// 
			// ConfirmUninstallPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblIntro);
			this.Controls.Add(this.txtActions);
			this.Name = "ConfirmUninstallPage";
			this.Size = new System.Drawing.Size(457, 228);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox txtActions;
		private System.Windows.Forms.Label lblIntro;
		private System.Windows.Forms.Label label1;
	}
}

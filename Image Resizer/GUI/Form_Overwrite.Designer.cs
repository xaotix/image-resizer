namespace ImageResizer
{
    partial class Form_Overwrite
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
            this.button_yes = new System.Windows.Forms.Button();
            this.button_yesAll = new System.Windows.Forms.Button();
            this.button_no = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_message = new System.Windows.Forms.Label();
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // button_yes
            // 
            this.button_yes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_yes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button_yes.Location = new System.Drawing.Point(128, 103);
            this.button_yes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_yes.Name = "button_yes";
            this.button_yes.Size = new System.Drawing.Size(112, 35);
            this.button_yes.TabIndex = 0;
            this.button_yes.Text = "Sim";
            this.button_yes.UseVisualStyleBackColor = true;
            // 
            // button_yesAll
            // 
            this.button_yesAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_yesAll.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_yesAll.Location = new System.Drawing.Point(249, 103);
            this.button_yesAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_yesAll.Name = "button_yesAll";
            this.button_yesAll.Size = new System.Drawing.Size(112, 35);
            this.button_yesAll.TabIndex = 1;
            this.button_yesAll.Text = "Sim p/ td";
            this.button_yesAll.UseVisualStyleBackColor = true;
            // 
            // button_no
            // 
            this.button_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_no.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button_no.Location = new System.Drawing.Point(370, 103);
            this.button_no.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_no.Name = "button_no";
            this.button_no.Size = new System.Drawing.Size(112, 35);
            this.button_no.TabIndex = 2;
            this.button_no.Text = "Não";
            this.button_no.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(492, 102);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(112, 35);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Cancelar";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // label_message
            // 
            this.label_message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_message.Location = new System.Drawing.Point(74, 14);
            this.label_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(531, 68);
            this.label_message.TabIndex = 4;
            this.label_message.Text = "This file already exists.\r\nOverwrite it ?";
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.Image = global::ImageResizer.Properties.Resources.help;
            this.pictureBox_icon.Location = new System.Drawing.Point(16, 14);
            this.pictureBox_icon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(48, 49);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_icon.TabIndex = 5;
            this.pictureBox_icon.TabStop = false;
            // 
            // Form_Overwrite
            // 
            this.AcceptButton = this.button_yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(622, 155);
            this.Controls.Add(this.pictureBox_icon);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_no);
            this.Controls.Add(this.button_yesAll);
            this.Controls.Add(this.button_yes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Overwrite";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Overwrite";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_yes;
        private System.Windows.Forms.Button button_yesAll;
        private System.Windows.Forms.Button button_no;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.PictureBox pictureBox_icon;
    }
}
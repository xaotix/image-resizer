namespace ImageResizer
{
    partial class Form_Resize
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
            this.components = new System.ComponentModel.Container();
            this.checkBox_keepAspectRatio = new System.Windows.Forms.CheckBox();
            this.groupBox_percentage = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_widthPc = new System.Windows.Forms.Label();
            this.label_heightPc = new System.Windows.Forms.Label();
            this.numUD_heightPc = new System.Windows.Forms.NumericUpDown();
            this.numUD_widthPc = new System.Windows.Forms.NumericUpDown();
            this.groupBox_flat = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_width = new System.Windows.Forms.Label();
            this.label_height = new System.Windows.Forms.Label();
            this.numUD_height = new System.Windows.Forms.NumericUpDown();
            this.numUD_width = new System.Windows.Forms.NumericUpDown();
            this.textBox_outputFolderPath = new System.Windows.Forms.TextBox();
            this.label_outputFolder = new System.Windows.Forms.Label();
            this.radioButton_flat = new System.Windows.Forms.RadioButton();
            this.radioButton_percentage = new System.Windows.Forms.RadioButton();
            this.button_start = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_selectOutputFolder = new System.Windows.Forms.Button();
            this.toolTip_main = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog_main = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox_percentage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_heightPc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_widthPc)).BeginInit();
            this.groupBox_flat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_width)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_keepAspectRatio
            // 
            this.checkBox_keepAspectRatio.AutoSize = true;
            this.checkBox_keepAspectRatio.Checked = true;
            this.checkBox_keepAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_keepAspectRatio.Location = new System.Drawing.Point(22, 214);
            this.checkBox_keepAspectRatio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_keepAspectRatio.Name = "checkBox_keepAspectRatio";
            this.checkBox_keepAspectRatio.Size = new System.Drawing.Size(161, 24);
            this.checkBox_keepAspectRatio.TabIndex = 2;
            this.checkBox_keepAspectRatio.Text = "Manter proporção";
            this.checkBox_keepAspectRatio.UseVisualStyleBackColor = true;
            this.checkBox_keepAspectRatio.CheckedChanged += new System.EventHandler(this.checkBox_keepAspectRatio_CheckedChanged);
            // 
            // groupBox_percentage
            // 
            this.groupBox_percentage.Controls.Add(this.label4);
            this.groupBox_percentage.Controls.Add(this.label3);
            this.groupBox_percentage.Controls.Add(this.label_widthPc);
            this.groupBox_percentage.Controls.Add(this.label_heightPc);
            this.groupBox_percentage.Controls.Add(this.numUD_heightPc);
            this.groupBox_percentage.Controls.Add(this.numUD_widthPc);
            this.groupBox_percentage.Enabled = false;
            this.groupBox_percentage.Location = new System.Drawing.Point(372, 68);
            this.groupBox_percentage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_percentage.Name = "groupBox_percentage";
            this.groupBox_percentage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_percentage.Size = new System.Drawing.Size(339, 137);
            this.groupBox_percentage.TabIndex = 1;
            this.groupBox_percentage.TabStop = false;
            this.groupBox_percentage.Text = "Porcentagem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "%";
            // 
            // label_widthPc
            // 
            this.label_widthPc.AutoSize = true;
            this.label_widthPc.Location = new System.Drawing.Point(28, 35);
            this.label_widthPc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_widthPc.Name = "label_widthPc";
            this.label_widthPc.Size = new System.Drawing.Size(68, 20);
            this.label_widthPc.TabIndex = 0;
            this.label_widthPc.Text = "Largura:";
            // 
            // label_heightPc
            // 
            this.label_heightPc.AutoSize = true;
            this.label_heightPc.Location = new System.Drawing.Point(28, 83);
            this.label_heightPc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_heightPc.Name = "label_heightPc";
            this.label_heightPc.Size = new System.Drawing.Size(55, 20);
            this.label_heightPc.TabIndex = 2;
            this.label_heightPc.Text = "Altura:";
            // 
            // numUD_heightPc
            // 
            this.numUD_heightPc.Location = new System.Drawing.Point(131, 77);
            this.numUD_heightPc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numUD_heightPc.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numUD_heightPc.Name = "numUD_heightPc";
            this.numUD_heightPc.Size = new System.Drawing.Size(149, 26);
            this.numUD_heightPc.TabIndex = 3;
            this.numUD_heightPc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUD_heightPc.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numUD_heightPc.ValueChanged += new System.EventHandler(this.numUD_heightPc_ValueChanged);
            // 
            // numUD_widthPc
            // 
            this.numUD_widthPc.Location = new System.Drawing.Point(131, 29);
            this.numUD_widthPc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numUD_widthPc.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numUD_widthPc.Name = "numUD_widthPc";
            this.numUD_widthPc.Size = new System.Drawing.Size(145, 26);
            this.numUD_widthPc.TabIndex = 1;
            this.numUD_widthPc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUD_widthPc.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numUD_widthPc.ValueChanged += new System.EventHandler(this.numUD_widthPc_ValueChanged);
            // 
            // groupBox_flat
            // 
            this.groupBox_flat.Controls.Add(this.label6);
            this.groupBox_flat.Controls.Add(this.label5);
            this.groupBox_flat.Controls.Add(this.label_width);
            this.groupBox_flat.Controls.Add(this.label_height);
            this.groupBox_flat.Controls.Add(this.numUD_height);
            this.groupBox_flat.Controls.Add(this.numUD_width);
            this.groupBox_flat.Location = new System.Drawing.Point(22, 68);
            this.groupBox_flat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_flat.Name = "groupBox_flat";
            this.groupBox_flat.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_flat.Size = new System.Drawing.Size(339, 137);
            this.groupBox_flat.TabIndex = 0;
            this.groupBox_flat.TabStop = false;
            this.groupBox_flat.Text = "Flat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pixels";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pixels";
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(16, 35);
            this.label_width.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(68, 20);
            this.label_width.TabIndex = 0;
            this.label_width.Text = "Largura:";
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(16, 83);
            this.label_height.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(55, 20);
            this.label_height.TabIndex = 2;
            this.label_height.Text = "Altura:";
            // 
            // numUD_height
            // 
            this.numUD_height.Location = new System.Drawing.Point(121, 77);
            this.numUD_height.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numUD_height.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numUD_height.Name = "numUD_height";
            this.numUD_height.Size = new System.Drawing.Size(143, 26);
            this.numUD_height.TabIndex = 3;
            this.numUD_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUD_height.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUD_height.ValueChanged += new System.EventHandler(this.numUD_height_ValueChanged);
            // 
            // numUD_width
            // 
            this.numUD_width.Location = new System.Drawing.Point(121, 29);
            this.numUD_width.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numUD_width.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numUD_width.Name = "numUD_width";
            this.numUD_width.Size = new System.Drawing.Size(143, 26);
            this.numUD_width.TabIndex = 1;
            this.numUD_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUD_width.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUD_width.ValueChanged += new System.EventHandler(this.numUD_width_ValueChanged);
            // 
            // textBox_outputFolderPath
            // 
            this.textBox_outputFolderPath.Location = new System.Drawing.Point(22, 294);
            this.textBox_outputFolderPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_outputFolderPath.Name = "textBox_outputFolderPath";
            this.textBox_outputFolderPath.ReadOnly = true;
            this.textBox_outputFolderPath.Size = new System.Drawing.Size(530, 26);
            this.textBox_outputFolderPath.TabIndex = 4;
            this.textBox_outputFolderPath.TextChanged += new System.EventHandler(this.textBox_outputFolderPath_TextChanged);
            // 
            // label_outputFolder
            // 
            this.label_outputFolder.AutoSize = true;
            this.label_outputFolder.Location = new System.Drawing.Point(22, 268);
            this.label_outputFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_outputFolder.Name = "label_outputFolder";
            this.label_outputFolder.Size = new System.Drawing.Size(133, 20);
            this.label_outputFolder.TabIndex = 3;
            this.label_outputFolder.Text = "Diretório de saída";
            // 
            // radioButton_flat
            // 
            this.radioButton_flat.AutoSize = true;
            this.radioButton_flat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButton_flat.Location = new System.Drawing.Point(27, 18);
            this.radioButton_flat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_flat.Name = "radioButton_flat";
            this.radioButton_flat.Size = new System.Drawing.Size(74, 24);
            this.radioButton_flat.TabIndex = 7;
            this.radioButton_flat.Text = "Pixels";
            this.radioButton_flat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton_flat.UseVisualStyleBackColor = true;
            this.radioButton_flat.CheckedChanged += new System.EventHandler(this.radioButton_flat_CheckedChanged);
            // 
            // radioButton_percentage
            // 
            this.radioButton_percentage.AutoSize = true;
            this.radioButton_percentage.Checked = true;
            this.radioButton_percentage.Location = new System.Drawing.Point(372, 18);
            this.radioButton_percentage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_percentage.Name = "radioButton_percentage";
            this.radioButton_percentage.Size = new System.Drawing.Size(129, 24);
            this.radioButton_percentage.TabIndex = 7;
            this.radioButton_percentage.TabStop = true;
            this.radioButton_percentage.Text = "Porcentagem";
            this.radioButton_percentage.UseVisualStyleBackColor = true;
            this.radioButton_percentage.CheckedChanged += new System.EventHandler(this.radioButton_percentage_CheckedChanged);
            // 
            // button_start
            // 
            this.button_start.Image = global::ImageResizer.Properties.Resources.accept_button;
            this.button_start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_start.Location = new System.Drawing.Point(561, 362);
            this.button_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(150, 35);
            this.button_start.TabIndex = 6;
            this.button_start.Text = "Iniciar";
            this.toolTip_main.SetToolTip(this.button_start, "Iniciar!");
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Image = global::ImageResizer.Properties.Resources.cancel;
            this.button_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cancel.Location = new System.Drawing.Point(402, 362);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(150, 35);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "Cancelar";
            this.toolTip_main.SetToolTip(this.button_cancel, "Cancelar");
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_selectOutputFolder
            // 
            this.button_selectOutputFolder.Image = global::ImageResizer.Properties.Resources.folder;
            this.button_selectOutputFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_selectOutputFolder.Location = new System.Drawing.Point(561, 292);
            this.button_selectOutputFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_selectOutputFolder.Name = "button_selectOutputFolder";
            this.button_selectOutputFolder.Size = new System.Drawing.Size(150, 35);
            this.button_selectOutputFolder.TabIndex = 5;
            this.button_selectOutputFolder.Text = "Selecionar...";
            this.toolTip_main.SetToolTip(this.button_selectOutputFolder, "Selecione a pasta de destino");
            this.button_selectOutputFolder.UseVisualStyleBackColor = true;
            this.button_selectOutputFolder.Click += new System.EventHandler(this.button_selectOutputFolder_Click);
            // 
            // Form_Resize
            // 
            this.AcceptButton = this.button_start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(734, 417);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.radioButton_percentage);
            this.Controls.Add(this.radioButton_flat);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.checkBox_keepAspectRatio);
            this.Controls.Add(this.groupBox_percentage);
            this.Controls.Add(this.groupBox_flat);
            this.Controls.Add(this.button_selectOutputFolder);
            this.Controls.Add(this.textBox_outputFolderPath);
            this.Controls.Add(this.label_outputFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Resize";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resize Images";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Resize_FormClosing);
            this.groupBox_percentage.ResumeLayout(false);
            this.groupBox_percentage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_heightPc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_widthPc)).EndInit();
            this.groupBox_flat.ResumeLayout(false);
            this.groupBox_flat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_keepAspectRatio;
        private System.Windows.Forms.GroupBox groupBox_percentage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_widthPc;
        private System.Windows.Forms.Label label_heightPc;
        private System.Windows.Forms.NumericUpDown numUD_heightPc;
        private System.Windows.Forms.NumericUpDown numUD_widthPc;
        private System.Windows.Forms.GroupBox groupBox_flat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.NumericUpDown numUD_height;
        private System.Windows.Forms.NumericUpDown numUD_width;
        private System.Windows.Forms.Button button_selectOutputFolder;
        private System.Windows.Forms.TextBox textBox_outputFolderPath;
        private System.Windows.Forms.Label label_outputFolder;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.RadioButton radioButton_flat;
        private System.Windows.Forms.RadioButton radioButton_percentage;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ToolTip toolTip_main;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_main;
    }
}
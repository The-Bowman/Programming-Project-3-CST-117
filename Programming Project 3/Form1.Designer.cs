namespace Programming_Project_3
{
    partial class instructionLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(instructionLabel));
            this.displayText = new System.Windows.Forms.RichTextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.exitButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveInstructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayText
            // 
            this.displayText.Location = new System.Drawing.Point(115, 138);
            this.displayText.Name = "displayText";
            this.displayText.ReadOnly = true;
            this.displayText.Size = new System.Drawing.Size(423, 179);
            this.displayText.TabIndex = 1;
            this.displayText.Text = "";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(345, 332);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "&Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFile
            // 
            this.openFile.AddExtension = false;
            this.openFile.DefaultExt = "txt";
            this.openFile.Filter = "\"Text files (*.txt)|*.txt|All files (*.*)|*.*\"";
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(345, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(112, 54);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(308, 65);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click \'Browse\' to select a text file to open:";
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "txt";
            this.saveFile.FileName = "File Contents Stats Results";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(345, 370);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveInstructionLabel
            // 
            this.saveInstructionLabel.AutoSize = true;
            this.saveInstructionLabel.Location = new System.Drawing.Point(112, 375);
            this.saveInstructionLabel.Name = "saveInstructionLabel";
            this.saveInstructionLabel.Size = new System.Drawing.Size(212, 13);
            this.saveInstructionLabel.TabIndex = 7;
            this.saveInstructionLabel.Text = "Click \'Save\' to specify a location to save to:";
            // 
            // instructionLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveInstructionLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.displayText);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.KeyPreview = true;
            this.Name = "instructionLabel";
            this.Text = "File Content Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox displayText;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label saveInstructionLabel;
    }
}


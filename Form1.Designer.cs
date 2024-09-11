namespace FileOrganiserSuccession
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFileCount = new Label();
            btnOrganise = new Button();
            lstOperationList = new ListBox();
            SuspendLayout();
            // 
            // lblFileCount
            // 
            lblFileCount.AutoSize = true;
            lblFileCount.Location = new Point(12, 9);
            lblFileCount.Name = "lblFileCount";
            lblFileCount.Size = new Size(91, 15);
            lblFileCount.TabIndex = 0;
            lblFileCount.Text = "Detected: X files";
            // 
            // btnOrganise
            // 
            btnOrganise.Location = new Point(205, 5);
            btnOrganise.Name = "btnOrganise";
            btnOrganise.Size = new Size(75, 23);
            btnOrganise.TabIndex = 1;
            btnOrganise.Text = "Organise";
            btnOrganise.UseVisualStyleBackColor = true;
            btnOrganise.Click += btnOrganise_Click;
            // 
            // lstOperationList
            // 
            lstOperationList.FormattingEnabled = true;
            lstOperationList.ItemHeight = 15;
            lstOperationList.Location = new Point(12, 34);
            lstOperationList.Name = "lstOperationList";
            lstOperationList.Size = new Size(268, 154);
            lstOperationList.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 200);
            Controls.Add(lstOperationList);
            Controls.Add(btnOrganise);
            Controls.Add(lblFileCount);
            Name = "Form1";
            Text = "File Manager Succession";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFileCount;
        private Button btnOrganise;
        private ListBox lstOperationList;
    }
}

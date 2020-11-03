namespace Soundboard
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.fileSelectButton = new System.Windows.Forms.Button();
            this.audioList = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(36, 41);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(86, 41);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // testButton
            // 
            this.testButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testButton.Location = new System.Drawing.Point(55, 88);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(50, 23);
            this.testButton.TabIndex = 1;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(159, 53);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(235, 20);
            this.filePath.TabIndex = 2;
            // 
            // fileSelectButton
            // 
            this.fileSelectButton.Location = new System.Drawing.Point(400, 51);
            this.fileSelectButton.Name = "fileSelectButton";
            this.fileSelectButton.Size = new System.Drawing.Size(75, 23);
            this.fileSelectButton.TabIndex = 3;
            this.fileSelectButton.Text = "Browse";
            this.fileSelectButton.UseVisualStyleBackColor = true;
            this.fileSelectButton.Click += new System.EventHandler(this.fileSelectButton_Click);
            // 
            // audioList
            // 
            this.audioList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.timeLength});
            this.audioList.HideSelection = false;
            this.audioList.Location = new System.Drawing.Point(159, 108);
            this.audioList.Name = "audioList";
            this.audioList.Scrollable = false;
            this.audioList.Size = new System.Drawing.Size(316, 274);
            this.audioList.TabIndex = 4;
            this.audioList.UseCompatibleStateImageBehavior = false;
            this.audioList.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 226;
            // 
            // timeLength
            // 
            this.timeLength.Text = "Time";
            this.timeLength.Width = 87;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(400, 79);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 412);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.audioList);
            this.Controls.Add(this.fileSelectButton);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Soundboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button fileSelectButton;
        private System.Windows.Forms.ListView audioList;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader timeLength;
        private System.Windows.Forms.Button addButton;
    }
}


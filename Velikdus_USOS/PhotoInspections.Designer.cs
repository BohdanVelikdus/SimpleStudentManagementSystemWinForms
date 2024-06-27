namespace Velikdus_USOS
{
    partial class PhotoInspections
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
            pictureBoxInspectingPhoto = new PictureBox();
            buttonLoadAnotherPhoto = new Button();
            textBoxCurrentPath = new TextBox();
            labelCurrentPath = new Label();
            buttonSaveCurrentState = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInspectingPhoto).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxInspectingPhoto
            // 
            pictureBoxInspectingPhoto.Location = new Point(161, 12);
            pictureBoxInspectingPhoto.Name = "pictureBoxInspectingPhoto";
            pictureBoxInspectingPhoto.Size = new Size(223, 259);
            pictureBoxInspectingPhoto.TabIndex = 0;
            pictureBoxInspectingPhoto.TabStop = false;
            // 
            // buttonLoadAnotherPhoto
            // 
            buttonLoadAnotherPhoto.Location = new Point(12, 277);
            buttonLoadAnotherPhoto.Name = "buttonLoadAnotherPhoto";
            buttonLoadAnotherPhoto.Size = new Size(247, 60);
            buttonLoadAnotherPhoto.TabIndex = 1;
            buttonLoadAnotherPhoto.Text = "Load another photo";
            buttonLoadAnotherPhoto.UseVisualStyleBackColor = true;
            buttonLoadAnotherPhoto.Click += buttonLoadAnotherPhoto_Click;
            // 
            // textBoxCurrentPath
            // 
            textBoxCurrentPath.Location = new Point(147, 384);
            textBoxCurrentPath.Name = "textBoxCurrentPath";
            textBoxCurrentPath.ReadOnly = true;
            textBoxCurrentPath.Size = new Size(247, 31);
            textBoxCurrentPath.TabIndex = 2;
            // 
            // labelCurrentPath
            // 
            labelCurrentPath.AutoSize = true;
            labelCurrentPath.Location = new Point(208, 340);
            labelCurrentPath.Name = "labelCurrentPath";
            labelCurrentPath.Size = new Size(109, 25);
            labelCurrentPath.TabIndex = 3;
            labelCurrentPath.Text = "Current Path";
            // 
            // buttonSaveCurrentState
            // 
            buttonSaveCurrentState.Location = new Point(265, 277);
            buttonSaveCurrentState.Name = "buttonSaveCurrentState";
            buttonSaveCurrentState.Size = new Size(240, 60);
            buttonSaveCurrentState.TabIndex = 4;
            buttonSaveCurrentState.Text = "Save current state";
            buttonSaveCurrentState.UseVisualStyleBackColor = true;
            buttonSaveCurrentState.Click += buttonSaveCurrentState_Click;
            // 
            // PhotoInspections
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 432);
            Controls.Add(buttonSaveCurrentState);
            Controls.Add(labelCurrentPath);
            Controls.Add(textBoxCurrentPath);
            Controls.Add(buttonLoadAnotherPhoto);
            Controls.Add(pictureBoxInspectingPhoto);
            Name = "PhotoInspections";
            Text = "PhotoInspections";
            ((System.ComponentModel.ISupportInitialize)pictureBoxInspectingPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxInspectingPhoto;
        private Button buttonLoadAnotherPhoto;
        private TextBox textBoxCurrentPath;
        private Label labelCurrentPath;
        private Button buttonSaveCurrentState;
    }
}
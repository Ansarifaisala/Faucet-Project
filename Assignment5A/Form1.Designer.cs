namespace Assignment5A
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TapPictureBox = new System.Windows.Forms.PictureBox();
            this.speedTrackBar = new System.Windows.Forms.TrackBar();
            this.colorButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.speedTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // TapPictureBox
            // 
            this.TapPictureBox.ErrorImage = global::Assignment5A.Properties.Resources.Faucet;
            this.TapPictureBox.Image = global::Assignment5A.Properties.Resources.Faucet;
            this.TapPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("TapPictureBox.InitialImage")));
            this.TapPictureBox.Location = new System.Drawing.Point(12, 148);
            this.TapPictureBox.Name = "TapPictureBox";
            this.TapPictureBox.Size = new System.Drawing.Size(92, 71);
            this.TapPictureBox.TabIndex = 0;
            this.TapPictureBox.TabStop = false;
            // 
            // speedTrackBar
            // 
            this.speedTrackBar.Location = new System.Drawing.Point(12, 77);
            this.speedTrackBar.Name = "speedTrackBar";
            this.speedTrackBar.Size = new System.Drawing.Size(188, 45);
            this.speedTrackBar.TabIndex = 1;
            this.speedTrackBar.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(12, 13);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 23);
            this.colorButton.TabIndex = 2;
            this.colorButton.Text = "Select Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(93, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // speedTimer
            // 
            this.speedTimer.Tick += new System.EventHandler(this.waterDrop);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.speedTrackBar);
            this.Controls.Add(this.TapPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox TapPictureBox;
        private System.Windows.Forms.TrackBar speedTrackBar;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Timer speedTimer;
    }
}


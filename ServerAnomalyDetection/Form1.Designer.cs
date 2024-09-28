namespace ServerAnomalyDetection
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
            btnDetectServerAnomaly = new Button();
            SuspendLayout();
            // 
            // btnDetectServerAnomaly
            // 
            btnDetectServerAnomaly.Location = new Point(607, 45);
            btnDetectServerAnomaly.Name = "btnDetectServerAnomaly";
            btnDetectServerAnomaly.Size = new Size(124, 41);
            btnDetectServerAnomaly.TabIndex = 0;
            btnDetectServerAnomaly.Text = "偵測伺服器異常";
            btnDetectServerAnomaly.UseVisualStyleBackColor = true;
            btnDetectServerAnomaly.Click += btnDetectServerAnomaly_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDetectServerAnomaly);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDetectServerAnomaly;
    }
}

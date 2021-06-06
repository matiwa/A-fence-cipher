namespace A_fence_cipher
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBSource = new System.Windows.Forms.GroupBox();
            this.rBText = new System.Windows.Forms.RadioButton();
            this.rBFile = new System.Windows.Forms.RadioButton();
            this.gBOperation = new System.Windows.Forms.GroupBox();
            this.rBD = new System.Windows.Forms.RadioButton();
            this.rBE = new System.Windows.Forms.RadioButton();
            this.gBKey = new System.Windows.Forms.GroupBox();
            this.tBKey = new System.Windows.Forms.TextBox();
            this.Btndraw = new System.Windows.Forms.Button();
            this.Btngo = new System.Windows.Forms.Button();
            this.tBText = new System.Windows.Forms.TextBox();
            this.tBMessage = new System.Windows.Forms.TextBox();
            this.gBSource.SuspendLayout();
            this.gBOperation.SuspendLayout();
            this.gBKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBSource
            // 
            this.gBSource.Controls.Add(this.rBFile);
            this.gBSource.Controls.Add(this.rBText);
            this.gBSource.Location = new System.Drawing.Point(13, 13);
            this.gBSource.Name = "gBSource";
            this.gBSource.Size = new System.Drawing.Size(69, 75);
            this.gBSource.TabIndex = 0;
            this.gBSource.TabStop = false;
            this.gBSource.Text = "Source";
            // 
            // rBText
            // 
            this.rBText.AutoSize = true;
            this.rBText.Checked = true;
            this.rBText.Location = new System.Drawing.Point(7, 20);
            this.rBText.Name = "rBText";
            this.rBText.Size = new System.Drawing.Size(46, 17);
            this.rBText.TabIndex = 0;
            this.rBText.TabStop = true;
            this.rBText.Text = "Text";
            this.rBText.UseVisualStyleBackColor = true;
            this.rBText.CheckedChanged += new System.EventHandler(this.SelectSource);
            // 
            // rBFile
            // 
            this.rBFile.AutoSize = true;
            this.rBFile.Location = new System.Drawing.Point(7, 43);
            this.rBFile.Name = "rBFile";
            this.rBFile.Size = new System.Drawing.Size(41, 17);
            this.rBFile.TabIndex = 1;
            this.rBFile.Text = "File";
            this.rBFile.UseVisualStyleBackColor = true;
            this.rBFile.CheckedChanged += new System.EventHandler(this.SelectSource);
            // 
            // gBOperation
            // 
            this.gBOperation.Controls.Add(this.rBD);
            this.gBOperation.Controls.Add(this.rBE);
            this.gBOperation.Location = new System.Drawing.Point(12, 94);
            this.gBOperation.Name = "gBOperation";
            this.gBOperation.Size = new System.Drawing.Size(74, 75);
            this.gBOperation.TabIndex = 2;
            this.gBOperation.TabStop = false;
            this.gBOperation.Text = "Operations";
            // 
            // rBD
            // 
            this.rBD.AutoSize = true;
            this.rBD.Location = new System.Drawing.Point(7, 43);
            this.rBD.Name = "rBD";
            this.rBD.Size = new System.Drawing.Size(62, 17);
            this.rBD.TabIndex = 1;
            this.rBD.Text = "Decrypt";
            this.rBD.UseVisualStyleBackColor = true;
            this.rBD.CheckedChanged += new System.EventHandler(this.SelectOperation);
            // 
            // rBE
            // 
            this.rBE.AutoSize = true;
            this.rBE.Checked = true;
            this.rBE.Location = new System.Drawing.Point(7, 20);
            this.rBE.Name = "rBE";
            this.rBE.Size = new System.Drawing.Size(61, 17);
            this.rBE.TabIndex = 0;
            this.rBE.TabStop = true;
            this.rBE.Text = "Encrypt";
            this.rBE.UseVisualStyleBackColor = true;
            this.rBE.CheckedChanged += new System.EventHandler(this.SelectOperation);
            // 
            // gBKey
            // 
            this.gBKey.Controls.Add(this.Btngo);
            this.gBKey.Controls.Add(this.Btndraw);
            this.gBKey.Controls.Add(this.tBKey);
            this.gBKey.Location = new System.Drawing.Point(12, 175);
            this.gBKey.Name = "gBKey";
            this.gBKey.Size = new System.Drawing.Size(115, 128);
            this.gBKey.TabIndex = 3;
            this.gBKey.TabStop = false;
            this.gBKey.Text = "Key";
            // 
            // tBKey
            // 
            this.tBKey.Location = new System.Drawing.Point(7, 20);
            this.tBKey.Name = "tBKey";
            this.tBKey.Size = new System.Drawing.Size(100, 20);
            this.tBKey.TabIndex = 0;
            // 
            // Btndraw
            // 
            this.Btndraw.Location = new System.Drawing.Point(7, 47);
            this.Btndraw.Name = "Btndraw";
            this.Btndraw.Size = new System.Drawing.Size(75, 23);
            this.Btndraw.TabIndex = 1;
            this.Btndraw.Text = "Draw";
            this.Btndraw.UseVisualStyleBackColor = true;
            this.Btndraw.Click += new System.EventHandler(this.Btndraw_Click);
            // 
            // Btngo
            // 
            this.Btngo.Location = new System.Drawing.Point(8, 99);
            this.Btngo.Name = "Btngo";
            this.Btngo.Size = new System.Drawing.Size(75, 23);
            this.Btngo.TabIndex = 2;
            this.Btngo.Text = "Encrypt";
            this.Btngo.UseVisualStyleBackColor = true;
            this.Btngo.Click += new System.EventHandler(this.Btngo_Click);
            // 
            // tBText
            // 
            this.tBText.Location = new System.Drawing.Point(133, 12);
            this.tBText.Multiline = true;
            this.tBText.Name = "tBText";
            this.tBText.Size = new System.Drawing.Size(325, 290);
            this.tBText.TabIndex = 4;
            // 
            // tBMessage
            // 
            this.tBMessage.Enabled = false;
            this.tBMessage.Location = new System.Drawing.Point(464, 12);
            this.tBMessage.Multiline = true;
            this.tBMessage.Name = "tBMessage";
            this.tBMessage.Size = new System.Drawing.Size(325, 290);
            this.tBMessage.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 315);
            this.Controls.Add(this.tBMessage);
            this.Controls.Add(this.tBText);
            this.Controls.Add(this.gBKey);
            this.Controls.Add(this.gBOperation);
            this.Controls.Add(this.gBSource);
            this.Name = "Form1";
            this.Text = "A fence cipher";
            this.gBSource.ResumeLayout(false);
            this.gBSource.PerformLayout();
            this.gBOperation.ResumeLayout(false);
            this.gBOperation.PerformLayout();
            this.gBKey.ResumeLayout(false);
            this.gBKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBSource;
        private System.Windows.Forms.RadioButton rBFile;
        private System.Windows.Forms.RadioButton rBText;
        private System.Windows.Forms.GroupBox gBOperation;
        private System.Windows.Forms.RadioButton rBD;
        private System.Windows.Forms.RadioButton rBE;
        private System.Windows.Forms.GroupBox gBKey;
        private System.Windows.Forms.Button Btngo;
        private System.Windows.Forms.Button Btndraw;
        private System.Windows.Forms.TextBox tBKey;
        private System.Windows.Forms.TextBox tBText;
        private System.Windows.Forms.TextBox tBMessage;
    }
}


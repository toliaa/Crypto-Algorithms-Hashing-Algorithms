namespace AsyncMethodsApp
{
    partial class AsyncMethods
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnRunAll;
        private System.Windows.Forms.Button btnStopAll;
        private System.Windows.Forms.Button btnRunREDOC;
        private System.Windows.Forms.Button btnStopREDOC;
        private System.Windows.Forms.Button btnRunSHA;
        private System.Windows.Forms.Button btnStopSHA;
        private System.Windows.Forms.Button btnRunLUC;
        private System.Windows.Forms.Button btnStopLUC;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxREDOC;
        private System.Windows.Forms.TextBox textBoxSHA;
        private System.Windows.Forms.TextBox textBoxLUC;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsyncMethods));
            this.btnRunAll = new System.Windows.Forms.Button();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.btnRunREDOC = new System.Windows.Forms.Button();
            this.btnStopREDOC = new System.Windows.Forms.Button();
            this.btnRunSHA = new System.Windows.Forms.Button();
            this.btnStopSHA = new System.Windows.Forms.Button();
            this.btnRunLUC = new System.Windows.Forms.Button();
            this.btnStopLUC = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxREDOC = new System.Windows.Forms.TextBox();
            this.textBoxSHA = new System.Windows.Forms.TextBox();
            this.textBoxLUC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRunAll
            // 
            this.btnRunAll.Location = new System.Drawing.Point(20, 41);
            this.btnRunAll.Name = "btnRunAll";
            this.btnRunAll.Size = new System.Drawing.Size(143, 23);
            this.btnRunAll.TabIndex = 9;
            this.btnRunAll.Text = "Run All";
            this.btnRunAll.UseVisualStyleBackColor = true;
            this.btnRunAll.Click += new System.EventHandler(this.btnRunAll_Click);
            // 
            // btnStopAll
            // 
            this.btnStopAll.Location = new System.Drawing.Point(169, 42);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(133, 23);
            this.btnStopAll.TabIndex = 10;
            this.btnStopAll.Text = "Stop All";
            this.btnStopAll.UseVisualStyleBackColor = true;
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // btnRunREDOC
            // 
            this.btnRunREDOC.Location = new System.Drawing.Point(20, 150);
            this.btnRunREDOC.Name = "btnRunREDOC";
            this.btnRunREDOC.Size = new System.Drawing.Size(143, 23);
            this.btnRunREDOC.TabIndex = 0;
            this.btnRunREDOC.Text = "Run REDOC";
            this.btnRunREDOC.UseVisualStyleBackColor = true;
            this.btnRunREDOC.Click += new System.EventHandler(this.btnRunREDOC_Click);
            // 
            // btnStopREDOC
            // 
            this.btnStopREDOC.Location = new System.Drawing.Point(169, 150);
            this.btnStopREDOC.Name = "btnStopREDOC";
            this.btnStopREDOC.Size = new System.Drawing.Size(133, 23);
            this.btnStopREDOC.TabIndex = 1;
            this.btnStopREDOC.Text = "Stop REDOC";
            this.btnStopREDOC.UseVisualStyleBackColor = true;
            this.btnStopREDOC.Click += new System.EventHandler(this.btnStopREDOC_Click);
            // 
            // btnRunSHA
            // 
            this.btnRunSHA.Location = new System.Drawing.Point(20, 179);
            this.btnRunSHA.Name = "btnRunSHA";
            this.btnRunSHA.Size = new System.Drawing.Size(143, 23);
            this.btnRunSHA.TabIndex = 2;
            this.btnRunSHA.Text = "Run SHA";
            this.btnRunSHA.UseVisualStyleBackColor = true;
            this.btnRunSHA.Click += new System.EventHandler(this.btnRunSHA_Click);
            // 
            // btnStopSHA
            // 
            this.btnStopSHA.Location = new System.Drawing.Point(169, 179);
            this.btnStopSHA.Name = "btnStopSHA";
            this.btnStopSHA.Size = new System.Drawing.Size(133, 23);
            this.btnStopSHA.TabIndex = 3;
            this.btnStopSHA.Text = "Stop SHA";
            this.btnStopSHA.UseVisualStyleBackColor = true;
            this.btnStopSHA.Click += new System.EventHandler(this.btnStopSHA_Click);
            // 
            // btnRunLUC
            // 
            this.btnRunLUC.Location = new System.Drawing.Point(20, 208);
            this.btnRunLUC.Name = "btnRunLUC";
            this.btnRunLUC.Size = new System.Drawing.Size(143, 23);
            this.btnRunLUC.TabIndex = 4;
            this.btnRunLUC.Text = "Run LUC";
            this.btnRunLUC.UseVisualStyleBackColor = true;
            this.btnRunLUC.Click += new System.EventHandler(this.btnRunLUC_Click);
            // 
            // btnStopLUC
            // 
            this.btnStopLUC.Location = new System.Drawing.Point(169, 208);
            this.btnStopLUC.Name = "btnStopLUC";
            this.btnStopLUC.Size = new System.Drawing.Size(133, 23);
            this.btnStopLUC.TabIndex = 5;
            this.btnStopLUC.Text = "Stop LUC";
            this.btnStopLUC.UseVisualStyleBackColor = true;
            this.btnStopLUC.Click += new System.EventHandler(this.btnStopLUC_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(308, 42);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(250, 22);
            this.textBoxInput.TabIndex = 11;
            this.textBoxInput.Text = "Enter text to encrypt";
            // 
            // textBoxREDOC
            // 
            this.textBoxREDOC.Location = new System.Drawing.Point(308, 151);
            this.textBoxREDOC.Name = "textBoxREDOC";
            this.textBoxREDOC.Size = new System.Drawing.Size(250, 22);
            this.textBoxREDOC.TabIndex = 6;
            // 
            // textBoxSHA
            // 
            this.textBoxSHA.Location = new System.Drawing.Point(308, 180);
            this.textBoxSHA.Name = "textBoxSHA";
            this.textBoxSHA.Size = new System.Drawing.Size(250, 22);
            this.textBoxSHA.TabIndex = 7;
            // 
            // textBoxLUC
            // 
            this.textBoxLUC.Location = new System.Drawing.Point(308, 208);
            this.textBoxLUC.Name = "textBoxLUC";
            this.textBoxLUC.Size = new System.Drawing.Size(250, 22);
            this.textBoxLUC.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "© Tolia Driapak 2024";
            // 
            // AsyncMethods
            // 
            this.ClientSize = new System.Drawing.Size(622, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxLUC);
            this.Controls.Add(this.textBoxSHA);
            this.Controls.Add(this.textBoxREDOC);
            this.Controls.Add(this.btnStopLUC);
            this.Controls.Add(this.btnRunLUC);
            this.Controls.Add(this.btnStopSHA);
            this.Controls.Add(this.btnRunSHA);
            this.Controls.Add(this.btnStopREDOC);
            this.Controls.Add(this.btnRunREDOC);
            this.Controls.Add(this.btnStopAll);
            this.Controls.Add(this.btnRunAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AsyncMethods";
            this.Text = "Async Methods App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}

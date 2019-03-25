namespace week_2___MyFirstRfidAppWithPhidgets22
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAntenna = new System.Windows.Forms.Button();
            this.btnAddSayHello = new System.Windows.Forms.Button();
            this.btnRemoveSayHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(20, 22);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1116, 464);
            this.listBox1.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(43, 505);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(167, 47);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "open rfid-reader";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(44, 569);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 44);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "close rfid-reader";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAntenna
            // 
            this.btnAntenna.Location = new System.Drawing.Point(335, 537);
            this.btnAntenna.Name = "btnAntenna";
            this.btnAntenna.Size = new System.Drawing.Size(187, 42);
            this.btnAntenna.TabIndex = 3;
            this.btnAntenna.Text = "antenna on/off";
            this.btnAntenna.UseVisualStyleBackColor = true;
            this.btnAntenna.Click += new System.EventHandler(this.btnAntenna_Click);
            // 
            // btnAddSayHello
            // 
            this.btnAddSayHello.Location = new System.Drawing.Point(639, 527);
            this.btnAddSayHello.Name = "btnAddSayHello";
            this.btnAddSayHello.Size = new System.Drawing.Size(295, 37);
            this.btnAddSayHello.TabIndex = 4;
            this.btnAddSayHello.Text = "add say hello";
            this.btnAddSayHello.UseVisualStyleBackColor = true;
            this.btnAddSayHello.Click += new System.EventHandler(this.btnAddSayHello_Click);
            // 
            // btnRemoveSayHello
            // 
            this.btnRemoveSayHello.Location = new System.Drawing.Point(641, 575);
            this.btnRemoveSayHello.Name = "btnRemoveSayHello";
            this.btnRemoveSayHello.Size = new System.Drawing.Size(293, 33);
            this.btnRemoveSayHello.TabIndex = 5;
            this.btnRemoveSayHello.Text = "remove say hello";
            this.btnRemoveSayHello.UseVisualStyleBackColor = true;
            this.btnRemoveSayHello.Click += new System.EventHandler(this.btnRemoveSayHello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 678);
            this.Controls.Add(this.btnRemoveSayHello);
            this.Controls.Add(this.btnAddSayHello);
            this.Controls.Add(this.btnAntenna);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAntenna;
        private System.Windows.Forms.Button btnAddSayHello;
        private System.Windows.Forms.Button btnRemoveSayHello;
    }
}


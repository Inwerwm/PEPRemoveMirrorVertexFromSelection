namespace RemoveMirrorVertexFromSelection
{
    partial class CtrlForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOpenNegative = new System.Windows.Forms.Button();
            this.buttonOpenPositive = new System.Windows.Forms.Button();
            this.buttonCloseNegative = new System.Windows.Forms.Button();
            this.buttonClosePositive = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonOpenNegative, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOpenPositive, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCloseNegative, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonClosePositive, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(468, 291);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonOpenNegative
            // 
            this.buttonOpenNegative.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenNegative.Location = new System.Drawing.Point(7, 9);
            this.buttonOpenNegative.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.buttonOpenNegative.Name = "buttonOpenNegative";
            this.buttonOpenNegative.Size = new System.Drawing.Size(220, 127);
            this.buttonOpenNegative.TabIndex = 0;
            this.buttonOpenNegative.Text = "除去\r\nX<0";
            this.buttonOpenNegative.UseVisualStyleBackColor = true;
            this.buttonOpenNegative.Click += new System.EventHandler(this.buttonOpenNegative_Click);
            // 
            // buttonOpenPositive
            // 
            this.buttonOpenPositive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenPositive.Location = new System.Drawing.Point(241, 9);
            this.buttonOpenPositive.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.buttonOpenPositive.Name = "buttonOpenPositive";
            this.buttonOpenPositive.Size = new System.Drawing.Size(220, 127);
            this.buttonOpenPositive.TabIndex = 0;
            this.buttonOpenPositive.Text = "除去\r\n0<X";
            this.buttonOpenPositive.UseVisualStyleBackColor = true;
            this.buttonOpenPositive.Click += new System.EventHandler(this.buttonOpenPositive_Click);
            // 
            // buttonCloseNegative
            // 
            this.buttonCloseNegative.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseNegative.Location = new System.Drawing.Point(7, 154);
            this.buttonCloseNegative.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.buttonCloseNegative.Name = "buttonCloseNegative";
            this.buttonCloseNegative.Size = new System.Drawing.Size(220, 128);
            this.buttonCloseNegative.TabIndex = 0;
            this.buttonCloseNegative.Text = "除去\r\nX≦0\r\n";
            this.buttonCloseNegative.UseVisualStyleBackColor = true;
            this.buttonCloseNegative.Click += new System.EventHandler(this.buttonCloseNegative_Click);
            // 
            // buttonClosePositive
            // 
            this.buttonClosePositive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClosePositive.Location = new System.Drawing.Point(241, 154);
            this.buttonClosePositive.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.buttonClosePositive.Name = "buttonClosePositive";
            this.buttonClosePositive.Size = new System.Drawing.Size(220, 128);
            this.buttonClosePositive.TabIndex = 0;
            this.buttonClosePositive.Text = "除去\r\n0≦X\r\n";
            this.buttonClosePositive.UseVisualStyleBackColor = true;
            this.buttonClosePositive.Click += new System.EventHandler(this.buttonClosePositive_Click);
            // 
            // CtrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 309);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Name = "CtrlForm";
            this.Text = "CtrlForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CtrlForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonOpenNegative;
        private System.Windows.Forms.Button buttonOpenPositive;
        private System.Windows.Forms.Button buttonCloseNegative;
        private System.Windows.Forms.Button buttonClosePositive;
    }
}
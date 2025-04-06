namespace LengthCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCM = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtFt = new System.Windows.Forms.TextBox();
            this.txtYard = new System.Windows.Forms.TextBox();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(137, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "公分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(276, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "公尺";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(413, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "公里";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(420, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "碼";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(279, 214);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "尺";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(137, 214);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "吋";
            // 
            // txtCM
            // 
            this.txtCM.Location = new System.Drawing.Point(143, 138);
            this.txtCM.Margin = new System.Windows.Forms.Padding(4);
            this.txtCM.Multiline = true;
            this.txtCM.Name = "txtCM";
            this.txtCM.Size = new System.Drawing.Size(132, 22);
            this.txtCM.TabIndex = 10;
            this.txtCM.TextChanged += new System.EventHandler(this.txtCM_TextChanged);
            this.txtCM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCM_KeyUp_1);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(284, 138);
            this.txtM.Margin = new System.Windows.Forms.Padding(4);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(132, 25);
            this.txtM.TabIndex = 11;
            this.txtM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtM_KeyUp);
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(425, 138);
            this.txtKM.Margin = new System.Windows.Forms.Padding(4);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(132, 25);
            this.txtKM.TabIndex = 12;
            this.txtKM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKM_KeyUp);
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(143, 244);
            this.txtIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(132, 25);
            this.txtIn.TabIndex = 15;
            this.txtIn.TextChanged += new System.EventHandler(this.txtIn_TextChanged);
            this.txtIn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIn_KeyUp);
            // 
            // txtFt
            // 
            this.txtFt.Location = new System.Drawing.Point(284, 244);
            this.txtFt.Margin = new System.Windows.Forms.Padding(4);
            this.txtFt.Name = "txtFt";
            this.txtFt.Size = new System.Drawing.Size(132, 25);
            this.txtFt.TabIndex = 16;
            this.txtFt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFt_KeyUp);
            // 
            // txtYard
            // 
            this.txtYard.Location = new System.Drawing.Point(427, 242);
            this.txtYard.Margin = new System.Windows.Forms.Padding(4);
            this.txtYard.Name = "txtYard";
            this.txtYard.Size = new System.Drawing.Size(132, 25);
            this.txtYard.TabIndex = 17;
            this.txtYard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtYard_KeyUp);
            // 
            // btnAllClear
            // 
            this.btnAllClear.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAllClear.Location = new System.Drawing.Point(143, 36);
            this.btnAllClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(175, 69);
            this.btnAllClear.TabIndex = 20;
            this.btnAllClear.Text = "清除";
            this.btnAllClear.UseVisualStyleBackColor = true;
            this.btnAllClear.Click += new System.EventHandler(this.btnAllClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(137, 332);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "說明文字";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(141, 356);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(415, 25);
            this.txtInfo.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAllClear);
            this.Controls.Add(this.txtYard);
            this.Controls.Add(this.txtFt);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtCM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCM_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCM;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox txtFt;
        private System.Windows.Forms.TextBox txtYard;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInfo;
    }
}


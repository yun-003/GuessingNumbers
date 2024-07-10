
namespace GuessingNumbers
{
    partial class GuessingNumber
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.begin = new System.Windows.Forms.Button();
            this.ce = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.ans = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.input.Font = new System.Drawing.Font("宋体", 50F);
            this.input.Location = new System.Drawing.Point(55, 38);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(333, 111);
            this.input.TabIndex = 0;
            this.input.Text = "1234";
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(418, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 111);
            this.button1.TabIndex = 1;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // begin
            // 
            this.begin.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.begin.Location = new System.Drawing.Point(62, 188);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(221, 94);
            this.begin.TabIndex = 2;
            this.begin.Text = "开始";
            this.begin.UseVisualStyleBackColor = true;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // ce
            // 
            this.ce.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ce.Location = new System.Drawing.Point(316, 188);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(236, 94);
            this.ce.TabIndex = 3;
            this.ce.Text = "清除";
            this.ce.UseVisualStyleBackColor = true;
            this.ce.Click += new System.EventHandler(this.button3_Click);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.output.Font = new System.Drawing.Font("宋体", 20F);
            this.output.Location = new System.Drawing.Point(55, 326);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(497, 487);
            this.output.TabIndex = 4;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // ans
            // 
            this.ans.BackColor = System.Drawing.SystemColors.Control;
            this.ans.Font = new System.Drawing.Font("宋体", 25F);
            this.ans.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ans.Location = new System.Drawing.Point(46, 841);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(497, 57);
            this.ans.TabIndex = 5;
            this.ans.Text = "答案：";
            this.ans.Click += new System.EventHandler(this.ans_Click);
            // 
            // GuessingNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 907);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.output);
            this.Controls.Add(this.ce);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input);
            this.Name = "GuessingNumber";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button begin;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label ans;
    }
}


namespace HymnPPT
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Input_tB = new System.Windows.Forms.TextBox();
            this.Search_Bt = new System.Windows.Forms.Button();
            this.Result_lb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Open_Bt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.preview_gB = new System.Windows.Forms.GroupBox();
            this.Preview_tB = new System.Windows.Forms.TextBox();
            this.preview_gB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input_tB
            // 
            this.Input_tB.Location = new System.Drawing.Point(13, 13);
            this.Input_tB.Name = "Input_tB";
            this.Input_tB.Size = new System.Drawing.Size(369, 21);
            this.Input_tB.TabIndex = 0;
            this.Input_tB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_tB_KeyDown);
            // 
            // Search_Bt
            // 
            this.Search_Bt.Location = new System.Drawing.Point(397, 12);
            this.Search_Bt.Name = "Search_Bt";
            this.Search_Bt.Size = new System.Drawing.Size(75, 23);
            this.Search_Bt.TabIndex = 1;
            this.Search_Bt.Text = "Search";
            this.Search_Bt.UseVisualStyleBackColor = true;
            this.Search_Bt.Click += new System.EventHandler(this.Search_Bt_Click);
            // 
            // Result_lb
            // 
            this.Result_lb.FormattingEnabled = true;
            this.Result_lb.ItemHeight = 12;
            this.Result_lb.Location = new System.Drawing.Point(13, 93);
            this.Result_lb.Name = "Result_lb";
            this.Result_lb.Size = new System.Drawing.Size(222, 436);
            this.Result_lb.TabIndex = 2;
            this.Result_lb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Result_lb_MouseDoubleClick);
            this.Result_lb.SelectedIndexChanged += new System.EventHandler(this.Result_lb_SelectedIndexChanged);
            this.Result_lb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Result_lb_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Result";
            // 
            // Open_Bt
            // 
            this.Open_Bt.Location = new System.Drawing.Point(397, 42);
            this.Open_Bt.Name = "Open_Bt";
            this.Open_Bt.Size = new System.Drawing.Size(75, 45);
            this.Open_Bt.TabIndex = 4;
            this.Open_Bt.Text = "Selected PPT Open";
            this.Open_Bt.UseVisualStyleBackColor = true;
            this.Open_Bt.Click += new System.EventHandler(this.Open_Bt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "made by SCV Team";
            // 
            // preview_gB
            // 
            this.preview_gB.Controls.Add(this.Preview_tB);
            this.preview_gB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.preview_gB.Location = new System.Drawing.Point(242, 93);
            this.preview_gB.Name = "preview_gB";
            this.preview_gB.Size = new System.Drawing.Size(230, 436);
            this.preview_gB.TabIndex = 6;
            this.preview_gB.TabStop = false;
            this.preview_gB.Text = "Preview Lyric";
            // 
            // Preview_tB
            // 
            this.Preview_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Preview_tB.Enabled = false;
            this.Preview_tB.Font = new System.Drawing.Font("굴림", 9F);
            this.Preview_tB.Location = new System.Drawing.Point(7, 21);
            this.Preview_tB.Multiline = true;
            this.Preview_tB.Name = "Preview_tB";
            this.Preview_tB.Size = new System.Drawing.Size(217, 409);
            this.Preview_tB.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 562);
            this.Controls.Add(this.preview_gB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Open_Bt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result_lb);
            this.Controls.Add(this.Search_Bt);
            this.Controls.Add(this.Input_tB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HymnPPT";
            this.preview_gB.ResumeLayout(false);
            this.preview_gB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_tB;
        private System.Windows.Forms.Button Search_Bt;
        private System.Windows.Forms.ListBox Result_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Open_Bt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox preview_gB;
        private System.Windows.Forms.TextBox Preview_tB;
    }
}


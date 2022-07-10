
namespace Scheduler_TermProject_V1
{
    partial class MainForm
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fcfs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sjf = new System.Windows.Forms.Button();
            this.btn_hrn = new System.Windows.Forms.Button();
            this.btn_nonpre = new System.Windows.Forms.Button();
            this.btn_egg = new System.Windows.Forms.Button();
            this.btn_pre = new System.Windows.Forms.Button();
            this.btn_rr = new System.Windows.Forms.Button();
            this.btn_srt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("둥근모꼴", 80F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(391, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 134);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAIN";
            // 
            // btn_fcfs
            // 
            this.btn_fcfs.Font = new System.Drawing.Font("둥근모꼴", 16.2F);
            this.btn_fcfs.Location = new System.Drawing.Point(60, 298);
            this.btn_fcfs.Name = "btn_fcfs";
            this.btn_fcfs.Size = new System.Drawing.Size(233, 61);
            this.btn_fcfs.TabIndex = 1;
            this.btn_fcfs.Text = "FCFS";
            this.btn_fcfs.UseVisualStyleBackColor = true;
            this.btn_fcfs.Click += new System.EventHandler(this.btn_fcfs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("둥근모꼴", 10F);
            this.label2.Location = new System.Drawing.Point(913, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "©1999 KIMJINHO";
            // 
            // btn_sjf
            // 
            this.btn_sjf.Font = new System.Drawing.Font("둥근모꼴", 16.2F);
            this.btn_sjf.Location = new System.Drawing.Point(299, 298);
            this.btn_sjf.Name = "btn_sjf";
            this.btn_sjf.Size = new System.Drawing.Size(233, 61);
            this.btn_sjf.TabIndex = 10;
            this.btn_sjf.Text = "SJF";
            this.btn_sjf.UseVisualStyleBackColor = true;
            this.btn_sjf.Click += new System.EventHandler(this.btn_sjf_Click);
            // 
            // btn_hrn
            // 
            this.btn_hrn.Font = new System.Drawing.Font("둥근모꼴", 16.2F);
            this.btn_hrn.Location = new System.Drawing.Point(538, 298);
            this.btn_hrn.Name = "btn_hrn";
            this.btn_hrn.Size = new System.Drawing.Size(233, 61);
            this.btn_hrn.TabIndex = 11;
            this.btn_hrn.Text = "HRN";
            this.btn_hrn.UseVisualStyleBackColor = true;
            this.btn_hrn.Click += new System.EventHandler(this.btn_hrn_Click);
            // 
            // btn_nonpre
            // 
            this.btn_nonpre.Font = new System.Drawing.Font("둥근모꼴", 16.2F);
            this.btn_nonpre.Location = new System.Drawing.Point(777, 298);
            this.btn_nonpre.Name = "btn_nonpre";
            this.btn_nonpre.Size = new System.Drawing.Size(233, 61);
            this.btn_nonpre.TabIndex = 13;
            this.btn_nonpre.Text = "nonPreemptive";
            this.btn_nonpre.UseVisualStyleBackColor = true;
            this.btn_nonpre.Click += new System.EventHandler(this.btn_nonpre_Click);
            // 
            // btn_egg
            // 
            this.btn_egg.Font = new System.Drawing.Font("둥근모꼴", 16.2F);
            this.btn_egg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_egg.Location = new System.Drawing.Point(777, 379);
            this.btn_egg.Name = "btn_egg";
            this.btn_egg.Size = new System.Drawing.Size(233, 61);
            this.btn_egg.TabIndex = 17;
            this.btn_egg.Text = "🥕";
            this.btn_egg.UseVisualStyleBackColor = true;
            this.btn_egg.Click += new System.EventHandler(this.btn_egg_Click);
            // 
            // btn_pre
            // 
            this.btn_pre.Font = new System.Drawing.Font("둥근모꼴", 16.2F);
            this.btn_pre.Location = new System.Drawing.Point(538, 379);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(233, 61);
            this.btn_pre.TabIndex = 16;
            this.btn_pre.Text = "Preemptive";
            this.btn_pre.UseVisualStyleBackColor = true;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // btn_rr
            // 
            this.btn_rr.Font = new System.Drawing.Font("둥근모꼴", 16.2F);
            this.btn_rr.Location = new System.Drawing.Point(299, 379);
            this.btn_rr.Name = "btn_rr";
            this.btn_rr.Size = new System.Drawing.Size(233, 61);
            this.btn_rr.TabIndex = 15;
            this.btn_rr.Text = "RoundRobin";
            this.btn_rr.UseVisualStyleBackColor = true;
            this.btn_rr.Click += new System.EventHandler(this.btn_rr_Click);
            // 
            // btn_srt
            // 
            this.btn_srt.Font = new System.Drawing.Font("둥근모꼴", 16.2F);
            this.btn_srt.Location = new System.Drawing.Point(60, 379);
            this.btn_srt.Name = "btn_srt";
            this.btn_srt.Size = new System.Drawing.Size(233, 61);
            this.btn_srt.TabIndex = 14;
            this.btn_srt.Text = "SRT";
            this.btn_srt.UseVisualStyleBackColor = true;
            this.btn_srt.Click += new System.EventHandler(this.btn_srt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1075, 569);
            this.Controls.Add(this.btn_egg);
            this.Controls.Add(this.btn_pre);
            this.Controls.Add(this.btn_rr);
            this.Controls.Add(this.btn_srt);
            this.Controls.Add(this.btn_nonpre);
            this.Controls.Add(this.btn_hrn);
            this.Controls.Add(this.btn_sjf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_fcfs);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Scheduler_TermProject_V1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_fcfs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sjf;
        private System.Windows.Forms.Button btn_hrn;
        private System.Windows.Forms.Button btn_nonpre;
        private System.Windows.Forms.Button btn_egg;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Button btn_rr;
        private System.Windows.Forms.Button btn_srt;
    }
}


namespace TicTacTok {
	partial class frmMain {
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent() {
			this.btnLT = new System.Windows.Forms.Button();
			this.btnT = new System.Windows.Forms.Button();
			this.btnRT = new System.Windows.Forms.Button();
			this.btnR = new System.Windows.Forms.Button();
			this.btnM = new System.Windows.Forms.Button();
			this.btnL = new System.Windows.Forms.Button();
			this.btnRB = new System.Windows.Forms.Button();
			this.btnB = new System.Windows.Forms.Button();
			this.btnLB = new System.Windows.Forms.Button();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.새로운게임NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLT
			// 
			this.btnLT.BackColor = System.Drawing.Color.White;
			this.btnLT.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
			this.btnLT.Location = new System.Drawing.Point(12, 36);
			this.btnLT.Name = "btnLT";
			this.btnLT.Size = new System.Drawing.Size(100, 100);
			this.btnLT.TabIndex = 0;
			this.btnLT.TabStop = false;
			this.btnLT.UseVisualStyleBackColor = false;
			this.btnLT.Click += new System.EventHandler(this.Buttons_Clicked);
			// 
			// btnT
			// 
			this.btnT.BackColor = System.Drawing.Color.White;
			this.btnT.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
			this.btnT.Location = new System.Drawing.Point(118, 36);
			this.btnT.Name = "btnT";
			this.btnT.Size = new System.Drawing.Size(100, 100);
			this.btnT.TabIndex = 1;
			this.btnT.TabStop = false;
			this.btnT.UseVisualStyleBackColor = false;
			this.btnT.Click += new System.EventHandler(this.Buttons_Clicked);
			// 
			// btnRT
			// 
			this.btnRT.BackColor = System.Drawing.Color.White;
			this.btnRT.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
			this.btnRT.Location = new System.Drawing.Point(224, 36);
			this.btnRT.Name = "btnRT";
			this.btnRT.Size = new System.Drawing.Size(100, 100);
			this.btnRT.TabIndex = 2;
			this.btnRT.TabStop = false;
			this.btnRT.UseVisualStyleBackColor = false;
			this.btnRT.Click += new System.EventHandler(this.Buttons_Clicked);
			// 
			// btnR
			// 
			this.btnR.BackColor = System.Drawing.Color.White;
			this.btnR.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
			this.btnR.Location = new System.Drawing.Point(224, 142);
			this.btnR.Name = "btnR";
			this.btnR.Size = new System.Drawing.Size(100, 100);
			this.btnR.TabIndex = 5;
			this.btnR.TabStop = false;
			this.btnR.UseVisualStyleBackColor = false;
			this.btnR.Click += new System.EventHandler(this.Buttons_Clicked);
			// 
			// btnM
			// 
			this.btnM.BackColor = System.Drawing.Color.White;
			this.btnM.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
			this.btnM.Location = new System.Drawing.Point(118, 142);
			this.btnM.Name = "btnM";
			this.btnM.Size = new System.Drawing.Size(100, 100);
			this.btnM.TabIndex = 4;
			this.btnM.TabStop = false;
			this.btnM.UseVisualStyleBackColor = false;
			this.btnM.Click += new System.EventHandler(this.Buttons_Clicked);
			// 
			// btnL
			// 
			this.btnL.BackColor = System.Drawing.Color.White;
			this.btnL.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
			this.btnL.Location = new System.Drawing.Point(12, 142);
			this.btnL.Name = "btnL";
			this.btnL.Size = new System.Drawing.Size(100, 100);
			this.btnL.TabIndex = 3;
			this.btnL.TabStop = false;
			this.btnL.UseVisualStyleBackColor = false;
			this.btnL.Click += new System.EventHandler(this.Buttons_Clicked);
			// 
			// btnRB
			// 
			this.btnRB.BackColor = System.Drawing.Color.White;
			this.btnRB.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
			this.btnRB.Location = new System.Drawing.Point(224, 248);
			this.btnRB.Name = "btnRB";
			this.btnRB.Size = new System.Drawing.Size(100, 100);
			this.btnRB.TabIndex = 8;
			this.btnRB.TabStop = false;
			this.btnRB.UseVisualStyleBackColor = false;
			this.btnRB.Click += new System.EventHandler(this.Buttons_Clicked);
			// 
			// btnB
			// 
			this.btnB.BackColor = System.Drawing.Color.White;
			this.btnB.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
			this.btnB.Location = new System.Drawing.Point(118, 248);
			this.btnB.Name = "btnB";
			this.btnB.Size = new System.Drawing.Size(100, 100);
			this.btnB.TabIndex = 7;
			this.btnB.TabStop = false;
			this.btnB.UseVisualStyleBackColor = false;
			this.btnB.Click += new System.EventHandler(this.Buttons_Clicked);
			// 
			// btnLB
			// 
			this.btnLB.BackColor = System.Drawing.Color.White;
			this.btnLB.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
			this.btnLB.Location = new System.Drawing.Point(12, 248);
			this.btnLB.Name = "btnLB";
			this.btnLB.Size = new System.Drawing.Size(100, 100);
			this.btnLB.TabIndex = 6;
			this.btnLB.TabStop = false;
			this.btnLB.UseVisualStyleBackColor = false;
			this.btnLB.Click += new System.EventHandler(this.Buttons_Clicked);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로운게임NToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(334, 24);
			this.menuStrip.TabIndex = 9;
			this.menuStrip.Text = "menuStrip1";
			// 
			// 새로운게임NToolStripMenuItem
			// 
			this.새로운게임NToolStripMenuItem.Name = "새로운게임NToolStripMenuItem";
			this.새로운게임NToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
			this.새로운게임NToolStripMenuItem.Text = "새로운 게임 (&N)";
			this.새로운게임NToolStripMenuItem.Click += new System.EventHandler(this.새로운게임NToolStripMenuItem_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 355);
			this.Controls.Add(this.btnRB);
			this.Controls.Add(this.btnB);
			this.Controls.Add(this.btnLB);
			this.Controls.Add(this.btnR);
			this.Controls.Add(this.btnM);
			this.Controls.Add(this.btnL);
			this.Controls.Add(this.btnRT);
			this.Controls.Add(this.btnT);
			this.Controls.Add(this.btnLT);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.Text = "Tic Tac Toe";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLT;
		private System.Windows.Forms.Button btnT;
		private System.Windows.Forms.Button btnRT;
		private System.Windows.Forms.Button btnR;
		private System.Windows.Forms.Button btnM;
		private System.Windows.Forms.Button btnL;
		private System.Windows.Forms.Button btnRB;
		private System.Windows.Forms.Button btnB;
		private System.Windows.Forms.Button btnLB;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem 새로운게임NToolStripMenuItem;
	}
}


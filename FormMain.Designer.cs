﻿namespace creonPlus
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.주식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종목검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종합화면ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시세ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.체결ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.잔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주식현재가단일종목ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관심종목ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.투자주체별현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주식시간대별체결ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주식일자별주가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주식호가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelStatus = new System.Windows.Forms.Label();
            this.주식현금주문ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주식계좌별매수가능금액수량ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주식계좌별매도가능수량ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주식예약주문ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.금일계좌별주문체결내역ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.금일전일체결기준내역ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계좌별미체결잔량ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주식체결ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계좌별잔고평가현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주식결제예정예수금가계산ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.플러스접속ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.화면모두닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.주식ToolStripMenuItem,
            this.종목검색ToolStripMenuItem,
            this.종합화면ToolStripMenuItem,
            this.설정ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 주식ToolStripMenuItem
            // 
            this.주식ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시세ToolStripMenuItem,
            this.주문ToolStripMenuItem,
            this.체결ToolStripMenuItem,
            this.잔ToolStripMenuItem});
            this.주식ToolStripMenuItem.Name = "주식ToolStripMenuItem";
            this.주식ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.주식ToolStripMenuItem.Text = "[1000]주식";
            // 
            // 종목검색ToolStripMenuItem
            // 
            this.종목검색ToolStripMenuItem.Name = "종목검색ToolStripMenuItem";
            this.종목검색ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.종목검색ToolStripMenuItem.Text = "종목검색";
            // 
            // 종합화면ToolStripMenuItem
            // 
            this.종합화면ToolStripMenuItem.Name = "종합화면ToolStripMenuItem";
            this.종합화면ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.종합화면ToolStripMenuItem.Text = "종합화면";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.플러스접속ToolStripMenuItem,
            this.화면모두닫기ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 시세ToolStripMenuItem
            // 
            this.시세ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.주식현재가단일종목ToolStripMenuItem,
            this.관심종목ToolStripMenuItem,
            this.투자주체별현황ToolStripMenuItem,
            this.주식시간대별체결ToolStripMenuItem,
            this.주식일자별주가ToolStripMenuItem,
            this.주식호가ToolStripMenuItem});
            this.시세ToolStripMenuItem.Name = "시세ToolStripMenuItem";
            this.시세ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.시세ToolStripMenuItem.Text = "[1100] 시세";
            // 
            // 주문ToolStripMenuItem
            // 
            this.주문ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.주식현금주문ToolStripMenuItem,
            this.주식계좌별매수가능금액수량ToolStripMenuItem,
            this.주식계좌별매도가능수량ToolStripMenuItem,
            this.주식예약주문ToolStripMenuItem,
            this.toolStripMenuItem2});
            this.주문ToolStripMenuItem.Name = "주문ToolStripMenuItem";
            this.주문ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.주문ToolStripMenuItem.Text = "[1200] 주문";
            // 
            // 체결ToolStripMenuItem
            // 
            this.체결ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.금일계좌별주문체결내역ToolStripMenuItem,
            this.금일전일체결기준내역ToolStripMenuItem,
            this.계좌별미체결잔량ToolStripMenuItem,
            this.주식체결ToolStripMenuItem});
            this.체결ToolStripMenuItem.Name = "체결ToolStripMenuItem";
            this.체결ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.체결ToolStripMenuItem.Text = "[1300] 체결";
            // 
            // 잔ToolStripMenuItem
            // 
            this.잔ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.계좌별잔고평가현황ToolStripMenuItem,
            this.주식결제예정예수금가계산ToolStripMenuItem});
            this.잔ToolStripMenuItem.Name = "잔ToolStripMenuItem";
            this.잔ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.잔ToolStripMenuItem.Text = "[1400] 잔고";
            // 
            // 주식현재가단일종목ToolStripMenuItem
            // 
            this.주식현재가단일종목ToolStripMenuItem.Name = "주식현재가단일종목ToolStripMenuItem";
            this.주식현재가단일종목ToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.주식현재가단일종목ToolStripMenuItem.Text = "[1101]주식현재가(단일종목)";
            this.주식현재가단일종목ToolStripMenuItem.Click += new System.EventHandler(this.주식현재가단일종목ToolStripMenuItem_Click);
            // 
            // 관심종목ToolStripMenuItem
            // 
            this.관심종목ToolStripMenuItem.Name = "관심종목ToolStripMenuItem";
            this.관심종목ToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.관심종목ToolStripMenuItem.Text = "[1102] 관심종목";
            // 
            // 투자주체별현황ToolStripMenuItem
            // 
            this.투자주체별현황ToolStripMenuItem.Name = "투자주체별현황ToolStripMenuItem";
            this.투자주체별현황ToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.투자주체별현황ToolStripMenuItem.Text = "[1103] 투자주체별 현황";
            // 
            // 주식시간대별체결ToolStripMenuItem
            // 
            this.주식시간대별체결ToolStripMenuItem.Name = "주식시간대별체결ToolStripMenuItem";
            this.주식시간대별체결ToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.주식시간대별체결ToolStripMenuItem.Text = "[1104] 주식 시간대별 체결";
            // 
            // 주식일자별주가ToolStripMenuItem
            // 
            this.주식일자별주가ToolStripMenuItem.Name = "주식일자별주가ToolStripMenuItem";
            this.주식일자별주가ToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.주식일자별주가ToolStripMenuItem.Text = "[1105] 주식 일자별 주가";
            // 
            // 주식호가ToolStripMenuItem
            // 
            this.주식호가ToolStripMenuItem.Name = "주식호가ToolStripMenuItem";
            this.주식호가ToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.주식호가ToolStripMenuItem.Text = "[1106] 주식 호가";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStatus.Location = new System.Drawing.Point(507, 284);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(77, 16);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "상태 표시";
            // 
            // 주식현금주문ToolStripMenuItem
            // 
            this.주식현금주문ToolStripMenuItem.Name = "주식현금주문ToolStripMenuItem";
            this.주식현금주문ToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.주식현금주문ToolStripMenuItem.Text = "[1201] 주식 현금주문";
            // 
            // 주식계좌별매수가능금액수량ToolStripMenuItem
            // 
            this.주식계좌별매수가능금액수량ToolStripMenuItem.Name = "주식계좌별매수가능금액수량ToolStripMenuItem";
            this.주식계좌별매수가능금액수량ToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.주식계좌별매수가능금액수량ToolStripMenuItem.Text = "[1202] 주식 계좌별 매수 가능금액/수량";
            // 
            // 주식계좌별매도가능수량ToolStripMenuItem
            // 
            this.주식계좌별매도가능수량ToolStripMenuItem.Name = "주식계좌별매도가능수량ToolStripMenuItem";
            this.주식계좌별매도가능수량ToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.주식계좌별매도가능수량ToolStripMenuItem.Text = "[1203] 주식 계좌별 매도 가능수량";
            // 
            // 주식예약주문ToolStripMenuItem
            // 
            this.주식예약주문ToolStripMenuItem.Name = "주식예약주문ToolStripMenuItem";
            this.주식예약주문ToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.주식예약주문ToolStripMenuItem.Text = "[1204] 주식 예약주문";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(287, 22);
            this.toolStripMenuItem2.Text = "[1205] 주식 예약주문 현황";
            // 
            // 금일계좌별주문체결내역ToolStripMenuItem
            // 
            this.금일계좌별주문체결내역ToolStripMenuItem.Name = "금일계좌별주문체결내역ToolStripMenuItem";
            this.금일계좌별주문체결내역ToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.금일계좌별주문체결내역ToolStripMenuItem.Text = "[1301] 금일 계좌별 주문체결 내역";
            // 
            // 금일전일체결기준내역ToolStripMenuItem
            // 
            this.금일전일체결기준내역ToolStripMenuItem.Name = "금일전일체결기준내역ToolStripMenuItem";
            this.금일전일체결기준내역ToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.금일전일체결기준내역ToolStripMenuItem.Text = "[1302] 금일/전일 체결기준 내역";
            // 
            // 계좌별미체결잔량ToolStripMenuItem
            // 
            this.계좌별미체결잔량ToolStripMenuItem.Name = "계좌별미체결잔량ToolStripMenuItem";
            this.계좌별미체결잔량ToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.계좌별미체결잔량ToolStripMenuItem.Text = "[1303] 계좌별 미체결잔량";
            // 
            // 주식체결ToolStripMenuItem
            // 
            this.주식체결ToolStripMenuItem.Name = "주식체결ToolStripMenuItem";
            this.주식체결ToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.주식체결ToolStripMenuItem.Text = "[1304] 주식 체결 실시간";
            // 
            // 계좌별잔고평가현황ToolStripMenuItem
            // 
            this.계좌별잔고평가현황ToolStripMenuItem.Name = "계좌별잔고평가현황ToolStripMenuItem";
            this.계좌별잔고평가현황ToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.계좌별잔고평가현황ToolStripMenuItem.Text = "[1401] 계좌별 잔고 평가현황";
            // 
            // 주식결제예정예수금가계산ToolStripMenuItem
            // 
            this.주식결제예정예수금가계산ToolStripMenuItem.Name = "주식결제예정예수금가계산ToolStripMenuItem";
            this.주식결제예정예수금가계산ToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.주식결제예정예수금가계산ToolStripMenuItem.Text = "[1402] 주식 결제예정예수금 가계산";
            // 
            // 플러스접속ToolStripMenuItem
            // 
            this.플러스접속ToolStripMenuItem.Name = "플러스접속ToolStripMenuItem";
            this.플러스접속ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.플러스접속ToolStripMenuItem.Text = "플러스 접속";
            this.플러스접속ToolStripMenuItem.Click += new System.EventHandler(this.플러스접속ToolStripMenuItem_Click);
            // 
            // 화면모두닫기ToolStripMenuItem
            // 
            this.화면모두닫기ToolStripMenuItem.Name = "화면모두닫기ToolStripMenuItem";
            this.화면모두닫기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.화면모두닫기ToolStripMenuItem.Text = "화면 모두닫기";
            this.화면모두닫기ToolStripMenuItem.Click += new System.EventHandler(this.화면모두닫기ToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 713);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "CreonPlusForm";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 주식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시세ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주식현재가단일종목ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 관심종목ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 투자주체별현황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주식시간대별체결ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주식일자별주가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주식호가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 체결ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종목검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종합화면ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ToolStripMenuItem 주식현금주문ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주식계좌별매수가능금액수량ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주식계좌별매도가능수량ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주식예약주문ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 금일계좌별주문체결내역ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 금일전일체결기준내역ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계좌별미체결잔량ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주식체결ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계좌별잔고평가현황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주식결제예정예수금가계산ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 플러스접속ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 화면모두닫기ToolStripMenuItem;
    }
}


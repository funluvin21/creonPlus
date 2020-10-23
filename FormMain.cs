using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using CPUTILLib;
using CPTRADELib;
using creonPlus.Common;
using creonPlus._1000_주식.주식_공통;
using creonPlus._1000_주식._1100_시세;

namespace creonPlus
{
    public partial class FormMain : Form
    {
        private CPUTILLib.CpStockCode _CpStockCode;
        private CPUTILLib.CpCodeMgr _CpCodeMgr;
        private CPUTILLib.CpCybos _CpCybos;
        private CPTRADELib.CpTdUtil _CpTdUtil;
        private DSCBO1Lib.CpConclusion _CpConclusion;

        private System.Timers.Timer _timerConnection;
        private int _timerCount;

        public DataTable _stockTable;
        private FormStockCodes _formStockCodes;


        private Form1101 _form1101;
        //private FormStockCodes _formStockCodes;

        public string stockCode;
        public string stockName;

        private bool _checkedTradeInit;

        public DataTable _stockTradeTable;

        public string accountNo;
        public string accountGoodsStock;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _CpStockCode = new CPUTILLib.CpStockCode();
            _CpCodeMgr = new CPUTILLib.CpCodeMgr();
            _CpTdUtil = new CPTRADELib.CpTdUtil();
            _CpConclusion = new DSCBO1Lib.CpConclusion();
            _CpConclusion.Received += new DSCBO1Lib._IDibEvents_ReceivedEventHandler(CpConclusion_Received);//_CpConclusion_Received;

            _CpCybos = new CPUTILLib.CpCybos();
            _CpCybos.OnDisconnect += _CpCybos_OnDisconnect;

            _stockTable = new DataTable();

            _checkedTradeInit = false;

            stockCode = "A003540";
            stockName = "대신증권";

            labelStatus.Visible = false;

            _stockTradeTable = new DataTable();

            accountNo = "";
            accountGoodsStock = "";
        }

        private void _CpCybos_OnDisconnect()
        {
            _CpCybos = null;

            menuStrip1.BackColor = Color.FromArgb(255, 230, 230);

            this.Text = "대신증권 플러스 Sample for C# (연결 안됨)";

            MessageBox.Show("대신증권 플러스 연결이 종료되었습니다.");
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            ChangeMainTitleConnection();
        }

        private void 플러스접속ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CpCybos = null;
            _CpCybos = new CPUTILLib.CpCybos();

            if (_CpCybos.IsConnect == 1)
            {
                MessageBox.Show("대신증권 플러스에 이미 연결된 상태입니다.");
                return;
            };

            if (_timerConnection != null)
            {
                _timerConnection.Stop();
                _timerConnection.Dispose();
                _timerConnection = null;
            }

            _timerCount = 0;

            ChangeMainTitleConnection();
        }

        private void CpCybos_OnDisconnect()
        {
            _CpCybos = null;

            menuStrip1.BackColor = Color.FromArgb(255, 230, 230);

            this.Text = "대신증권 플러스 Sample for C# (연결 안됨)";

            MessageBox.Show("대신증권 플러스 연결이 종료되었습니다.");
        }

        private void ChangeMainTitleConnection()
        {
            _CpCybos = null;
            _CpCybos = new CPUTILLib.CpCybos();

            if (_CpCybos.IsConnect == 1)
            {
                if (_timerConnection != null)
                {
                    _timerConnection.Stop();
                    _timerConnection.Dispose();
                    _timerConnection = null;
                }

                _timerCount = 0;

                menuStrip1.BackColor = Color.FromArgb(228, 254, 226);
                Invoke(new MethodInvoker(ConnectionCompleted));
                MessageBox.Show("대신증권 플러스에 연결되었습니다.");

                LoadStockCodes();
            }
            else
            {
                this.Text = "대신증권 플러스 Sample for C# (연결 안됨)";

                if (_timerCount == 0)
                {
                    DialogConnection dialog = new DialogConnection();
                    dialog.SetParent(this);
                    dialog.ShowDialog(this);
                }

            }
        }

        public void RequestConnection()
        {
            _timerConnection = new System.Timers.Timer();
            _timerConnection.Interval = 1000;
            _timerConnection.Elapsed += new ElapsedEventHandler(_timerConnection_Elapsed);
            _timerConnection.Start();
            _timerCount = 0;
        }

        private void _timerConnection_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_timerCount > 180)
            {
                _timerConnection.Stop();
                _timerConnection.Dispose();
                _timerConnection = null;
                _timerCount = 0;
            }

            _timerCount += 1;

            ChangeMainTitleConnection();
        }

        public void ConnectionCompleted()
        {
            this.Text = "대신증권 플러스 Sample for C# (연결 완료)";
        }

        private void LoadStockCodes()
        {
            SetStatus("주식 종목정보 수신중...");

            _stockTable.Columns.Clear();
            _stockTable.Columns.Add("순번");
            _stockTable.Columns.Add("종목코드");
            _stockTable.Columns.Add("종목명");

            _stockTable.Clear();

            for (short i = 0; i < _CpStockCode.GetCount(); i++)
                _stockTable.Rows.Add((i + 1).ToString(), _CpStockCode.GetData(0, i).ToString(), _CpStockCode.GetData(1, i).ToString());

            SetStatus("");
        }

        public void CloseStockSelector(object sender)
        {
            if (_formStockCodes != null && _formStockCodes.Visible == true)
                _formStockCodes.Visible = false;
        }






        private void SetStatus(string status)
        {
            if (status != "")
            {
                labelStatus.Visible = true;
                labelStatus.Text = status;
                labelStatus.Location = new Point((this.Size.Width - labelStatus.Size.Width) / 2, (this.Size.Height - labelStatus.Size.Height) / 2 - 50);
                this.Refresh();
            }
            else
            {
                labelStatus.Visible = false;
            }
        }




        private void 화면모두닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
                childForm.Close();
        }

        public void ChangedStockCode(string code, string name)
        {
            stockCode = code;
            stockName = name;

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.Text.Length >= 5)
                {
                    string title = childForm.Text.Substring(1, 4);
                    if (title == "1101" || title == "1102" || title == "1103" || title == "1104" || title == "1105" || title == "1106" || title == "1201" || title == "1202" || title == "1203" || title == "1204" || title == "1301" || title == "1302" || title == "1303")
                        ((FormRoot)childForm).ChangedStockCode(code, name);
                }
            }
        }

        private void CpConclusion_Received()
        {
            DataRow row = _stockTradeTable.NewRow();

            row["계좌명"] = _CpConclusion.GetHeaderValue(1);
            row["계좌번호"] = _CpConclusion.GetHeaderValue(7);
            row["계좌상품"] = _CpConclusion.GetHeaderValue(8);
            row["종목명"] = _CpConclusion.GetHeaderValue(2);
            row["종목코드"] = _CpConclusion.GetHeaderValue(9);
            row["주문번호"] = _CpConclusion.GetHeaderValue(5);
            row["원주문번호"] = _CpConclusion.GetHeaderValue(6);
            row["체결가격"] = _CpConclusion.GetHeaderValue(4);
            row["체결수량"] = _CpConclusion.GetHeaderValue(3);

            if (_CpConclusion.GetHeaderValue(12).ToString() == "1")
                row["매매"] = "매도";
            else
                row["매매"] = "매수";

            if (_CpConclusion.GetHeaderValue(14).ToString() == "1")
                row["실시간"] = "체결";
            else if (_CpConclusion.GetHeaderValue(14).ToString() == "2")
                row["실시간"] = "확인";
            else if (_CpConclusion.GetHeaderValue(14).ToString() == "3")
                row["실시간"] = "거부";
            else if (_CpConclusion.GetHeaderValue(14).ToString() == "4")
                row["실시간"] = "접수";

            if (_CpConclusion.GetHeaderValue(16).ToString() == "1")
                row["정정취소"] = "정상";
            else if (_CpConclusion.GetHeaderValue(16).ToString() == "2")
                row["정정취소"] = "정정";
            else if (_CpConclusion.GetHeaderValue(16).ToString() == "3")
                row["정정취소"] = "취소";

            if (_CpConclusion.GetHeaderValue(18).ToString() == "01")
                row["주문구분"] = "보통";
            else if (_CpConclusion.GetHeaderValue(18).ToString() == "03")
                row["주문구분"] = "시장가";
            else if (_CpConclusion.GetHeaderValue(18).ToString() == "05")
                row["주문구분"] = "조건부지정가";
            else if (_CpConclusion.GetHeaderValue(18).ToString() == "12")
                row["주문구분"] = "최유리지정가";
            else if (_CpConclusion.GetHeaderValue(18).ToString() == "13")
                row["주문구분"] = "최우선지정가";

            if (_CpConclusion.GetHeaderValue(19).ToString() == "0")
                row["주문조건"] = "없음";
            else if (_CpConclusion.GetHeaderValue(19).ToString() == "1")
                row["주문조건"] = "IOC";
            else if (_CpConclusion.GetHeaderValue(19).ToString() == "2")
                row["주문조건"] = "FOK";

            row["장부가"] = _CpConclusion.GetHeaderValue(21).ToString();
            row["체결기준잔고수량"] = _CpConclusion.GetHeaderValue(23).ToString();

            _stockTradeTable.Rows.InsertAt(row, 0);

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.Text.Length >= 5)
                {
                    string title = childForm.Text.Substring(1, 4);
                    if (title == "1301" || title == "1302" || title == "1303" || title == "1304" || title == "1401" || title == "1402")
                        ((FormTrade)childForm).ReceivedStockTrade();
                }
            }
        }

        private void 주식현재가단일종목ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }





    }
}

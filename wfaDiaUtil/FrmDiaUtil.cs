using System;
using System.Windows.Forms;

namespace wfaDiaUtil
{
    public partial class FrmDiaUtil : Form
    {
        public FrmDiaUtil()
        {
            InitializeComponent();
        }

        private void FrmDiaUtil_Load(object sender, EventArgs e)
        {
            McaData.TodayDate = DateTime.Now;
            //Funciona também:
            //McaData.SelectionStart = Convert.ToDateTime("2020/01/06 12:00");
            McaData.SelectionStart = new DateTime(2020, 1, 6, 12, 0, 0);
        }

        private void BtnCalcula_Click(object sender, EventArgs e)
        {
            double DblDiasUteis = Convert.ToDouble(NudDiasPrazo.Value);

            DtpDataChapada.Value = McaData.SelectionStart.AddDays(DblDiasUteis);
            DblDiasUteis = ClsDiaUtil.NumeroDiasUteis(DblDiasUteis, McaData.SelectionStart, RbtSoma.Checked);
            DtpDataFutura.Value = McaData.SelectionStart.AddDays(DblDiasUteis);
            LblResposta.Text = DblDiasUteis.ToString();
        }

        private void BtnCalculaAmanha_Click(object sender, EventArgs e)
        {
            double DblDiasUteis = 1;
            NudDiasPrazo.Value = Convert.ToDecimal(DblDiasUteis);
            McaData.SelectionStart = DateTime.Now;

            DtpDataChapada.Value = McaData.SelectionStart.AddDays(DblDiasUteis);
            DblDiasUteis = ClsDiaUtil.NumeroDiasUteis(DblDiasUteis, null);
            DtpDataFutura.Value = McaData.SelectionStart.AddDays(DblDiasUteis);
            LblResposta.Text = DblDiasUteis.ToString();
        }
    }
}

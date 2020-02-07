using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace SeisanKanri
{

    public partial class FormBuhinHattyu : Form
    {
        //SQLサーバー接続文字
        private string constr = @Properties.Settings.Default.ConnectStr;

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        private string acName = ""; //アクティブなコントロールの名前を入れる
                                    //明細カラム設定
        const int intMSeihinCode = 0;
        const int intMSeihinMei = 1;
        const int intMSuryo = 2;
        const int intMNouki = 3;
        const int intMTekiyo = 4;

        public FormBuhinHattyu()
        {
            InitializeComponent();
        }

        private void FormBuhinHattyu_Load(object sender, EventArgs e)
        {
            dt.TableName = "発注明細";

            dt.Columns.Add("製品コード");
            dt.Columns.Add("製品名");
            dt.Columns.Add("数量", Type.GetType("System.Decimal"));
            dt.Columns.Add("納期", Type.GetType("System.DateTime"));
            dt.Columns.Add("摘要");

            ds.Tables.Add(dt);

            dataGridViewMeisai.AutoGenerateColumns = false;
            dataGridViewMeisai.DataSource = ds.Tables["発注明細"];

            Program.CalendarColumn col5 = new Program.CalendarColumn();
            col5.DataPropertyName = "納期";
            col5.Name = "納期";
            //col5.HeaderText = "　　納　　期　　";
            dataGridViewMeisai.Columns.Remove("納期");
            dataGridViewMeisai.Columns.Insert(intMNouki, col5);
            dataGridViewMeisai.Columns[intMNouki].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewMeisai.Columns[intMNouki].Width = 125;
            labelID.Text = "";
            labelJutyuNo.Text = "";

            //データグリッドビューの設定
            //dataGridViewMeisai.Columns["製品コード"].Width = 100;
            //dataGridViewMeisai.Columns["製品名"].Width = 200;
            //dataGridViewMeisai.Columns["数量"].Width = 100;
            //dataGridViewMeisai.Columns["数量"].DefaultCellStyle.Format = "#.0.#";
            //dataGridViewMeisai.Columns["納期"].Width = 300;

            this.ActiveControl = this.textBoxTanto;
        }


        //選択レコード画面表示
        private void RecordDisp(string sqlstr)
        {
            //SQL文が空白なら処理しない
            if (sqlstr != "")
            {
                //サーバー接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {

                    //SQL文で検索
                    SqlCommand com = new SqlCommand(sqlstr, con);
                    SqlDataReader sdr = com.ExecuteReader();

                    //見つかった場合のみ処理を行う
                    if (sdr.Read() == true)
                    {
                        int jutyuNo = (int)sdr["発注番号"];
                        string ID = sdr["id"].ToString();
                        DateTime jutyuBi = Convert.ToDateTime(sdr["発注日付"]);
                        int nenkanNo = (int)sdr["年間番号"];
                        string tanto = (string)sdr["発注者"];

                        labelJutyuNo.Text = jutyuNo.ToString();
                        textBoxJutyuNo.Text = nenkanNo.ToString();
                        dateTimePickerJutyu.Value = jutyuBi;
                        textBoxTanto.Text = tanto;
                        labelID.Text = ID;

                        sdr.Close();

                        //データテーブル初期化
                        ds.Tables["発注明細"].Rows.Clear();

                        //テーブルへ行を追加

                        string meiSql = "SELECT * FROM 発注明細 WHERE 発注番号 = " + jutyuNo.ToString() + " ORDER BY 行番号";
                        SqlCommand comMei = new SqlCommand(meiSql, con);
                        SqlDataReader sdrMei = comMei.ExecuteReader();

                        while (sdrMei.Read())
                        {
                            DataRow row = ds.Tables["発注明細"].NewRow();

                            row["製品コード"] = (string)sdrMei["製品コード"];
                            row["製品名"] = (string)sdrMei["製品名"];
                            row["数量"] = (decimal)sdrMei["数量"];
                            row["納期"] = Convert.ToDateTime(sdrMei["納期"]);
                            row["摘要"] = (string)sdrMei["摘要"];

                            ds.Tables["発注明細"].Rows.Add(row);
                        }

                        sdrMei.Close();

                        //dataGridViewMeisai.DataSource = ds.Tables["受注明細"];
                    }

                }
                finally
                {
                    //サーバー切断
                    con.Close();
                }

            }
        }

        private string AddFieldValueString(DataRow row, string fieldName)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (string)row[fieldName];
            else
                return String.Empty;
        }

        private bool AddFieldValueBool(DataRow row, string fieldName)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (bool)row[fieldName];
            else
                return false;
        }

        private decimal AddFieldValueDecimal(DataRow row, string fieldName)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (decimal)row[fieldName];
            else
                return 0;
        }

        private DateTime AddFieldValueDateTime(DataRow row, string fieldName, DateTime defaultDate)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (DateTime)row[fieldName];
            else
                return defaultDate;
        }


        // 表示ボタン
        private void buttonView_Click(object sender, EventArgs e)
        {
            if (textBoxJutyuNo.Text.Trim() != "")
            {
                int NoInt = int.Parse(textBoxJutyuNo.Text.Trim());
                string YearStr = dateTimePickerJutyu.Value.Year.ToString();
                string jtyNoStr = string.Format("{0}{1:00000}", YearStr, NoInt);
                string sqlStr = "SELECT * FROM 発注 WHERE 発注番号 = " + jtyNoStr;
                RecordDisp(sqlStr);
            }
        }

        //フォームロード
        private void FormJutyu_Load(object sender, EventArgs e)
        {


        }

        private void dataGridViewMeisai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //bool tfl;

            //tfl = AddFieldValueBool(ds.Tables["受注明細"].Rows[0], "特注FL");

            //MessageBox.Show(tfl ? "true" : "false");

            //三項演算子
        }

        //保存ボタン
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //年度
            string yrStr = dateTimePickerJutyu.Value.Year.ToString();

            //保存前チェック
            string errMsgStr = "";
            //メッセージ用変数を初期化
            string msgstr = "";
            //保存クエリー用の変数
            string saveSqlStr = "";
            string noSaveSqlStr = "";  //番号保存用

            bool newFL = true;
            string editNo = "";

            //サーバー接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                //labelJutyuNoが空白なら新規、そうでなければその番号で更新
                if (labelJutyuNo.Text != "")
                {
                    //更新
                    newFL = false;
                    editNo = labelJutyuNo.Text;

                    saveSqlStr = "UPDATE 発注 " +
                        "SET" +
                        " 発注日付 = '" + dateTimePickerJutyu.Value + "' ," +
                        " 発注者 = '" + textBoxTanto.Text.Trim() + "' " +
                        " where 発注番号  = " + editNo;
                }
                else
                {
                    //新規
                    newFL = true;
                    //新しい番号を取得
                    int newNoInt = 1;
                    //年度で番号を検索
                    string sqlstr = "select * from 発注番号 where 年度 = " + yrStr;
                    SqlCommand comNo = new SqlCommand(sqlstr, con);
                    SqlDataReader sdrNo = comNo.ExecuteReader();
                    if (sdrNo.Read() == true)
                    {
                        newNoInt = (int)sdrNo["番号"] + 1;

                        //年度が見つかった場合
                        //更新
                        noSaveSqlStr = "UPDATE 発注番号 SET 番号 = " + newNoInt.ToString() + " where 年度  = " + yrStr;
                    }
                    else
                    {
                        //新規
                        noSaveSqlStr = "INSERT INTO 発注番号 (年度, 番号) VALUES (" + yrStr + ", 1)";
                    }

                    //検索結果を破棄
                    sdrNo.Close();

                    //クエリー実行　新しい番号を保存
                    SqlCommand comNoSave = new SqlCommand(noSaveSqlStr, con);
                    comNoSave.ExecuteNonQuery();

                    editNo = string.Format("{0}{1:00000}", yrStr, newNoInt);
                    labelJutyuNo.Text = editNo;
                    textBoxJutyuNo.Text = newNoInt.ToString();

                    //発注データ　新規登録
                    saveSqlStr = "INSERT INTO 発注 (" +
                            "発注番号, 発注日付, 年間番号, 発注者" +
                            ") VALUES (" +
                            editNo + ",'" +
                            dateTimePickerJutyu.Value + "', " +
                            newNoInt.ToString() + ", N'" +
                            textBoxTanto.Text + "')";
                }


                //クエリー実行
                SqlCommand saveCom = new SqlCommand(saveSqlStr, con);
                saveCom.ExecuteNonQuery();
                msgstr = "保存しました";


                //
                //明細保存

                //明細データの件数を取得 A (新規の場合は0にしておく)
                int meiRowCnt;
                if (newFL)
                {
                    //新規
                    meiRowCnt = 0;
                }
                else
                {
                    //明細数を取得
                    string meiCntSql = "SELECT COUNT(id) as 明細数 FROM 発注明細 WHERE 発注番号 = " + editNo;
                    SqlCommand comMeiCnt = new SqlCommand(meiCntSql, con);
                    meiRowCnt = (int)comMeiCnt.ExecuteScalar();
                }

                //データセットの行数を取得 B
                int dgvCnt = 0;
                dgvCnt = dataGridViewMeisai.BindingContext[dataGridViewMeisai.DataSource, dataGridViewMeisai.DataMember].Count;

                // A か Bの小さい方の回数でループしてUPDATE文を作成(同じ場合はAとする）
                int loopCnt = 0;
                if (meiRowCnt <= dgvCnt)
                {
                    //明細データ件数がデータセットの行数よりも少ない場合
                    loopCnt = meiRowCnt;
                }
                else
                {
                    //明細データ件数がデータセットの行数よりも多い場合
                    loopCnt = dgvCnt;
                }



                DataTable dtm = ds.Tables["発注明細"];
                DataRowCollection mrows = dtm.Rows;

                using (var transaction = con.BeginTransaction())
                using (var mcom = new SqlCommand() { Connection = con, Transaction = transaction })
                {
                    try
                    {
                        //親テーブル準備
                        //SQL実行


                        //子テーブル準備
                        //string seihinCode;
                        //string seihinMei;
                        //decimal suryo;
                        //decimal tanka;
                        //decimal kingaku;
                        DateTime nouki;
                        DateTime yotei;
                        //bool tokuFL;
                        //bool sisakuFL;
                        //string tekiyo;


                        //既存データに上書き
                        int i = 0;
                        int rowNo = 0;
                        while (i < loopCnt)
                        {
                            rowNo = i + 1;
                            nouki = AddFieldValueDateTime(mrows[i], "納期", System.DateTime.Today);
                            mcom.CommandText = "UPDATE 発注明細 SET " +
                                "製品コード = '" + AddFieldValueString(mrows[i], "製品コード") + "', " +
                                "製品名 = N'" + AddFieldValueString(mrows[i], "製品名") + "', " +
                                "数量 = " + AddFieldValueDecimal(mrows[i], "数量").ToString() + ", " +
                                "納期 = '" + nouki + "', " +
                                "摘要 = N'" + AddFieldValueString(mrows[i], "摘要") + "' " +
                                "WHERE 発注番号 = " + editNo + " AND 行番号 = " + rowNo.ToString();
                            mcom.ExecuteNonQuery();
                            i++;
                        }

                        if (meiRowCnt > dgvCnt)
                        {
                            //既存データ > グリッド行数
                            //データ削除
                            mcom.CommandText = "DELETE FROM 発注明細 WHERE 発注番号 = " + editNo + " 行番号 > " + dgvCnt.ToString();

                            mcom.ExecuteNonQuery();
                        }
                        else
                        {
                            //既存データ < グリッド行数
                            //データ追加
                            i = meiRowCnt;
                            loopCnt = dgvCnt;
                            while (i < loopCnt)
                            {
                                rowNo = i + 1;
                                nouki = AddFieldValueDateTime(mrows[i], "納期", System.DateTime.Today);

                                mcom.CommandText = "INSERT INTO 発注明細 (" +
                                    "発注番号,行番号,製品コード, 製品名, 数量, 納期, 摘要)" +
                                    " VALUES (" +
                                    editNo + ", " +
                                    rowNo.ToString() + ", " +
                                    "'" + AddFieldValueString(mrows[i], "製品コード") + "', " +
                                    "N'" + AddFieldValueString(mrows[i], "製品名") + "', " +
                                    AddFieldValueDecimal(mrows[i], "数量").ToString() + ", " +
                                    "'" + nouki + "', " +
                                    "N'" + AddFieldValueString(mrows[i], "摘要") + "')";
                                mcom.ExecuteNonQuery();
                                i++;
                            }

                        }

                        transaction.Commit();

                    }
                    catch (Exception exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show(exception.Message);
                    }
                }

            }
            catch (Exception)
            {
                //書き込み失敗
                msgstr = "書き込み失敗";
            }
            finally
            {
                //サーバー切断
                con.Close();
            }
            //レコードを表示
            //RecordDisp(textBoxSeihinCode.Text.Trim());
            //結果をメッセージボックスで表示
            MessageBox.Show(msgstr, "発注");


        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonReference_Click(object sender, EventArgs e)
        {
            string dlg = "";
            int colNo = -1;
            int rowNo = -1;
            switch (acName)
            {
                case "発注番号":
                    dlg = acName;
                    break;
                case "明細":
                    rowNo = dataGridViewMeisai.CurrentCellAddress.Y;
                    colNo = dataGridViewMeisai.CurrentCellAddress.X;
                    if (rowNo == -1) break;
                    switch (colNo)
                    {
                        case intMSeihinCode:     //製品コード
                            dlg = "製品コード";
                            break;
                        case intMNouki:     //納期
                            dlg = "納期";
                            break;
                        default:
                            dlg = "";
                            break;
                    }
                    break;
                default:
                    dlg = "";
                    break;
            }

            DialogResult drRet;
            switch (dlg)
            {

                case "製品コード":
                    FormInSeihin frmInSeihin = new FormInSeihin();
                    drRet = frmInSeihin.ShowDialog();
                    if (drRet == DialogResult.OK)
                    {
                        //リストから選択されていなければなにもしない
                        if (frmInSeihin.listBoxSeihin.SelectedIndex == -1) break;
                        //リストの選択されているところから製品コードを抽出
                        string listStr = frmInSeihin.listBoxSeihin.SelectedItem.ToString();
                        string codeStr = listStr.Substring(0, 13).Trim();

                        //サーバーに接続
                        SqlConnection con = new SqlConnection(constr);
                        con.Open();
                        try
                        {
                            //接続成功
                            //レコードをコードで検索
                            string sqlstr = "SELECT * FROM 製品マスタ WHERE 製品コード = '" + codeStr + "'";
                            SqlCommand com = new SqlCommand(sqlstr, con);
                            SqlDataReader sdr = com.ExecuteReader();

                            //リスト表示
                            if (sdr.Read() == true)
                            {
                                ds.Tables["発注明細"].Rows[rowNo]["製品コード"] = (string)sdr["製品コード"];
                                ds.Tables["発注明細"].Rows[rowNo]["製品名"] = (string)sdr["製品名"];

                            }

                        }
                        finally
                        {
                            //サーバー切断
                            con.Close();
                        }
                    }
                    break;

                case "納期":
                    FormInDate frmInDate = new FormInDate();
                    drRet = frmInDate.ShowDialog();
                    if (drRet == DialogResult.OK)
                    {
                        ds.Tables["発注明細"].Rows[rowNo][colNo] = frmInDate.monthCalendar.SelectionRange.Start;
                    }
                    break;

            }

        }

        private void textBoxJutyuNo_Enter(object sender, EventArgs e)
        {
            acName = "発注番号";
        }

        private void dateTimePickerJutyu_Enter(object sender, EventArgs e)
        {
            acName = "発注日付";
        }

        private void dataGridViewMeisai_Enter(object sender, EventArgs e)
        {
            acName = "明細";

        }

        private void buttonAddMeisai_Click(object sender, EventArgs e)
        {
            //明細行追加ボタン
            ds.Tables["発注明細"].Rows.Add(ds.Tables["発注明細"].NewRow());

            int rowNo = ds.Tables["発注明細"].Rows.Count - 1;
            dataGridViewMeisai.CurrentCell = dataGridViewMeisai["製品コード", rowNo];
            dataGridViewMeisai.Focus();


        }

        private void dataGridViewMeisai_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridViewMeisai_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewMeisai_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


            switch (e.ColumnIndex)
            {
                case intMSeihinCode:

                    if (!DBNull.Value.Equals(ds.Tables["発注明細"].Rows[e.RowIndex]["製品コード"]))
                    {
                        //リストの選択されているところから製品コードを抽出
                        string codeStr = (string)ds.Tables["発注明細"].Rows[e.RowIndex]["製品コード"];

                        //サーバーに接続
                        SqlConnection con = new SqlConnection(constr);
                        con.Open();
                        try
                        {
                            //接続成功
                            //レコードをコードで検索
                            string sqlstr = "SELECT * FROM 製品マスタ WHERE 製品コード = '" + codeStr + "'";
                            SqlCommand com = new SqlCommand(sqlstr, con);
                            SqlDataReader sdr = com.ExecuteReader();

                            //リスト表示
                            if (sdr.Read() == true)
                            {
                                if (AddFieldValueString(ds.Tables["発注明細"].Rows[e.RowIndex], "製品名") == "")
                                {
                                    ds.Tables["発注明細"].Rows[e.RowIndex]["製品名"] = (string)sdr["製品名"];
                                }
                            }
                            else
                            {
                                //コードに該当する製品がなければなにもしない
                                break;
                            }
                        }
                        finally
                        {
                            //サーバー切断
                            con.Close();
                        }
                    }
                    break;

            }
        }

        private void buttonDeleteMeisai_Click(object sender, EventArgs e)
        {
            DataTable ddt = ds.Tables["発注明細"];
            //現在のアクティブな行を取得 0～
            int rowNo = dataGridViewMeisai.CurrentCellAddress.Y;

            //選択されていなければなにもしない
            if (rowNo == -1) return;

            if (MessageBox.Show((string)ddt.Rows[rowNo]["製品コード"] + " : " +
                                        (string)ddt.Rows[rowNo]["製品名"] + " を削除します。\r\n" +
                                        "よろしいですか？",
                                        "受注入力",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                ddt.Rows.Remove(dt.Rows[rowNo]);
            }
        }

        private void buttonMeisaiSounyu_Click(object sender, EventArgs e)
        {
            DataRow drIns = dt.NewRow();
            //現在のアクティブな行を取得 0～
            int rowNo = dataGridViewMeisai.CurrentCellAddress.Y;

            //選択されていなければなにもしない
            if (rowNo == -1) return;

            ds.Tables["発注明細"].Rows.InsertAt(drIns, rowNo);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {

        }

        private void FormBuhinHattyu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                // このフォームで現在アクティブなコントロールを取得する
                //Control cControl = this.ActiveControl;

                // 取得できた場合のみ、そのコントロールの名前を表示する
                //if (cControl != null)
                //{
                //    MessageBox.Show(cControl.Name);
                //}
                buttonReference.PerformClick();

            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (labelJutyuNo.Text == "") return;

            using (SqlConnection con = new SqlConnection(constr))
            {
                DatasetJutyu dsm = new DatasetJutyu();

                string tkgName = Properties.Settings.Default.TkgName;
                string tkgAddress = Properties.Settings.Default.TkgAddress;
                string tkgTelFax = Properties.Settings.Default.TkgTelFax;
                string tkgEmail = Properties.Settings.Default.TkgEmail;
                string ooinoName = Properties.Settings.Default.OoinoName;

                con.Open();
                SqlCommand com = con.CreateCommand();
                string sql = "SELECT 発注明細.Id, 発注明細.発注番号, 発注明細.行番号, 発注明細.製品コード, 発注明細.製品名, 発注明細.数量, " +
                                      "発注明細.納期, 発注明細.摘要, 発注.発注日付, 発注.発注者 " +
                                      "FROM 発注明細 INNER JOIN " +
                                      "発注 ON 発注明細.発注番号 = 発注.発注番号 " +
                                      "WHERE 発注明細.発注番号 = '" + labelJutyuNo.Text + "' " +
                                      "ORDER BY 発注明細.行番号";


                //データセット作成
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsm.発注書);

                FormReportViewer frmRptViewer = new FormReportViewer();

                frmRptViewer.Text = "発注書　印刷";
                //レポートセッティング
                frmRptViewer.reportViewer1.Reset();
                frmRptViewer.reportViewer1.ProcessingMode = ProcessingMode.Local;
                //frmRptViewer.reportViewer1.LocalReport.ReportPath = @"C: \Users\yoshi\source\repos\TakagiMokkou\SeisanKanri" + @"\ReportHattyuOoino.rdlc";
                frmRptViewer.reportViewer1.LocalReport.ReportPath = @Properties.Settings.Default.ProFName + @"\ReportHattyuOoino.rdlc";
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = dsm.発注書;
                //ReportViewerに表示
                frmRptViewer.reportViewer1.LocalReport.DataSources.Add(rds);

                ReportParameter paramName = new ReportParameter("rpName", tkgName);
                ReportParameter paramAddress = new ReportParameter("rpAddress", tkgAddress);
                ReportParameter paramTelFax = new ReportParameter("rpTelFax", tkgTelFax);
                ReportParameter paramEmail = new ReportParameter("rpEmail", tkgEmail);
                ReportParameter paramOoinoName = new ReportParameter("rpOoinoName", ooinoName);

                frmRptViewer.reportViewer1.LocalReport.SetParameters(paramName);
                frmRptViewer.reportViewer1.LocalReport.SetParameters(paramAddress);
                frmRptViewer.reportViewer1.LocalReport.SetParameters(paramTelFax);
                frmRptViewer.reportViewer1.LocalReport.SetParameters(paramEmail);
                frmRptViewer.reportViewer1.LocalReport.SetParameters(paramOoinoName);

                frmRptViewer.reportViewer1.RefreshReport();

                frmRptViewer.Show();

            }
        }
    }
}

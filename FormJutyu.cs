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

namespace SeisanKanri
{
    public partial class FormJutyu : Form
    {

        //SQLサーバー接続文字
        private string constr = @Properties.Settings.Default.ConnectStr;

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        private string acName = ""; //アクティブなコントロールの名前を入れる

        public string strRefTokui = "";

        //明細カラム設定
        const int intMSeihinCode = 0;
        const int intMSeihinMei = 1;
        const int intMSuryo = 2;
        const int intMTanka = 3;
        const int intMKingaku = 4;
        const int intMNouki = 5;
        const int intMYotei = 6;
        const int intMTekiyo = 7;
        const int intMTokutyu = 8;
        const int intMSisaku = 9;


        public FormJutyu()
        {
            InitializeComponent();
            //this.dataGridViewMeisai.Dock = DockStyle.Fill;
            //this.Controls.Add(this.dataGridViewMeisai);
            //this.Load += new EventHandler(FormJutyu_Load);
            //this.Text = "DataGridView calendar column demo";

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
                        int jutyuNo = (int)sdr["受注番号"];
                        string tokuCode = (string)sdr["得意先コード"];
                        string tokuName = (string)sdr["得意先名"];
                        string senpoNo = (string)sdr["先方受注番号"];
                        string ID = sdr["id"].ToString();
                        DateTime jutyuBi = Convert.ToDateTime(sdr["受注日付"]);
                        int nenkanNo = (int)sdr["年間番号"];

                        labelJutyuNo.Text = jutyuNo.ToString();
                        textBoxJutyuNo.Text = nenkanNo.ToString();
                        textBoxTokuisakiCode.Text = tokuCode;
                        textBoxTokuisakiMei.Text = tokuName;
                        textBoxSenpoNo.Text = senpoNo;
                        dateTimePickerJutyu.Value = jutyuBi;
                        labelID.Text = ID;

                        sdr.Close();

                        //データテーブル初期化
                        ds.Tables["受注明細"].Rows.Clear();

                        //テーブルへ行を追加

                        string meiSql = "SELECT * FROM 受注明細 WHERE 受注番号 = " + jutyuNo.ToString() + " ORDER BY 行番号";
                        SqlCommand comMei = new SqlCommand(meiSql, con);
                        SqlDataReader sdrMei = comMei.ExecuteReader();

                        while (sdrMei.Read())
                        {
                            DataRow row = ds.Tables["受注明細"].NewRow();

                            row["Id"] = (int)sdrMei["Id"];
                            row["製品コード"] = (string)sdrMei["製品コード"];
                            row["製品名"] = (string)sdrMei["製品名"];
                            row["数量"] = (decimal)sdrMei["数量"];
                            row["単価"] = (decimal)sdrMei["単価"];
                            row["金額"] = (decimal)sdrMei["金額"];
                            row["納期"] = Convert.ToDateTime(sdrMei["納期"]);
                            row["生産完了予定日"] = Convert.ToDateTime(sdrMei["生産完了予定日"]);
                            row["特注FL"] = (bool)sdrMei["特注FL"];
                            row["試作FL"] = (bool)sdrMei["試作FL"];
                            row["摘要"] = (string)sdrMei["摘要"];
                            row["必着FL"] = (bool)sdrMei["必着FL"];
                            row["発注先コード"] = (sdrMei["発注先コード"] == DBNull.Value ? "": sdrMei["発注先コード"]);
                            row["削除FL"] = false;

                            ds.Tables["受注明細"].Rows.Add(row);
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

        private Int32 AddFieldValueInt(DataRow row, string fieldName)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (Int32)row[fieldName];
            else
                return -1;
        }

        // 表示ボタン
        private void buttonView_Click(object sender, EventArgs e)
        {
            if (textBoxJutyuNo.Text.Trim() != "")
            {
                int NoInt = int.Parse(textBoxJutyuNo.Text.Trim());
                string YearStr = dateTimePickerJutyu.Value.Year.ToString();
                string jtyNoStr = string.Format("{0}{1:00000}", YearStr,NoInt);
                string sqlStr = "SELECT * FROM 受注 WHERE 受注番号 = " + jtyNoStr;
                RecordDisp(sqlStr);
            }
        }

        //フォームロード
        private void FormJutyu_Load(object sender, EventArgs e)
        {
            dt.TableName = "受注明細";

            dt.Columns.Add("Id", Type.GetType("System.Int32"));
            dt.Columns.Add("製品コード");
            dt.Columns.Add("製品名");
            dt.Columns.Add("数量", Type.GetType("System.Decimal"));
            dt.Columns.Add("単価", Type.GetType("System.Decimal"));
            dt.Columns.Add("金額", Type.GetType("System.Decimal"));
            dt.Columns.Add("納期", Type.GetType("System.DateTime"));
            dt.Columns.Add("生産完了予定日", Type.GetType("System.DateTime"));
            dt.Columns.Add("摘要");
            dt.Columns.Add("特注FL", Type.GetType("System.Boolean"));
            dt.Columns.Add("試作FL", Type.GetType("System.Boolean"));
            dt.Columns.Add("必着FL", Type.GetType("System.Boolean"));
            dt.Columns.Add("発注先コード");
            dt.Columns.Add("削除FL", Type.GetType("System.Boolean"));

            ds.Tables.Add(dt);
            
            dataGridViewMeisai.AutoGenerateColumns = false;
            dataGridViewMeisai.DataSource = ds.Tables["受注明細"];

            Program.CalendarColumn col5 = new Program.CalendarColumn();
            col5.DataPropertyName = "納期";
            col5.HeaderText = "納期";
            dataGridViewMeisai.Columns.Remove("納期");
            dataGridViewMeisai.Columns.Insert(intMNouki, col5);

            Program.CalendarColumn col6 = new Program.CalendarColumn();
            col6.DataPropertyName = "生産完了予定日";
            col6.HeaderText = "生産完了";
            dataGridViewMeisai.Columns.Remove("生産完了予定日");
            dataGridViewMeisai.Columns.Insert(intMYotei, col6);

            //col.DataPropertyName = "納期";
            //this.dataGridViewMeisai.Columns.Insert(5, col);

            //this.dataGridViewMeisai.RowCount = 5;
            //foreach (DataGridViewRow row in this.dataGridView1.Rows)
            //{
            //    row.Cells[0].Value = DateTime.Now;
            //}

            labelID.Text = "";
            labelJutyuNo.Text = "";

            //データグリッドビューの設定
            //dataGridViewMeisai.Columns["製品コード"].Width = 100;
            //dataGridViewMeisai.Columns["製品名"].Width = 200;
            //dataGridViewMeisai.Columns["数量"].Width = 100;
            //dataGridViewMeisai.Columns["数量"].DefaultCellStyle.Format = "#.0.#";
            //dataGridViewMeisai.Columns["納期"].Width = 100;
            //dataGridViewMeisai.Columns["生産完了予定日"].Width = 100;
            //dataGridViewMeisai.Columns["特注FL"].Width = 100;
            //dataGridViewMeisai.Columns["試作FL"].Width = 100;


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int rowNo = dataGridViewMeisai.CurrentCellAddress.Y;

            int mId;

            mId = AddFieldValueInt(ds.Tables["受注明細"].Rows[rowNo], "Id");

            MessageBox.Show(mId.ToString());

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

            string editNo = "";
            string sqlStr = "";

            //得意先が選択されてないとNG
            if (textBoxTokuisakiCode.Text == "")
            {
                errMsgStr += "得意先を選択してください。\r\n";
            }

            //サーバー接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                //labelJutyuNoが空白なら新規、そうでなければその番号で更新
                if (labelJutyuNo.Text != "")
                {
                    //更新
                    editNo = labelJutyuNo.Text;
                    sqlStr = "SELECT * FROM 受注 WHERE 受注番号 = " + editNo;

                    saveSqlStr = "UPDATE 受注 " +
                        "SET" +
                        " 得意先コード = '" + textBoxTokuisakiCode.Text + "'," +
                        " 得意先名 = N'" + textBoxTokuisakiMei.Text.Trim() + "'," +
                        " 受注日付 = '" + dateTimePickerJutyu.Value + "' ," +
                        " 先方受注番号 = '" + textBoxSenpoNo.Text.Trim() + "' " +
                        " where 受注番号  = " + editNo;
                }
                else
                {
                    //新規
                    //新しい番号を取得
                    int newNoInt = 1;
                    //年度で番号を検索
                    string sqlstr = "select * from 受注番号 where 年度 = " + yrStr;
                    SqlCommand comNo = new SqlCommand(sqlstr, con);
                    SqlDataReader sdrNo = comNo.ExecuteReader();
                    if (sdrNo.Read() == true)
                    {
                        newNoInt = (int)sdrNo["番号"] + 1;

                        //年度が見つかった場合
                        //更新
                        noSaveSqlStr = "UPDATE 受注番号 SET 番号 = " + newNoInt.ToString() + " where 年度  = " + yrStr;
                    }
                    else
                    {
                        //新規
                        noSaveSqlStr = "INSERT INTO 受注番号 (年度, 番号) VALUES (" + yrStr + ", 1)";
                    }

                    //検索結果を破棄
                    sdrNo.Close();

                    //クエリー実行　新しい番号を保存
                    SqlCommand comNoSave = new SqlCommand(noSaveSqlStr, con);
                    comNoSave.ExecuteNonQuery();

                    editNo = string.Format("{0}{1:00000}", yrStr, newNoInt);
                    sqlStr = "SELECT * FROM 受注 WHERE 受注番号 = " + editNo;

                    //受注データ　新規登録
                    saveSqlStr = "INSERT INTO 受注 (" +
                            "受注番号, 得意先コード, 得意先名, 受注日付, 先方受注番号, 年間番号" +
                            ") VALUES (" +
                            editNo + ","+
                             "'" + textBoxTokuisakiCode.Text.Trim() + "'," +
                            " N'" + textBoxTokuisakiMei.Text.Trim() + "', '" +
                            dateTimePickerJutyu.Value + "', " +
                            "'" + textBoxSenpoNo.Text.Trim() + "'," +
                            newNoInt.ToString() + ")";
                }


                //クエリー実行
                SqlCommand saveCom = new SqlCommand(saveSqlStr, con);
                saveCom.ExecuteNonQuery();
                msgstr = "保存しました";


                //
                //明細保存

                //データセットの行数分ループ
                int loopCnt = dataGridViewMeisai.BindingContext[dataGridViewMeisai.DataSource, dataGridViewMeisai.DataMember].Count;
                if (loopCnt == 0) return;   //0行なら何もしない


                

                DataTable dtm = ds.Tables["受注明細"];
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
                        int iId;
                        while (i < loopCnt)
                        {
                            //データセットの削除フラグをチェック
                            if (AddFieldValueBool(mrows[i], "削除FL"))
                            {
                                //削除フラグ=True
                                //IDをチェック
                                iId = AddFieldValueInt(mrows[i], "Id");
                                if (iId == -1)
                                {
                                    //ID=NULL(新規のデータ)
                                    //何もしない

                                }
                                else
                                {
                                    //ID!=NULL(既にDB上に存在するデータ)
                                    //削除
                                    mcom.CommandText = "DELETE FROM 受注明細 WHERE ID = " + iId.ToString();

                                    mcom.ExecuteNonQuery();

                                }
                            }
                            else
                            {
                                //削除フラグ=Fasle
                                //IDをチェック
                                rowNo = i + 1;
                                nouki = AddFieldValueDateTime(mrows[i], "納期", System.DateTime.Today);
                                yotei = AddFieldValueDateTime(mrows[i], "生産完了予定日", nouki);

                                iId = AddFieldValueInt(mrows[i], "Id");
                                if (iId == -1)
                                {
                                    //ID=NULL
                                    //新規登録
                                    mcom.CommandText = "INSERT INTO 受注明細 (" +
                                        "受注番号,行番号,製品コード, 製品名, 数量, 単価, 金額, 納期, 生産完了予定日, 特注FL, 試作FL, 摘要)" +
                                        " VALUES (" +
                                        editNo + ", " +
                                        rowNo.ToString() + ", " +
                                        "'" + AddFieldValueString(mrows[i], "製品コード") + "', " +
                                        "N'" + AddFieldValueString(mrows[i], "製品名") + "', " +
                                        AddFieldValueDecimal(mrows[i], "数量").ToString() + ", " +
                                        AddFieldValueDecimal(mrows[i], "単価").ToString() + ", " +
                                        AddFieldValueDecimal(mrows[i], "金額").ToString() + ", " +
                                        "'" + nouki + "', " +
                                        "'" + yotei + "', " +
                                        "'" + AddFieldValueBool(mrows[i], "特注FL") + "', " +
                                        "'" + AddFieldValueBool(mrows[i], "試作FL") + "', " +
                                        "N'" + AddFieldValueString(mrows[i], "摘要") + "')";
                                    mcom.ExecuteNonQuery();
                                }
                                else
                                {
                                    //ID!=NULL
                                    //上書き
                                    mcom.CommandText = "UPDATE 受注明細 SET " +
                                        "行番号 = " + rowNo.ToString() + ", " +
                                        "製品コード = '" + AddFieldValueString(mrows[i], "製品コード") + "', " +
                                        "製品名 = N'" + AddFieldValueString(mrows[i], "製品名") + "', " +
                                        "数量 = " + AddFieldValueDecimal(mrows[i], "数量").ToString() + ", " +
                                        "単価 = " + AddFieldValueDecimal(mrows[i], "単価").ToString() + ", " +
                                        "金額 = " + AddFieldValueDecimal(mrows[i], "金額").ToString() + ", " +
                                        "納期 = '" + nouki + "', " +
                                        "生産完了予定日 = '" + yotei + "', " +
                                        "特注FL = '" + AddFieldValueBool(mrows[i], "特注FL") + "', " +
                                        "試作FL = '" + AddFieldValueBool(mrows[i], "試作FL") + "', " +
                                        "摘要 = N'" + AddFieldValueString(mrows[i], "摘要") + "' " +
                                        "WHERE Id = " + iId.ToString();
                                    mcom.ExecuteNonQuery();


                                }
                            }
                            i++;

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
            if (sqlStr != "")
            {
                RecordDisp(sqlStr);
                makeNouhin();
            }
            //結果をメッセージボックスで表示
            MessageBox.Show(msgstr, "受注");


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
                case "得意先コード":
                    dlg = acName;
                    break;
                case "受注番号":
                    dlg = acName;
                    break;
                case "明細":
                    rowNo = dataGridViewMeisai.CurrentCellAddress.Y;
                    colNo = dataGridViewMeisai.CurrentCellAddress.X;
                    if (rowNo == -1) break;
                    switch(colNo)
                    {
                        case intMSeihinCode:     //製品コード
                            dlg = "製品コード";
                            break;
                        case intMNouki:     //納期
                            dlg = "納期";
                            break;
                        case intMYotei:     //生産完了予定日
                            dlg = "生産完了予定日";
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
                case "得意先コード":
                    FormInTokuisaki frmInTokuisaki = new FormInTokuisaki();
                    drRet = frmInTokuisaki.ShowDialog();
                    if (drRet == DialogResult.OK)
                    {
                        //リストから選択されていなければなにもしない
                        if (frmInTokuisaki.listBoxTokuisaki.SelectedIndex == -1) break;
                        //リストの選択されているところから得意先コードを抽出
                        string listStr = frmInTokuisaki.listBoxTokuisaki.SelectedItem.ToString();
                        string codeStr = listStr.Substring(0, 13).Trim();

                        //サーバーに接続
                        SqlConnection con = new SqlConnection(constr);
                        con.Open();
                        try
                        {
                            //接続成功
                            //すべてのレコードをコード昇順で出力
                            string sqlstr = "SELECT * FROM 得意先マスタ WHERE 得意先コード = '" + codeStr + "'";
                            SqlCommand com = new SqlCommand(sqlstr, con);
                            SqlDataReader sdr = com.ExecuteReader();

                            //リスト表示
                            while (sdr.Read() == true)
                            {
                                textBoxTokuisakiCode.Text = (string)sdr["得意先コード"];
                                textBoxTokuisakiMei.Text = (string)sdr["得意先名"];
                            }

                        }
                        finally
                        {
                            //サーバー切断
                            con.Close();
                        }
                    }
                    break;

                case "製品コード":
                    FormInSeihin frmInSeihin = new FormInSeihin();
                    frmInSeihin.strRefTokui = textBoxTokuisakiCode.Text;
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
                                ds.Tables["受注明細"].Rows[rowNo]["製品コード"] = (string)sdr["製品コード"];
                                ds.Tables["受注明細"].Rows[rowNo]["製品名"] = (string)sdr["製品名"];
                                ds.Tables["受注明細"].Rows[rowNo]["単価"] = (decimal)sdr["単価"];

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
                case "生産完了予定日":
                    FormInDate frmInDate = new FormInDate();
                    drRet = frmInDate.ShowDialog();
                    if (drRet == DialogResult.OK)
                    {
                        ds.Tables["受注明細"].Rows[rowNo][colNo] = frmInDate.monthCalendar.SelectionRange.Start;
                    }
                    break;

            }

        }

        private void FormJutyu_KeyDown(object sender, KeyEventArgs e)
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

        private void textBoxSenpoNo_Enter(object sender, EventArgs e)
        {
            acName = "先方受注番号";
        }

        private void textBoxJutyuNo_Enter(object sender, EventArgs e)
        {
            acName = "受注番号";
        }

        private void dateTimePickerJutyu_Enter(object sender, EventArgs e)
        {
            acName = "受注日付";
        }

        private void textBoxTokuisakiCode_Enter(object sender, EventArgs e)
        {
            acName = "得意先コード";
        }

        private void textBoxTokuisakiMei_Enter(object sender, EventArgs e)
        {
            acName = "";
        }

        private void dataGridViewMeisai_Enter(object sender, EventArgs e)
        {
            acName = "明細";

        }

        private void buttonAddMeisai_Click(object sender, EventArgs e)
        {
            //明細行追加ボタン
            ds.Tables["受注明細"].Rows.Add(ds.Tables["受注明細"].NewRow());
            
            int rowNo = ds.Tables["受注明細"].Rows.Count - 1;
            ds.Tables["受注明細"].Rows[rowNo]["削除FL"] = false;

            dataGridViewMeisai.CurrentCell = dataGridViewMeisai["製品コード",rowNo];
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

                    if (!DBNull.Value.Equals(ds.Tables["受注明細"].Rows[e.RowIndex]["製品コード"]))
                    {
                        //リストの選択されているところから製品コードを抽出
                        string codeStr = (string)ds.Tables["受注明細"].Rows[e.RowIndex]["製品コード"];

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
                                if (AddFieldValueString(ds.Tables["受注明細"].Rows[e.RowIndex],"製品名") == "")
                                {
                                    ds.Tables["受注明細"].Rows[e.RowIndex]["製品名"] = (string)sdr["製品名"];
                                }
                                if (AddFieldValueDecimal(ds.Tables["受注明細"].Rows[e.RowIndex],"単価") == 0)
                                {
                                    ds.Tables["受注明細"].Rows[e.RowIndex]["単価"] = (decimal)sdr["単価"];
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

                case intMSuryo:
                case intMTanka:
                    if (DBNull.Value.Equals(ds.Tables["受注明細"].Rows[e.RowIndex]["数量"])) break;
                    if (DBNull.Value.Equals(ds.Tables["受注明細"].Rows[e.RowIndex]["単価"])) break;

                    decimal suryo = (decimal)ds.Tables["受注明細"].Rows[e.RowIndex]["数量"];
                    decimal tanka = (decimal)ds.Tables["受注明細"].Rows[e.RowIndex]["単価"];

                    decimal kingaku = suryo * tanka;
                    ds.Tables["受注明細"].Rows[e.RowIndex]["金額"] = kingaku;
                    break;

               case intMKingaku:
                    if (DBNull.Value.Equals(ds.Tables["受注明細"].Rows[e.RowIndex]["金額"])) break;
                    if (DBNull.Value.Equals(ds.Tables["受注明細"].Rows[e.RowIndex]["数量"]))
                    {
                        ds.Tables["受注明細"].Rows[e.RowIndex]["数量"] = 1;
                    }
                    if (DBNull.Value.Equals(ds.Tables["受注明細"].Rows[e.RowIndex]["単価"]))
                    {
                        ds.Tables["受注明細"].Rows[e.RowIndex]["単価"] = ds.Tables["受注明細"].Rows[e.RowIndex]["金額"];
                    }
                    break;

                case intMNouki:
                    if (DBNull.Value.Equals(ds.Tables["受注明細"].Rows[e.RowIndex]["生産完了予定日"]))
                    {
                        ds.Tables["受注明細"].Rows[e.RowIndex]["生産完了予定日"] = ds.Tables["受注明細"].Rows[e.RowIndex]["納期"];
                    }
                    break;
            }
        }

        private void buttonDeleteMeisai_Click(object sender, EventArgs e)
        {
            DataTable ddt = ds.Tables["受注明細"];
            //現在のアクティブな行を取得 0～
            int rowNo = dataGridViewMeisai.CurrentCellAddress.Y;
            int mId;

            //選択されていなければなにもしない
            if (rowNo == -1) return;

            //削除フラグ
            //  true
            //      製品コード、製品名、摘要に文字がなければ行を削除
            //                                      あれば取り消し線を表示してフラグＯＮ
            // false
            //      取り消し線の非表示にしてフラグＯＦＦ
            if ((bool)ddt.Rows[rowNo]["削除FL"] == false)
            {
                //if (AddFieldValueString(ddt.Rows[rowNo], "製品コード") +
                //    AddFieldValueString(ddt.Rows[rowNo], "製品名") +
                //    AddFieldValueString(ddt.Rows[rowNo], "摘要") == "")
                //{
                if (DBNull.Value.Equals(ddt.Rows[rowNo]["Id"]))
                {
                        ddt.Rows.Remove(dt.Rows[rowNo]);
                    return;
                }
                ddt.Rows[rowNo]["削除FL"] = true;
                dataGridViewMeisai.Rows[rowNo].DefaultCellStyle.Font = new Font("MS UI Gothic", 9, FontStyle.Strikeout);
            }
            else
            {
                ddt.Rows[rowNo]["削除FL"] = false;
                dataGridViewMeisai.Rows[rowNo].DefaultCellStyle.Font = new Font("MS UI Gothic", 9);
            }

        }

        private void buttonMeisaiSounyu_Click(object sender, EventArgs e)
        {
            DataRow drIns = dt.NewRow();
            //現在のアクティブな行を取得 0～
            int rowNo = dataGridViewMeisai.CurrentCellAddress.Y;

            //選択されていなければなにもしない
            if (rowNo == -1) return;

            ds.Tables["受注明細"].Rows.InsertAt(drIns, rowNo);
            ds.Tables["受注明細"].Rows[rowNo]["削除FL"] = false;
        }

        private void makeNouhin()
        {
            //納品データの作成
            DateTime nouki;
            //メッセージ用変数を初期化
            string msgstr = "";
            //サーバー接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            try
            {
                int loopCnt = dataGridViewMeisai.BindingContext[dataGridViewMeisai.DataSource, dataGridViewMeisai.DataMember].Count;
                if (loopCnt == 0) return;   //0行なら何もしない

                DataTable dtm = ds.Tables["受注明細"];
                DataRowCollection mrows = dtm.Rows;

                using (var transaction = con.BeginTransaction())
                using (var mcom = new SqlCommand() { Connection = con, Transaction = transaction })
                {
                    try
                    {

                        //既存データに上書き
                        int i = 0;
                        int iId;
                        while (i < loopCnt)
                        {

                            //IDを取得
                            iId = (int)mrows[i]["Id"];

                            //納期を読み込み（もし設定がなければシステムの日付を入力)
                            nouki = AddFieldValueDateTime(mrows[i], "納期", System.DateTime.Today);

                            //更新と挿入
                            //まずアップデートしてその後実行できた件数を取得
                            //実行件数が０ならインサートを実行
                            mcom.CommandText = "UPDATE 納品 " +
                                "SET" +
                                " 納品日='" + nouki + "'," +
                                " 納品数=" + AddFieldValueDecimal(mrows[i], "数量") +
                                " where 受注明細ID  = " + iId.ToString() + " AND 行番号 = 0" +
                                " if @@ROWCOUNT = 0 "+
                                "INSERT INTO 納品 (" +
                                    "受注明細ID, 納品日, 納品数, 必着FL, 完了FL, 摘要, 行番号" +
                                    ") VALUES (" +
                                    iId.ToString() + ", " +
                                    "'" + nouki + "', " +
                                    AddFieldValueDecimal(mrows[i], "数量").ToString() + ", " +
                                    "'false' ," +
                                    "'false' ," +
                                    "'',0)";
                            mcom.ExecuteNonQuery();
                            i++;
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
                msgstr = "納品データの書き込みに失敗しました";
            }
            finally
            {
                //サーバー切断
                con.Close();
            }
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            labelJutyuNo.Text = "";
            textBoxJutyuNo.Text = "新規";
            textBoxTokuisakiCode.Text = "";
            textBoxTokuisakiMei.Text = "";
            textBoxSenpoNo.Text = "";
            dateTimePickerJutyu.Value = DateTime.Now;
            labelID.Text = "";


            //データテーブル初期化
            ds.Tables["受注明細"].Rows.Clear();

        }

        private void TextBoxJutyuNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonNohin_Click(object sender, EventArgs e)
        {
            int rowNo = dataGridViewMeisai.CurrentCellAddress.Y;
            if (rowNo < 0) return;

            DataTable dtm = ds.Tables["受注明細"];
            DataRowCollection mrows = dtm.Rows;


            FormNohinHenko frmNH = new FormNohinHenko();
            

            //製品名

            frmNH.labelSeihinMei.Text = (string)mrows[rowNo]["製品名"];

            frmNH.toolSSLabel1.Text = mrows[rowNo]["Id"].ToString();
            frmNH.ShowDialog();

        }

        private void buttonPre_Click(object sender, EventArgs e)
        {
            string sqlStr;
            if (labelID.Text.Trim() != "")
            {
                int NoInt = int.Parse(labelID.Text.Trim());

                sqlStr = "SELECT * FROM 受注 WHERE Id IN (" +
                                "SELECT MAX(Id) FROM 受注 WHERE Id < " + NoInt + ")";
            }
            else
            {
                sqlStr = "SELECT * FROM 受注 WHERE Id IN (" +
                                "SELECT MAX(Id) FROM 受注)";

            }
            RecordDisp(sqlStr);

        }

        private void textBoxTokuisakiCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTokuisakiCode_Leave(object sender, EventArgs e)
        {
            string codeStr;
            if (textBoxTokuisakiCode.Text == "") return;

            codeStr = textBoxTokuisakiCode.Text;


            //サーバーに接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                //接続成功
                //すべてのレコードをコード昇順で出力
                string sqlstr = "SELECT * FROM 得意先マスタ WHERE 得意先コード = '" + codeStr + "'";
                SqlCommand com = new SqlCommand(sqlstr, con);
                SqlDataReader sdr = com.ExecuteReader();

                while (sdr.Read() == true)
                {
                    textBoxTokuisakiMei.Text = (string)sdr["得意先名"];
                }

            }
            finally
            {
                //サーバー切断
                con.Close();
            }

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            string sqlStr;
            if (labelID.Text.Trim() != "")
            {
                int NoInt = int.Parse(labelID.Text.Trim());

                sqlStr = "SELECT * FROM 受注 WHERE Id IN (" +
                                "SELECT MIN(Id) FROM 受注 WHERE Id  > " + NoInt + ")";
            }
            else
            {
                sqlStr = "SELECT * FROM 受注 WHERE Id IN (" +
                                "SELECT MAX(Id) FROM 受注)";

            }
            
            RecordDisp(sqlStr);

        }
    }
}



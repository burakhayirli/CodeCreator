using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CodeCreator
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        SqlConnection ActiveConn = null;
        Creator creator = null;
        List<Creator.Field> ActiveTableFieldList = null;
        private bool isDatabaseConnection;
        private bool isConnectedDatabase;

        public bool IsConnectedDatabase
        {
            get { return isConnectedDatabase; }
            set { 
                 isConnectedDatabase = value;
                 if (isConnectedDatabase)
                 {
                     gb_DatabaseConnection.Visible = false;
                     gb_DatabaseAndTableSelection.Visible = true;
                     cb_Databases.SelectedIndex = -1;
                     cb_Tables.SelectedIndex = -1;
                     this.Refresh();
                 }            
            }
        }
        public bool IsDatabaseConnection
        {
            get { return isDatabaseConnection; }
            set { 
                isDatabaseConnection = value;
                if (isDatabaseConnection)
                {
                    gb_DatabaseConnection.Visible = true;
                    txt_ColumnNames.Text = "";
                    txt_InsertCode.Text = "";
                    txt_UpdateCode.Text = "";
                    txt_ClassCode.Text = "";
                    txt_TableOrPropertyName.Text = "";
                    chkb_UseOrjinalColumnNameOnSQL.Checked = true;
                    creator.UseOrjinalColumnNameOnSQL = true;
                    this.Refresh();
                }
                else
                {
                    gb_DatabaseConnection.Visible = false;
                    gb_DatabaseAndTableSelection.Visible = false;
                    cb_Databases.Items.Clear();
                    cb_Tables.Items.Clear();
                    cb_Tables.Text = "";
                    txt_ColumnNames.Text = "";
                    txt_InsertCode.Text = "";
                    txt_UpdateCode.Text = "";
                    txt_ClassCode.Text = "";
                    txt_TableOrPropertyName.Text = "";
                    creator.UseOrjinalColumnNameOnSQL = false;
                    creator.UseOrjinalColumnNameOnClass = false;
                    chkb_UseOrjinalColumnNameOnClass.Checked = false;
                    chkb_UseOrjinalColumnNameOnSQL.Checked = false;
                    this.Refresh();
                }
            }
        }


        private void btn_CreateCode_Click(object sender, EventArgs e)
        {
            if (rb_Manuel.Checked)
            {
                if ((txt_ColumnNames.Text != "") && (txt_ColumnNames.Text != null))
                {
                    creator.ClassOrTableName = txt_TableOrPropertyName.Text;
                    ActiveTableFieldList = creator.GetColumnNames(txt_ColumnNames.Text);
                    creator.PropertyOrColumnList = ActiveTableFieldList;
                    GetCreatedCodes(creator);
                }
                else
                    MessageBox.Show("Sütun yada Özellik alanı boş olamaz.", "Uyarı!");
            }
            else
            {
                if ((cb_Databases.SelectedIndex == -1) || (cb_Tables.SelectedIndex == -1))
                {
                    MessageBox.Show("Veritabanı ve Tablo seçilmek zorundadır.");
                }
                else
                {
                    creator.PropertyOrColumnList = ActiveTableFieldList;
                    creator.UseOrjinalColumnNameOnClass = chkb_UseOrjinalColumnNameOnClass.Checked;
                    GetCreatedCodes(creator);
                }
            }
        }

        private void GetCreatedCodes(Creator creator)
        {
            txt_ClassCode.Text = creator.CreateClassCode();
            txt_InsertCode.Text = creator.CreateInsertCode();
            txt_UpdateCode.Text = creator.CreateUpdateCode();
        }

        private void rb_Database_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Database.Checked)
                IsDatabaseConnection = true;
            else
                IsDatabaseConnection = false;

            this.Refresh();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            bool isConnected = false;
            string connsql ="";
            if ((txt_DbUser.Text != "") && (txt_DbPassword.Text != ""))
            { 
                connsql = @"Data Source=" + txt_ServerName.Text + ";Initial Catalog=master;User Id="+txt_DbUser.Text+"; Password="+txt_DbPassword.Text+";"; 
            }
            else
                connsql = @"Data Source="+txt_ServerName.Text+";Initial Catalog=master;Integrated Security= True";
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases WHERE name NOT IN('master','tempdb','model','msdb')",conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cb_Databases.Items.Add(dr["name"].ToString());
                isConnected = true;
            }
            cmd.Dispose();
            dr.Dispose();
            conn.Dispose();
            if (isConnected) IsConnectedDatabase = true;
            else { 
                IsConnectedDatabase = false;
                MessageBox.Show("Veritabanında tablo bulunamadı. Boş bir veritabanı seçtiniz.");
            }            
        }

        private void GetTablesByDatabase(string databaseName)
        {
            string strConn = "";
             if ((txt_DbUser.Text != "") && (txt_DbPassword.Text != ""))
            { 
                strConn = @"Data Source=" + txt_ServerName.Text + ";Initial Catalog="+databaseName+";User Id="+txt_DbUser.Text+"; Password="+txt_DbPassword.Text+";"; 
            }
            else
                strConn = @"Data Source=" + txt_ServerName.Text + ";Initial Catalog=" + databaseName + ";Integrated Security= True";
            ActiveConn =new SqlConnection(strConn);
            ActiveConn.Open();
            if (ActiveConn.State != ConnectionState.Open)
                ActiveConn.Open();
            string SelectSql = "SELECT name FROM sys.tables ORDER BY name";
            SqlCommand cmd = new SqlCommand(SelectSql, ActiveConn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cb_Tables.Items.Add(dr["name"].ToString());
            }

            cmd.Dispose();
            dr.Dispose();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            creator = new Creator();
            ActiveTableFieldList = new List<Creator.Field>();
        }

        private void cb_Databases_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_Databases.SelectedIndex > -1)
            {
                cb_Tables.Items.Clear(); 
                txt_TableOrPropertyName.Text = "";
                txt_UpdateCode.Text = "";
                txt_InsertCode.Text = "";
                txt_ClassCode.Text = "";
                txt_ColumnNames.Text = "";
                GetTablesByDatabase(cb_Databases.SelectedItem.ToString());
            }
        }

        private void cb_Tables_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_Tables.SelectedIndex > -1)
            {
                creator.ClassOrTableName = cb_Tables.SelectedItem.ToString();
                creator.UseOrjinalColumnNameOnSQL = chkb_UseOrjinalColumnNameOnSQL.Checked;
                creator.UseOrjinalColumnNameOnClass = chkb_UseOrjinalColumnNameOnClass.Checked;
                txt_TableOrPropertyName.Text = creator.ClassOrTableName;
                txt_ColumnNames.Text = "";
                ActiveTableFieldList = creator.GetColumnNamesByTable(ActiveConn, creator.ClassOrTableName);
                string cols = "";
                foreach (Creator.Field C in ActiveTableFieldList)
                {
                    cols += C.FieldName + ",";
                }
                txt_ColumnNames.Text = cols.Substring(0,cols.Length-1);
                btn_CreateCode_Click(null, null);
            }
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,
                "Code Creator v1 \n\n"+
                "Burak HAYIRLI tarafından kodlanmıştır.\n\n"+
                "C# ile uygulama yazarken CLASS yapılarında ve INSERT, UPDATE sorgularında yapılan basit hatalar çok zaman kaybettirebildiği için bu uygulamayı hazırladım.\n\n" +
                "Benim çok işime yarıyor, size de yararlı olması dileğiyle.\n\n"+
                "www.burakhayirli.com \n\n"+
                "Freeware Software (2013)"                
                ,"Hakkında",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
     

        //public void ConnectionDialog()
        //{
        //    DataConnectionDialog dcd = new DataConnectionDialog();
        //    DataConnectionConfiguration dcs = new DataConnectionConfiguration(null);
        //    dcs.LoadConfiguration(dcd);

        //    if (DataConnectionDialog.Show(dcd) == DialogResult.OK)
        //    {
        //        // load tables
        //        using (SqlConnection connection = new SqlConnection(dcd.ConnectionString))
        //        {
        //            connection.Open();
        //            SqlCommand cmd = new SqlCommand("SELECT * FROM sys.Tables", connection);
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    Console.WriteLine(reader.HasRows);
        //                }
        //            }
        //        }
        //    }
        //    dcs.SaveConfiguration(dcd);
        
        //}

    }
}

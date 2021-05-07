using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CodeCreator
{
    public class Creator
    {
        const string Enter = "\r\n";
        private string classOrTableName;
        private List<Field> propertyOrColumnList;
        private bool useOrjinalColumnNameOnSQL;
        private bool useOrjinalColumnNameOnClass;

        public bool UseOrjinalColumnNameOnClass
        {
            get { return useOrjinalColumnNameOnClass; }
            set { useOrjinalColumnNameOnClass = value; }
        }
        public bool UseOrjinalColumnNameOnSQL
        {
            get { return useOrjinalColumnNameOnSQL; }
            set { useOrjinalColumnNameOnSQL = value; }
        }

        public List<Field> PropertyOrColumnList
        {
            get { return propertyOrColumnList; }
            set { propertyOrColumnList = value; }
        }

        public string ClassOrTableName
        {
            get { return classOrTableName; }
            set { classOrTableName = value; }
        }

        public Creator()
        {
            useOrjinalColumnNameOnClass = false;
            useOrjinalColumnNameOnSQL = false;
        }

        public class Field
        {
            private string fieldName;
            private string typeName;

            public string FieldName
            {
                get { return fieldName; }
                set { fieldName = value; }
            }
            public string TypeName
            {
                get { return typeName; }
                set { typeName = value; }
            }
        }

        public string CreateClassCode()
        {
            string ClassDeclaretion = "";
            string Properties = "public class " + ClassOrTableName + Enter + "{" + Enter;
            string GetSetMethods = "";
            string Constructor = "public "+classOrTableName+"()"+Enter+"{"+Enter;
            foreach (Field P in propertyOrColumnList)
            {
                string privateProp = ConvertToPrivatePropertyName(P.FieldName).Replace("ı", "i").Replace("İ","I");
                string publicGetSet = ConvertToPublicGetSetName(P.FieldName);       
                Properties += "private "+GetDataType(P.TypeName)+" " + privateProp + ";" + Enter;
                GetSetMethods += "public "+GetDataType(P.TypeName)+" " + publicGetSet + Enter + "{" + Enter + " get { return " + privateProp + "; }" + Enter +
                    " set { " + privateProp + " = value; }" + Enter + "}" + Enter;
                Constructor += privateProp + " = " + GetValueByDataType(GetDataType(P.TypeName))+";"+Enter;
            }

            return ClassDeclaretion + Properties + Enter + GetSetMethods + Enter + Constructor + Enter + "}" + Enter + "}";
        }

        private string GetValueByDataType(string DataType)
        {
            string result = "";
            switch (DataType)
            {
                case "int": result = "0"; break;
                case "string": result = "\"\""; break;
                case "DateTime": result = "DateTime.Now"; break;
                case "bool": result = "true"; break;
                case "double": result = "0"; break;
            }
            return result;
        }

        private string ConvertToPublicGetSetName(string P)
        {
            bool isFirst = false;
            string columnName = "";
            foreach (char C in P)
            {
                if (!useOrjinalColumnNameOnClass)
                {
                    if ((C.ToString() == C.ToString().ToUpper()))
                    {
                        if (!isFirst) { isFirst = true; columnName += C.ToString(); }
                        else columnName += C.ToString();
                    }
                    else
                        columnName += C.ToString();
                    columnName = columnName.Substring(0, 1).ToUpper() + columnName.Substring(1, columnName.Length - 1);
                }
                else
                    columnName = P; //private property adı
            }

            return columnName;
        }

        private string ConvertToPrivatePropertyName(string P)
        {
            bool isFirstUpper = false;
            string columnName = "";
            foreach (char C in P)
            {
                if (!useOrjinalColumnNameOnClass)
                {
                    if ((C.ToString() == C.ToString().ToUpper()))
                    {
                        if ((!isFirstUpper) && (P.IndexOf(C) == 0)) { isFirstUpper = true; columnName += C.ToString().ToLower(); }
                        else
                            columnName += C.ToString();
                    }
                    else
                        columnName += C.ToString();
                    columnName = columnName.Substring(0, 1).ToLower() + columnName.Substring(1, columnName.Length - 1);
                }
                else
                    columnName = P + "_";
            }
            return columnName;
        }


        public string CreateInsertCode()
        {
            string Insert = @"SqlCommand cmdInsert = new SqlCommand(""INSERT INTO " + classOrTableName + "(";
            string Values = "VALUES(";
            string Parameters = "";

            foreach (Field C in propertyOrColumnList)
            {
                string columnName="";
                if (useOrjinalColumnNameOnSQL) columnName = C.FieldName;
                else
                    columnName = ConvertToPublicGetSetName(C.FieldName);
                Insert += columnName + ",";
                Values += "@" + columnName + ",";
                Parameters += "cmdInsert.Parameters.AddWithValue(\"@" + columnName + "\"," + classOrTableName+"__."+ columnName + ");" + Enter;
            }
            Insert = Insert.Substring(0, Insert.Length - 1) + ") ";
            Values = Values.Substring(0, Values.Length - 1) + ")\");";
            Insert += Values + Enter + Parameters;

            return Insert;
        }

        public List<Field> GetColumnNames(string ColumnNames)
        {
            List<Field> columns = new List<Field>();
            Field field = null;
            foreach (string C in ColumnNames.Split(','))
            {
                field = new Field();
                field.FieldName = C.Replace(Convert.ToChar(','), Convert.ToChar(" "));
                field.TypeName = "string";
                columns.Add(field);
            }
            return columns;
        }

        public List<Field> GetColumnNamesByTable(SqlConnection ActiveConn, string TableName)
        {
            List<Field> fieldList = new List<Field>();
            Field field = null;
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM " + "["+TableName+"]", ActiveConn);
            SqlDataReader dr = cmd.ExecuteReader();

            for (int i = 0; i < dr.FieldCount; i++)
            {
                field = new Field();
                field.FieldName = dr.GetName(i).ToString();
                field.TypeName = dr.GetDataTypeName(i).ToString();
                fieldList.Add(field);
            }

            dr.Dispose();
            cmd.Dispose();
            return fieldList;
        }

        public string CreateUpdateCode()
        {
            string Update = @"SqlCommand cmdUpdate = new SqlCommand(""UPDATE " + classOrTableName+" SET ";
            string Set = "";
            string Parameters = "";

            foreach (Field C in propertyOrColumnList)
            {
                string columnName = "";
                if (useOrjinalColumnNameOnSQL) columnName = C.FieldName;
                else
                    columnName = ConvertToPublicGetSetName(C.FieldName);
                Set += columnName + "=" + "@" + columnName + ",";
                Parameters += "cmdUpdate.Parameters.AddWithValue(\"@" + columnName + "\"," + classOrTableName+"__."+columnName + ");" + Enter;
            }
            Set=Set.Substring(0, Set.Length - 1)+"\");";
            return Update + Set  + Enter+Parameters;
           
        }

        public string GetDataType(string datatype)
        {
            string result=datatype;
            switch (datatype)
            {
                case "char": result = "string"; break;
                case "nchar": result = "string"; break;
                case "nvarchar": result = "string"; break;
                case "datetime": result = "DateTime"; break;
                case "bit": result = "bool"; break;
                case "money": result = "double"; break;
                case "varchar": result = "string"; break;
                case "smalldatetime": result = "DateTime"; break;
                case "tinyint": result = "int"; break;
                case "decimal": result = "int"; break;
                case "smallint": result = "int"; break;
                case "ntext": result = "string"; break;
                case "text": result = "string"; break;
                case "image": result = "NULL"; break;
            }
            return result;
        }

        public static List<string> GetColumnNamesBySqlDataReader(ref SqlDataReader dr)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < dr.FieldCount-1; i++)
            {
                list.Add(dr.GetName(i));
                string str = dr.GetDataTypeName(i);
            }
            return list;           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PxDataLoader.Import
{
    class ExcelFileWrapper
    {
        private string _path;

        public ExcelFileWrapper(string path)
        {
            _path = path;
        }

        public DataTable GetSheetData(string sheet)
        {
            var conn = new System.Data.OleDb.OleDbConnection(
                String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=Yes;IMEX=1';", _path));
            DataSet ds = new DataSet();

            var adapter = new System.Data.OleDb.OleDbDataAdapter(
                String.Format("SELECT * FROM [{0}$] ", sheet), conn);
            adapter.Fill(ds);

            return ds.Tables[0];
        }

        public DataTable GetSheetDataForInsert(string qrySecondPart)
        {
            var conn = new System.Data.OleDb.OleDbConnection(
                String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=Yes;IMEX=1';", _path));
            DataSet ds = new DataSet();

            var adapter = new System.Data.OleDb.OleDbDataAdapter(
                qrySecondPart, conn);
            adapter.Fill(ds);

            return ds.Tables[0];
        }
    }
}

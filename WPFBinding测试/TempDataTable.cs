using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WPFBinding测试
{
    public class TempDataTable
    {
        // DataTable 
        public DataTable tempDT;
        public TempDataTable()
        {
            InitializeTempDataTable();
        }
        /// <summary>
        /// 初始化内存表
        /// </summary>
        public void InitializeTempDataTable()
        {
            tempDT = new DataTable();
            tempDT.Columns.Add("DOC_ID", typeof(string));
            tempDT.Columns.Add("OBJ_WEI", typeof(string));
            tempDT.Columns.Add("FStatus", typeof(Int32));
            tempDT.Columns.Add("SCAN_TIME", typeof(DateTime));
            // tempDT.Columns.Add("DB_TIME", Type.GetType("System.String"));
        }
        public void AddRowData(List<string> paramList)
        {
            DataRow dr = tempDT.NewRow();
            dr["DOC_ID"] = paramList[0];
            dr["OBJ_WEI"] = paramList[1];
            dr["FStatus"] = Convert.ToInt32(paramList[2]);
            dr["SCAN_TIME"] = Convert.ToDateTime(paramList[3]);
            tempDT.Rows.Add(dr);
        }
    }
}

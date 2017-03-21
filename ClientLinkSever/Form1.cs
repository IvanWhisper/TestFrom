using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using System.IO;
using MS_SQLHelper;

namespace ClientLinkSever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource = GetList();
        }
        public  void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://10.20.23.199:8081/api/JsProducts");
            var request = new RestRequest(Method.GET);

            RestResponse response = (RestResponse)client.Execute(request);

            string content = response.Content; // raw content as string
            content = content.Replace("\"","");
            MessageBox.Show(DoAES.Decrypt(content));

            //MessageBox.Show(DoAES.Decrypt(content));
        }
        List<Product> GetList  ()
        {
            
            var client = new RestClient("http://10.20.23.199:8081/api/Products");
            var request = new RestRequest(Method.GET);
            RestResponse response = (RestResponse)client.Execute(request);
            string content = response.Content; // raw content as string
            //content = content.Remove(content.Length - 1, 1);
            //content = content.Remove(0, 1);
          //  string str = "wc0vv6i+VLjQcHxaET2731O/MNzTM2qdJCX/1lMJQ+WeOv3ba7eAOO9PIffE+KIjqDxCWVaixEflOTVbcZX6vcgCGBnCrv8dwvgXptUY3vc0bN4czTraA87TvHHhdumdKcGviODW9N0GpyNan5eWht1gh/7cKeGiNLXkIFW5LcqqJKooCjE2FcWwBDosWwxmT4bq+GxkwXu5k68qD/t1KePAwAszYRPWCNPpkOQxNaLhh0hURr6FNuur0hf6LcqMhKdgxL6tsj2dBMCn7WV2gmdMydBBGvXeqdVI5mCpcnhK/5SoK0yu4/ZIM8gPFN9cCszlBkHzIAkssFhFzEB6svP22ZUWtHRfTS7OlwAlC7EPK5Cww2JV/nnbD2uXkrMyrL0wl6n6IiPAexTKKdWccOk8R0vSIxXcQjXTcHOahLcidlzvR9TQFemp8sejm1HO84owKeX7+7ebm8TxZEn0WZIB/tP1auZ/FUzniN6/Ypcy/30hla2fCKQfYIYRU/ElVOP5QSDo/pInznH8iSeuMHZynQOypIgxg4zYPwxKwCSNRRW4z7pbks/m4mGOw3EJZAIgRFbBv0H6G+18t0r1xid1CkMiOYCl7adYSsjEw/M+PzgirnH6eHksaizhlgJCcncOFUwpEJ0hebchOXGcbnVXanf9gJD7dZJbpMjXZxYCkFvQiYBMvAT4RAxPji0l";

            //MessageBox.Show(DoAES.Decrypt(content));
            JsonSerializer serializer = new JsonSerializer();
            StringReader sr = new StringReader(content);
            object o = serializer.Deserialize(new JsonTextReader(sr), typeof(List<Product>));
            List<Product> list = o as List<Product>;
            return list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://10.20.23.199:8081/api/Products");
            var request = new RestRequest(Method.GET);
            RestResponse response = (RestResponse)client.Execute(request);
            var content = response.Content; // raw content as string

            MessageBox.Show(content);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://10.20.23.199:8081/api/JsProducts");
            var request = new RestRequest(Method.GET);
            RestResponse response = (RestResponse)client.Execute(request);
            var content = response.Content; // raw content as string
            
            string str = "wc0vv6i+VLjQcHxaET2731O/MNzTM2qdJCX/1lMJQ+WeOv3ba7eAOO9PIffE+KIjqDxCWVaixEflOTVbcZX6vcgCGBnCrv8dwvgXptUY3vc0bN4czTraA87TvHHhdumdKcGviODW9N0GpyNan5eWht1gh/7cKeGiNLXkIFW5LcqqJKooCjE2FcWwBDosWwxmT4bq+GxkwXu5k68qD/t1KePAwAszYRPWCNPpkOQxNaLhh0hURr6FNuur0hf6LcqMhKdgxL6tsj2dBMCn7WV2gmdMydBBGvXeqdVI5mCpcnhK/5SoK0yu4/ZIM8gPFN9cCszlBkHzIAkssFhFzEB6svP22ZUWtHRfTS7OlwAlC7EPK5Cww2JV/nnbD2uXkrMyrL0wl6n6IiPAexTKKdWccOk8R0vSIxXcQjXTcHOahLcidlzvR9TQFemp8sejm1HO84owKeX7+7ebm8TxZEn0WZIB/tP1auZ/FUzniN6/Ypcy/30hla2fCKQfYIYRU/ElVOP5QSDo/pInznH8iSeuMHZynQOypIgxg4zYPwxKwCSNRRW4z7pbks/m4mGOw3EJZAIgRFbBv0H6G+18t0r1xid1CkMiOYCl7adYSsjEw/M+PzgirnH6eHksaizhlgJCcncOFUwpEJ0hebchOXGcbnVXanf9gJD7dZJbpMjXZxYCkFvQiYBMvAT4RAxPji0l";
            MessageBox.Show(DoAES.Decrypt(str));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "[{\"Id\":1,\"pdid\":\"pdsb001\"}]";
            string aa = DoAES.Encrypt(str);
            MessageBox.Show(aa);
            string bb = DoAES.Decrypt(aa);
            MessageBox.Show(bb);

        }
        public DataTable GetDt()
        {
            DataTable dt = new DataTable();
            string con = "Data Source=.;Initial Catalog=TestApi;Persist Security Info=True;User ID=sa;Password=123456";
            string sqlstr = "select * from ProductInfo";
            dt = SqlHelper.ExecuteDataset(con, CommandType.Text, sqlstr).Tables[0];
            return dt;
        }
        public List<Product> GetProducts()
        {
            DataTable dt = GetDt();
            List<Product> listp = new List<Product>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Product pt = new Product();
                pt.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                pt.pdid = dt.Rows[i]["pdid"].ToString();
                pt.pdname = dt.Rows[i]["pdname"].ToString();
                pt.pdcate = dt.Rows[i]["pdcate"].ToString();
                pt.Price = Convert.ToDecimal(dt.Rows[i]["price"]);
                listp.Add(pt);
            }
            return listp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://10.20.23.199:8081/api/Str");
            var request = new RestRequest(Method.GET);
            RestResponse response = (RestResponse)client.Execute(request);

            string content = response.Content; // raw content as string

            MessageBox.Show(DoAES.Decrypt(content));
        }
    }
}

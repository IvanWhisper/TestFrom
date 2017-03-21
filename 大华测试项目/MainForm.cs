using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MvView.Scale;
using MvView.YunDa;

namespace 大华测试项目
{
    public partial class MainForm : Form
    {
        private static string _strMac = string.Empty;
        private static string _strDeviceID = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnMachinelink_Click(object sender, EventArgs e)
        {

        }
        public void Open()
        {
            if (!MvView.YunDa.DeviceManager.Instance.Initialization(string.Empty, "YaoHuaA7"))
            {
                MessageBox.Show(@"Initialization device failed");
            }

            if (_strMac == string.Empty)
            {
                _strMac = MvView.YunDa.DeviceManager.Instance.MacAddress;//MAC
            }

            if (_strDeviceID == string.Empty)
            {
                _strDeviceID = MvView.YunDa.DeviceManager.Instance.DeviceID;//客户端ID
            }

            if (!MvView.YunDa.DeviceManager.Instance.IsOpen)
            {
                if (!MvView.YunDa.DeviceManager.Instance.Open())
                {
                    //  LoadingState.Hide();
                    MessageBox.Show(@"启动设备失败");
                    //Environment.Exit(-1);
                }
            }
            if (MvView.YunDa.DeviceManager.Instance.IsOpen)
            {
                if (!MvView.YunDa.DeviceManager.Instance.Start())
                {
                    MessageBox.Show(@"打开设备对象失败");
                    //Environment.Exit(-1);
                }
                MvView.YunDa.DeviceManager.Instance.BarCodeHandle += GetBarCodeInfo;
                MvView.YunDa.DeviceManager.Instance.WeightHandle += GetWeightInfo;
                MvView.YunDa.DeviceManager.Instance.EmbraceHandle += GetCameraData;
            }
        }

        private void GetCameraData(object sender, EmbraceEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GetWeightInfo(object sender, WeightEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GetBarCodeInfo(object sender, BarCodeEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

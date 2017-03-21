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
using com.rotoac.ScannerSDK;
using System.IO;

namespace TestDaHua
{
    public partial class Form1 : Form
    {
        private static string _strMac = string.Empty;
        private static string _strDeviceID = string.Empty;

        private Control _parent;

        private string _lastBarcode = "";
        private Scanner _scanner;
        private readonly ScannerRule _rule = new ScannerRule();
        private readonly string _imageDir = Path.Combine(Environment.CurrentDirectory, "Image");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Open();
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
            //throw new NotImplementedException();
            MessageBox.Show("相机获取数据");
        }

        private void GetWeightInfo(object sender, WeightEventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show("磅秤获取数据");

        }

        private void GetBarCodeInfo(object sender, BarCodeEventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show("获取code数据");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { Strat(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                Strat();
        }
        void Strat()
        {
            // 重复时间
            _rule.DuplicateInterval = 2000;
            // 是否仅采集条码
            _rule.BarcodeOnly = false;
            // 条码规则，正则表达式
           _rule.RegexList = File.ReadAllLines("barcode.txt").ToList();


            _scanner = new Scanner(_rule)
            {
                ImageSavePath = _imageDir,
                SaveImage = true
            };
            _scanner.OnConnected += OnScanner_Connected;
            _scanner.OnDisconnected += OnScanner_Disconnected;
            _scanner.OnRetryConnect += OnScanner_RetryConntect;
            _scanner.OnBarcodeChecking += OnScanner_BarcodeChecking;
            _scanner.OnPicture += OnScanner_Picture;
            _scanner.OnBarcode += OnScanner_Barcode;
            _scanner.OnNewBarcode += OnScanner_NewBarcode;
            _scanner.OnBarcodeWeight += OnScanner_BarcodeWeight;
            _scanner.OnWeight += OnScanner_Weight;

        }

        private void OnScanner_Weight(string weight)
        {
            throw new NotImplementedException();
        }

        private void OnScanner_BarcodeWeight(string barcode, string weight)
        {
            throw new NotImplementedException();
        }

        private void OnScanner_NewBarcode(string barcode)
        {
            throw new NotImplementedException();
        }

        private void OnScanner_Barcode(string barcode)
        {
            throw new NotImplementedException();
        }

        private void OnScanner_Picture(Image image)
        {
            throw new NotImplementedException();
        }

        private bool OnScanner_BarcodeChecking(string barcode)
        {
            throw new NotImplementedException();
        }

        private void OnScanner_RetryConntect(DataChannel channel)
        {
            throw new NotImplementedException();
        }

        private void OnScanner_Disconnected(DataChannel channel)
        {
            throw new NotImplementedException();
        }

        private void OnScanner_Connected(DataChannel channel)
        {

            if (channel == DataChannel.Data)
                Invoke(new EventHandler((sender, e) =>
                {
                    lbMsg2.Text = @"OK";
                    lbMsg2.ForeColor = Color.Green;
                }), null, null);

            if (channel == DataChannel.Picture)
                Invoke(new EventHandler((sender, e) =>
                {
                    lbMsg1.Text = @"OK";
                    lbMsg1.ForeColor = Color.Green;
                }), null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }
    }

    }


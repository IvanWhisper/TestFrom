using DevExpress.LookAndFeel;
using DevExpress.XtraToolbox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dev主题皮肤
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
Dev皮肤名称：
DevExpress Style
DevExpress Dark Style
Metropolis
VS2010
Seven Classic
Office 2010 Blue
Office 2010 Black
Office 2010 Silver
Coffee
Liquid Sky
London Liquid Sky
Glass Oceans
Stardust
Xmas 2008 Blue
Valentine
McSkin
Summer 2008
Pumpkin
Dark Side
Springtime
Foggy
High Contrast
Seven
Sharp
Sharp Plus
The Asphalt World
Whiteprint
Caramel
Money Twins
Lilian
iMaginary
Black
Office 2007 Blue
Office 2007 Black
Office 2007 Silver
Office 2007 Green
Office 2007 Pink
Blue
Darkroom
Blueprint
    */
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"\Menu.ini");
            ToolboxGroup toolboxGroup = new ToolboxGroup();
            int i = toolboxGroup.Items.Count;
            while (sr.Peek() >= 0)
            {
                string ID = sr.ReadLine();
                ToolboxItem menuitem = new ToolboxItem();
                menuitem.Caption = ID;
                toolboxGroup.Items.Add(menuitem);
                menuitem.Tag = ID;
                i++;

            }
            toolboxControl1.Groups.Add(toolboxGroup);
            sr.Close();
        }
        //public static void favoriteIni(ToolboxControl favorite, string address, Dictionary<string, JToken> dicMenu)
        //{
        //    StreamReader sr = new StreamReader(address + "\\Menu.ini");
        //    int i = favorite.DropDownItems.Count;
        //    while (sr.Peek() >= 0)
        //    {
        //        string ID = sr.ReadLine();
        //        ToolStripMenuItem menuitem = new ToolStripMenuItem((string)dicMenu[ID]["name"]);
        //        favorite.DropDownItems.Insert(i, menuitem);
        //        menuitem.Tag = ID;
        //        i++;
        //    }
        //    sr.Close();
        //}

        private void toolboxControl1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace DockSample
{
    public partial class DummyToolbox : ToolWindow
    {
        public MainForm myParent;
        public DummyToolbox()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 检查同一窗体是否已经打开，如打开则直接激活 否则全新加载
        /// </summary>
        /// <returns></returns>
        private bool CheckForm(String FormName)
        {
            Control[] c = myParent.Controls.Find(FormName, true);
            if (c.Length > 0)
            {
                (c[0] as DockContent).Activate();
                return true;
            }
            else
            {
                return false;
            }
        }
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            String FormName = "test1";
            if (!CheckForm(FormName))
            {
                DummyDoc dummyDoc = new DummyDoc();
                dummyDoc.Name = FormName;
                dummyDoc.MdiParent = myParent;
                dummyDoc.Show(myParent.dockPanel);
            }
            //DummyDoc dummyDoc = new DummyDoc();
            ////if (myParent.dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            ////{
            ////    dummyDoc.MdiParent = this;
            ////    dummyDoc.Show();
            ////}
            ////else
            ////    dummyDoc.Show(myParent.dockPanel);

            //dummyDoc.MdiParent = myParent;
            //dummyDoc.Show(myParent.dockPanel);
        }

        public void SetAuth(DataSet dsAuth)
        {
            #region 设置大类权限
            int iCount = treeView1.Nodes.Count;
            for (int i = iCount - 1; i >= 0; i--)
            {
                foreach (DataRow dr in dsAuth.Tables["BIGCLASS"].Rows)
                {
                    if (treeView1.Nodes[i].Tag != null)
                    {
                        if (dr["TYPETAG"].ToString() == treeView1.Nodes[i].Tag.ToString())
                        {
                            treeView1.Nodes.RemoveAt(i);
                            break;
                        }
                    }
                }
            }

            #endregion

            #region 设置子权限
            foreach (TreeNode tn in treeView1.Nodes)
            {
                if (tn.Tag == null)
                    continue;

                int isCount = tn.Nodes.Count;
                for (int i = isCount - 1; i >= 0; i--)
                {
                    if (tn.Nodes[i].Tag == null)
                    { }
                    else
                    {
                        foreach (DataRow dr in dsAuth.Tables["SMALLROLE"].Rows)
                        {
                            if (dr["TYPETAG"].ToString() == tn.Tag.ToString() && dr["FUNCTAG"].ToString() == tn.Nodes[i].Tag.ToString())
                            {
                                tn.Nodes.RemoveAt(i);
                                break;
                            }
                        }
                    }
                    
                }
            }
            treeView1.Refresh();
            #endregion
        }
    }
}
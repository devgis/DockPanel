namespace DockSample
{
    partial class DummyToolbox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点7");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点8");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("节点9");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("节点10");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("节点11");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("节点12");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("节点13");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("节点1", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("节点2");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("节点3");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("节点6");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DummyToolbox));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点0";
            treeNode1.Tag = "ribbonTab1";
            treeNode1.Text = "节点0";
            treeNode2.Name = "节点7";
            treeNode2.Tag = "ribbonButton5";
            treeNode2.Text = "节点7";
            treeNode3.Name = "节点8";
            treeNode3.Tag = "ribbonButton4";
            treeNode3.Text = "节点8";
            treeNode4.Name = "节点9";
            treeNode4.Text = "节点9";
            treeNode5.Name = "节点10";
            treeNode5.Text = "节点10";
            treeNode6.Name = "节点11";
            treeNode6.Text = "节点11";
            treeNode7.Name = "节点12";
            treeNode7.Text = "节点12";
            treeNode8.Name = "节点13";
            treeNode8.Text = "节点13";
            treeNode9.Name = "节点1";
            treeNode9.Tag = "ribbonTab2";
            treeNode9.Text = "节点1";
            treeNode10.Name = "节点2";
            treeNode10.Text = "节点2";
            treeNode11.Name = "节点3";
            treeNode11.Text = "节点3";
            treeNode12.Name = "节点4";
            treeNode12.Text = "节点4";
            treeNode13.Name = "节点5";
            treeNode13.Text = "节点5";
            treeNode14.Name = "节点6";
            treeNode14.Text = "节点6";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(115, 340);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // DummyToolbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(115, 344);
            this.Controls.Add(this.treeView1);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DummyToolbox";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockLeftAutoHide;
            this.TabText = "导航";
            this.Text = "导航";
            this.ResumeLayout(false);

		}
		#endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TreeView treeView1;
    }
}
namespace 公寓管理系统
{
    partial class 学生管理系统帮助
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("数据备份与恢复");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("系统帮助", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("基本信息设置");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("学生信息管理");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("公寓维修管理");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("公寓住宿管理");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("业务帮助", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.HelpProvider helpProvider1;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Size = new System.Drawing.Size(970, 465);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "数据备份与恢复";
            treeNode2.Name = "节点0";
            treeNode2.Text = "系统帮助";
            treeNode3.Name = "节点6";
            treeNode3.Text = "基本信息设置";
            treeNode4.Name = "节点7";
            treeNode4.Text = "学生信息管理";
            treeNode5.Name = "节点8";
            treeNode5.Text = "公寓维修管理";
            treeNode6.Name = "节点9";
            treeNode6.Text = "公寓住宿管理";
            treeNode7.Name = "节点2";
            treeNode7.Text = "业务帮助";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(224, 441);
            this.treeView1.TabIndex = 0;
            // 
            // 学生管理系统帮助
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 465);
            this.Controls.Add(this.splitContainer1);
            this.Name = "学生管理系统帮助";
            this.Text = "学生管理系统帮助";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
    }
}
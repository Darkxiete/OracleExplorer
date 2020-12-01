using ICSharpCode.TextEditor;

namespace OracleExplorer
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.treeConnections = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lblConn = new System.Windows.Forms.Label();
            this.bnHelp = new System.Windows.Forms.Button();
            this.bnEdit = new System.Windows.Forms.Button();
            this.bnDelete = new System.Windows.Forms.Button();
            this.bnNew = new System.Windows.Forms.Button();
            this.bnExecute = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textEditorControl1 = new ICSharpCode.TextEditor.TextEditorControlEx();
            this.gridOutput = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // treeConnections
            // 
            this.treeConnections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeConnections.ImageIndex = 0;
            this.treeConnections.ImageList = this.imageList;
            this.treeConnections.Location = new System.Drawing.Point(8, 37);
            this.treeConnections.Name = "treeConnections";
            this.treeConnections.SelectedImageIndex = 0;
            this.treeConnections.Size = new System.Drawing.Size(232, 377);
            this.treeConnections.TabIndex = 3;
            this.treeConnections.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeConnections_AfterExpand);
            this.treeConnections.DoubleClick += new System.EventHandler(this.treeConnections_DoubleClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "");
            this.imageList.Images.SetKeyName(1, "");
            this.imageList.Images.SetKeyName(2, "");
            this.imageList.Images.SetKeyName(3, "table.png");
            this.imageList.Images.SetKeyName(4, "view.png");
            this.imageList.Images.SetKeyName(5, "");
            // 
            // lblConn
            // 
            this.lblConn.AutoSize = true;
            this.lblConn.Location = new System.Drawing.Point(352, 15);
            this.lblConn.Name = "lblConn";
            this.lblConn.Size = new System.Drawing.Size(71, 12);
            this.lblConn.TabIndex = 2;
            this.lblConn.Text = "Connection:";
            // 
            // bnHelp
            // 
            this.bnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnHelp.Image = global::OracleExplorer.OracleExplorer.Properties.Resource.help;
            this.bnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnHelp.Location = new System.Drawing.Point(696, 7);
            this.bnHelp.Name = "bnHelp";
            this.bnHelp.Size = new System.Drawing.Size(56, 22);
            this.bnHelp.TabIndex = 7;
            this.bnHelp.Text = "Help";
            this.bnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnHelp.UseVisualStyleBackColor = true;
            this.bnHelp.Click += new System.EventHandler(this.bnHelp_Click);
            // 
            // bnEdit
            // 
            this.bnEdit.Image = global::OracleExplorer.OracleExplorer.Properties.Resource.edit;
            this.bnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnEdit.Location = new System.Drawing.Point(144, 7);
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(48, 22);
            this.bnEdit.TabIndex = 2;
            this.bnEdit.Text = "Edit";
            this.bnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnEdit.UseVisualStyleBackColor = true;
            this.bnEdit.Click += new System.EventHandler(this.bnEdit_Click);
            // 
            // bnDelete
            // 
            this.bnDelete.Image = global::OracleExplorer.OracleExplorer.Properties.Resource.db_remove;
            this.bnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnDelete.Location = new System.Drawing.Point(72, 7);
            this.bnDelete.Name = "bnDelete";
            this.bnDelete.Size = new System.Drawing.Size(64, 22);
            this.bnDelete.TabIndex = 1;
            this.bnDelete.Text = "Delete";
            this.bnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnDelete.UseVisualStyleBackColor = true;
            this.bnDelete.Click += new System.EventHandler(this.bnDelete_Click);
            // 
            // bnNew
            // 
            this.bnNew.Image = global::OracleExplorer.OracleExplorer.Properties.Resource.db_add;
            this.bnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnNew.Location = new System.Drawing.Point(8, 7);
            this.bnNew.Name = "bnNew";
            this.bnNew.Size = new System.Drawing.Size(56, 22);
            this.bnNew.TabIndex = 0;
            this.bnNew.Text = "New";
            this.bnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnNew.UseVisualStyleBackColor = true;
            this.bnNew.Click += new System.EventHandler(this.bnNew_Click);
            // 
            // bnExecute
            // 
            this.bnExecute.Image = global::OracleExplorer.OracleExplorer.Properties.Resource.control_play_blue;
            this.bnExecute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnExecute.Location = new System.Drawing.Point(248, 7);
            this.bnExecute.Name = "bnExecute";
            this.bnExecute.Size = new System.Drawing.Size(96, 22);
            this.bnExecute.TabIndex = 4;
            this.bnExecute.Text = "Execute SQL";
            this.bnExecute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnExecute.UseVisualStyleBackColor = true;
            this.bnExecute.Click += new System.EventHandler(this.bnExecute_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(248, 37);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textEditorControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridOutput);
            this.splitContainer1.Size = new System.Drawing.Size(504, 377);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 9;
            // 
            // textEditorControl1
            // 
            this.textEditorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditorControl1.FoldingStrategy = "XML";
            this.textEditorControl1.Font = new System.Drawing.Font("Courier New", 10F);
            this.textEditorControl1.Location = new System.Drawing.Point(0, 0);
            this.textEditorControl1.Name = "textEditorControl1";
            this.textEditorControl1.Size = new System.Drawing.Size(504, 132);
            this.textEditorControl1.SyntaxHighlighting = "SQL";
            this.textEditorControl1.TabIndex = 9;
            // 
            // gridOutput
            // 
            this.gridOutput.AllowUserToAddRows = false;
            this.gridOutput.AllowUserToDeleteRows = false;
            this.gridOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOutput.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridOutput.Location = new System.Drawing.Point(0, 0);
            this.gridOutput.Name = "gridOutput";
            this.gridOutput.Size = new System.Drawing.Size(504, 241);
            this.gridOutput.TabIndex = 7;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 422);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bnHelp);
            this.Controls.Add(this.bnEdit);
            this.Controls.Add(this.bnDelete);
            this.Controls.Add(this.bnNew);
            this.Controls.Add(this.bnExecute);
            this.Controls.Add(this.lblConn);
            this.Controls.Add(this.treeConnections);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(558, 203);
            this.Name = "MainWindow";
            this.Text = "Oracle Explorer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeConnections;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label lblConn;
        private System.Windows.Forms.Button bnExecute;
        private System.Windows.Forms.Button bnNew;
        private System.Windows.Forms.Button bnDelete;
        private System.Windows.Forms.Button bnEdit;
        private System.Windows.Forms.Button bnHelp;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private TextEditorControlEx textEditorControl1;
        private System.Windows.Forms.DataGridView gridOutput;
    }
}


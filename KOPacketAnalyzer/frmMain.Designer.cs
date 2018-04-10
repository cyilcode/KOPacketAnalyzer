namespace KOPacketAnalyzer
{
    partial class frmMain
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
            this.txtPkt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pktDetails = new System.Windows.Forms.ListView();
            this.lstvHdrDataType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvHdrRange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvHdrHexRep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvHdrByteRep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvHdrTextRep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBeep = new System.Windows.Forms.CheckBox();
            this.lblState = new System.Windows.Forms.Label();
            this.btnParse = new System.Windows.Forms.Button();
            this.chkAllowedTypes = new System.Windows.Forms.CheckedListBox();
            this.chkSkipSubOpCode = new System.Windows.Forms.CheckBox();
            this.chkSkipOpcode = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPkt
            // 
            this.txtPkt.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkt.Location = new System.Drawing.Point(19, 53);
            this.txtPkt.Name = "txtPkt";
            this.txtPkt.Size = new System.Drawing.Size(811, 32);
            this.txtPkt.TabIndex = 0;
            this.txtPkt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPkt_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Packet as Hexadecimal String";
            // 
            // pktDetails
            // 
            this.pktDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstvHdrDataType,
            this.lstvHdrRange,
            this.lstvHdrHexRep,
            this.lstvHdrByteRep,
            this.lstvHdrTextRep});
            this.pktDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pktDetails.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pktDetails.FullRowSelect = true;
            this.pktDetails.GridLines = true;
            this.pktDetails.Location = new System.Drawing.Point(3, 16);
            this.pktDetails.MultiSelect = false;
            this.pktDetails.Name = "pktDetails";
            this.pktDetails.Size = new System.Drawing.Size(1575, 254);
            this.pktDetails.TabIndex = 2;
            this.pktDetails.UseCompatibleStateImageBehavior = false;
            this.pktDetails.View = System.Windows.Forms.View.Details;
            this.pktDetails.DoubleClick += new System.EventHandler(this.pktDetails_DoubleClick);
            // 
            // lstvHdrDataType
            // 
            this.lstvHdrDataType.Text = "Data Type";
            this.lstvHdrDataType.Width = 358;
            // 
            // lstvHdrRange
            // 
            this.lstvHdrRange.Text = "Range";
            this.lstvHdrRange.Width = 292;
            // 
            // lstvHdrHexRep
            // 
            this.lstvHdrHexRep.Text = "Hex Value";
            this.lstvHdrHexRep.Width = 450;
            // 
            // lstvHdrByteRep
            // 
            this.lstvHdrByteRep.Text = "Byte Value";
            this.lstvHdrByteRep.Width = 231;
            // 
            // lstvHdrTextRep
            // 
            this.lstvHdrTextRep.Text = "Char Value";
            this.lstvHdrTextRep.Width = 239;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkBeep);
            this.groupBox1.Controls.Add(this.lblState);
            this.groupBox1.Controls.Add(this.btnParse);
            this.groupBox1.Controls.Add(this.chkAllowedTypes);
            this.groupBox1.Controls.Add(this.chkSkipSubOpCode);
            this.groupBox1.Controls.Add(this.chkSkipOpcode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPkt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1581, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data and Settings";
            // 
            // chkBeep
            // 
            this.chkBeep.AutoSize = true;
            this.chkBeep.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBeep.Location = new System.Drawing.Point(338, 159);
            this.chkBeep.Name = "chkBeep";
            this.chkBeep.Size = new System.Drawing.Size(173, 28);
            this.chkBeep.TabIndex = 7;
            this.chkBeep.Text = "Beep on Copy";
            this.chkBeep.UseVisualStyleBackColor = true;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(836, 53);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(142, 24);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "State: Idle";
            // 
            // btnParse
            // 
            this.btnParse.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParse.Location = new System.Drawing.Point(541, 91);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(289, 96);
            this.btnParse.TabIndex = 5;
            this.btnParse.Text = "Parse Packet";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // chkAllowedTypes
            // 
            this.chkAllowedTypes.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllowedTypes.FormattingEnabled = true;
            this.chkAllowedTypes.Items.AddRange(new object[] {
            "byte",
            "int16",
            "int32",
            "int64"});
            this.chkAllowedTypes.Location = new System.Drawing.Point(19, 91);
            this.chkAllowedTypes.Name = "chkAllowedTypes";
            this.chkAllowedTypes.Size = new System.Drawing.Size(313, 85);
            this.chkAllowedTypes.TabIndex = 4;
            this.chkAllowedTypes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkAllowedTypes_KeyDown);
            // 
            // chkSkipSubOpCode
            // 
            this.chkSkipSubOpCode.AutoSize = true;
            this.chkSkipSubOpCode.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSkipSubOpCode.Location = new System.Drawing.Point(338, 125);
            this.chkSkipSubOpCode.Name = "chkSkipSubOpCode";
            this.chkSkipSubOpCode.Size = new System.Drawing.Size(197, 28);
            this.chkSkipSubOpCode.TabIndex = 3;
            this.chkSkipSubOpCode.Text = "Skip SubOpCode";
            this.chkSkipSubOpCode.UseVisualStyleBackColor = true;
            // 
            // chkSkipOpcode
            // 
            this.chkSkipOpcode.AutoSize = true;
            this.chkSkipOpcode.Checked = true;
            this.chkSkipOpcode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSkipOpcode.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSkipOpcode.Location = new System.Drawing.Point(338, 91);
            this.chkSkipOpcode.Name = "chkSkipOpcode";
            this.chkSkipOpcode.Size = new System.Drawing.Size(161, 28);
            this.chkSkipOpcode.TabIndex = 2;
            this.chkSkipOpcode.Text = "Skip OpCode";
            this.chkSkipOpcode.UseVisualStyleBackColor = true;
            this.chkSkipOpcode.CheckedChanged += new System.EventHandler(this.chkSkipOpcode_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pktDetails);
            this.groupBox2.Location = new System.Drawing.Point(12, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1581, 273);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "KOPacket Analyzer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPkt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView pktDetails;
        private System.Windows.Forms.ColumnHeader lstvHdrDataType;
        private System.Windows.Forms.ColumnHeader lstvHdrHexRep;
        private System.Windows.Forms.ColumnHeader lstvHdrRange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkSkipSubOpCode;
        private System.Windows.Forms.CheckBox chkSkipOpcode;
        private System.Windows.Forms.CheckedListBox chkAllowedTypes;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.ColumnHeader lstvHdrByteRep;
        private System.Windows.Forms.ColumnHeader lstvHdrTextRep;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.CheckBox chkBeep;
    }
}


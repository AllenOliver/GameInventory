namespace WindowsFormsApplication2
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.listViewCheckItems = new System.Windows.Forms.ListView();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.buttonTrade = new System.Windows.Forms.Button();
            this.textBoxScan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTradeValue = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listViewTotal = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewCheckItems
            // 
            this.listViewCheckItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewCheckItems.FullRowSelect = true;
            this.listViewCheckItems.Location = new System.Drawing.Point(20, 88);
            this.listViewCheckItems.MultiSelect = false;
            this.listViewCheckItems.Name = "listViewCheckItems";
            this.listViewCheckItems.Size = new System.Drawing.Size(1223, 615);
            this.listViewCheckItems.TabIndex = 0;
            this.listViewCheckItems.UseCompatibleStateImageBehavior = false;
            this.listViewCheckItems.SelectedIndexChanged += new System.EventHandler(this.listViewCheckItems_SelectedIndexChanged);
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCheckOut.Location = new System.Drawing.Point(1328, 720);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(121, 35);
            this.buttonCheckOut.TabIndex = 1;
            this.buttonCheckOut.Text = "Check Out";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdd.Location = new System.Drawing.Point(1047, 27);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 32);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxGameName
            // 
            this.textBoxGameName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxGameName.Enabled = false;
            this.textBoxGameName.Location = new System.Drawing.Point(799, 37);
            this.textBoxGameName.Name = "textBoxGameName";
            this.textBoxGameName.Size = new System.Drawing.Size(210, 22);
            this.textBoxGameName.TabIndex = 3;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxCustomerName.Enabled = false;
            this.textBoxCustomerName.Location = new System.Drawing.Point(354, 726);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(139, 22);
            this.textBoxCustomerName.TabIndex = 5;
            // 
            // buttonTrade
            // 
            this.buttonTrade.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonTrade.Location = new System.Drawing.Point(652, 720);
            this.buttonTrade.Name = "buttonTrade";
            this.buttonTrade.Size = new System.Drawing.Size(97, 35);
            this.buttonTrade.TabIndex = 4;
            this.buttonTrade.Text = "Apply Tade";
            this.buttonTrade.UseVisualStyleBackColor = true;
            this.buttonTrade.Click += new System.EventHandler(this.buttonTrade_Click);
            // 
            // textBoxScan
            // 
            this.textBoxScan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxScan.Location = new System.Drawing.Point(613, 37);
            this.textBoxScan.Name = "textBoxScan";
            this.textBoxScan.Size = new System.Drawing.Size(100, 22);
            this.textBoxScan.TabIndex = 6;
            this.textBoxScan.TextChanged += new System.EventHandler(this.textBoxScan_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(861, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Game Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Game ID";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxCustomerID.Location = new System.Drawing.Point(228, 726);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(100, 22);
            this.textBoxCustomerID.TabIndex = 9;
            this.textBoxCustomerID.TextChanged += new System.EventHandler(this.textBoxCustomerID_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 706);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 706);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 706);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Trade Value";
            // 
            // textBoxTradeValue
            // 
            this.textBoxTradeValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxTradeValue.Enabled = false;
            this.textBoxTradeValue.Location = new System.Drawing.Point(515, 726);
            this.textBoxTradeValue.Name = "textBoxTradeValue";
            this.textBoxTradeValue.Size = new System.Drawing.Size(100, 22);
            this.textBoxTradeValue.TabIndex = 12;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRemove.Location = new System.Drawing.Point(1172, 27);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 32);
            this.buttonRemove.TabIndex = 14;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listViewTotal
            // 
            this.listViewTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTotal.Location = new System.Drawing.Point(1266, 88);
            this.listViewTotal.Name = "listViewTotal";
            this.listViewTotal.Size = new System.Drawing.Size(639, 615);
            this.listViewTotal.TabIndex = 15;
            this.listViewTotal.UseCompatibleStateImageBehavior = false;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 786);
            this.Controls.Add(this.listViewTotal);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTradeValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxScan);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.buttonTrade);
            this.Controls.Add(this.textBoxGameName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.listViewCheckItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesForm";
            this.Text = "Check Out";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCheckItems;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxGameName;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Button buttonTrade;
        private System.Windows.Forms.TextBox textBoxScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTradeValue;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ListView listViewTotal;
    }
}
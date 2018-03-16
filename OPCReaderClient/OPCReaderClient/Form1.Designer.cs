namespace OPCReaderClient
{
    partial class OPCClient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Connect = new System.Windows.Forms.Button();
            this.DATABASECLIENT = new System.Windows.Forms.Label();
            this.OPCSERVER = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oPCServerConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPCServerConnectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Connect);
            this.panel1.Controls.Add(this.DATABASECLIENT);
            this.panel1.Controls.Add(this.OPCSERVER);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 511);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(4, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1061, 399);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EventLog";
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.Red;
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connect.Location = new System.Drawing.Point(146, 25);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(742, 68);
            this.Connect.TabIndex = 2;
            this.Connect.Text = "Dis-Connected";
            this.Connect.UseVisualStyleBackColor = false;
            // 
            // DATABASECLIENT
            // 
            this.DATABASECLIENT.AutoSize = true;
            this.DATABASECLIENT.Location = new System.Drawing.Point(12, 80);
            this.DATABASECLIENT.Name = "DATABASECLIENT";
            this.DATABASECLIENT.Size = new System.Drawing.Size(87, 13);
            this.DATABASECLIENT.TabIndex = 1;
            this.DATABASECLIENT.Text = "Database Server";
            // 
            // OPCSERVER
            // 
            this.OPCSERVER.AutoSize = true;
            this.OPCSERVER.Location = new System.Drawing.Point(894, 80);
            this.OPCSERVER.Name = "OPCSERVER";
            this.OPCSERVER.Size = new System.Drawing.Size(63, 13);
            this.OPCSERVER.TabIndex = 0;
            this.OPCSERVER.Text = "OPC Server";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.oPCServerConnectionBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1055, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // oPCServerConnectionBindingSource
            // 
            this.oPCServerConnectionBindingSource.DataSource = typeof(OPCReaderClient.Connections.OPCServerConnection);
            // 
            // OPCClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 511);
            this.Controls.Add(this.panel1);
            this.Name = "OPCClient";
            this.Text = "OPC Reader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPCServerConnectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label DATABASECLIENT;
        private System.Windows.Forms.Label OPCSERVER;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource oPCServerConnectionBindingSource;
    }
}


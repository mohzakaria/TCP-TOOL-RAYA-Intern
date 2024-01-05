
namespace TCPTOOL
{
    partial class Form1
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
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHostID = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.statustext = new System.Windows.Forms.TextBox();
            this.TCPIP = new System.Windows.Forms.GroupBox();
            this.AutoReply = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hexaserv = new System.Windows.Forms.TextBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.replymsg = new System.Windows.Forms.TextBox();
            this.replybtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.startbtn = new System.Windows.Forms.Button();
            this.Client = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hexclient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.disconnectbtn = new System.Windows.Forms.Button();
            this.statustxtclient = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.connectbtn = new System.Windows.Forms.Button();
            this.TXTMSG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientHost = new System.Windows.Forms.TextBox();
            this.ClientPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TCPIP.SuspendLayout();
            this.Client.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(17, 41);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(37, 17);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Host";
            this.lblHost.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHostID
            // 
            this.txtHostID.Location = new System.Drawing.Point(73, 36);
            this.txtHostID.Name = "txtHostID";
            this.txtHostID.Size = new System.Drawing.Size(190, 22);
            this.txtHostID.TabIndex = 1;
            this.txtHostID.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(362, 36);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(190, 22);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "12345";
            this.txtPort.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(291, 37);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(34, 17);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port";
            this.lblPort.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // statustext
            // 
            this.statustext.Location = new System.Drawing.Point(0, 400);
            this.statustext.Multiline = true;
            this.statustext.Name = "statustext";
            this.statustext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statustext.Size = new System.Drawing.Size(434, 139);
            this.statustext.TabIndex = 4;
            this.statustext.TextChanged += new System.EventHandler(this.statustext_TextChanged);
            // 
            // TCPIP
            // 
            this.TCPIP.Controls.Add(this.AutoReply);
            this.TCPIP.Controls.Add(this.label5);
            this.TCPIP.Controls.Add(this.label4);
            this.TCPIP.Controls.Add(this.hexaserv);
            this.TCPIP.Controls.Add(this.clearbtn);
            this.TCPIP.Controls.Add(this.replymsg);
            this.TCPIP.Controls.Add(this.replybtn);
            this.TCPIP.Controls.Add(this.stopbtn);
            this.TCPIP.Controls.Add(this.startbtn);
            this.TCPIP.Controls.Add(this.statustext);
            this.TCPIP.Controls.Add(this.lblHost);
            this.TCPIP.Controls.Add(this.txtHostID);
            this.TCPIP.Controls.Add(this.txtPort);
            this.TCPIP.Controls.Add(this.lblPort);
            this.TCPIP.Location = new System.Drawing.Point(12, 12);
            this.TCPIP.Name = "TCPIP";
            this.TCPIP.Size = new System.Drawing.Size(587, 738);
            this.TCPIP.TabIndex = 5;
            this.TCPIP.TabStop = false;
            this.TCPIP.Text = "Sever";
            this.TCPIP.Enter += new System.EventHandler(this.TCPIP_Enter);
            // 
            // AutoReply
            // 
            this.AutoReply.AutoSize = true;
            this.AutoReply.Location = new System.Drawing.Point(9, 121);
            this.AutoReply.Name = "AutoReply";
            this.AutoReply.Size = new System.Drawing.Size(99, 21);
            this.AutoReply.TabIndex = 14;
            this.AutoReply.Text = "Auto Reply";
            this.AutoReply.UseVisualStyleBackColor = true;
            this.AutoReply.CheckedChanged += new System.EventHandler(this.AutoReply_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 556);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hex Box";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Message Box";
            // 
            // hexaserv
            // 
            this.hexaserv.Location = new System.Drawing.Point(0, 576);
            this.hexaserv.Multiline = true;
            this.hexaserv.Name = "hexaserv";
            this.hexaserv.Size = new System.Drawing.Size(434, 139);
            this.hexaserv.TabIndex = 10;
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(110, 332);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 45);
            this.clearbtn.TabIndex = 9;
            this.clearbtn.Text = "clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // replymsg
            // 
            this.replymsg.Location = new System.Drawing.Point(6, 142);
            this.replymsg.Multiline = true;
            this.replymsg.Name = "replymsg";
            this.replymsg.Size = new System.Drawing.Size(546, 184);
            this.replymsg.TabIndex = 8;
            // 
            // replybtn
            // 
            this.replybtn.Location = new System.Drawing.Point(6, 332);
            this.replybtn.Name = "replybtn";
            this.replybtn.Size = new System.Drawing.Size(75, 45);
            this.replybtn.TabIndex = 7;
            this.replybtn.Text = "send";
            this.replybtn.UseVisualStyleBackColor = true;
            this.replybtn.Click += new System.EventHandler(this.replybtn_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.Location = new System.Drawing.Point(142, 70);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(85, 40);
            this.stopbtn.TabIndex = 6;
            this.stopbtn.Text = "Stop";
            this.stopbtn.UseVisualStyleBackColor = true;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(20, 70);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(93, 40);
            this.startbtn.TabIndex = 5;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // Client
            // 
            this.Client.Controls.Add(this.label6);
            this.Client.Controls.Add(this.hexclient);
            this.Client.Controls.Add(this.label3);
            this.Client.Controls.Add(this.disconnectbtn);
            this.Client.Controls.Add(this.statustxtclient);
            this.Client.Controls.Add(this.sendbtn);
            this.Client.Controls.Add(this.connectbtn);
            this.Client.Controls.Add(this.TXTMSG);
            this.Client.Controls.Add(this.label1);
            this.Client.Controls.Add(this.clientHost);
            this.Client.Controls.Add(this.ClientPort);
            this.Client.Controls.Add(this.label2);
            this.Client.Location = new System.Drawing.Point(605, 12);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(634, 738);
            this.Client.TabIndex = 6;
            this.Client.TabStop = false;
            this.Client.Text = "Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 556);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hex Box";
            // 
            // hexclient
            // 
            this.hexclient.Location = new System.Drawing.Point(20, 576);
            this.hexclient.Multiline = true;
            this.hexclient.Name = "hexclient";
            this.hexclient.Size = new System.Drawing.Size(489, 139);
            this.hexclient.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Message Box";
            // 
            // disconnectbtn
            // 
            this.disconnectbtn.Enabled = false;
            this.disconnectbtn.Location = new System.Drawing.Point(168, 66);
            this.disconnectbtn.Name = "disconnectbtn";
            this.disconnectbtn.Size = new System.Drawing.Size(103, 49);
            this.disconnectbtn.TabIndex = 7;
            this.disconnectbtn.Text = "Disconnect";
            this.disconnectbtn.UseVisualStyleBackColor = true;
            this.disconnectbtn.Visible = false;
            this.disconnectbtn.Click += new System.EventHandler(this.disconnectbtn_Click);
            // 
            // statustxtclient
            // 
            this.statustxtclient.Location = new System.Drawing.Point(20, 400);
            this.statustxtclient.Multiline = true;
            this.statustxtclient.Name = "statustxtclient";
            this.statustxtclient.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statustxtclient.Size = new System.Drawing.Size(489, 139);
            this.statustxtclient.TabIndex = 7;
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(20, 332);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(75, 45);
            this.sendbtn.TabIndex = 6;
            this.sendbtn.Text = "send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(69, 66);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(91, 49);
            this.connectbtn.TabIndex = 5;
            this.connectbtn.Text = "Connect";
            this.connectbtn.UseVisualStyleBackColor = true;
            this.connectbtn.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // TXTMSG
            // 
            this.TXTMSG.Location = new System.Drawing.Point(6, 142);
            this.TXTMSG.Multiline = true;
            this.TXTMSG.Name = "TXTMSG";
            this.TXTMSG.Size = new System.Drawing.Size(600, 184);
            this.TXTMSG.TabIndex = 4;
            this.TXTMSG.TextChanged += new System.EventHandler(this.TXTMSG_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // clientHost
            // 
            this.clientHost.Location = new System.Drawing.Point(69, 38);
            this.clientHost.Name = "clientHost";
            this.clientHost.Size = new System.Drawing.Size(190, 22);
            this.clientHost.TabIndex = 1;
            this.clientHost.Text = "127.0.0.1";
            // 
            // ClientPort
            // 
            this.ClientPort.Location = new System.Drawing.Point(352, 40);
            this.ClientPort.Name = "ClientPort";
            this.ClientPort.Size = new System.Drawing.Size(190, 22);
            this.ClientPort.TabIndex = 3;
            this.ClientPort.Text = "12345";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 851);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.TCPIP);
            this.Name = "Form1";
            this.Text = "TCPTOOL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TCPIP.ResumeLayout(false);
            this.TCPIP.PerformLayout();
            this.Client.ResumeLayout(false);
            this.Client.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHostID;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox statustext;
        private System.Windows.Forms.GroupBox TCPIP;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.GroupBox Client;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.TextBox TXTMSG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientHost;
        private System.Windows.Forms.TextBox ClientPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox statustxtclient;
        private System.Windows.Forms.Button disconnectbtn;
        private System.Windows.Forms.TextBox replymsg;
        private System.Windows.Forms.Button replybtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.TextBox hexaserv;
        private System.Windows.Forms.TextBox hexclient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox AutoReply;
    }
}


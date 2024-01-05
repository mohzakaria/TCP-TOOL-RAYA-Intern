using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;
using System.Data.SqlClient;

namespace TCPTOOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        SimpleTcpClient client;
        SimpleTcpClient server1;
        int count = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF32;
            server.DataReceived += DataReceived;
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF32;
            client.DataReceived +=client_DataReceived;
            server1 = new SimpleTcpClient();
            server1.StringEncoder = Encoding.UTF32;
            server1.DataReceived += client_DataReceived;

           

        }


        private void client_DataReceived(object sender, SimpleTCP.Message e)
        {
            statustxtclient.Invoke((MethodInvoker)delegate ()
                {
                 
                


                    if (connectbtn.Text == "connected")
                    {
                        
                        statustxtclient.Text += e.MessageString.Substring(0, e.MessageString.Length - 1)+"\r\n";
                        byte[] bac = Encoding.Default.GetBytes(e.MessageString);
                        hexclient.Text = BitConverter.ToString(bac);
                    }
                }
            );
        }
        ////////////////////////////////////////////////////////////////////////////
        private void DataReceived(object sender, SimpleTCP.Message e)

        {
            string checker;



            statustext.Invoke((MethodInvoker)delegate ()
            {

            statustext.Text += e.MessageString.Substring(0, e.MessageString.Length - 1) + "\r\n";
            e.ReplyLine(string.Format(e.MessageString.Substring(0, e.MessageString.Length - 1)));
            byte[] ba = Encoding.Default.GetBytes(e.MessageString);
            hexaserv.Text = BitConverter.ToString(ba);
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-96T5DV7\MSSQLSERVER01;Initial Catalog=Raya;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into SERVER(ip,dateandtime,message)values('" + txtHostID.Text + "','" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH: mm:ss") + "','" + e.MessageString.Substring(0, e.MessageString.Length - 1) + "')", con);
            SqlCommand cmd1 = new SqlCommand(e.MessageString.Substring(0, e.MessageString.Length - 1), con);
            int x = cmd.ExecuteNonQuery();
                int y = 0;
                try
                {
                    y = cmd1.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    if (AutoReply.Checked && count == 0)
                    {
                        server1.WriteLineAndGetReply("\nServer: A wrong query", TimeSpan.FromSeconds(0));
                        count =0;
                        AutoReply.Checked = false;
                        e.MessageString.Remove(0, e.MessageString.Length);
                    }
                }
             


                if (AutoReply.Checked && count == 0 )
                {
                   if(y!=0)
                    server1.WriteLineAndGetReply("\nServer: A correct query", TimeSpan.FromSeconds(0));
                    AutoReply.Checked = false;
                    count = 0;
                    e.MessageString.Remove(0, e.MessageString.Length);
                    
                }
                else if (AutoReply.Checked == false)
                {
                    count = 0;
                }
                
                
                
                
            }
            );
            



        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Server has started");
                IPAddress ip = IPAddress.Parse(txtHostID.Text);
                server.Start(ip, Convert.ToInt32(txtPort.Text));
                server1.Connect(txtHostID.Text, Convert.ToInt32(txtPort.Text));
            }
            catch (Exception w)
            {
                MessageBox.Show("Server has already started");
            }
        }
        private void stopbtn_Click(object sender, EventArgs e)
        {
            if (server.IsStarted) {
                server.Stop();
                connectbtn.Enabled = true;
                connectbtn.Text = "Connect";
            }
        }

        private void TCPIP_Enter(object sender, EventArgs e)
        {

        }

        private void connectbtn_Click(object sender, EventArgs e)
        {
            connectbtn.Enabled = false;
            try {
                connectbtn.Text = "connecting";
                client.Connect(clientHost.Text, Convert.ToInt32(ClientPort.Text));
                connectbtn.Text = "connected";
                disconnectbtn.Visible = true;
                disconnectbtn.Enabled = true;

            }
            catch (Exception ex)
            {
                connectbtn.Text = "Connect";
                MessageBox.Show("Wrong Configuration");
                connectbtn.Enabled = true;
            }
            

        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            if(connectbtn.Text == "connected")
            client.WriteLineAndGetReply("\n"+TXTMSG.Text, TimeSpan.FromSeconds(0));
        }

        private void disconnectbtn_Click(object sender, EventArgs e)
        {
           
                client.Disconnect();
                connectbtn.Enabled = true;
                connectbtn.Text = "Connect";
                disconnectbtn.Visible = false;
                disconnectbtn.Enabled = false;

            
        }

        private void replybtn_Click(object sender, EventArgs e)
        {
            server1.WriteLineAndGetReply("\nServer: "+replymsg.Text, TimeSpan.FromSeconds(0));
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            statustext.Text = " ";
            statustxtclient.Text = " ";
            TXTMSG.Text = " ";
            replymsg.Text = " ";
            hexaserv.Text = " ";
            hexclient.Text = " ";

        }

        private void statustext_TextChanged(object sender, EventArgs e)
        {

        }

        private void AutoReply_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void TXTMSG_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

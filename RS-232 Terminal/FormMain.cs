

// v02: Devon has nice working program.
// v06: Make BAUD = 115K work.
// v08: Add Loop Function

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;                  // For ManagementObjectSearcher port names
using System.Threading;
using System.Windows.Forms;
using System.IO;					// For INI file StreamReader
using System.IO.Ports;
using System.Drawing;               // For defining colors
using System.Text;                  // For stringbuilder
using System.Text.RegularExpressions;       //For Regex.Replace

namespace RS_232_Terminal

{
    public partial class FormMain : Form
	{

		SerialPort myPort = new SerialPort();
        string recv = null;             // Received response from GEN, ex: "OK"
        const int RCV_TIME_OUT = 2000;	// in milliseconds, value < 1000 doesn't do anything
		//string strTextPath;				// Path to INI file
		const string strIniPath = "GEN LAN Console Script INI.txt";

        private List<string> portList;      // v02 COM port list
        private List<string> baudList;      // v02 Baud rate list

		Color myLightViolet = Color.FromArgb(192, 192, 255);
		Color myPink = Color.FromArgb(255, 128, 255);
		Color myLightGreen = Color.FromArgb(37, 226, 27);
		Color myLightRed = Color.FromArgb(227, 74, 73);
		bool btnWasClicked = false;


		public FormMain()
		{
			//string inLine;
			InitializeComponent();

			this.KeyPreview = true;			// Enables form detecting if <ESC> pressed

			butnOpenPort.Enabled = true;
			butnWriteRead.Enabled = false;
            //butnWrite.Enabled = false;
			butnClosePort.Enabled = false;
			btnSingleOn.BackColor = myLightGreen;
			btnLoopOn.BackColor = myLightRed;
			rtbCmd.Text = "ADR 6";
			rtbCmd.Enabled = true;
			rtbScript.Enabled = true;
			rtbResults.Enabled = false;
			rtbHistory.Enabled = true;
			butnTextADR6.Enabled = true;
			butnTextFLT.Enabled = true;
			butnTextOUT_ON.Enabled = true;
			butnTextOUT_OFF.Enabled = true;
			butnTextRST.Enabled = true;
			#region Open_INI_File
			//strTextPath = Application.StartupPath;	   // Default path for TEXT files

			//if (File.Exists(strIniPath))
			//{
			//	StreamReader textReader = new StreamReader(strIniPath);
			//	while ((inLine = textReader.ReadLine()) != null)
			//	{
			//		inLine = StripComment(inLine).ToUpper();	// Strip comments after '//'
			//		if (String.IsNullOrWhiteSpace(inLine))
			//			continue;		               // Ignore lines if "//" is first characters
			//		else if (inLine.Contains("TEXT FILES PATH"))
			//			strTextPath = inLine.Substring(inLine.IndexOf(']') + 1).Trim();

			//		//else if (inLine.Contains("IP ADDRESS"))
			//			//targetComPort = inLine.Substring(inLine.IndexOf(']') + 1).Trim();
			//	}
			//	textReader.Close();
			//}
			#endregion
		}

		private void ComInit()
        {
            // v02:  Add pull down menu for COM port and Baud rate
            // Show list of valid com port friendly names in listbox

			int index;
            using (var searcher = new System.Management.ManagementObjectSearcher(
                                        "SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<System.Management.ManagementBaseObject>().ToList().Select(
                                        p => p["Caption"].ToString());

                portList = portnames.Select(n => n + " - " +
                                        ports.FirstOrDefault(s => s.Contains(n))).ToList();
				foreach (string sItem in portList)
				{		// Shorten friendly name by removing trailing "(COMn)"
					index = sItem.IndexOf("(");
					if (index > 3)
						cboxPortSelect.Items.Add(sItem.Substring(0, index).Trim());
					else
						cboxPortSelect.Items.Add(sItem);		// No parenthesis found, keep long name
				}
            }

            labComPort.Select();		// Remove focus from combo box
			//index = 0;
			//index = cboxPortSelect.SelectedIndex;
			//if (index == -1 & cboxPortSelect.Items.Count > 0)
			//{
			//	cboxPortSelect.SelectedIndex = 0;
			//}

            // v02 Auto-Selct USB Serial 
            int index2 = 0;
            foreach(string sItem in portList)
            {
                if (sItem.Contains("USB"))
                    cboxPortSelect.SelectedIndex = index2;
                index2++;
            }

            // Show list of Baud rates
            baudList = new List<string>() { "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            foreach (string sItem in baudList)
            {
				cboxBaudSelect.Items.Add(sItem.ToString());
//				cboxBaudSelect.Invoke(new Action(() => cboxBaudSelect.Items.Add(sItem.ToString()))); ;
            }
            cboxBaudSelect.SelectedIndex = 2;
        }

		private void butnOpenPort_Click(object sender, EventArgs e)
		{
            Cursor.Current = Cursors.WaitCursor;		// Set cursor as spinning ring
			labComPort.Select();						// Otherwise, the COM port box may get highlighted

			try
            {
                subErrorReset();                        // Clear the error message indicators

					// Pull COM from pulldown menu
                string comName = cboxPortSelect.SelectedItem.ToString();
					// Example comName = "COM3 - USB Serial Port"
					//				     "COM1 - Communications Port"
				string targetComPort = comName.Substring(0, comName.IndexOf(" "));
                targetComPort = targetComPort.Trim();

					// Pull Baud rate from pulldown menu
                string targetBaudRate = cboxBaudSelect.Text;
                targetBaudRate = targetBaudRate.Trim();

					// Print COM and Baud
				rtbHistory.Text += "\n" + "OPEN: " + targetComPort
					+ "     Baud: " + targetBaudRate + ".\n";

					// Open RS-232 COM port to power supply 
                myPort.PortName = targetComPort;
                myPort.BaudRate = Convert.ToInt32(targetBaudRate);
                myPort.NewLine = "\r";
                myPort.ReadTimeout = RCV_TIME_OUT;      // Read TMO = 2.0 Sec
                myPort.Open();
                rtbHistory.SelectionStart = rtbHistory.Text.Length;
                rtbHistory.ScrollToCaret();            // Scroll to bottom

					// Enable buttons
                butnOpenPort.Enabled = false;
				butnOpenPort.BackColor = myLightViolet;
                butnWriteRead.Enabled = true;
				butnWriteRead.BackColor = myPink;
                butnClosePort.Enabled = true;
				butnClosePort.BackColor = Color.Coral;
					// Disable port selects
				cboxPortSelect.Enabled = false;
				cboxBaudSelect.Enabled = false;
				return;
            }
            catch (Exception ex)
			{
                rtbHistory.Text += "*** Could Not Open Port ***\n";
                rtbHistory.Text += ex.Message;
				subErrorShow(ex);
			}
			finally
			{
				Cursor.Current = Cursors.Default;		// Set cursor as default arrow
			}
		}

        private void FormMain_Load(object sender, EventArgs e)
        {
			butnOpenPort.Enabled = true;
			butnOpenPort.BackColor = Color.Lime;

			butnWriteRead.Enabled = false;
			butnWriteRead.BackColor = myLightViolet;
			butnClosePort.Enabled = false;
			butnClosePort.BackColor = myLightViolet;

			// Populate the ComPort combo listbox
            ComInit();
			return;
        }

 		private void butnRead_Click(object sender, EventArgs e)
		{
			try
			{
				subErrorReset();						// Clear the error message indicators
				Cursor.Current = Cursors.WaitCursor;	// Set cursor as spinning ring

					// Read the response
				rtbHistory.Text += " READ :  ";         // Show something, even if exception (TMO) occurs
                recv = myPort.ReadLine();

					// Put response string into textbox
				rtbHistory.Text += recv + "\n";		    // Finish READ line in text box
				Cursor.Current = Cursors.Default;		// Set cursor as default arrow
				rtbHistory.SelectionStart = rtbHistory.Text.Length;
				rtbHistory.ScrollToCaret();             // Scroll to bottom

				rtbCmd.SelectAll();						// v02 Highlight input text after Read
                rtbCmd.Focus();
                return;
			}
            catch (TimeoutException ex)
            {
                rtbHistory.Text += "**** TMO ERROR ****";
                subErrorShow(ex);
            }
            catch (Exception ex)
			{
				subErrorShow(ex);
			}
		}

        private void butnWriteRead_Click(object sender, EventArgs e)
        {
            try
            {
                subErrorReset();                        // Clear the error message indicators

					// Write
                string strCmd = rtbCmd.Text;
				//strCmd = strCmd.Trim();
					// Add checksum to cmd if button is set to ADD 
					//   and if there is not already a checksum in the cmd
				if (butnAddChecksum.Text == "ADD CS" && strCmd.Contains("$") == false)
				{
					strCmd = strCmd + "$" + CalcChecksum(strCmd);
					rtbCmd.Text = strCmd;
				}

                rtbHistory.Text += "WRITE-:  " + rtbCmd.Text + "\n";
                rtbHistory.SelectionStart = rtbHistory.Text.Length;
                rtbHistory.ScrollToCaret();             // Scroll to bottom                                              
                myPort.WriteLine(strCmd);
                Thread.Sleep(50);

					//Read
                Cursor.Current = Cursors.WaitCursor;    // Set cursor as spinning ring                                                        
                rtbHistory.Text += " READ :  ";         // Show something. even if exception (TMO) occurs
                recv = myPort.ReadLine();

					// Put response string into textbox
                rtbHistory.Text += recv + "\n";         // Finish READ line in text box

				// Look for checksum in response, verify it if found
				if (recv.Contains("$"))
				{
					string[] parts = recv.Split('$');
					string recvData = parts[0];
					string recvCS = parts[1];
					string expectCS = CalcChecksum( recvData);
					if (recvCS != expectCS)
					{
						cboxErrorLED.Checked = true;
						tboxErrorHex.Text = "NO NUMB";    // "00000000";
						tboxErrorMsg.Text = "Recvd bad CheckSum." + "\nExpect '$" + expectCS + "'.";
					}
				}

                Cursor.Current = Cursors.Default;       // Set cursor as default arrow
                rtbHistory.SelectionStart = rtbHistory.Text.Length;
                rtbHistory.ScrollToCaret();             // Scroll to bottom

					// v02 Highlight Text after Write/Read
                rtbCmd.SelectAll();
                rtbCmd.Focus();
                return;
            }
            catch (TimeoutException ex)
            {
                rtbHistory.Text += "**** TMO ERROR ****";
                subErrorShow(ex);
            }
            catch (Exception ex)
            {
                subErrorShow(ex);
            }
        }

        private void butnClosePort_Click(object sender, EventArgs e)
		{
			try
			{
				subErrorReset();						// Clear the error message indicators
				myPort.Close();

					// If closed with no exception...
				rtbHistory.Text += "PORT CLOSED." + "\n";
				rtbHistory.SelectionStart = rtbHistory.Text.Length;
				rtbHistory.ScrollToCaret();		        // Scroll to bottom

					// Disable buttons
				butnOpenPort.Enabled = true;
				butnOpenPort.BackColor = Color.Lime;
				butnWriteRead.Enabled = false;
				butnWriteRead.BackColor = myLightViolet;
				butnClosePort.Enabled = false;
				butnClosePort.BackColor = myLightViolet;
					// Enable port selects
				cboxPortSelect.Enabled = true;
				cboxBaudSelect.Enabled = true;
				return;
			}
			catch (Exception ex)
			{
				subErrorShow(ex);
			}
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (myPort != null)
			{
				if (myPort.IsOpen)
					myPort.Close();
				myPort.Dispose();
			}

		}

	

		private void subErrorReset()
		{
			cboxErrorLED.Checked = false;
			tboxErrorHex.Text = "0";	// "00000000";
			tboxErrorMsg.Text = "";
			return;
		}

		private void subErrorShow(Exception exx )
		{
			cboxErrorLED.Checked = true;
			tboxErrorHex.Text = exx.HResult.ToString();
			tboxErrorMsg.Text = exx.Message;

			if (exx.HResult == -2147467259)
			{	rtbHistory.Text += "         (Error)" + exx.HResult.ToString() + "  (TMO)\n";
			}
			else
			{	rtbHistory.Text += "         (Error)" + exx.HResult.ToString() + "\n";
			}
			rtbHistory.SelectionStart = rtbHistory.Text.Length;
			rtbHistory.ScrollToCaret();		// Scroll to bottom
			return;
		}

		private void rtbCmd_KeyDown(object sender, KeyEventArgs e)
		{	// If <Enter> pressed while in Cmd text box, send and read the cmd
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;	// Silence the bell because multi-line <Enter> not allowed
				butnWriteRead_Click(this, new EventArgs()); 
			}
			return;
		}

		//private void tboxCOM_KeyDown(object sender, KeyEventArgs e)
		//{	// If <Enter> pressed while in COM Port text box, OPEN the port.
		//	if (e.KeyCode == Keys.Enter)
		//	{
		//			e.SuppressKeyPress = true;	// Silence the bell because multi-line <Enter> not allowed
		//			butnOpenPort_Click(this, new EventArgs());
		//	}
		//	return;
		//}

		private void butnClearText_Click(object sender, EventArgs e)
		{
			rtbHistory.Text = "";
		}

		private void butnTextIDN_Click(object sender, EventArgs e)
		{
			rtbCmd.Text = "IDN?";
            butnWriteRead_Click(this, new EventArgs());
        }

		private void butnTextSTT_Click(object sender, EventArgs e)
		{
			rtbCmd.Text = "STT?";
            butnWriteRead_Click(this, new EventArgs());
        }

		private void butnTextRST_Click(object sender, EventArgs e)
		{
			rtbCmd.Text = "RST";
            butnWriteRead_Click(this, new EventArgs());
        }

		private void butnTextOutOn_Click(object sender, EventArgs e)
		{
			rtbCmd.Text = "OUT ON";
            butnWriteRead_Click(this, new EventArgs());
        }

		private void butnTextOutOff_Click(object sender, EventArgs e)
		{
			rtbCmd.Text = "OUT OFF";
			butnWriteRead_Click(this, new EventArgs());
		}

		private void butnTextMV_Click(object sender, EventArgs e)
		{
			rtbCmd.Text = "MV?";
            butnWriteRead_Click(this, new EventArgs());
        }

		private void butnTextMC_Click(object sender, EventArgs e)
		{
			rtbCmd.Text = "MC?";
            butnWriteRead_Click(this, new EventArgs());
        }

		private void butnTextADR6_Click(object sender, EventArgs e)
		{
			rtbCmd.Text = "ADR 6";
            butnWriteRead_Click(this, new EventArgs());
		}

		private void butnTextMode_Click(object sender, EventArgs e)
		{
			rtbCmd.Text = "MODE?";
			butnWriteRead_Click(this, new EventArgs());
		}

		private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
		{		// If <ESC> pressed anywhere on form
			if (e.KeyChar == 27 )		// Escape key = 27 ASCII
			{
				//rtbCmd.SelectAll();
				//rtbCmd.Focus();
				btnWasClicked = true;
				Thread.Sleep(500);
				btnWasClicked = false;

			}
			return;
		}

		private void butnTextFLT_Click(object sender, EventArgs e)
		{
			rtbCmd.Text = "FLT?";
			butnWriteRead_Click(this, new EventArgs());
		}

		private void butnTextFFLT_Click(object sender, EventArgs e)
		{
			byte[] recvBinChars = new byte[50];
			// Close serial port that always adds <CR> terminator
			myPort.Close();
			SerialPort binPort = new SerialPort();

			try
			{
				//byte[] sendBinChars = new byte[] { 0x86, 0x86 };
				rtbCmd.Text = "0x86 0x86";

				string comName = cboxPortSelect.SelectedItem.ToString();
				string targetComPort = comName.Substring(0, comName.IndexOf(" "));
				targetComPort = targetComPort.Trim();
				binPort.PortName = targetComPort;

				string targetBaudRate = cboxBaudSelect.Text;
				targetBaudRate = targetBaudRate.Trim();
				binPort.BaudRate = Convert.ToInt16(targetBaudRate);
				// Open new port for binary data with no terminator
				binPort.Open();
				binPort.Write(new byte[] { 0x86, 0x86 }, 0, 2);		// Write 2 bytes: Fast Register Read

				rtbHistory.Text += "WRITE-:  <86><86> (Fast Read Regs)" + "\n";
				Thread.Sleep(50);
				int recvCount = binPort.BytesToRead;
				if (recvCount < 16 )
				{	throw new Exception("Read fast reg returned less tahn 16 chars");
				}
				binPort.Read(recvBinChars, 0, 50);

				StringBuilder sbPrintStr = new StringBuilder();
				int n = 0;
				while (recvBinChars[n] != 13 && recvBinChars[n] != 0)
				{
					sbPrintStr.Append(Convert.ToChar(recvBinChars[n]).ToString());
					if (n == 1 || n == 3 || n == 5 || n == 7 || n == 9 || n == 11)
					{
						sbPrintStr.Append(" ");
					}
					n++;
				}

				rtbHistory.Text += " READ :  ";         // Show something. even if exception (TMO) occurs
														// Put response string into textbox
				rtbHistory.Text += sbPrintStr.ToString() + "\n";    // Finish READ line in text box
				rtbHistory.SelectionStart = rtbHistory.Text.Length;
				rtbHistory.ScrollToCaret();             // Scroll to bottom
														// v02 Highlight Text after Write/Read
				rtbCmd.SelectAll();
				rtbCmd.Focus();

			}
			catch (Exception )
			{
				rtbHistory.Text += " READ :  <ERROR>" + "\n";	// Show something. even if exception (TMO) occurs
			}
			try
			{
				Thread.Sleep(10);
				binPort.Close();
				Thread.Sleep(10);
				// Open original port with <CR> terminators
				myPort.Open();
			}
			catch (Exception)
			{
				rtbHistory.Text += "ERROR :  Cannot re-open port";  // Show something. even if exception (TMO) occurs
			}
		}
		private void cboxBaudSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			// After Baud selected, remove selection highlight
			labBaudRate.Focus();
		}

		private void cboxPortSelect_MouseLeave(object sender, EventArgs e)
		{
			// After Port selected, remove selection highlight
			labBaudRate.Focus();
		}
		private void butnClearBuffers_Click(object sender, EventArgs e)
		{
			if (myPort is null || (myPort.IsOpen == false))
				return;

			if (myPort.BytesToRead != 0)
			{
				//Read
				Cursor.Current = Cursors.WaitCursor;    // Set cursor as spinning ring                                                        
				rtbHistory.Text += "+READ :  ";         // Show something. even if exception (TMO) occurs
				recv = myPort.ReadLine();

				// Put response string into textbox
				rtbHistory.Text += recv + "\n";         // Finish READ line in text box
				Cursor.Current = Cursors.Default;       // Set cursor as default arrow
				rtbHistory.SelectionStart = rtbHistory.Text.Length;
				rtbHistory.ScrollToCaret();             // Scroll to bottom
			}
			myPort.DiscardInBuffer();
			myPort.DiscardOutBuffer();
		}

		private void butnAddChecksum_Click(object sender, EventArgs e)
		{
			if (butnAddChecksum.Text == "ADD CS")
				butnAddChecksum.Text = "NO CS";
			else
				butnAddChecksum.Text = "ADD CS";
		}
		private string CalcChecksum( string strInput)
		{	// Return 2-Hex char calculated checksum for input string
			UInt32 intSum = 0;

			byte[] bytesAscii = System.Text.Encoding.ASCII.GetBytes(strInput);
			foreach (uint byteAscii in bytesAscii)
				intSum += byteAscii;

			string strChecksum = String.Format("{0:X02}", intSum & 0xFF);
			return (strChecksum);
		}

        private void rtbHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void tlpBiggest_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labComPort_Click(object sender, EventArgs e)
        {

        }

        private void btnSingleOn_Click(object sender, EventArgs e)
        {
			btnSingleOn.BackColor = myLightGreen;
			btnLoopOn.BackColor = myLightRed;
			//rtbCmd.Text = "";
			rtbCmd.Enabled = true;
			//rtbScript.Enabled = false;
			rtbResults.Enabled = false;
			rtbHistory.Enabled = true;
			butnWriteRead.Enabled = true;
			butnTextADR6.Enabled = true;
			butnTextFLT.Enabled = true;
			butnTextOUT_ON.Enabled = true;
			butnTextOUT_OFF.Enabled = true;
			butnTextRST.Enabled = true;
			btnWasClicked = false;
		}

        private void btnLoopOn_Click(object sender, EventArgs e)
        {
			btnSingleOn.BackColor = myLightRed;
			Thread.Sleep(10);
			btnLoopOn.BackColor = myLightGreen;
			btnWasClicked = false;
			rtbCmd.Enabled = false;
			rtbScript.Enabled = true;
			rtbResults.Enabled = true;
			rtbHistory.Enabled = false;
			butnWriteRead.Enabled = false;
			butnTextADR6.Enabled = false;
			butnTextFLT.Enabled = false;
			butnTextOUT_ON.Enabled = false;
			butnTextOUT_OFF.Enabled = false;
			butnTextRST.Enabled = false;
			Thread.Sleep(10);
			string strResp = "";
			//rtbResults.Text = "";
			//rtbResults.Refresh();
			int mSec;
			int i = 0;
			String txtLoopCount = rtbLoopCount.Text;
			int loopCount = int.Parse(txtLoopCount);
			if (txtLoopCount == "inf")
            {
				i = 100;
            }
			try
			{
				btnSingleOn.BackColor = myLightRed;
				string[] saryCmds = rtbScript.Text.Split('\n');
				//for (int i = 0; i < saryCmds.Length; i++)
				while (btnWasClicked | i < loopCount)
                {
					foreach (string strCmd in saryCmds)
					{
						if (String.IsNullOrWhiteSpace(strCmd) || strCmd.Trim().Length < 1)
						{
							rtbResults.Text = "\n";
							rtbResults.Refresh();
						}
						else if (strCmd.ToUpper().IndexOf("WAIT") >= 0)
						{
							int.TryParse(Regex.Replace(strCmd, "[^0-9]+", string.Empty), out mSec);
							Thread.Sleep(mSec);
							rtbResults.Text = "...\n";
							rtbResults.Refresh();
						}
						else if (btnWasClicked)
                        {
							break;
                        }
						else
                        {
							myPort.WriteLine(strCmd);
							Thread.Sleep(2);
							strResp = myPort.ReadLine();
							rtbResults.Text = strResp.Trim() + '\n';
							rtbResults.Refresh();
							
						}
					}
					if (txtLoopCount == "inf")
					{
						i = 100;
					}
					else
					{
						i++;
					}
				}

			}

			catch (TimeoutException ex)
			{
				rtbResults.Text = "<TMO>" + '\n';
				rtbResults.Refresh();
				MessageBox.Show("ERROR: Serial Port Timeout.\n" +
								ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show("ERROR: \n" +
								ex.Message);
				return;
			}
            return;
		}

        private void rtbScript_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbResults_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbCmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }	// End of: class FormMain
}

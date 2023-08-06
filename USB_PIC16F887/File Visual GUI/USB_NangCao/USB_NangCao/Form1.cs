using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UsbLibrary;

namespace USB_NangCao
{
    public partial class Form1 : Form
    {
        int count = 0;
        byte[] readbuff = new byte[65];
        // Bo dem chua du lieu doc va ghi. Mang gom 65 byte de gui du lieu 64 byte
        byte[] writebuff = new byte[65];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.usbHidPort.VendorId = 0x04d8; // Vendor ID cua thiet bi (Microchip)
            this.usbHidPort.ProductId = 0x0001; // Product ID cua thiet bi (PIC18F4550)
            this.usbHidPort.CheckDevicePresent(); // Kiem tra su co mat cua thiet bi
            if (this.usbHidPort.SpecifiedDevice != null)
            {
                this.usbHidPort.SpecifiedDevice.SendData(writebuff);
            }
            textBox_VID.Text = usbHidPort.VendorId.ToString("x4");
            // Hien thi Vendor ID cua thiet bi
            textBox_PID.Text = usbHidPort.ProductId.ToString("x4");
            // Hien thi Product ID cua thiet bi
        }

        private void button_Exit_Click_1(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to exit the program?",
                             "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button_ON_Click_1(object sender, EventArgs e)
        {
            writebuff[1] = 1; // Thong tin device dieu khien bat LED
            //---------------------------------------------
            if (this.usbHidPort.SpecifiedDevice != null)
                this.usbHidPort.SpecifiedDevice.SendData(writebuff);
            // Gui du lieu tu Byte[1] den Byte[64].
            else
            {
                MessageBox.Show("Device not found. Please reconnect USB device to use.",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Thong bao loi neu chua tim thay thiet bi USB tuong thich.
            }
        }

        private void button_OFF_Click_1(object sender, EventArgs e)
        {
            writebuff[1] = 0; // Thong tin device dieu khien tat LED
            //---------------------------------------------
            if (this.usbHidPort.SpecifiedDevice != null)
                this.usbHidPort.SpecifiedDevice.SendData(writebuff);
            // Gui du lieu tu Byte[1] den Byte[64].
            else
            {
                MessageBox.Show("Device not found. Please reconnect USB device to use.",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Thong bao loi neu chua tim thay thiet bi USB tuong thich.
            }
        }

        private void usbHidPort_OnSpecifiedDeviceArrived(object sender, EventArgs e)
        {
            toolStripStatusLabel_InforDevice.Text = "Device Detected";
            // Hien thi thong tin tren ToolStrip.
            textBox_Status.Text = "Connected!";
            // Hien thi thong tin tren TextBox.
            textBox_Status.BackColor = Color.Lime;
            // Doi mau thong tin tren TextBox.
            textBox_SW1.Text = "0"; // Hien thi gia tri ban dau cua so lan nhan SW
            ovalShape_LED.BackColor = Color.DarkGray;
            ovalShape_LED2.BackColor = Color.DarkGray;
        }

        private void usbHidPort_OnSpecifiedDeviceRemoved(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler(usbHidPort_OnSpecifiedDeviceRemoved), new object[] {
                sender, e });
            }
            else
            {
                toolStripStatusLabel_InforDevice.Text = "Device Disconnected";
                textBox_Status.Text = "Disconnected!!";
                textBox_Status.BackColor = Color.Red;
            }
        }

        private void usbHidPort_OnDeviceArrived(object sender, EventArgs e)
        {
            toolStripStatusLabel_InforDevice.Text = "USB Connected";
        }

        private void usbHidPort_OnDeviceRemoved(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler(usbHidPort_OnDeviceRemoved), new object[] { sender, e });
            }
            else
            {
                toolStripStatusLabel_InforDevice.Text = "USB Removed";
            }
        }

        private void usbHidPort_OnDataRecieved(object sender, UsbLibrary.DataRecievedEventArgs args)
        {
            if (InvokeRequired)
            {
                try
                {
                     Invoke(new DataRecievedEventHandler(usbHidPort_OnDataRecieved), new
                     object[] { sender, args });
                }
                catch
                { }
            }
            else
            {
                readbuff = args.data;
                // Nhan du lieu tu thiet bi, Byte[0] duoc bo qua, du lieu bat dau tu Byte[1].
                toolStripStatusLabel_InforDevice.Text = "New Received Data";
                if (readbuff[1] == 'S')
                {
                    count++;
                }
                //--------------------------------------------------------------------------
                textBox_SW1.Text = count.ToString(); // Hien thi gia tri so lan nhan SW
                //--------------------------------------------------------------------------
                if (readbuff[1] == 'O') // Dieu chinh mau doi tuong theo du lieu LED sang
                {
                    ovalShape_LED.BackColor = Color.Yellow;
                }
                else if (readbuff[1] == 'F') // Dieu chinh mau doi tuong theo du lieu LED tat
                {
                    ovalShape_LED.BackColor = Color.DarkGray;
                }
                //--------------------------------------------------------------------------
                else if (readbuff[1] == 'Q') // Dieu chinh mau doi tuong theo du lieu LED sang
                {
                    ovalShape_LED2.BackColor = Color.Yellow;
                }
                else if (readbuff[1] == 'W') // Dieu chinh mau doi tuong theo du lieu LED tat
                {
                    ovalShape_LED2.BackColor = Color.DarkGray;
                }
                else if (readbuff[1] == 'B') // Dieu chinh mau doi tuong theo du lieu LED sang
                {
                    ovalShape_LED2.BackColor = Color.Yellow;
                }
                else if (readbuff[1] == 'T') // Dieu chinh mau doi tuong theo du lieu LED tat
                {
                    ovalShape_LED2.BackColor = Color.DarkGray;
                }         
            }
        }

        private void usbHidPort_OnDataSend(object sender, EventArgs e)
        {
            toolStripStatusLabel_InforDevice.Text = "Data sent";
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            usbHidPort.RegisterHandle(Handle);
        }
        protected override void WndProc(ref Message m)
        {
            usbHidPort.ParseMessages(ref m);
            base.WndProc(ref m); // pass message on to base form
        }

        private void button_ON2_Click(object sender, EventArgs e)
        {
            writebuff[1] = 2; // Thong tin device dieu khien bat LED
            //---------------------------------------------
            if (this.usbHidPort.SpecifiedDevice != null)
                this.usbHidPort.SpecifiedDevice.SendData(writebuff);
            // Gui du lieu tu Byte[1] den Byte[64].
            else
            {
                MessageBox.Show("Device not found. Please reconnect USB device to use.",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Thong bao loi neu chua tim thay thiet bi USB tuong thich.
            }
        }

        private void button_OFF2_Click(object sender, EventArgs e)
        {
            writebuff[1] = 3; // Thong tin device dieu khien tat LED
            //---------------------------------------------
            if (this.usbHidPort.SpecifiedDevice != null)
                this.usbHidPort.SpecifiedDevice.SendData(writebuff);
            // Gui du lieu tu Byte[1] den Byte[64].
            else
            {
                MessageBox.Show("Device not found. Please reconnect USB device to use.",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Thong bao loi neu chua tim thay thiet bi USB tuong thich.
            }
        }

    }
}

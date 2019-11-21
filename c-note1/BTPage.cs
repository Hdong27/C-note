using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace c_note1
{
    public partial class BTPage : Form
    {
        note_P child1 = new note_P();

        public BTPage()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataRecieved); //데이터 받을때의 이벤트 생성
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = txtBoxRecievePort.Text; //포트 이름 설정. txtBoxRecievePort의 텍스트 값으로 설정
            serialPort1.BaudRate = 9600; //통신속도를 9600으로 설정합니다.
            try
            {
                if (!serialPort1.IsOpen) serialPort1.Open(); //만약 포트가 열려있지 않다면 엽시다.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //예외일 때 보여주기
            }
        }

        delegate void SetTextHandler(string message);
        public void SetText(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new SetTextHandler(SetText), message);
            }
            else
            {
                txtBoxReceive.AppendText(message); //txtBoxReceive 맨밑에 message 적기
                txtBoxReceive.ScrollToCaret(); //자동으로 맨 밑 내용 보여주기

                // txtBoxReceive.Text = message; //텍스트박스 내용을 바로 message로 바꾸고싶은 경우.
            }
        }

        public void DataRecieved(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort spl = (SerialPort)sender;
                string recievedData = spl.ReadLine();
                SetText("Data" + " : " + recievedData + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("데이타 리시브 실패\n\r" + ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        //델리게이트 선언
        public delegate void FormSendDataHandler(string sendstring);
        //이벤트 생성
        public event FormSendDataHandler FormSendEvent;

        private void txtBoxReceive_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //델리게이트 이벤트를통해 폼1(부모폼)으로 데이터 전송
                this.FormSendEvent("1");
            }
            catch
            {

            }
        }
    }
}
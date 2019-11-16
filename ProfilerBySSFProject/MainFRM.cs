using System;

using System.Drawing;

using System.Threading;

using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.IO;

namespace ProfilerBySSFProject
{
    public partial class MainFRM : Form
    {

        public MainFRM()
        {
            InitializeComponent();
        }

        private void MainFRM_Load(object sender, EventArgs e)
        {

            #region Camera Init
            m_bInitSDK = CHCNetSDK.NET_DVR_Init();
            if (m_bInitSDK == false)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("NET_DVR_Init error!");
                return;
            }
            else
            {
                CHCNetSDK.NET_DVR_SetLogToFile(3, ".", true);

                for (int i = 0; i < 64; i++)
                {
                    iIPDevID[i] = -1;
                    iChannelNum[i] = -1;
                }
            } 
            #endregion

            this.Cursor = Cursors.Default;
        }


      
        private void MainFRM_FormClosing(object sender,
            FormClosingEventArgs e) // هنگام خروج از برنامه
        {
           
        }


        #region Camera Setup
        private bool m_bInitSDK = false;
        private bool m_bRecord = false;
        private uint iLastErr = 0;
        private Int32 camera_id = -1;
        private Int32 camera_handle = -1;

        private Int32 i = 0;
        private Int32 m_lTree = 0;
        private string str;
        private long iSelIndex = 0;
        private uint dwAChanTotalNum = 0;
        private Int32 m_lPort = -1;
        private IntPtr m_ptrRealHandle;
        private int[] iIPDevID = new int[96];
        private int[] iChannelNum = new int[96];

        public CHCNetSDK.REALDATACALLBACK RealData = null;
        public CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo_top;

        public CHCNetSDK.NET_DVR_IPPARACFG_V40 m_struIpParaCfgV40;
        public CHCNetSDK.NET_DVR_STREAM_MODE m_struStreamMode;
        public CHCNetSDK.NET_DVR_IPCHANINFO m_struChanInfo;
        public CHCNetSDK.NET_DVR_IPCHANINFO_V40 m_struChanInfoV40;
        private PlayCtrl.DECCBFUN m_fDisplayFun = null;


        public delegate void MyDebugInfo(string str);

        public void InfoIPChannel()
        {
            uint dwSize = (uint)Marshal.SizeOf(m_struIpParaCfgV40);

            IntPtr ptrIpParaCfgV40 = Marshal.AllocHGlobal((Int32)dwSize);
            Marshal.StructureToPtr(m_struIpParaCfgV40, ptrIpParaCfgV40, false);

            uint dwReturn = 0;
            int iGroupNo = 0;
            if (!CHCNetSDK.NET_DVR_GetDVRConfig(camera_id, CHCNetSDK.NET_DVR_GET_IPPARACFG_V40, iGroupNo, ptrIpParaCfgV40, dwSize, ref dwReturn))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_GET_IPPARACFG_V40 failed, error code= " + iLastErr;
                //获取IP资源配置信息失败，输出错误号 Failed to get configuration of IP channels and output the error code
                DebugInfo(str);
            }
            else
            {
                DebugInfo("NET_DVR_GET_IPPARACFG_V40 succ!");

                m_struIpParaCfgV40 = (CHCNetSDK.NET_DVR_IPPARACFG_V40)Marshal.PtrToStructure(ptrIpParaCfgV40, typeof(CHCNetSDK.NET_DVR_IPPARACFG_V40));

                for (i = 0; i < dwAChanTotalNum; i++)
                {
                    ListAnalogChannel(i + 1, m_struIpParaCfgV40.byAnalogChanEnable[i]);
                    iChannelNum[i] = i + (int)DeviceInfo_top.byStartChan;
                }

                byte byStreamType;
                for (i = 0; i < m_struIpParaCfgV40.dwDChanNum; i++)
                {
                    iChannelNum[i + dwAChanTotalNum] = i + (int)m_struIpParaCfgV40.dwStartDChan;
                    byStreamType = m_struIpParaCfgV40.struStreamMode[i].byGetStreamType;

                    dwSize = (uint)Marshal.SizeOf(m_struIpParaCfgV40.struStreamMode[i].uGetStream);
                    switch (byStreamType)
                    {
                        //目前NVR仅支持直接从设备取流 NVR supports only the mode: get stream from device directly
                        case 0:
                            IntPtr ptrChanInfo = Marshal.AllocHGlobal((Int32)dwSize);
                            Marshal.StructureToPtr(m_struIpParaCfgV40.struStreamMode[i].uGetStream, ptrChanInfo, false);
                            m_struChanInfo = (CHCNetSDK.NET_DVR_IPCHANINFO)Marshal.PtrToStructure(ptrChanInfo, typeof(CHCNetSDK.NET_DVR_IPCHANINFO));

                            //列出IP通道 List the IP channel
                            ListIPChannel(i + 1, m_struChanInfo.byEnable, m_struChanInfo.byIPID);
                            iIPDevID[i] = m_struChanInfo.byIPID + m_struChanInfo.byIPIDHigh * 256 - iGroupNo * 64 - 1;

                            Marshal.FreeHGlobal(ptrChanInfo);
                            break;

                        case 6:
                            IntPtr ptrChanInfoV40 = Marshal.AllocHGlobal((Int32)dwSize);
                            Marshal.StructureToPtr(m_struIpParaCfgV40.struStreamMode[i].uGetStream, ptrChanInfoV40, false);
                            m_struChanInfoV40 = (CHCNetSDK.NET_DVR_IPCHANINFO_V40)Marshal.PtrToStructure(ptrChanInfoV40, typeof(CHCNetSDK.NET_DVR_IPCHANINFO_V40));

                            //列出IP通道 List the IP channel
                            ListIPChannel(i + 1, m_struChanInfoV40.byEnable, m_struChanInfoV40.wIPID);
                            iIPDevID[i] = m_struChanInfoV40.wIPID - iGroupNo * 64 - 1;

                            Marshal.FreeHGlobal(ptrChanInfoV40);
                            break;

                        default:
                            break;
                    }
                }
            }
            Marshal.FreeHGlobal(ptrIpParaCfgV40);
        }

        public void ListIPChannel(Int32 iChanNo, byte byOnline, int byIPID)
        {

        }

        public void ListAnalogChannel(Int32 iChanNo, byte byEnable)
        {

        }

        private void listViewIPChannel_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewIPChannel.SelectedItems.Count > 0)
            {
                iSelIndex = listViewIPChannel.SelectedItems[0].Index;  //当前选中的行
            }
        }

        //解码回调函数
        private void DecCallbackFUN(int nPort, IntPtr pBuf, int nSize, ref PlayCtrl.FRAME_INFO pFrameInfo, int nReserved1, int nReserved2)
        {
            // 将pBuf解码后视频输入写入文件中（解码后YUV数据量极大，尤其是高清码流，不建议在回调函数中处理）
            if (pFrameInfo.nType == 3) //#define T_YV12	3
            {
            }
        }

        private void StartLiveView()
        {
            // نمایش زنده ویدیو ها  // Video Live
            CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfoA = new CHCNetSDK.NET_DVR_PREVIEWINFO();
            lpPreviewInfoA.hPlayWnd = picCamLeft.Handle;//预览窗口 live view window
            lpPreviewInfoA.lChannel = iChannelNum[(int)iSelIndex];//预览的设备通道 the device channel number
            lpPreviewInfoA.dwStreamType = 0;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
            lpPreviewInfoA.dwLinkMode = 0;//连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP
            lpPreviewInfoA.bBlocked = true; //0- 非阻塞取流，1- 阻塞取流

            IntPtr pUser = IntPtr.Zero;//用户数据 user data

            if (true)
            {
                //打开预览 Start live view
                camera_handle = CHCNetSDK.NET_DVR_RealPlay_V40(camera_id, ref lpPreviewInfoA, null/*RealData*/, pUser);
            }
        }

        private void StopLiveView()
        {
            try
            {
                CHCNetSDK.NET_DVR_StopRealPlay(camera_handle);
                camera_handle = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Happned !!!\n" + ex.Message );

                return;
            }
        }

        private void ConnectToCamera()
        {
            try
            {
                string ip_address_top = txtIPAddress.Text;

                Int16 DVRPortNumber = 8000;
                string DVRUserName = txtUsername.Text;
                string DVRPassword = txtPassword.Text;
                //登录设备 Login the device
                camera_id = CHCNetSDK.NET_DVR_Login_V30(ip_address_top, DVRPortNumber, DVRUserName, DVRPassword, ref DeviceInfo_top);
                dwAChanTotalNum = (uint)DeviceInfo_top.byChanNum;

                for (i = 0; i < dwAChanTotalNum; i++)
                {
                    ListAnalogChannel(i + 1, 1);
                    iChannelNum[i] = i + (int)DeviceInfo_top.byStartChan;
                }
                if (camera_id < 0)
                {
                    if (MessageBox.Show("IP Cameras Connecting Error", "Fatal Error - IP Camera", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        btnStart_Click(null, null);
                        return;
                    }
                }
                if (m_bRecord)
                {
                    MessageBox.Show("Please stop recording firstly!");
                    return;
                }
                if (camera_handle < 0)
                {
                    //  StartLiveView();

                    if (camera_handle < 0)
                    {
                        iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                        str = "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr; //预览失败，输出错误号 failed to start live view, and output the error code.
                        DebugInfo(str);
                        return;
                    }
                    else
                    {
                        //预览成功
                        DebugInfo("NET_DVR_RealPlay_V40 succ!");
                        // btnStart.Text = "Stop View";
                    }
                }
                else
                {
                    //停止预览 Stop live view
                    if (!CHCNetSDK.NET_DVR_StopRealPlay(camera_handle))
                    {
                        iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                        str = "NET_DVR_StopRealPlay failed, error code= " + iLastErr;
                        DebugInfo(str);
                        return;
                    }

                    if ((true) && (m_lPort >= 0))
                    {
                        if (!PlayCtrl.PlayM4_Stop(m_lPort))
                        {
                            iLastErr = PlayCtrl.PlayM4_GetLastError(m_lPort);
                            str = "PlayM4_Stop failed, error code= " + iLastErr;
                            DebugInfo(str);
                        }
                        if (!PlayCtrl.PlayM4_CloseStream(m_lPort))
                        {
                            iLastErr = PlayCtrl.PlayM4_GetLastError(m_lPort);
                            str = "PlayM4_CloseStream failed, error code= " + iLastErr;
                            DebugInfo(str);
                        }
                        if (!PlayCtrl.PlayM4_FreePort(m_lPort))
                        {
                            iLastErr = PlayCtrl.PlayM4_GetLastError(m_lPort);
                            str = "PlayM4_FreePort failed, error code= " + iLastErr;
                            DebugInfo(str);
                        }
                        m_lPort = -1;
                    }

                    DebugInfo("NET_DVR_StopRealPlay succ!");
                    camera_handle = -1;
                    //btnStart.Text= "Live View";
                    picCamLeft.Invalidate();//刷新窗口 refresh the window
                }
            }
            catch
            {
                //btnStart.Enabled = true;
                //btnStop.Enabled = false;
                MessageBox.Show("Error in Connecting Camera\nContact SSF Groups");
                Application.Exit();
                this.Close();
                return;
            }

            //btnStart.Enabled = false;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (camera_id < 0)
            {
                MessageBox.Show("Please login the device firstly!");
                return;
            }

            if (m_bRecord)
            {
                MessageBox.Show("Please stop recording firstly!");
                return;
            }
            //    MessageBox.Show();
            if (camera_handle < 0)
            {
                CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                lpPreviewInfo.hPlayWnd = picCamLeft.Handle;//预览窗口 live view window
                lpPreviewInfo.lChannel = iChannelNum[(int)iSelIndex];//预览的设备通道 the device channel number
                lpPreviewInfo.dwStreamType = 0;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
                lpPreviewInfo.dwLinkMode = 0;//连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP
                lpPreviewInfo.bBlocked = true; //0- 非阻塞取流，1- 阻塞取流

                IntPtr pUser = IntPtr.Zero;//用户数据 user data

                if (true)
                {
                    //打开预览 Start live view
                    camera_handle = CHCNetSDK.NET_DVR_RealPlay_V40(camera_id, ref lpPreviewInfo, null/*RealData*/, pUser);
                }
                else
                {
                    lpPreviewInfo.hPlayWnd = IntPtr.Zero;//预览窗口 live view window
                    m_ptrRealHandle = picCamLeft.Handle;
                    RealData = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack);//预览实时流回调函数 real-time stream callback function
                    camera_handle = CHCNetSDK.NET_DVR_RealPlay_V40(camera_id, ref lpPreviewInfo, RealData, pUser);
                }

                if (camera_handle < 0)
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr; //预览失败，输出错误号 failed to start live view, and output the error code.
                    DebugInfo(str);
                    return;
                }
                else
                {
                    //预览成功
                    DebugInfo("NET_DVR_RealPlay_V40 succ!");
                    //btnPreview.Text = "Stop View";
                }
            }
            else
            {
                //停止预览 Stop live view
                if (!CHCNetSDK.NET_DVR_StopRealPlay(camera_handle))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_StopRealPlay failed, error code= " + iLastErr;
                    DebugInfo(str);
                    return;
                }

                if ((true) && (m_lPort >= 0))
                {
                    if (!PlayCtrl.PlayM4_Stop(m_lPort))
                    {
                        iLastErr = PlayCtrl.PlayM4_GetLastError(m_lPort);
                        str = "PlayM4_Stop failed, error code= " + iLastErr;
                        DebugInfo(str);
                    }
                    if (!PlayCtrl.PlayM4_CloseStream(m_lPort))
                    {
                        iLastErr = PlayCtrl.PlayM4_GetLastError(m_lPort);
                        str = "PlayM4_CloseStream failed, error code= " + iLastErr;
                        DebugInfo(str);
                    }
                    if (!PlayCtrl.PlayM4_FreePort(m_lPort))
                    {
                        iLastErr = PlayCtrl.PlayM4_GetLastError(m_lPort);
                        str = "PlayM4_FreePort failed, error code= " + iLastErr;
                        DebugInfo(str);
                    }
                    m_lPort = -1;
                }

                DebugInfo("NET_DVR_StopRealPlay succ!");
                camera_handle = -1;
                // btnPreview.Text = "Live View";
                picCamLeft.Invalidate();//刷新窗口 refresh the window
            }
            return;
        }

        private void btnJPEG_Click(object sender, EventArgs e)
        {
            int lChannel = iChannelNum[(int)iSelIndex]; //通道号 Channel number

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara.wPicQuality = 0; //图像质量 Image quality
            lpJpegPara.wPicSize = 0xff; //抓图分辨率 Picture size: 0xff-Auto(使用当前码流分辨率)
                                        //抓图分辨率需要设备支持，更多取值请参考SDK文档

            //JPEG抓图保存成文件 Capture a JPEG picture
            string sJpegPicFileName;
            sJpegPicFileName = "filetest.jpg";//图片保存路径和文件名 the path and file name to save

            if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(camera_id, lChannel, ref lpJpegPara, sJpegPicFileName))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_CaptureJPEGPicture failed, error code= " + iLastErr;
                DebugInfo(str);
                return;
            }
            else
            {
                str = "NET_DVR_CaptureJPEGPicture succ and the saved file is " + sJpegPicFileName;
                DebugInfo(str);
            }

            //JEPG抓图，数据保存在缓冲区中 Capture a JPEG picture and save in the buffer
            uint iBuffSize = 400000; //缓冲区大小需要不小于一张图片数据的大小 The buffer size should not be less than the picture size
            byte[] byJpegPicBuffer = new byte[iBuffSize];
            uint dwSizeReturned = 0;

            if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture_NEW(camera_id, lChannel, ref lpJpegPara, byJpegPicBuffer, iBuffSize, ref dwSizeReturned))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_CaptureJPEGPicture_NEW failed, error code= " + iLastErr;
                DebugInfo(str);
                return;
            }
            else
            {
                //将缓冲区里的JPEG图片数据写入文件 save the data into a file
                string str = "buffertest.jpg";
                FileStream fs = new FileStream(str, FileMode.Create);
                int iLen = (int)dwSizeReturned;
                fs.Write(byJpegPicBuffer, 0, iLen);
                fs.Close();

                str = "NET_DVR_CaptureJPEGPicture_NEW succ and save the data in buffer to 'buffertest.jpg'.";
                DebugInfo(str);
            }

            return;
        }

        private void cameraExit()
        {
            //停止预览
            if (camera_handle >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(camera_handle);
                camera_handle = -1;
            }

            //注销登录
            if (camera_id >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(camera_id);
                camera_id = -1;
            }

            CHCNetSDK.NET_DVR_Cleanup();

            Application.Exit();
        }

        public void start_Shown(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            m_bInitSDK = CHCNetSDK.NET_DVR_Init();
            if (m_bInitSDK == false)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("NET_DVR_Init error!");
                return;
            }
            else
            {
                //保存SDK日志 To save the SDK log
                CHCNetSDK.NET_DVR_SetLogToFile(3, ".", true);

                //comboBoxView.SelectedIndex = 0;

                for (int i = 0; i < 64; i++)
                {
                    iIPDevID[i] = -1;
                    iChannelNum[i] = -1;
                }
            }
        }

        public void DebugInfo(string str)
        {
            if (str.Length > 0)
            {
                str += "\n";
                // TextBoxInfo.AppendText(str);
            }
        }

        public void RealDataCallBack(Int32 lRealHandle, UInt32 dwDataType, IntPtr pBuffer, UInt32 dwBufSize, IntPtr pUser)
        {
            MyDebugInfo AlarmInfo = new MyDebugInfo(DebugInfo);
            switch (dwDataType)
            {
                case CHCNetSDK.NET_DVR_SYSHEAD:     // sys head
                    if (dwBufSize > 0)
                    {
                        //获取播放句柄 Get the port to play
                        if (!PlayCtrl.PlayM4_GetPort(ref m_lPort))
                        {
                            iLastErr = PlayCtrl.PlayM4_GetLastError(m_lPort);
                            str = "PlayM4_GetPort failed, error code= " + iLastErr;
                            this.BeginInvoke(AlarmInfo, str);
                            break;
                        }

                        //设置流播放模式 Set the stream mode: real-time stream mode
                        if (!PlayCtrl.PlayM4_SetStreamOpenMode(m_lPort, PlayCtrl.STREAME_REALTIME))
                        {
                            iLastErr = PlayCtrl.PlayM4_GetLastError(m_lPort);
                            str = "Set STREAME_REALTIME mode failed, error code= " + iLastErr;
                            this.BeginInvoke(AlarmInfo, str);
                        }

                        //打开码流，送入头数据 Open stream
                        if (!PlayCtrl.PlayM4_OpenStream(m_lPort, pBuffer, dwBufSize, 2 * 1024 * 1024))
                        {
                            iLastErr = PlayCtrl.PlayM4_GetLastError(m_lPort);
                            str = "PlayM4_OpenStream failed, error code= " + iLastErr;
                            this.BeginInvoke(AlarmInfo, str);
                            break;
                        }

                        //设置显示缓冲区个数 Set the display buffer number
                        if (!PlayCtrl.PlayM4_SetDisplayBuf(m_lPort, 15))
                        {
                            iLastErr = PlayCtrl.PlayM4_GetLastError(m_lPort);
                            str = "PlayM4_SetDisplayBuf failed, error code= " + iLastErr;
                            this.BeginInvoke(AlarmInfo, str);
                        }

                        //设置显示模式 Set the display mode
                        if (!PlayCtrl.PlayM4_SetOverlayMode(m_lPort, 0, 0/* COLORREF(0)*/)) //play off screen
                        {
                            iLastErr = PlayCtrl.PlayM4_GetLastError(m_lPort);
                            str = "PlayM4_SetOverlayMode failed, error code= " + iLastErr;
                            this.BeginInvoke(AlarmInfo, str);
                        }

                        //设置解码回调函数，获取解码后音视频原始数据 Set callback function of decoded data
                        m_fDisplayFun = new PlayCtrl.DECCBFUN(DecCallbackFUN);
                        if (!PlayCtrl.PlayM4_SetDecCallBackEx(m_lPort, m_fDisplayFun, IntPtr.Zero, 0))
                        {
                            this.BeginInvoke(AlarmInfo, "PlayM4_SetDisplayCallBack fail");
                        }

                        //开始解码 Start to play
                        if (!PlayCtrl.PlayM4_Play(m_lPort, m_ptrRealHandle))
                        {
                            iLastErr = PlayCtrl.PlayM4_GetLastError(m_lPort);
                            str = "PlayM4_Play failed, error code= " + iLastErr;
                            this.BeginInvoke(AlarmInfo, str);
                            break;
                        }
                    }
                    break;

                case CHCNetSDK.NET_DVR_STREAMDATA:     // video stream data
                    if (dwBufSize > 0 && m_lPort != -1)
                    {
                        for (int i = 0; i < 999; i++)
                        {
                            //送入码流数据进行解码 Input the stream data to decode
                            if (!PlayCtrl.PlayM4_InputData(m_lPort, pBuffer, dwBufSize))
                            {
                                iLastErr = PlayCtrl.PlayM4_GetLastError(m_lPort);
                                str = "PlayM4_InputData failed, error code= " + iLastErr;
                                Thread.Sleep(2);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    break;

                default:
                    if (dwBufSize > 0 && m_lPort != -1)
                    {
                        //送入其他数据 Input the other data
                        for (int i = 0; i < 999; i++)
                        {
                            if (!PlayCtrl.PlayM4_InputData(m_lPort, pBuffer, dwBufSize))
                            {
                                iLastErr = PlayCtrl.PlayM4_GetLastError(m_lPort);
                                str = "PlayM4_InputData failed, error code= " + iLastErr;
                                Thread.Sleep(2);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    break;
            }
        }

        private void CameraDisconnect()
        {
            listViewIPChannel.Items.Clear();//清空通道列表 Clean up the channel list
            CHCNetSDK.NET_DVR_Logout(camera_id);
            camera_id = -1;
        }

        private int m_lRealHandle = -1;

        private void playOnBig(int userid)
        {
            CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
            picCamLeft.Visible = true;
            CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfoBig = new CHCNetSDK.NET_DVR_PREVIEWINFO();
            lpPreviewInfoBig.hPlayWnd = picCamLeft.Handle;//预览窗口 live view window
            lpPreviewInfoBig.lChannel = iChannelNum[(int)iSelIndex];//预览的设备通道 the device channel number
            lpPreviewInfoBig.dwStreamType = 0;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
            lpPreviewInfoBig.dwLinkMode = 0;//连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP
            lpPreviewInfoBig.bBlocked = true; //0- 非阻塞取流，1- 阻塞取流
            IntPtr pUser = IntPtr.Zero;//用户数据 user data
            m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V40(userid, ref lpPreviewInfoBig, null/*RealData*/, pUser);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
        }

        private bool CameraRunning = false;


        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (!CameraRunning)
            {
                this.Cursor = Cursors.WaitCursor;
                StopLiveView();
                CameraDisconnect();
                ConnectToCamera();
                playOnBig(camera_id);
                this.Cursor = Cursors.Default;
                CameraRunning = true;
                picCamLeft.Visible = true;
            }
            else
            {
                CameraRunning = false;
                StopLiveView();
                CameraDisconnect();
                picCamLeft.Visible = false;
            }
        }







        private string[] filenamesdroped;

        private void MainFRM_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                filenamesdroped = (string[])e.Data.GetData(DataFormats.FileDrop);
            }
        }

        private void MainFRM_DragOver(object sender, DragEventArgs e)
        {
        }

        private void MainFRM_DragDrop(object sender, DragEventArgs e)
        {

        }

        private bool handyBarcode = false;

        public string pathoSavePhoto { get; private set; }

        private void picCamLeft_Click(object sender, EventArgs e)
        {
            if (!CameraRunning) return;
            try
            {
                shotImage(camera_id, "pic.jpg");
                System.Diagnostics.Process.Start("pic.jpg");
            }
            catch
            {
            }
        }

        private Image shotImage(int cameraID, string path)
        {
            int lChannel = iChannelNum[(int)iSelIndex]; //通道号 Channel number

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara.wPicQuality = 0; //图像质量 Image quality
            lpJpegPara.wPicSize = 0xff; //抓图分辨率 Picture size: 0xff-Auto(使用当前码流分辨率)
            //抓图分辨率需要设备支持，更多取值请参考SDK文档
            //JPEG抓图保存成文件 Capture a JPEG picture
            string sJpegPicFileName;
            sJpegPicFileName = path;

            try
            {
                File.Delete(path);
            }
            catch
            {
            }
            try
            {
                CHCNetSDK.NET_DVR_CaptureJPEGPicture(cameraID, lChannel, ref lpJpegPara, sJpegPicFileName);
                return Image.FromFile(sJpegPicFileName);
            }
            catch
            {
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();

            return null;
        }

        #endregion

    }
}
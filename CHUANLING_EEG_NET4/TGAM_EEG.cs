using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CHUANLING_EEG
{
    /// <summary>
    /// EEG串口逻辑
    /// </summary>
    public class TGAM_EEG
    {
        public delegate void RefreshPara(EEG_Para para);

        public event RefreshPara refreshpara;

        public bool IsClose = false;
        /// <summary>
        /// 是否链接到有效串口
        /// </summary>
        public bool isConnected = false;
        /// <summary>
        /// 串口数据缓存
        /// </summary>
        private List<byte> BufferPort = new List<byte>();
        /// <summary>
        /// cache数据缓存
        /// </summary>
        private List<byte> BufferData = new List<byte>();

        public TGAM_EEG(int baute = 115200)
        {
            sport.BaudRate = 115200;
            sport.ReadTimeout = 2000;

            sport.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler((obj, e) =>
            {
                if (IsClose) return;
                try
                {
                    int n = sport.BytesToRead;

                    byte[] buf = new byte[n];

                    sport.Read(buf, 0, n);
                    BufferPort.AddRange(buf);
                    while (BufferPort.Count >= 3)
                    {
                        if (BufferPort[0] == 0xAA && BufferPort[1] == 0xAA)
                        {
                            //获取数据长度
                            byte len = BufferPort[2];
                            //判断数据完整性
                            if (BufferPort.Count < len + 2 + 1) break;
                            byte[] bytCheck = new byte[len];
                            BufferPort.CopyTo(3, bytCheck, 0, bytCheck.Length);
                            byte sum = sumCheck(bytCheck);
                            //比对
                            //通过
                            if (sum != BufferPort[len + 3])
                            {
                                BufferPort.RemoveRange(0, 3);
                                continue;
                            }

                            byte[] tmp = new byte[len + 3 + 1];
                            BufferPort.CopyTo(0, tmp, 0, len + 3 + 1);
                            BufferPort.RemoveRange(0, len + 3);
                            BufferData.Clear();
                            BufferData.AddRange(tmp);
                            isCache = true;
                        }
                        else
                        {
                            BufferPort.RemoveAt(0);
                        }
                    }



                }
                catch (Exception ex)
                {

                    //    throw;
                }


            });
        }
        Thread th_AutoConnect;
        public void InitEEG()
        {
            th_AutoConnect = new Thread(() =>
           {
               while (true)
               {
                   while (!isConnected)
                   {
                       string[] allPorts = System.IO.Ports.SerialPort.GetPortNames();
                       foreach (string item in allPorts)
                       {

                           sport.PortName = item;
                           try
                           {
                               sport.Open();
                               byte[] vs = new byte[50];
                               sport.Read(vs, 0, 50);

                               if (Array.IndexOf(vs, new byte[] { 0xaa, 0xaa }) != 0)
                               {
                                   isConnected = true;
                                   break;
                               }


                           }
                           catch (Exception ex)
                           {
                               sport.Close();

                           }

                           Thread.Sleep(200);

                       }
                       Thread.Sleep(1000);

                   }
                   while (isConnected)
                   {
                       if (!sport.IsOpen)
                       {
                           sport.Close();
                           isConnected = false;
                       }
                       Thread.Sleep(1000);
                   }
                   Thread.Sleep(1000);
               }
           });
            th_AutoConnect.IsBackground = true;
            th_AutoConnect.Start();
        }

        public EEG_Para para = new EEG_Para();


        Thread th_UpdataEEG;
        public void UpdateEEGPara()
        {
            th_UpdataEEG = new Thread(() =>
            {
                while (true)
                {
                    while (isCache && BufferData.Count == 36)
                    {
                        try
                        {
                            List<byte> BufferList = BufferData;
                            if (BufferList[0] == 0xaa
                                && BufferList[1] == 0xaa
                                && BufferList[2] == 0x20
                                && BufferList[3] == 0x02)
                            {
                                try
                                {
                                    EEG_Para para = this.para;
                                    lock (para)
                                    {


                                        List<byte> vs = BufferList.GetRange(7, 3);
                                        //Signal
                                        para.Signal = BufferList[4];
                                        //Delta
                                        para.Delta = GetUInt(BufferList.GetRange(7, 3));
                                        //Thrta
                                        para.Theta = GetUInt(BufferList.GetRange(10, 3));
                                        //LowAlpha
                                        para.LowAlpha = GetUInt(BufferList.GetRange(13, 3));
                                        //HighAlpha
                                        para.HighAlpha = GetUInt(BufferList.GetRange(16, 3));
                                        //LowBeta
                                        para.LowBeta = GetUInt(BufferList.GetRange(19, 3));
                                        //HighBeta
                                        para.HighBeta = GetUInt(BufferList.GetRange(22, 3));
                                        //LowGamma
                                        para.LowGamma = GetUInt(BufferList.GetRange(25, 3));
                                        //MiddleGamma
                                        para.MiddleGamma = GetUInt(BufferList.GetRange(28, 3));


                                        //Attention
                                        para.Attention = BufferList[32];
                                        //Meditation
                                        para.Meditation = BufferList[34];
                                    }

                                    this.para = para;
                                }
                                catch (Exception ex)
                                {

                                    // throw;
                                }



                                if (refreshpara != null)
                                {
                                    refreshpara(para);
                                }
                            }
                            else
                            {

                            };
                        }
                        catch (Exception ex)
                        {

                            //throw;
                        }


                    }
                    Thread.Sleep(500);
                }
            });

            th_UpdataEEG.IsBackground = true;
            th_UpdataEEG.Start();



        }



        private UInt32 GetUInt(List<byte> enumerable)
        {
            byte Hb = enumerable[0];
            byte Mb = enumerable[1];
            byte Lb = enumerable[2];
            UInt32 result = 0;
            result = (UInt32)((Hb << 16) | (Mb << 8) | Lb);
            return result;
        }

        public static byte sumCheck(byte[] vs)
        {
            long l = 0;
            foreach (byte item in vs)
            {
                l += item;
            }
            long i = (l ^ 0xffffffff) & 0xff;
            //int i = (ushort)~l & 0xff;
            return (byte)i;
        }



        #region 通信相关
        /// <summary>
        /// 串口
        /// </summary>
        private System.IO.Ports.SerialPort sport = new System.IO.Ports.SerialPort();

        /// <summary>
        /// 缓存标志位
        /// </summary>
        private bool isCache = false;


        /// <summary>
        /// 串口是否关闭
        /// </summary>
        private bool ComClosed = false;

        #endregion

    }
}

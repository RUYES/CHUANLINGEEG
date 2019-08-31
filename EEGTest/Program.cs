using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EEGTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CHUANLING_EEG.TGAM_EEG tgam = new CHUANLING_EEG.TGAM_EEG();
            tgam.InitEEG();
            tgam.UpdateEEGPara();
            //tgam.refreshpara += Tgam_refreshpara;
            while (true)
            {
                StringBuilder stringBuilder = new StringBuilder();
                CHUANLING_EEG.EEG_Para para = tgam.para;
                stringBuilder.Append("Attention:\t\t").Append(para.Attention).Append("\r\n");
                stringBuilder.Append("LowAlpha:\t\t").Append(para.LowAlpha).Append("\r\n");
                stringBuilder.Append("LowBeta:\t\t").Append(para.LowBeta).Append("\r\n");
                stringBuilder.Append("LowGamma:\t\t").Append(para.LowGamma).Append("\r\n");
                stringBuilder.Append("Meditation:\t\t").Append(para.Meditation).Append("\r\n");
                stringBuilder.Append("MiddleGamma:\t\t").Append(para.MiddleGamma).Append("\r\n");
                stringBuilder.Append("Signal:\t\t\t").Append(para.Signal).Append("\r\n");
                stringBuilder.Append("Theta:\t\t\t").Append(para.Theta).Append("\r\n");
                stringBuilder.Append("Delta:\t\t\t").Append(para.Delta).Append("\r\n");
                stringBuilder.Append("HighAlpha:\t\t").Append(para.HighAlpha).Append("\r\n");
                stringBuilder.Append("HighBeta:\t\t").Append(para.HighBeta).Append("\r\n");
                stringBuilder.Append("EarphoneReady:\t\t").Append(para.EarphoneReady).Append("\r\n");
                Console.Clear();

                Console.WriteLine(stringBuilder.ToString());

                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }

        private static void Tgam_refreshpara(CHUANLING_EEG.EEG_Para para)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(para.Attention).Append("\r\n");
            stringBuilder.Append(para.Delta).Append("\r\n");
            stringBuilder.Append(para.HighAlpha).Append("\r\n");
            stringBuilder.Append(para.HighBeta).Append("\r\n");
            Console.WriteLine(stringBuilder.ToString());

        }
    }
}

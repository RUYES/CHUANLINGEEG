using System;
using System.Collections.Generic;
using System.Text;

namespace CHUANLING_EEG
{
    /// <summary>
    /// EEG参数
    /// </summary>
    public class EEG_Para
    {
        #region 数值
        private UInt32 delta = 0;

        public UInt32 Delta
        {
            get { return delta; }
            set { delta = value; }
        }
        private UInt32 theta = 0;

        public UInt32 Theta
        {
            get { return theta; }
            set { theta = value; }
        }
        private UInt32 lowAlpha = 0;

        public UInt32 LowAlpha
        {
            get { return lowAlpha; }
            set { lowAlpha = value; }
        }
        private UInt32 highAlpha = 0;

        public UInt32 HighAlpha
        {
            get { return highAlpha; }
            set { highAlpha = value; }
        }

        private UInt32 lowBeta = 0;
        public UInt32 LowBeta
        {
            get { return lowBeta; }
            set { lowBeta = value; }
        }

        private UInt32 highBeta = 0;
        public UInt32 HighBeta
        {
            get { return highBeta; }
            set { highBeta = value; }
        }

        private UInt32 lowGamma = 0;

        public UInt32 LowGamma
        {
            get { return lowGamma; }
            set { lowGamma = value; }
        }
        private UInt32 middleGamma = 0;

        public UInt32 MiddleGamma
        {
            get { return middleGamma; }
            set { middleGamma = value; }
        }


        private ushort attention = 0;

        public ushort Attention
        {
            get { return attention; }
            set { attention = value; }
        }
        private ushort meditation = 0;

        public ushort Meditation
        {
            get { return meditation; }
            set { meditation = value; }
        }

        private ushort signal = 0;

        public ushort Signal
        {
            get { return signal; }
            set { signal = value; }
        }


        /// <summary>
        /// 耳机是否带好
        /// </summary>
        public bool EarphoneReady
        {
            get
            {
                return (signal == 29 || signal == 54 || signal == 55 || signal == 56 || signal == 80 || signal == 81 || signal == 82 || signal == 107 || signal == 200) ? false : true;
            }
        }

        #endregion
    }
}

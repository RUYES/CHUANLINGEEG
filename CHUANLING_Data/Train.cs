using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHUANLING_Data
{
    public class Train
    {
        public Train()
        {
            FifthAttRate = FourthAttRate = ThridAttRate = SecondAttRate = FirstAttRate =
            CVMeditation = CVAttention = UserName = TableName = Date = Item = Start = End = Duration = Remarks =
            FirstMedRate = SecondMedRate = ThridMedRate = FourthMedRate = FifthMedRate = "";
            MaxAttention = MaxMeditation = MinAttention = AverageAttention = AverageMeditation = CalculateAttention = CalculateMeditation =
                AttentionIndex = MeditationIndex = TranScore = 0;

        }

        public string UserName { get; set; }
        public string TableName { get; set; }
        public string Date { get; set; }
        public string Item { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Duration { get; set; }
        public int MaxAttention { get; set; }
        public int MaxMeditation { get; set; }
        public int MinAttention { get; set; }
        public int MinMeditation { get; set; }
        public int AverageAttention { get; set; }
        public int AverageMeditation { get; set; }
        public int CalculateAttention { get; set; }
        public int CalculateMeditation { get; set; }
        public string CVAttention { get; set; }
        public string CVMeditation { get; set; }
        public string FirstAttRate { get; set; }
        public string SecondAttRate { get; set; }
        public string ThridAttRate { get; set; }
        public string FourthAttRate { get; set; }
        public string FifthAttRate { get; set; }
        public string FirstMedRate { get; set; }
        public string SecondMedRate { get; set; }
        public string ThridMedRate { get; set; }
        public string FourthMedRate { get; set; }
        public string FifthMedRate { get; set; }
        public int AttentionIndex { get; set; }
        public int MeditationIndex { get; set; }
        public int TranScore { get; set; }
        public string Remarks { get; set; }

        //  public Dictionary<string, string> GetDictionary()
        //{
        //Dictionary<string, string> valuePairs = new Dictionary<string, string>();
        //if (UserName != null) valuePairs.Add("UserName", UserName);
        //if (TableName != null) valuePairs.Add("Password", Password);
        //if (Date != null) valuePairs.Add("Name", Name);
        //if (Item != null) valuePairs.Add("Sex", Sex);
        //if (Start != null) valuePairs.Add("Years", Years);
        //if (End != null) valuePairs.Add("Height", Height);
        //if (Duration != null) valuePairs.Add("Weight", Weight);
        //if (Province != null) valuePairs.Add("Province", Province);
        //if (City != null) valuePairs.Add("City", City);
        //if (County != null) valuePairs.Add("County", County);
        //if (Address != null) valuePairs.Add("Address", Address);
        //if (QQ != null) valuePairs.Add("QQ", QQ);
        //if (Wechat != null) valuePairs.Add("Wechat", Wechat);
        //if (Phone != null) valuePairs.Add("Phone", Phone);
        //if (Email != null) valuePairs.Add("Email", Email);
        //if (Remarks != null) valuePairs.Add("Remarks", Remarks);

        //return valuePairs;
        // }

    }
}

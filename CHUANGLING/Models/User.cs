using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHUANLING.Models
{
    public class User
    {
        public User(string username, string name, string passwd = "000000", string phone = "136********")
        {
            UserName = username;
            Name = name;
            Phone = phone;
            Password = passwd;

            Sex = Years = Height = Weight = Province = City = County = Address = QQ = Wechat = Email = Remarks = "";


        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Years { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Address { get; set; }
        public string QQ { get; set; }
        public string Wechat { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Remarks { get; set; }

        public Dictionary<string, string> GetDictionary()
        {
            Dictionary<string, string> valuePairs = new Dictionary<string, string>();
            if (UserName != null) valuePairs.Add("UserName", UserName);
            if (Password != null) valuePairs.Add("Password", Password);
            if (Name != null) valuePairs.Add("Name", Name);
            if (Sex != null) valuePairs.Add("Sex", Sex);
            if (Years != null) valuePairs.Add("Years", Years);
            if (Height != null) valuePairs.Add("Height", Height);
            if (Weight != null) valuePairs.Add("Weight", Weight);
            if (Province != null) valuePairs.Add("Province", Province);
            if (City != null) valuePairs.Add("City", City);
            if (County != null) valuePairs.Add("County", County);
            if (Address != null) valuePairs.Add("Address", Address);
            if (QQ != null) valuePairs.Add("QQ", QQ);
            if (Wechat != null) valuePairs.Add("Wechat", Wechat);
            if (Phone != null) valuePairs.Add("Phone", Phone);
            if (Email != null) valuePairs.Add("Email", Email);
            if (Remarks != null) valuePairs.Add("Remarks", Remarks);

            return valuePairs;
        }

    }
}

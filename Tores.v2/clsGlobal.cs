using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tores.v2
{
    public class clsGlobal
    {
        // Database için...
        public static string DBConnectionString
        {
            get { return "Server=PHOKAIA; Database=Tores; Trusted_Connection=True;"; } // Database First--Code First
        }

        // Formların tepe tanımları için...
        public static string SystemName
        {
            get { return "Toplantı Odaları Rezervasyon Sistemi v2"; }
        }

        // Kullanıcıların Login bilgileri için...
        static string _UName; // UserName
        public static string UName
        {
            get { return _UName; }
            set { _UName = value; }
        }

        static string _UPass; // UserPassword
        public static string UPass
        {
            get { return _UPass; }
            set { _UPass = value; }
        }

        // Kullanıcıların detay bilgileri için
        static int _UserID; // UserID
        public static int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        static string _UserFName; // UserFName
        public static string UserFName { get;set;}

        static string _UserLName; // UserFName
        public static string UserLName { get; set; }

        static int _UserTypeID; // UserFName
        public static int UserTypeID { get; set; }

        static string _UserTypeDesc; // UserFName
        public static string UserTypeDesc { get; set; }



    }
}

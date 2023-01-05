using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace MyFirstProject
{
    class CustInfo
    {
      public int CustNo;
      public String CustName;
      public long ContactNo;
    }
    class Program
    {
        public static void Main()
        {
            List<CustInfo> ICust = new List<CustInfo>();
            for(int i=0;i<2;i++){
                Console.WriteLine("Enter employee details: ");
                int ID=Convert.ToInt32(Console.ReadLine());
                string Name=Console.ReadLine();
                long Contact=Convert.ToInt64(Console.ReadLine());
                ICust.Add(new CustInfo{CustNo=ID, CustName=Name,ContactNo=Contact });
            }
            StreamWriter file = File.CreateText(@"C:\Users\VMAdmin\Desktop\test.txt");
            foreach(CustInfo obj in ICust){
                file.WriteLine(obj.CustNo.ToString() + "," + obj.CustName + "," +  obj.ContactNo);
            }
            file.Close();
        }
    }
}
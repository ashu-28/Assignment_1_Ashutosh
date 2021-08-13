using System;
using System.Collections.Generic;
using System.IO;

namespace Read_csv
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            var strLines = File.ReadLines("Contacts.csv");
            foreach (var line in strLines)
            {
                if (line.Split(',')[0].Equals("12345")) cnt = 1;
            }
            if (cnt == 0)
            {
                addRecord("12345", "Ashutosh", "Jaipur Rajasthan", "9876546709", "14-06-21 8:00", "ashutosh@blackstone.com", "Contacts.csv");
            }
            ReadCSVFile();
            Console.ReadLine();
        }
        public static void addRecord(string Id,string Name,string Adress,string Phone,string Joindate,string email, string filepath)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(@filepath,true))
                {
                    file.WriteLine(Id + "," + Name + "," + Adress + "," + Phone + "," + Joindate + "," + email);
                }
            }
            catch(Exception ex)
            {
                throw new ApplicationException("This prog did a mistake :", ex);
            }
        }
        static void ReadCSVFile()
        {
            var lines = File.ReadAllLines("Contacts.csv");
            foreach(var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
    public class Contact
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Joindate { get; set; }
        public string email { get; set; }
    }

}

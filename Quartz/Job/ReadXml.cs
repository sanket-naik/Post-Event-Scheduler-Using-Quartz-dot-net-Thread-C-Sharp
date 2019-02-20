using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Quartz.Job
{
    class Id
    {
        public string Email { get; set; }
        public string Task { get; set; }
    }

    class ReadXml
    {
        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Data\Jobs.xml";
        public void Get()
        {
            string cMonth = DateTime.Now.ToString("dd/MM");

            List<Id> job =
            (from jobs in XDocument.Load(path)
                                  //.Descendants("Student")
                                  .Element("Jobs").Elements("Job")
             where (string)jobs.Element("Date").Value == cMonth
             select new Id()
             {

                 Email = (string)jobs.Element("Email"),

                 Task = (string)jobs.Element("Task")

             }).ToList();



            foreach (Id task in job)
            {
                Console.WriteLine("Email :" + task.Email);
                Console.WriteLine("Task :{0}\n", task.Task);
            }
        }
    }
}

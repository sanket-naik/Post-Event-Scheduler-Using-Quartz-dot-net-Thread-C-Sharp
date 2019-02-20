using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Quartz.Job
{
    class GenerateXml
    {
        string path= Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Data\Jobs.xml";
        public void write()
        {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Creating the xml tree"),
                new XElement("Jobs",

                          from job in Jobs.GetAllJobs()
                          select new XElement("Job", new XAttribute("Id", job.Id),
                                      new XElement("Email", job.Email),
                                      new XElement("Task", job.Task),
                                      new XElement("Date", job.Date))
                            ));

            xmlDocument.Save(path);
        }
    }
}

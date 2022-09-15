using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_Framework
{
    class Program
    {   //Step1: Connection String
        string path = "C:\\Users\\Shubhankar Shubham\\source\\repos\\LINQ_Framework\\LINQ_Framework\\ParticipantDetails.xml";
        private void GetXml()
        {
            try
            {
                //Step2:Loading
                XDocument xDocument = XDocument.Load(path);
                //XDocument xDocument = XDocument.Parse(path);
                //Console.WriteLine("ROOT" + xDocument.Root);
                var Students = from participant in xDocument.Descendants("Participant")
                               select new
                               {
                                   ID = Convert.ToInt32(participant.Attribute("ID").Value),
                                   Name = participant.Element("Name").Value
                               };
                //Console.WriteLine(Students.ToString());
                foreach (var student in Students)
                {
                    Console.WriteLine("--");
                    Console.WriteLine(student.ID + " - " + student.Name);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }



        }     

        private void SetXml(string name)
        {
            try
            {   //loading the document
                XDocument myXml = XDocument.Load(path);
                XElement newParticipant = new XElement("Participant",new XElement("Name",name));
                var LastStudent = myXml.Descendants("Participant").Last();
                int newID = Convert.ToInt32(LastStudent.Attribute("ID").Value);

                newParticipant.SetAttributeValue("ID", newID + 1);
                myXml.Element("Participants").Add(newParticipant);
                myXml.Save(path);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
        }

        private void ModifyXmlData(string name, int id)
        {
            try
            {   //loading the document
                XDocument myXml = XDocument.Load(path);
                var ListStudent = myXml.Descendants("Participant").Where(c => c.Attribute("ID").Value.Equals(id.ToString())).FirstOrDefault();

                ListStudent.Element("Name").Value = name;
                myXml.Save(path);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }

        }

        private void DeleteXml(int id)
        {
            try
            {   //loading the document
                XDocument myXml = XDocument.Load(path);
                var DStudent = myXml.Descendants("Participant").Where(c => c.Attribute("ID").Value.Equals(id.ToString())).FirstOrDefault();

                DStudent.Remove();
                myXml.Save(path);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("LINQ TO XML");

            Program obj1 = new Program();
            //obj1.GetXml();

            //obj1.SetXml("Sohan");
            //obj1.GetXml();

            //obj1.ModifyXmlData("gmail", 1);
            obj1.DeleteXml(1);
            obj1.GetXml();

        }
    }
}

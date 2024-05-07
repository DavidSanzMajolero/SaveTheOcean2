using System.Xml;

namespace SaveTheOcean2
{
    public class XMLHelper
    {
        public static void CreateXMLPersona()
        {
            XmlDocument xmlDocum = new XmlDocument();
            XmlElement root = xmlDocum.CreateElement("Personas");
            xmlDocum.AppendChild(root);
            root.InnerText = "";
            xmlDocum.Save("Personas.xml");
        }
        public static void AppendPerson (Player person)
        { 
            XmlDocument xmlDocum = new XmlDocument();
            xmlDocum.Load("Personas.xml");
            XmlElement root = xmlDocum.DocumentElement;
            XmlElement personElement = xmlDocum.CreateElement("Persona");
            XmlElement nameElement = xmlDocum.CreateElement("Name");
            nameElement.InnerText = person.Name;
            XmlElement experienceElement = xmlDocum.CreateElement("Experience");
            experienceElement.InnerText = person.Experience.ToString();
            personElement.AppendChild(nameElement);
            personElement.AppendChild(experienceElement);
            root.AppendChild(personElement);
            xmlDocum.Save("Personas.xml");
        }
    }
}

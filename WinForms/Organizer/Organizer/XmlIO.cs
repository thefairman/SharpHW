using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Organizer
{
    public class XmlIO
    {
        public string XmlDefaultPath { get; protected set; } = "events.xml";
        protected XmlDocument xmlDocument = new XmlDocument();
        virtual public void SaveToXML(XmlDocument xmlDocument = null)
        {
            if (xmlDocument == null)
                xmlDocument = this.xmlDocument;
            xmlDocument?.Save(XmlDefaultPath);
        }

        virtual public void LoadFromXML(string path = null)
        {
            if (String.IsNullOrEmpty(path))
                path = XmlDefaultPath;
            xmlDocument.Load(path);
            if (xmlDocument == null)
                xmlDocument = new XmlDocument();
        }
    }

    public class XmlIOAdapter : XmlIO
    {
        MyBindingList<MyEvent> myEvents;
        public XmlIOAdapter(MyBindingList<MyEvent> myEvents)
        {
            this.myEvents = myEvents;
        }

        public MyBindingList<MyEvent> EventsCollectionFromXmlDocument()
        {
            foreach (XmlNode item in xmlDocument?.DocumentElement?.ChildNodes)
            {
                var myEvent = new MyEvent();
                foreach (XmlNode elem in item.ChildNodes)
                {
                    switch (elem.Name)
                    {
                        case "Description":
                            myEvent.Description = elem.InnerText ?? "";
                            break;
                        case "Duration":
                            if (TimeSpan.TryParse(elem.InnerText, out TimeSpan duration))
                                myEvent.Duration = duration;
                            break;
                        case "EventDate":
                            if (DateTime.TryParse(elem.InnerText, out DateTime date))
                                myEvent.EventDate = date;
                            break;
                        case "Name":
                            myEvent.Name = elem.InnerText ?? "";
                            break;
                        case "Priority":
                            if (Enum.TryParse(elem.InnerText, out EventPriority prior))
                                myEvent.Priority = prior;
                            else
                                myEvent.Priority = EventPriority.Medium;
                            break;
                        case "Guid":
                            if (Guid.TryParse(elem.InnerText, out Guid guid))
                                myEvent.Guid = guid;
                            else
                                myEvent.Guid = Guid.NewGuid();
                            break;
                    }
                }
                myEvents.Add(myEvent);
            }
            return myEvents;
        }

        public XmlDocument EventsCollectionToXmlDocument()
        {
            XmlDocument collectionXML = new XmlDocument();
            collectionXML.AppendChild(collectionXML.CreateElement("EventsCollection"));
            foreach (var item in myEvents)
            {
                XmlElement element = collectionXML.CreateElement("Event");
                element.AppendChild(collectionXML.CreateElement("Description")).InnerText = item.Description;
                element.AppendChild(collectionXML.CreateElement("Duration")).InnerText = item.Duration.ToString();
                element.AppendChild(collectionXML.CreateElement("EventDate")).InnerText = item.EventDate.ToString();
                element.AppendChild(collectionXML.CreateElement("Name")).InnerText = item.Name;
                element.AppendChild(collectionXML.CreateElement("Priority")).InnerText = item.Priority.ToString();
                element.AppendChild(collectionXML.CreateElement("Guid")).InnerText = item.Guid.ToString();
                collectionXML.DocumentElement.AppendChild(element);
            }
            return collectionXML;
        }

        public override void LoadFromXML(string path = null)
        {
            base.LoadFromXML(path);
            EventsCollectionFromXmlDocument();
        }

        public override void SaveToXML(XmlDocument xmlDocument = null)
        {
            if (xmlDocument == null)
                xmlDocument = EventsCollectionToXmlDocument();
            base.SaveToXML(xmlDocument);
        }
    }
}

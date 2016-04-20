using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Reflection;
using System.IO;

namespace MeraDoctorBot_API.Models
{
   public class MessageTracker
    {
        //Accept input app id and check if it exists in log file.
         static XmlDocument xmlObj = new XmlDocument();
         //const string FirstMsg = "Hi! I am Ami G. Dala, your guide to MeraDoctor Pro. If you want me to show you around, type 'go'. If you're busy, come back later. I'll wait...";
         static Uri uri = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase));
         static string path = "";

        public static  string GetLastMessage(string AppId)
        {
            path = uri.AbsolutePath;
            xmlObj.Load(string.Format("{0}\\DoctorLog.xml", path));
            XmlNodeList xnList = xmlObj.SelectNodes("//App[@id='" + AppId + "']");// ("/DoctorLog/App");
            if (xnList.Count > 0)
            {   return xnList[0].InnerText.Trim();  }
            else
            {
                return "";
                //goto label1;
            }       
            
            //label1:
            //{//If App id not found insert one with default first text.
            //    XmlNode node = xmlObj.DocumentElement;
            //    XmlElement elem = xmlObj.CreateElement("App");
            //    elem.InnerText = FirstMsg;
            //    XmlAttribute newAttribute = xmlObj.CreateAttribute("id");
            //    newAttribute.Value = AppId;
            //    elem.Attributes.Append(newAttribute);
            //    node.AppendChild(elem);
            //    xmlObj.Save(string.Format("{0}\\DoctorLog.xml", path));
            //    return FirstMsg.Trim();
            //}    
            

        }

        public static void WriteLastMessaage(string AppId, string Message)
        {
            path = uri.AbsolutePath;
            xmlObj = new XmlDocument();
            xmlObj.Load(string.Format("{0}\\DoctorLog.xml", path));
            XmlNodeList xnList = xmlObj.SelectNodes("//App[@id='"+AppId+"']");
            if (xnList.Count > 0)
            {
                xnList[0].InnerText = Message;                
            }
            else
            {
                //If App id not found insert one with default first text.
                XmlNode node = xmlObj.DocumentElement;
                XmlElement elem = xmlObj.CreateElement("App");
                elem.InnerText = Message;
                XmlAttribute newAttribute = xmlObj.CreateAttribute("id");
                newAttribute.Value = AppId;
                elem.Attributes.Append(newAttribute);
                node.AppendChild(elem);
                
            }
            xmlObj.Save(string.Format("{0}\\DoctorLog.xml", path));
        }
    }
}

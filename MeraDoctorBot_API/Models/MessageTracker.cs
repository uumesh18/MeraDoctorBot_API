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
         XmlDocument xmlObj = new XmlDocument();
         string FirstMsg = "Hi Doc! I am Ami G. Dala. Your friendly patient and guide. Since you are new to the app, I would like to show you around. Type 'go' whenever you have 5 minutes for me. You can leave this chat at anytime and then return to it to resume our conversation.";
         Uri uri = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase));
         string path = "";

        public  string GetLastMessage(string AppId)
        {
            path = uri.AbsolutePath;
            xmlObj.Load(string.Format("{0}\\DoctorLog.xml", path));
            XmlNodeList xnList = xmlObj.SelectNodes("//App[@id=" + AppId + "]");// ("/DoctorLog/App");
            if (xnList.Count > 0)
            {   return xnList[0].InnerText.Trim();  }
            else
            {
                goto label1;
            }       
            
            label1:
            {//If App id not found insert one with default first text.
                XmlNode node = xmlObj.DocumentElement;
                XmlElement elem = xmlObj.CreateElement("App");
                elem.InnerText = FirstMsg;
                XmlAttribute newAttribute = xmlObj.CreateAttribute("id");
                newAttribute.Value = AppId;
                elem.Attributes.Append(newAttribute);
                node.AppendChild(elem);
                xmlObj.Save(string.Format("{0}\\DoctorLog.xml", path));
                return FirstMsg.Trim();
            }    
            

        }

        public  void WriteLastMessaage(string AppId, string Message)
        {
            path = uri.AbsolutePath;
            xmlObj.Load(string.Format("{0}\\DoctorLog.xml", path));
            XmlNodeList xnList = xmlObj.SelectNodes("//App[@id="+AppId+"]");
            xnList[0].InnerText = Message;
            xmlObj.Save(string.Format("{0}\\DoctorLog.xml", path));
        }
    }
}

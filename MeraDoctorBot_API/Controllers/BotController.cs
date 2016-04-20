using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.IO;
using System.Reflection;
using MeraDoctorBot_API.Models;

namespace MeraDoctorBot_API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BotController : ApiController
    {

        //MessageTracker objMsgTrcker = new MessageTracker();
        //MessageResponse objResponse = new MessageResponse();
        [Route("api/Bot/v1.0/{appId}")]
        // GET: api/Bot/5
        public string Get(string appId)
        {
            //var synBot = new SynBot();
            //var botUser = synBot.CreateUser();

            //var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            //var packageString = File.ReadAllText(Path.Combine(outPutDirectory, "DocBotPackage.simlpk"));
            //synBot.PackageManager.LoadFromString(packageString);
            //var chatRequest = new ChatRequest("how are you", botUser);
            //var chatResult = synBot.Chat(chatRequest);
            //var botMessage = chatResult.BotMessage;


            //if (chatResult.Success)
            // {
            //     //Do Something
            // }
            try
            {
                if (string.IsNullOrEmpty(appId)) { return "Sorry Bot cannot identify user."; }
                string response = MessageResponse.Response("", "").Trim();
                MessageTracker.WriteLastMessaage(appId, response);
                return response;
                
            }
            catch (Exception ex) { return ex.Message; }  //return "Something went wrong while communicating with Bot!"; }
        }

        [Route("api/Bot/v1.0/{appId}/{userInput}")]
        // GET: api/Bot/5/userInput
        public string Get(string appId, string userInput)
        {
            try
            {
                if (string.IsNullOrEmpty(appId)) { return "Sorry Bot cannot identify user."; }
                if (string.IsNullOrEmpty(userInput)) { return "Please input some text for Bot to read."; }
                string LastMsg = MessageTracker.GetLastMessage(appId);
                string response = MessageResponse.Response(LastMsg, userInput).Trim();
                MessageTracker.WriteLastMessaage(appId, response);
                return response;
            }
            catch (Exception ex) { return ex.Message; } //return "Something went wrong while communicating with Bot!"; }
        }

        //// POST: api/Bot
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Bot/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Bot/5
        //public void Delete(int id)
        //{
        //}
    }
}

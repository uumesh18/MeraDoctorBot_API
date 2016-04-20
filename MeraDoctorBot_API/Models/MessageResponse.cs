using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using IronPython.Hosting;
using System.Reflection;
using System.IO;
using Microsoft.Scripting.Hosting;


namespace MeraDoctorBot_API.Models
{
   class MessageResponse
    {
       static public string Response(string x, string userInput)
        {
            userInput = userInput.Trim();
            Uri uri = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase));
            string path = uri.AbsolutePath ;

            //ScriptEngine pythonEngine = Python.CreateEngine();

            //dynamic py = pythonEngine.ExecuteFile(Path.Combine(path, "chatbot3.py"));
            //dynamic res = py.Bot(userInput,x);
            //return res.chatbot();



            //First message communicating to Doctor
            if (x.Contains("Hi! I am Ami G. Dala, your guide to MeraDoctor Pro. If you want me to show you around, type 'go'. If you're busy, come back later. I'll wait...") || x.Contains("Sorry, my cerebral cortex isn't evolved enough to understand that! Type 'go' when you want to continue"))
            {
                if (userInput.Equals("go", StringComparison.OrdinalIgnoreCase))
                { return "Cool! MeraDoctor Pro lets you chat with your patients, at a time and price of your choosing - like we’re doing now. Why don’t you try to chat? Say “hello” to continue."; }
                else
                { return "Sorry, my cerebral cortex isn’t evolved enough to understand that! Type ‘Go’ when you want to continue."; }
            }

            //Second conversation triggers
            if (x.Contains("Cool! MeraDoctor Pro lets you chat with your patients, at a time and price of your choosing - like we’re doing now. Why don’t you try to chat? Say “hello” to continue.") || x.Contains("Wait that’s not how you type “hello” is it? You have to type ‘hello’ to continue!"))
            {
                if (userInput.Equals("hello", StringComparison.OrdinalIgnoreCase))
                { return "Hello to you too! Next up, you can also send photos  of anything - like your prescriptions or pamphlets, by tapping the paperclip button next to the chat box. I’ve disabled this in our chat, for now. All clear so far? Type ‘yes’ to continue."; }
                else
                { return "Wait that’s not how you type “hello” is it? You have to type ‘hello’ to continue!"; }
            }

            //Third Conversation triggers
            if (x.Contains("Hello to you too! Next up, you can also send photos  of anything - like your prescriptions or pamphlets, by tapping the paperclip button next to the chat box. I’ve disabled this in our chat, for now. All clear so far? Type ‘yes’ to continue.") || x.Contains("Sorry, my Wernicke’s area couldn’t process that! You need to type ‘yes’ to continue."))
            {
                if (userInput.Equals("yes", StringComparison.OrdinalIgnoreCase))
                { return "Now, tap the “Rs” icon on the top right corner of the chat window to charge your patients. You can only do this with your real patients, not with me. Want to continue? Add the missing word: Show me the _____."; }
                else
                { return "Sorry, my Wernicke’s area couldn’t process that! You need to type ‘yes’ to continue."; }
            }

            //Fourth conversation triggers
            if (x.Contains("Now, tap the “Rs” icon on the top right corner of the chat window to charge your patients. You can only do this with your real patients, not with me. Want to continue? Add the missing word: Show me the _____.") || x.Contains("Nope! The right answer was “money” - type “money” in now, to proceed!"))
            {
                if (userInput.Equals("money", StringComparison.OrdinalIgnoreCase))
                { return "You got it! BTW, important: If you Request Payment from  your patients, they won’t be able to chat until they pay. (Your messages will still go to them) Got it? Type “yes” to continue."; }
                else
                { return "Nope! The right answer was “money” - type “money” in now, to proceed!"; }
            }

            //Fifth conversation triggers
            if (x.Contains("You got it! BTW, important: If you Request Payment from  your patients, they won’t be able to chat until they pay. (Your messages will still go to them) Got it? Type “yes” to continue.") || x.Contains("Doctors are supposed to have bad handwriting but I can’t read that! Is that a “yes”?"))
            {
                if (userInput.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                { return "In case you have a change of heart (possibly prompted by your own amygdala) you can cancel by tapping the text that says “Cancel Fee Request”. Ready for more? Type “yes” to continue!"; }
                else
                { return "Doctors are supposed to have bad handwriting but I can’t read that! Is that a “yes”?"; }
            }

            //Sixth conversation triggers
            if (x.Contains("In case you have a change of heart (possibly prompted by your own amygdala) you can cancel by tapping the text that says “Cancel Fee Request”. Ready for more? Type “yes” to continue!") || x.Contains("Is your input the new “yes”? I can’t proceed without consent!"))
            {
                if (userInput.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                { return "Chatting with your patients will build up a timeline. To see what that looks like, you can tap my name on the top of this chat! Type “done” when you’re back."; }
                else
                { return "Is your input the new “yes”? I can’t proceed without consent!"; }
            }

            //Seventh conversation triggers
            if (x.Contains("Chatting with your patients will build up a timeline. To see what that looks like, you can tap my name on the top of this chat! Type “done” when you’re back.") || x.Contains("You may be done, but I won’t know until you type “done”!"))
            {
                if (userInput.Equals("done", StringComparison.OrdinalIgnoreCase))
                { return "The timeline page lets you add a note against your patient’s name to remind you of their case. You can tap the pencil icon under the patient’s name to add a note. If you want to proceed, say “yes”"; }
                else
                { return "You may be done, but I won’t know until you type “done”!"; }
            }

            //eighth conversation triggers
            if (x.Contains("The timeline page lets you add a note against your patient’s name to remind you of their case. You can tap the pencil icon under the patient’s name to add a note. If you want to proceed, say “yes”") || x.Contains("Sorry, I was not able to understand that - if you didn’t type “yes”, please do so now!"))
            {
                if (userInput.Equals("yes", StringComparison.OrdinalIgnoreCase))
                { return "Apart from adding a note for the patient, you can also tap the pencil icon against each interaction to build a timeline with the highlights. Type anything to continue."; }
                else
                { return "Sorry, I was not able to understand that - if you didn’t type “yes”, please do so now!"; }
            }

            //ninth conversation triggers
            if (x.Contains("Apart from adding a note for the patient, you can also tap the pencil icon against each interaction to build a timeline with the highlights. Type anything to continue.") || x.Contains("No no, you don’t understand - you have to literally type “anything” to continue :)"))
            {
                if (userInput.Equals("anything", StringComparison.OrdinalIgnoreCase))
                { return "Congrats, you made it to the end! One last tip: If you’re ever stuck you can go to “Need Help?” from the side pane , and tap “Chat with us”, to talk to a human. You can exit this chat now. Remember, if you come back, I’ll take you through this tutorial again! (Until I evolve into something more awesome!)"; }
                else
                { return "No no, you don’t understand - you have to literally type “anything” to continue :)"; }
            }

            //loop conversation triggers
            if (x.Contains("Congrats, you made it to the end! One last tip: If you’re ever stuck you can go to “Need Help?” from the side pane , and tap “Chat with us”, to talk to a human. You can exit this chat now. Remember, if you come back, I’ll take you through this tutorial again! (Until I evolve into something more awesome!)") || string.IsNullOrEmpty(x))
            {
                return "Hi! I am Ami G. Dala, your guide to MeraDoctor Pro. If you want me to show you around, type 'go'. If you're busy, come back later. I'll wait...";
            }

            throw new Exception("Sorry couldn't understand you message");
        }
    }
}

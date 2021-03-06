
# coding: utf-8

# In[19]:

class Bot():
    def __init__(self,userInput,x):
        self.userInput=userInput.lower()
        self.x=x
    def chatbot(self):    #x is the lastmsg
        if (self.x =="" or 'Congrats, you made it to the end' in self.x):
            return "Hi! I am Ami G. Dala, your guide to MeraDoctor Pro. If you want me to show you around, type 'go'. If you're busy, come back later. I'll wait..."
        while True:
            if "Hi! I am Ami G. Dala" in self.x :
                if self.userInput =="go":
                    self.x="Cool! MeraDoctor Pro lets you stay in chat with your patients, at a time and price of your choosing - like we're doing now. Why don't you say something too? Try saying,'hello'"
                else:
                    self.x= "Sorry, my cerebral cortex isn't evolved enough to understand that! Type 'go' when you want to continue"
            elif "Cool! MeraDoctor Pro lets you stay" in self.x:
                if self.userInput=="hello":
                    self.x= "Hello to you too! Next up, you can also send pics of anything - like your prescriptions or pamphlets, by tapping the paperclip button next to the chat box. I've disabled this in our chat, for now. All clear so far? Type 'yes' to continue"
                else:
                    self.x="Wait that's not how you type 'hello' is it? You have to type 'hello' to continue!"
            elif "Hello to you too" in self.x:
                if self.userInput == "yes":
                    self.x="Now, tap the 'Rs' icon on the top right corner of any chat window to charge your patients. You can only do this with your real patients, not me. Want to continue? Complete this: Show me the _____."
                else:
                    self.x= "Sorry, my Wernicke's area couldn't process that! You need to type 'yes' to continue"
            elif "Now, tap the b Rsb  icon" in self.x:
                if self.userInput == "money":
                    self.x="You got it! BTW, important: If you charge your patients, they won't be able to chat until they pay. (Your messages will still go to them) Got it? Type b yesb  to continue"
                else:
                    self.x ="Nope! The right answer was 'money' - type 'money' in now, to proceed!"
            elif "You got it! BTW, important" in self.x:
                if self.userInput == "yes":
                    self.x="In case you have a change of heart (possibly prompted by your own amygdala) you can cancel by tapping the text that says b Cancel Fee Requestb . Ready for more? Type b yesb  to continue!"
                else:
                    self.x= "Doctors are supposed to have bad handwriting but I can't read that! Is that a 'yes'?"
            elif "In case you have a change of heart" in self.x:
                if self.userInput == "yes":
                    self.x= "Chatting with your patients will build up a timeline. To see what that looks like, you can tap my name on the top of this chat! Type 'done' when you're back."
                else:
                    self.x= "Is " + userInput + " the new 'yes'? I can't proceed without consent!"
            elif "Chatting with your patients will" in self.x:
                if self.userInput == "done":
                    self.x="The timeline page lets you add notes for all your patients, by tapping the pencil icon under the patient's name. If you want to proceed, say 'yes'"
                else:
                    self.x= "You may be done, but I won't know until you type 'done'"
            elif "The timeline page lets you add" in self.x:
                if self.userInput == "yes":
                    self.x="Apart from adding a note for a patient, you can also tap the pencil icon against each interaction, to record what happened. Type anything to continue."
                else:
                    self.x = "Sorry, I was not able to understand that - if you didn't type 'yes', please do so now!"
            elif "Apart from adding a note for a patient" in self.x:
                if self.userInput == "anything":
                    self.x="Congrats, you made it to the end! One last tip: If you're ever stuck you can go to 'Need Help?' in the main menu, and tap 'Chat with us', to talk to a human. You can exit this chat now . Remember, if you come back, I'll take you through this tutorial again! (Until I evolve into something more awesome!)"
                else:
                    self.x="No no, you don't understand - you have to literally type 'anything' to continue :)"
            return self.x

        

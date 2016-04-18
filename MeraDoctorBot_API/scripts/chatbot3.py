
# coding: utf-8

# In[1]:

def chatbot(userInput,x):    #x is the lastmsg
    import random
    if (x=="Hi! I am Ami G. Dala, your guide to MeraDoctor Pro. If you want me to show you around, type 'go'. If you're busy, come back later. I'll wait..."):
        return x
    while True:
        #userInput = raw_input(">>> ").lower()
        if "Hi! I am Ami G. Dala" in x:
            if userInput =="go":
                x="Cool! MeraDoctor Pro lets you stay in chat with your patients, at a time and price of your choosing - like we're doing now. Why don't you say something too? Try saying,'hello'"
            else:
                x= "Sorry, my cerebral cortex isn't evolved enough to understand that! Type 'go' when you want to continue"
        elif "Cool! MeraDoctor Pro lets you stay" in x:
            if userInput=="hello":
                x= "Hello to you too! Next up, you can also send pics of anything - like your prescriptions or pamphlets, by tapping the paperclip button next to the chat box. I've disabled this in our chat, for now. All clear so far? Type 'yes' to continue"
            else:
                x="Wait that's not how you type 'hello' is it? You have to type 'hello' to continue!"
        elif "Hello to you too" in x:
            if userInput == "yes":
                x="Now, tap the 'Rs' icon on the top right corner of any chat window to charge your patients. You can only do this with your real patients, not me. Want to continue? Complete this: Show me the _____."
            else:
                x= "Sorry, my Wernicke's area couldn't process that! You need to type 'yes' to continue"
        elif "Now, tap the b Rsb  icon" in x:
            if userInput == "money":
                x="You got it! BTW, important: If you charge your patients, they won't be able to chat until they pay. (Your messages will still go to them) Got it? Type b yesb  to continue"
            else:
                x ="Nope! The right answer was 'money' - type 'money' in now, to proceed!"
        elif "You got it! BTW, important" in x:
            if userInput == "yes":
                x="In case you have a change of heart (possibly prompted by your own amygdala) you can cancel by tapping the text that says b Cancel Fee Requestb . Ready for more? Type b yesb  to continue!"
            else:
                x= "Doctors are supposed to have bad handwriting but I can't read that! Is that a 'yes'?"
        elif "In case you have a change of heart" in x:
            if userInput == "yes":
                x= "Chatting with your patients will build up a timeline. To see what that looks like, you can tap my name on the top of this chat! Type 'done' when you're back."
            else:
                x= "Is " + userInput + " the new 'yes'? I can't proceed without consent!"
        elif "Chatting with your patients will" in x:
            if userInput == "done":
                x="The timeline page lets you add notes for all your patients, by tapping the pencil icon under the patient's name. If you want to proceed, say 'yes'"
            else:
                x= "You may be done, but I won't know until you type 'done'"
        elif "The timeline page lets you add" in x:
            if userInput == "yes":
                x="Apart from adding a note for a patient, you can also tap the pencil icon against each interaction, to record what happened. Type anything to continue."
            else:
                x = "Sorry, I was not able to understand that - if you didn't type 'yes', please do so now!"
        elif "Apart from adding a note for a patient" in x:
            if userInput == "anything":
                x="Congrats, you made it to the end! One last tip: If you're ever stuck you can go to 'Need Help?' in the main menu, and tap b Chat with usb , to talk to a human. You can exit this chat now. Remember, if you come back, I'll take you through this tutorial again! (Until I evolve into something more awesome!)"
            else:
                x="No no, you don't understand - you have to literally type 'anything' to continue :)"
        return x

    
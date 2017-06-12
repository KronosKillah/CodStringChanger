**This tool was origionally supposed to be a paid tool, but ive lost interest in modding and it was sitting in my projects folder so it thought i would release it free and open source.**

Of course since this tool is open sourced i expect people will take it and use it in their own projects. ALL I ASK IS THAT YOU GIVE CREDITS TO ME.

I put Hundreds of hours into researching and making this tool, dont be a skid and C&P, actually take your time to learn how i did things and apply it to your own project.

****Disclamer****

*This tool will be buggy and will contain alot of shitty code (im a noob)*

*it is also unfinished, there is alot of shit to add that i never got around to adding*

# CodStringChanger (dont have an official name)
A Multi Tool that allows you to change strings in Cods BO1, MW3, BO2, Ghosts, and AW

Everything in this Tool has been created by me. Except where credit has been given.

All the offsets in this tool for the strings ETC where found by me. i dont like leeching so i found my own shit.


Now i am a noob at coding (self taught, probably badly self taught i might add) so dont expect the source to be pretty, if i found a problem i would usually research on how to do something my self, but this wasnt always the case. i got some help from people along the way. The Credits to the people that helped make this tool are as follows - 

    Robert/robhrgs - Helped me when i first started.
    Kryptus - Helped me with JSON (the tool settings loader thingy)
    Tustin - General question Answering
    Specter - General question Answering
    basically the whole NGU staff people for answering my noob questions in the modbox.
    Jessey Stephen - helped with a basic auth when first started tool
    Various other people for testing etc
  


**About the tool**

  I understand that string editing has been a thing for a while with some people having it in their tools. But i think my tool is unique. Most tools that use strings are limmited as to what they can Edit. Set to many characters and the strings will fuck up.

  My tool is unique because what it does is it changes the Pointer for that offset to a different address in memory (an empty un used one(to my knowledge)) and then fills that adress with the string input you set, therefore it doesnt break the text or make the game fuck up.
  
  
**How i found the Offsets + Shit required**

  For this i used NetCheat, Prodg Debugger and IDA Pro.

  At first i would manually search for a string in Debugger, this was a tedious method and would take forever, this is when i started to use NetCheat.

  First in NetCheat i would do a range scan. This would find the places in memory that where being used by the game. I knew to my self that the game had to store all these strings somewhere.

  After i found all the ranges i would dump them from the memory. After dumping i would open each dump in IDA pro and Use its bult in functions to show me all the strings, then it was a simple process of searching a string from ingame. once i found the string IDA would give me its offset. i then searched this offset in NetCheat to find the Pointer.
  
  and then once i found the pointer i would locate a free address in memory and set the pointer to "Point" to that address instead of the origional string address. this is how i bypassed the character limitation.
  
  Ofc this is just a quick explanation of how i did it, this was the best method i found after probably 100+ hours of researching.




Feel free to fix things or recode things and send them to me or whatever. when im bored i will update this with more shit that i find, eventually getting on to the other cods.

But untill then have fun i guess.

     _   __                              _______ 
    | | / /                             / /____ |
    | |/ / _ __ ___  _ __   ___  ___   / /    / /
    |    \| '__/ _ \| '_ \ / _ \/ __| < <     \ \
    | |\  \ | | (_) | | | | (_) \__ \  \ \.___/ /
    \_| \_/_|  \___/|_| |_|\___/|___/   \_\____/ 
                                            

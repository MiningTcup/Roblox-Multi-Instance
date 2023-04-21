# Roblox Multi-Instance
Open this program to run multiple Roblox instances (on different accounts) on the same device. Thanks to [MainDabRblx](https://github.com/MainDabRblx).
I do not care how you use this, do what you like, MIT license. If you give any credit, it should be to [MainDabRblx](https://github.com/MainDabRblx).


**Download** [**Here**](https://github.com/MiningTcup/Roblox-Multi-Instance/releases/tag/v1.0)

***

Instructions
---
1. Open the program
2. Make sure to close all instances of Roblox
3. Press any key
4. You can now open as many Roblox instances as you want on the same device, granted they are on seperate accounts.

***

How it works
---
```c#
new Mutex(true, "ROBLOX_singletonMutex");
```
Basically, this line of code takes control of the part of Roblox that says "No multi-instance for you!" and disables it.
You can see the whole thing in [Program.cs](https://github.com/MiningTcup/Roblox-Multi-Instance/blob/main/Program.cs).

***

More
---
Q. Is this a virus?


A. It's open source, you can look for yourself.


Q. Why does my antivirus ding it?


A. Becuase it uses a mutex, which could be malicious.


Q. Will I get banned from Roblox?


A. Extremly unlikely, as this is not against Roblox ToS and is undetectable anyways. However, I cannot guarantee anything.

# Roblox MultiInstance
Open this program to run multiple Roblox instances (on different accounts) on the same device. Thanks to MainDabRblx.
I do not care how you use this, do what you like, MIT license. If you give aany credit, it should be to MainDabRblx.

Instructions:
1. Open the program
2. Make sure to close all instances of Roblox
3. Press any key
4. You can now open as many Roblox instances as you want on the same device, granted they are on seperate accounts.

How it works:
```c#
new Mutex(true, "ROBLOX_singletonMutex");
```

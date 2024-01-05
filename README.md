# Roblox Multi-Instance
Open this program to run multiple Roblox instances (on different accounts) on the same Windows device.


**Download** [**Here**](https://github.com/MiningTcup/Roblox-Multi-Instance/releases/tag/v1.0)

***

## Instructions
[**Video Tutorial**](https://youtu.be/052rSExTrZY)
1. Open the program
2. Make sure to close all instances of Roblox
3. Press any key
4. You can now open as many Roblox instances as you want on the same device, granted they are on separate accounts.

***

## How it works
```c#
new Mutex(true, "ROBLOX_singletonMutex");
```
Basically, this line of code takes control of the part of Roblox that says "No multi-instance for you!" and disables it.
You can see the whole thing in [Program.cs](https://github.com/MiningTcup/Roblox-Multi-Instance/blob/main/Program.cs).

***
## Malware
I want to address any concerns about the legitimacy of this software. OpenResize is distributed under the MIT license, and I encourage users to review the source code and compile it themselves for assurance.

> "In no event shall the authors or copyright holders be liable for any claim, damages, or other liability, whether in an action of contract, tort, or otherwise, arising from, out of, or in connection with the software or the use or other dealings in the software." - [MIT License](https://opensource.org/licenses/MIT)

If you have any questions or concerns about OpenResize, feel free to contact me through appropriate channels. I appreciate your understanding and cooperation.
***
## More
Q. Why does my antivirus ding it?


A. Because it uses a mutex, which could be malicious.


Q. Will I get banned from Roblox?


A. Extremely unlikely, as this is not against Roblox ToS and the exploit is undetectable anyway. However, I cannot guarantee anything, and, as Roblox is banning alt accounts, try not to be too suspicious.

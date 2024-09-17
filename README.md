iOptron_Mount_Control written by Lawrence Widacki.

This source is Open-Source and may be modified to your liking using a branch Pull request.

It's just a simple manual control program for iOptron CEM GEM telescope mounts.
Coded in C# using Microsoft Visual Studio.
Have not added in any Exceptions to the code yet because need to get a working version going first.

I did find a few issues with the CEM firmware and have written iOptron support about the issues. No responce yet as of 03-21-2024.

02-05-2024 Addin was the Periodic Error Correction tracking & record and the Reset PEC recording.

03-21-2024 Added 'Slew to Object' - requires internet to search SIMBA for data using https://.

11-13-2024 Added Sidereal Time to Main_Control form

11-16-2024 Fixed so the mount models listed in "iOptron Mount RS-232 Command Language" version 3.10 are only used.

11-17-2024 Made changes to the main control panel (upper left) to add in BaudRate and once connected to the mount, prevent changing BaudRate and COM port while connected to the mount.

Future addins:

4. Make the program ASCOM compatible. - This feature may take awhile because I have to write an ASCOM driver for it.



View of the main control panel


![MainControlPic](https://github.com/user-attachments/assets/cd475902-514a-410a-8eb0-de89e7eb1f9c)

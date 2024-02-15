iOptron_Mount_Control written by Lawrence Widacki.

It's just a simple manual control program for iOptron CEM GEM telescope mounts.
Coded in C# using Microsoft Visual Studio. 

I did find a few issues with the CEM firmware and have written iOptron support about the issues.
One issue is the meridian flip's Degrees Past Meridian should be Minutes Past Meridian.
  The reason is that in astrophotography, it's better to know the amount of time one has before doing the flip past meriadian.
  Another reason is 1 degree is 4 minutes on earths rotation and one would have 0 to 40 minutes vers 0 to 10 degrees.
  It would be better control.
Latest addin was the one button Periodic Error Correction tracking & record and the Reset PEC recording.

Future addins:
1. Manual entering RA & DEC coordinates or ALT AZ coordinates.
2. Manual entering location and time.
3. Slew to object.  ......................... Next
4. Make the program ASCOM compatible.

# CustomSwitch
Custom switch for app Windows Forms .NET

![alt text](https://www.marcopuccio.com/GitHubSwitchImgs/1.JPG)
# Getting Started
After compile the control in release mode, in ..Bin/Release there will be a .dll file. In my case "Interruttore.dll".

![alt text](https://www.marcopuccio.com/GitHubSwitchImgs/2.JPG)

<b>Insert the Switch control into the ToolBox in Visual Studio</b><br>
1. Open Visual Studio's Toolbox,
2. Right mouse button and click in "Choose items" (Scegli elementi in Italian Language)  ![alt text](https://www.marcopuccio.com/GitHubSwitchImgs/3.JPG)<br><br>
3. In the tab ".NET Framework Component", click in Open (Sfoglia in Italian Language)  ![alt text](https://www.marcopuccio.com/GitHubSwitchImgs/4.JPG)<br><br>
4. Go to Bin/Relese directory of SwitchControl and click in dll file ![alt text](https://www.marcopuccio.com/GitHubSwitchImgs/5.JPG)<br><br>
5. Click OK and the control is addedd in your ToolBox.<br>

<b>Add Switch Control in Forms</b><br>
For add the control in Windows Forms, you can drag and drop the control from ToolBox in Windows Forms

<b>Events Of Control</b><br>
The control generates two events: 
<code>Private Sub Interruttore1_SwitchOFF() Handles Interruttore1.SwitchOFF</code>
and <code>Private Sub Interruttore1_SwitchON() Handles Interruttore1.SwitchON</code><br>

<b>Property Of Control</b><br>
The control has some property: 
- <code>State:</code> This property get or set the status of the control. Is possibile change this value from code and Property Box of control in the Appearance category<br>
- <code>NoTextState:</code> This property display or hides the control status text. <br>

<b>Basic Example of functionality:<b><br>
In the Off Event
<code> 
        PictureBox1.Image = My.Resources.spenta <br>
<br>
</code><br>
![alt text](https://www.marcopuccio.com/GitHubSwitchImgs/6.JPG)

In the On Event
<code> 
        PictureBox1.Image = My.Resources.accesa <br>
<br>
</code><br>
![alt text](https://www.marcopuccio.com/GitHubSwitchImgs/7.JPG)

# More Information
This project was created for educational purposes only. It is available to everyone for download and is open to modifications.

# The Author
My name is <a href='https://www.marcopuccio.com/'>Marco Puccio</a>, I am a software developer from Palermo. I love technology in all its forms. I also deal with IT teaching.


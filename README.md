
# PCTO2024
This repository contains all of the code, examples and sketches used during our GameAbility Unity project.


## TEAM
Our team is composed of 4 ITIS students from Cuneo, Italy.

## Simone Arrigoni
**Simone Arrigoni** is the group leader and manager, he had the most impact on the project because he tried his hardest to get to know as much as possible about **Microsoft Hololens 2** and, thanks to **Leonardo Pollicino**, he managed to transfer the **Unity** projects into **Hololens 2**

## Leonardo Pollicino
**Leonardo Pollicino** had the most impact regarding the implementation of **Unity** in **Hololens 2**, he has also looked into the **C#** programming language to help **Karol Bruno** and **Marco Masoero** scripting the **GameObjects**.

## Marco Masoero
**Marco Masoero** has contributed in the **C# scripting** and especially in the process of **brainstorming**, because coming up with doable ideas is absolutely crucial, considering the one and a half week deadline, He also made the website, which can be found at: [marcomasoero.github.io](https://marcomasoero.github.io/).

## Karol Bruno
**Karol Bruno**'s role in the team was converting all of the ideas into code, assigning the **scripts** to the **GameObjects**, and doing research on the coding language **C#**. 
Inevitably, he has also looked into how **Unity** works and gave a contribute to the project.

# DEMONSTRATION
Here are the demonstration videos of the game:
Flow Level: https://www.youtube.com/watch?v=_vb9uKh1L3o
Random Level: https://www.youtube.com/watch?v=8ITSHjMXKj8

# INSTRUCTION MANUAL
- In settings, look for *developer mode* and activate it.
- Download and install **Unity Hub** on your PC
- Download the *HoloTrainer* folder on your machine, 
- If the multiple files  are not already in a folder, put them in one
- THIS FOLDER BECOMES YOUR UNITY PROJECT
- Open **Unity Hub**
- On the left-hand side of the window, you will find the *Projects* tab
- Click *Add*
- Select the folder which contains the project
- The project will get added below the *Add* button
- Open the project
- Now it will ask you to download the right **Unity** version (2022.3.20f1 LTS)
- With **Unity** it will in the *installs* tab a menu with different options you can checkmark
- Checkmark *Visual Studio Community 2022*, *Universal Windows Platform Build Support*, *Windows Build Support(IL2CPP)* 
- Click *Install*
- It will open the *Visual Studio Installer* window
- In this window checkmark *_●_ .NET desktop development_  
_● Desktop development with C++_  
_● Universal Windows Platform (UWP) development_  
● Game development with Unity,*
- On the right-hand side of the screen click *Universal Windows Platform (UWP) development*
- checkmark *
_● USB Device Connectivity (required to deploy/debug to HoloLens over USB)_  
_● C++ (v143) Universal Windows Platform tools_*
- Click *Install*
- Now you want to build the project:
1.  In the menu bar, select  **File**  >  **Build Settings...**.
    
2.  In the  **Build Settings**  window, select  **Universal Windows Platform**. If you see a message "No Universal Windows Platform module loaded.", select  **Install with Unity Hub**.
    
3.  Make sure the following settings are active:
    
    **Architecture**: ARM 64-bit
    
    **Build Type**: D3D Project
    
    **Target SDK Version**: Latest Installed
    
    **Minimum Platform Version**: 10.0.10240.0
    
    **Visual Studio Version**: Latest installed
    
    **Build and Run on**: Local Machine
    
    **Build configuration**: Release (there are known performance issues with Debug)
    
4.  Select the  **Switch Platform**  button. Unity displays a progress bar while it switches platforms.
    
5.  After the switch platform process is finished, click on  **Build** and select an empty directory.
6. Open that same directory and open *_HoloTrainer.sln*
7. Configure Visual Studio for Hololens by selecting the **Release** configuration and the **ARM64** architecture
![enter image description here](https://learn.microsoft.com/en-us/training/modules/learn-mrtk-tutorials/media/037-visual-studio-build-options.png)

**NOTE**: If you don't see "Device" as a target option in Visual Studio, you may need to change the startup project for the solution from the IL2CPP project to the UWP project. To do this, in the Solution Explorer, right-click [your project name](Universal Windows) and then select Set as StartUp Project.
Before building to your device, the device must be in Developer Mode and paired with your development computer. See the section named "Enabling Developer Mode" on this page.

8. Select the deployment target drop-down and then do one of the following:
If you're building and deploying via USB, select Device.
9. Connect your HoloLens to your computer, and then in Visual Studio, do one of the following:

To deploy to your HoloLens and automatically start the app without the Visual Studio debugger attached, select Debug > Start Without Debugging.
![enter image description here](https://learn.microsoft.com/en-us/training/modules/learn-mrtk-tutorials/media/038-start-without-debugging.png)
To deploy to your HoloLens without having the app start automatically, select Build > Deploy Solution.


10. Pairing your device
The first time you deploy an app to your HoloLens from your PC, you'll be prompted for a PIN. To create a PIN:

In your HoloLens and your machine, look for developer settings
Select Pair. This displays the PIN in the HoloLens.
Enter the PIN in the dialog in Visual Studio.
After pairing is complete, in the HoloLens, select Done.
Your PC is now paired with your HoloLens and you can deploy apps automatically. Repeat these steps for every PC that's used to deploy apps to your HoloLens.

11. Running your app on your HoloLens
After your app finishes building, in the HoloLens Start menu, find your app, and then select it.

# DO IT YOURSELF
If you want to make a **Unity** Hololens project yourself, follow this tutorial: 
https://learn.microsoft.com/en-us/training/paths/beginner-hololens-2-tutorials/

**NOTE**: If you are following the Italian version of the tutorial: **DO NOT SELECT "Mixed Reality Toolkit Foundation"** in *Mixed Reality Toolkit* in *Microsoft Mixed Reality Feature Tool*

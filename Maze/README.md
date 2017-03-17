# Maze

In this maze the player moves through waypoints to find the hidden key that opens the gate. Along the way coins can be collected. 

![alt tag](https://github.com/devreis/Udacity-VRDeveloper/blob/master/Maze/Screenshots/AerialFrontView.png?raw=true)

## The process

In this project i designed the maze with the given itens and used C# scripting and Monobehaviour built-in methods to interact with itens and make them interact with each other: coins that disappears when clicked, sparkling particles and sound; a gate that play different sounds based on the key status; the gate moves upward when the user have the key; the fake wall that contains the key is destroyed with the click and reveal the key; if the final UI panel is clicked the player is teleported to the initial state.

## My experience

I learned a lot in this project, mainly programming. I spent a lot of time dealing with how to make the door interact with the key and sounds.

## How to run

**Tested on Unity 5.5.1f1 and GVR 5.0.3**

To run the VR experiences you will need to follow these steps:

- Download the Google GVR SDK for Unity indicated on the README.md project 
- Open the downloaded project and click the GVR Unity installer and import all
- Build and export the app for your platform 

###If you see any Unity error follow these steps:

- Select the option **Import All** in Unity
- Restart the Project

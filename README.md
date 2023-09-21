# ARMAZE
In this project, we creating an AR Maze programe. and we're using Unity to build that. Based on this AR Maze, we trying to use camera to scan the image target. Next to let camera show out the virtual target. Meanwhile, to make an AR Maze, we also need a plugin tool called Vuforia. This also build in the Unity platform.
<img width="768" alt="image" src="https://github.com/sphexas/ARMAZE/assets/37029200/e45beaf7-67db-4611-b300-ffb401be05c8">

The game is an interactive ball maze that can be built to Android or IOS. It utilizes the front facing camera to track an image target. 
Also, we need a maze picture to be an image target. ![F16WBMDIQ6VC5V2](https://github.com/sphexas/ARMAZE/assets/37029200/1a59fc9e-ec01-4e06-b985-38f979d5bfdf)


Building steps
#Add Image Target
Create a developer account on Vuforia and add the above picture to your image target database. Download a copy of the database for Unity 3D as well as the Vuforia plugin for Unity.
<img width="761" alt="image" src="https://github.com/sphexas/ARMAZE/assets/37029200/c4948526-072a-4e6b-a5ad-d21a2af7e876">

Import Vuforia plug-ins and image databases into Unity. 
In the Vuforia folder, create a prefab and drag it into the hierarchy. Then find the imageTarget prefab, import our image target and drag it into the hierarchy. That image target will be our scanning target, once the camera finding this target, it will show out the virtual object.
![F1ZE66CIQ6VCCD7](https://github.com/sphexas/ARMAZE/assets/37029200/72faca1a-ebaa-4666-a2ea-47719bfc738e)

#Create virtual target
In the scene, move the imageTarget prefab a few units away from the camera. Drag it onto the ARCamera prefab (make it a child).
Here you need to pay attention to the proportion, the proportion of the cube on the image target and the proportion on the camera. Also, the proportion of the cube and the proportion of the image target.

#Functionality and code to create a ball
Use a cube to create a 3D copy of the maze on top of the image target. Make a small sphere and create a new material.
Drag the new material onto the sphere and give it a bright color.

Create a cube and place it above the maze (this is going to be the spawn point for the sphere). Remove the mesh renderer and collider of the sphere.
Add a C# script to the sphere, call it "ballScript". This function is for the ball running. Our purpose is spawn the ball into the maze, and move the maza that let ball running in it. Finally to pass the maze. Once it done, it will show the conguatulations page. Also, it will spawn the ball again.
![FCTHW4OIQ6VCDNO](https://github.com/sphexas/ARMAZE/assets/37029200/e19c2294-53f5-4f30-b7b6-b34ec6fb1152)

#UI implementation and 3D mode testing
We also create a 3D mode maze game, this one is for testing our thinking and backlog, some of it may have problem or error to add into the AR maze project.
In the project, we add UI interface to let player choosing the mode, and level of it. Also, we can add music, time count, and some other function in it.
<img width="770" alt="image" src="https://github.com/sphexas/ARMAZE/assets/37029200/ff85ce42-f720-4a21-ae3e-992417ed564e">

Here is our 3D Maze project link: https://github.com/Yucong-cheems/3Dmaze.git

# ARMAZE
In this project, we creating an AR Maze programe. and we're using Unity to build that. Based on this AR Maze, we trying to use camera to scan the image target. Next to let camera show out the virtual target. Meanwhile, to make an AR Maze, we also need a plugin tool called Vuforia. This also build in the Unity platform.
![F16WBMDIQ6VC5V2](https://github.com/sphexas/ARMAZE/assets/37029200/1a59fc9e-ec01-4e06-b985-38f979d5bfdf)
<img width="768" alt="image" src="https://github.com/sphexas/ARMAZE/assets/37029200/e45beaf7-67db-4611-b300-ffb401be05c8">

The game is an interactive ball maze that can be built to Android or IOS. It utilizes the front facing camera to track an image target. 
Also, we need a maze picture to be an image target.
<img width="426" alt="image" src="https://github.com/sphexas/ARMAZE/assets/37029200/76439854-3b95-43ff-9686-245b01e1f351">
<img width="435" alt="image" src="https://github.com/sphexas/ARMAZE/assets/37029200/921b4b30-8e9a-4816-9ab6-ac92dd936a11">


Building steps
Create a developer account on Vuforia and add the above picture to your image target database. Download a copy of the database for Unity 3D as well as the Vuforia plugin for Unity.
<img width="761" alt="image" src="https://github.com/sphexas/ARMAZE/assets/37029200/c4948526-072a-4e6b-a5ad-d21a2af7e876">

Import Vuforia plug-ins and image databases into Unity.

In the Vuforia folder, create a prefab and drag it into the hierarchy. Then find the imageTarget prefab, import our image target and drag it into the hierarchy.


In the scene, move the imageTarget prefab a few units away from the camera. Drag it onto the ARCamera prefab (make it a child).
Here you need to pay attention to the proportion, the proportion of the cube on the picture target and the proportion on the camera.

Use a cube to create a 3D copy of the maze on top of the image target. Make a small sphere and create a new material.

Drag the new material onto the sphere and give it a bright color.

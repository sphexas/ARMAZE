# Read Me

In this project, we creating an AR Maze programe. and we're using Unity to build that. Based on this AR Maze, we trying to use camera to scan the image target. Next to let camera show out the virtual target. Meanwhile, to make an AR Maze, we also need a plugin tool called Vuforia. This also build in the Unity platform.

The game is an interactive ball maze that can be built to Android or IOS. It utilizes the front facing camera to track an image target. 
Also, we need a maze picture to be an image target.
![F16WBMDIQ6VC5V2](https://github.com/Yucong-cheems/ARMAZE/assets/37029200/146f2a92-bc1e-4211-a086-870678238238)


![image](https://github.com/Yucong-cheems/ARMAZE/assets/37029200/2004275d-80df-4f6a-9f50-00e3b1188d37)
Building steps
Create a developer account on Vuforia and add the above picture to your image target database. Download a copy of the database for Unity 3D as well as the Vuforia plugin for Unity.

Import Vuforia plug-ins and image databases into Unity.

In the Vuforia folder, create a prefab and drag it into the hierarchy. Then find the imageTarget prefab, import our image target and drag it into the hierarchy.
<img width="762" alt="image" src="https://github.com/Yucong-cheems/ARMAZE/assets/37029200/d905ab86-e522-4ef1-b1be-57312ed1bd76">


In the scene, move the imageTarget prefab a few units away from the camera. Drag it onto the ARCamera prefab (make it a child).
Here you need to pay attention to the proportion, the proportion of the cube on the picture target and the proportion on the camera.
<img width="757" alt="image" src="https://github.com/Yucong-cheems/ARMAZE/assets/37029200/f2a15f43-817c-439f-b479-fe8c61f7f778">

![image](https://github.com/Yucong-cheems/ARMAZE/assets/37029200/55a60110-5b39-46b9-993d-d3a534ccc43e)


Use a cube to create a 3D copy of the maze on top of the image target. Make a small sphere and create a new material.

Drag the new material onto the sphere and give it a bright color.

AR Maze Program

Welcome to the AR Maze Program! This project explores the creation of an Augmented Reality (AR) experience centered around a virtual maze. In addition to building the AR maze using Unity, we've also utilized a 3D project for testing and verification purposes.

Implementation Steps:

Unity and Vuforia Integration: To bring this project to life, we've harnessed the power of Unity and the Vuforia plugin for AR model scanning and generation.

Setting Up Vuforia: To get started, you'll need to create a developer account on Vuforia. Afterward, add an image of the maze to the image target database. Don't forget to download Unity 3D's database and the Vuforia plugin for Unity.

Adding Image Targets: Add your newly created image target to the developer library. This step is crucial for seamless utilization in the subsequent development process.

Unity Setup: Import the Vuforia plugin and your image database into Unity. Within the Vuforia folder, locate and drag the ARCamera prefab into the hierarchy. Similarly, find the imageTarget prefab in the same folder and add it to the hierarchy. To ensure proper functionality, move the imageTarget prefab a few units away from the camera within the scene. Make it a child of the ARCamera prefab.

Creating the 3D Maze: Let your creative juices flow as you construct a 3D replica of the maze atop the image target using cubes. Enhance the visual appeal by adding a small sphere and applying a bright color material to it.

Spawn Point: Designate a cube as the spawn point, positioning it above the maze. This cube serves as the starting point for the sphere's journey through the maze.

Sphere Behavior: Customize a C# script to define the sphere's behavior. The primary goal is to release the sphere from above, allowing it to traverse the maze. As you physically manipulate the AR maze, the sphere follows suit, navigating the maze's twists and turns. Success is achieved when the sphere reaches the exit.

This project combines Unity, Vuforia, and creative coding to deliver an engaging AR maze experience. By following these steps, you'll embark on a journey to create your AR adventure.

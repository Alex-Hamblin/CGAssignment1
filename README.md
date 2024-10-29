Computer Graphics Assignment 1

Lighter Woods

Controls:
WASD to move
First person camera controls

Gameplay:
Find the 4 signboards that have the code on them.
code is from smallest number to largest.
Input the code into the console near the exit door.
You will find this door by looking for the wall that looks different from the others.
Avoid the monster.
When you enter the code correctly the wall will dissapear and reveal the exit.

press 1 turn off color grading.

use 2,3,4,5,6 to switch between different color grading effects. 
Implementation:
All of the Shaders were implemented using ShaderLab

Colour Grading:
Color Grading Shader Code

![image](https://github.com/user-attachments/assets/c36aed67-8220-4e81-8233-275bd1bbe60d)


Color Grading Camera code

![image](https://github.com/user-attachments/assets/0036e2e6-21a5-4192-a84f-de627494c1cd)

Color Grading was added to add a unique visual style to the game and has toggleable options to allow players to enable it if they want. The color grading choices we used were mainly for cold colors as we wanted to achieve a darker, more spookier feel to the games visuals.

Toon Ramp:

![image](https://github.com/user-attachments/assets/efb53cc9-1b36-4351-ac49-72f2d8bd54d5)
![image](https://github.com/user-attachments/assets/f58fe465-596f-49ac-bc13-64f0b0a82a35)




The toon ramp was used to create a unique look to thie environment as well as test how it would look with different colours, we found a way to apply a texture to the toon shader allowing us to achieve the desired effect, keeping the toon lighting while still having the detail from the textures. 



Diffuse:

![image](https://github.com/user-attachments/assets/bf1b8a16-d27b-47bc-b32f-cb5871ae2bb6)

![image](https://github.com/user-attachments/assets/e3c72cb9-96b5-4573-a40c-6009b30209e4)



Diffuse was applied to the ground in one of the areas to showcase the changes in elevation and landscape. This is to experiement with the lighting and how it effects the terrain. we wanted a way to accentuate the differences in the height of the elevation and outline the ground, this was one of the methods that we used to acheve this. We messed with the colours to make the terrain pop out more and fit the style that we were looking for.

Ambient:

![image](https://github.com/user-attachments/assets/deccc69a-dc28-4b37-8384-493a8d3c75ca)
![image](https://github.com/user-attachments/assets/2bf110e8-c82e-4be8-8554-46b38457a84b)





Ambient was applied to the trees to show the difference in the styles and to experiment with different lighting effects on the trees. We changed the colour of the shader to match the theme of the environment that it was in. We found that the trees with the ambient shader had softer lighting tones in the shadows but brighter ones in the light, leading to a very bright object. 

Specular:

![image](https://github.com/user-attachments/assets/8dc81a8c-3e1a-4c41-81fa-3e4de28b477c)
![image](https://github.com/user-attachments/assets/3f75d02a-03cb-47db-98cc-8c04d2695ef0)



specular was applied to the environment to create a ghostly look, we also changed the colour to fit this style. it created a look that made it seem that the light was being absorbed into the ground. Creating a very unique look to the environment, the look we were going for in this area was more of a ghostly possessed environment, which this lighting acheived perfectly. 


Decal:


![image](https://github.com/user-attachments/assets/d070e160-8fac-4f4e-a494-0d6a0623bf77)
![image](https://github.com/user-attachments/assets/6da31bed-37d1-40d8-b977-a7f2cf9af757)


![image](https://github.com/user-attachments/assets/b2ed9d47-9529-4f4a-9f35-3b0f1d97daa1)



The decal was used to apply different textures to the signs, we experimented with 2 different methods of applying decals, one way was to apply the number texture then the decal over top, the other way was to apply a decal then the texture so that the texture would only show through the area that the decal was on.

Alpha:

![image](https://github.com/user-attachments/assets/b3bc9a3b-a4d6-41da-be06-79d3878db23b)

The Alpha Transparency was used to create numbers on some of the signboards around in our game. It's useful as we're able to display the numbers we need without needing to create a special texture for the objects themselves that contains the numbers It also helps as we have some holographics trees as some sort of ghost tree but because the alpha transparency can only be seen from the front then players won't be able to just see what the number is from behind the object.

Hologram:

![image](https://github.com/user-attachments/assets/bfc573f4-647f-4fce-8a4b-d9fe405f1e8d)

Was modified to add the properties of Rim Intensity to the base hologram shader. The Emission of the shader was increased to provide a brighter color and effect to the shader. Rim intensity is meant to control how strong the glow effect of the holgram is and thus is multiplied into the emission equation to have the effect working and more noticeable. This effect was used as for a more spooky atmosphere we figured applying it to some trees could act as a nice looking effect but could be seen as a sort of ghost tree or ghost effect. 

Reference used for the hologram shader: https://medium.com/@FeGameArt/unity-tutorial-rim-light-shader-905380b28600
The code was used for it's code portions on rim intensity both as an idea and how to set-up the rim intensity property.

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



The toon ramp was used to create a unique look to thie environment as well as test how it would look with different colours, we found a way to apply a texture to the toon shader allowing us to achieve the desired effect, keeping the toon lighting while still having the detail from the textures. 



Diffuse:

Ambient:

Specular:

Decal:

Alpha:

![image](https://github.com/user-attachments/assets/b3bc9a3b-a4d6-41da-be06-79d3878db23b)

The Alpha Transparency was used to create numbers on some of the signboards around in our game. It's useful as we're able to display the numbers we need without needing to create a special texture for the objects themselves that contains the numbers It also helps as we have some holographics trees as some sort of ghost tree but because the alpha transparency can only be seen from the front then players won't be able to just see what the number is from behind the object.

Hologram:

![image](https://github.com/user-attachments/assets/bfc573f4-647f-4fce-8a4b-d9fe405f1e8d)

Was modified to add the properties of Rim Intensity to the base hologram shader. The Emission of the shader was increased to provide a brighter color and effect to the shader. Rim intensity is meant to control how strong the glow effect of the holgram is and thus is multiplied into the emission equation to have the effect working and more noticeable. This effect was used as for a more spooky atmosphere we figured applying it to some trees could act as a nice looking effect but could be seen as a sort of ghost tree or ghost effect. 

Reference used for the hologram shader: https://medium.com/@FeGameArt/unity-tutorial-rim-light-shader-905380b28600
The code was used for it's code portions on rim intensity both as an idea and how to set-up the rim intensity property.

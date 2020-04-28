# Pokemon_go_simulator

Introduction:
Player live in a world full of Pokemons, what player needs to do to is to walk around and find pokemons. Thus, this is a VR game based on LBS and 3D objects registration. It combines the real world map with the virtual word. In the game, player can see their location of real world is showed on a rendered virtual map. When player click the scan area map, they can see pokemons was generated around them. Player can go to the location of those pokemons and interact with those pokemons. Then, player can turn on their camera to see a pokemon around them and throw a ball to the pokemons. When the ball hit the pokemons, that means player catch a pokemon and player can put them in the box to store.  
AR Application Design
1.	LBS
LBS means the location based services. LBS uses various types of positioning technology to obtain the current location of the positioning device, and provide information resources and basic services to the positioning device through the mobile Internet. LBS users can first use positioning technology to determine their spatial location, and then players can obtain location-related resources and information through the mobile Internet. In this game, I use the plugins call GO map to do the job. GO Map is a dynamic map SDK for making location based games with unity 3D. Highly customizable with the classic Unity inspector interface GO Map is the easiest map plugin around.
2.	  Pokemon catching
When the player go to the location of the pokemon, the game will open the camera  and player can see the pokemon is hanging in the air before the player. This is done by registering the 3D object of the camera. Then the program will use the prefabs of balls to generate a ball on the location of camera. Player can touch the screen to throw the ball to the pokemon to catch them.

Integration
1.	Hardware
An android phones with GPS open because this game need the GPS signal of the use’s phones. 
2.	Software
(1)	Unity2017
I develop this project on the Unity2017, because it is stable. I tried Unity 2019 and Unity 2018, but the plugins I use do not support, so I give up the newer version.
3.	Plugins
(1)	Go map
Go Map uses vector map data to procedurally generate meshes in the scene. Vector map tiles contains all the information to render a map without the use of images. Vector tiles are way more efficient than raster (images) in terms of size, internet traffic, and resolution.
(2)	Vuforia
Vuforia is an AR SDK to develop a AR app on the mobile devices through unity. It mainly uses the computer vision technology to recognize and track planar images and 3D objects in real time. I use this SDK to do the part of catching pokemons after player go to the location of pokemons.
(3)	Android SDK
This SDK make it possible to develop an android game through Unity. Just in the Build settings, select the platform as Android except PC, users can have an android APP.
4.	Audio resource
All of the audio resources are from Internet, but no commercial use. 
1.Background music 
Pokemon
5.	3D Models
All of the 3D models are from Internet and free, but no commercial use. 
(1)	Pokemons
I don’t have 3D pokemon models, so I replace them by some 3D models of animals.
(2)	Balls
One prefab of ball.
(3)	3D objects
Made by unity
User experience
The main work of this project focuses on the LBS about how to generate pokemons near the location of player and how to intact with pokemons in the AR camera. 
At first, players can see their location on a real world map. After click the scan area button, some pokemons and balls will appear. Players need move to catch those things. When players go to pokemons’ location, AR camera will open, players need to throw balls on the pokemons to catch them and put them on the box. 
This app actually combine real and virtual, and player can interact with virtual objects in real time.
Conclusions
Considering initial design goals, most features are completed, LBS, catching.I have learned a lot from this project. However, there are also many improvements can be made.
Improvement
Network feature. Different player can see the same pokemon on the map and they can compete with each other. The first one arrive at the position of pokemon get the pokemon.

Appendix 2:
I think Go map is very useful plugins and have a lot of potentials.
Appendix 3:
1.	Just install the apk like all the android apps.
2.	Some permissions are required, such as GPS, camera. User need agree all.
3.	Click the scan area to find pokemons.
4.	Throw balls on the pokemon to catch them. 

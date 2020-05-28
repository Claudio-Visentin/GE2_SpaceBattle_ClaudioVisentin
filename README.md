### Claudio Visentin
# Star Trek - Deep Space Nine </br> Sacrfice of Angels Battle

# Assignment Description
The goal of the current assignment is to recreate the space battle in the episode "Sacrfice of Angels" from the serie "Start Trek- Deep Space Nine".
All the "animations" seen in the recreation should work thanks to code and AI and not by using the animator in Unity.

# Scene Breakdown
## Scene 1
![Scene 1](https://github.com/Claudio-Visentin/GE2_SpaceBattle_ClaudioVisentin/blob/master/Screenshots/Scene%201.png)
- The camera should follow the first spaceship and then pan out to show all of the four attacking spaceships.
- This scene is a great benchmark for the colour palette and lightning used thorough the clip.
- Everything in the action, while hectic, is always clear to the eye - viewers can see all spaceships at all time.

## Scene 2
![Scene 2](https://github.com/Claudio-Visentin/GE2_SpaceBattle_ClaudioVisentin/blob/master/Screenshots/Scene%202.png)
- In this scene, we see the protagonists organising for the battle that just started, with the captain pushing onward.
- Since this is a live action scene, it could be implemented either in a very stylized fashion with different models, or as a clip playing in-between the spaceships battling.

## Scene 3
![Scene 3](https://github.com/Claudio-Visentin/GE2_SpaceBattle_ClaudioVisentin/blob/master/Screenshots/Scene%203.png)
- In this short scene, we see the spaceships from scene 1 fighting their way through the enemy fleet.
- The camera is in front of the protagonists, looking and moving with them.

## Scene 4
![Scene 4](https://github.com/Claudio-Visentin/GE2_SpaceBattle_ClaudioVisentin/blob/master/Screenshots/Scene%204.png)
- In this scene, we see new Klingon units entering the battle and breaking the Dominion's defense lines.
- The camera is in two different static positions, looking at the ships entering the fight

## Scene 5
![Scene 5](https://github.com/Claudio-Visentin/GE2_SpaceBattle_ClaudioVisentin/blob/master/Screenshots/Scene%205.png)
- In this scene, we see the crew discussing what's happening and making plans for what to do, deciding to enter the Dominion's lines.

## Scene 6
![Scene 6](https://github.com/Claudio-Visentin/GE2_SpaceBattle_ClaudioVisentin/blob/master/Screenshots/Scene%206.png)
- In the final scene, we see the Defiance breaking through followed by the Klingons and at the end destroying a massive spaceship

# Instructions
Download the project, press play and simply click "Start", the scene will play by itself.

# How Does It Work
The project is timed and directed by a main script which, thanks to a coroutine, times the start of each scene.
During each scene, the main spaceship will follow a trail set through waypoints while the friendly spaceships will either follow the main one or follow their own path.
A separate script will time the laser shots each spaceship take.
The cutscenes with human characters have been left intact in order to focus more on the spaceships scenes.
Another script also times the explosions, spawning an "explosion effect" and destroying the spaceship models.

# What I Am Most Proud Of
I am mainly proud of the level of cinematic quality accomplished in the assignment, using proper camera angles, effects and post-processing.
I am also proud of how the action syncs up well with what happens in the recreated scenes.

# List of Assets used and Credits
- Post Processing Stack by Unity
- Spaceships models by Viktor Hahn, licensed under the Creative Commons Attribution 3.0 Unported License - found on OpenGameArt (https://opengameart.org/content/spaceships-6) (https://opengameart.org/content/more-spaceships)
- FX Explosion Pack by GAPH on the Unity Asset Store (https://assetstore.unity.com/packages/vfx/particles/fire-explosions/fx-explosion-pack-30102)
- Starfield Skybox by Pulsar Bytes on the Unity Asset Store (https://assetstore.unity.com/packages/2d/textures-materials/sky/starfield-skybox-92717)
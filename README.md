# Purpose
This script allows you to play a natural walking sound when your character's feet touch the ground. 

# Installation
* Create two small spheres, make them children of both feet and place them so that they barely touch the ground while your character is standing. Disable the spheres' renderer, but keep the sphere colliders. 
* Attach an "Audio Source" to any object in the scene. You do not need to manipulate anything here. 
* Attach the script "FootstepsSound.cs" to any object. Insert your feet colliders in "Feet", the ground in "Ground1", the "Audio Source" you just created, and some audio files in "Footstep Sounds1" (There are many free ones on the internet, e.g. in the asset "Free Footsteps System".). It is nice to have various audio files which are similar, but not identical: the script will randomly draw one of them for each step, resulting in a more natural sound than using the same audio file for each step.
* Press play and let your character walk somewhere. 

# Extend
* This script is meant to be a simple solution to just play one type of walking sound for your character(s). While it is extendable to account for different surfaces elicitating different sounds, there exist more elegant assets to achieving complex walking sounds (e.g. "Free Footsteps System" on the Asset Store). These systems involve several scripts which interact with each other, taking some more time to set up. 


# License
This script runs under the GPLv3 license.

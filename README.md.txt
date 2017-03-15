# Purpose
This script allows you to play a natural walking sound precisely when your character's feet touch the ground. 

# Installation
* Create two small spheres, make them children of both feet and place them so that they barely touch the ground while your character is standing (this may need some fine-tuning: if the spheres are placed too high, they may miss triggering a sound on some steps - placing them too low may result in double sounds during a single step when the character is walking a curve). Disable the spheres' renderer, but keep the sphere colliders. 
* Attach an "Audio Source" to any object in the scene. You do not need to manipulate anything here. 
* Attach the script "FootstepsSound.cs" to any object. Insert your feet colliders in "Feet", the ground in "Ground1", the "Audio Source" you just created, and some audio files in "Footstep Sounds1" (for example the ones in this repo, but there are many free ones on the internet). It is nice to have various audio files which are similar, but not identical: the script will randomly draw one of them for each step, resulting in a more natural sound than using the same audio file for each step.
* Press play and let your character walk somewhere. 

# Extend
* This script is meant to be the simplest possible solution to just play one walking sound for your character(s). While it is extendable to account for different surfaces elicitating different sounds, there exist more elegant assets to achieving complex walking sounds (e.g. "Free Footsteps System" on the Asset Store). These systems involve several scripts which interact with each other, taking some more time to set up. 


# License
The script "FootstepsSound.cs" runs under the GPLv3 license. The audio files were published in the "Free Footsteps System". 

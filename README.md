# GenerationSTEM-Tutorial
A GenerationSTEM block coding tutorial for fifth grade classes to prepare/teach students about block coding with Cue Robots. It starts by giving the student the option to start the block code activity or to watch the block code tutorial.

In the block code tutorial, there is an animation that explains the students what each component of the screen is meant for. Before students start the block code activity, there is a prompt of the task they should complete with the block code. Then it transitions to the block code activity screen.

There are four scenes in this Unity Project:

1. Start Scene - gives the 2 options to the students (start activity. tutorial)
2. Tutorial Scene - simple animation
3. Transition Scene - a simple animation that explains the prompt(the coding task students should do)
4. Game Scene - the block code activity

Main Scripts:
AniLoader.cs - for the tutorial animation, loads them in order 
SceneLoader.cs - for every time a scene has to be transitioned(changed)
BottonLoader.cs - used in Game Scene for when certain buttons are clicked
OnMouse.cs - does the command on mouse down()

More Details:

In the AniLoader.cs the animation works by using IEnumerators to load up the next simple animation (game object). It destroys the previous game object that has audio so the next game object can be loaded.

Tutorial Scene: there are grouped game objects that are for the animations. Each group displays at its given time.

Game Scene is currently not finished. There is a text that says "Currently still being worked on". Button features work but actually developing working block code and assigning that code to move the bicycle have to be done.

The character animation was done by a Graphic Arts student at Cal Poly.
Some of the art work for the buttons was taken from the Cue Robot app.


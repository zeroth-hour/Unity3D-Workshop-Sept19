# Unity Tutorial: Simple Hat Trick Catch Game.

Hi, this is a simple tutorial on how to create a Catch Game for Unity.  It's adapted from [these](https://www.youtube.com/watch?v=N_U7GNchLZc&t=1469s) [three](https://www.youtube.com/watch?v=oFzT17M1Xxs&t=271s) [links](https://www.youtube.com/watch?v=18f9GhseTwM) and updated to the latest version of Unity (verified on 2019.1.0f2).

# Tools

You'll need Unity and assets to get started.  Download Unity at https://unity.com/

Importing the assets will come later.  

# Starting a new project

Open the Unity Hub and create a new project, and use the 2D template.  Import the assets you downloaded by going straight to https://assetstore.unity.com/packages/templates/hat-trick-the-catch-game-80408, purchasing the asset (it's free) and open it in Unity.  This will open the page in the Unity project.  Hit "Import".  This will cause the assets to be imported automatically into your project.

A scene in Unity is essentially a single level.  You'll only create a single scene for this game.

## Setting up the canvas

Hit the "Game" tab (beside the asset store) and select "Standalone" from the dropdown menu near "Free Aspect".  This fixes your canvas to a specific resolution, which will be useful.

Then open the Sprites folder under Assets/Hat Trick... and drag the HatBackSprite and HatFrontSprite to the scene.  The two sprites combined is your "player" (the hat is trying to catch the bowling balls).
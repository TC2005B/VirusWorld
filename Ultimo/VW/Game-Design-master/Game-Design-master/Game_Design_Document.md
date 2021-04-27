# **Virus World**

<img src="https://user-images.githubusercontent.com/65837382/110890455-adb5db00-82b5-11eb-9db0-cdbab7c9ce05.png">


## _Game Design Document_

![](RackMultipart20210224-4-casz78_html_237499165a11f2b9.gif)

##### **Copyright notice / author information / boring legal stuff nobody likes**

##
## _Index_

 ![](RackMultipart20210224-4-casz78_html_237499165a11f2b9.gif)Index

1. [Index](#index)
2. [Game Design](#gamedesign)
  1. [Summary](#summary)
  2. [Gameplay](#gameplay)
  3. [Mindset](#mindset)
3. [Technical](#technical)
  1. [Screens](#screens)
  2. [Controls](#controls)
  3. [Mechanics](#mechanics)
4. [Level Design](#leveldesign)
  1. [Themes](#themes)
  2. [Game Flow](#gameflow)
5. [Development](#developement)
  1. [Abstract Classes](#abstractclasses)
  2. [Derived Classes](#derivedclasses)
6. [Graphics](#graphics) <ol>
  1. Style Attributes
  2. Graphics Needed </ol>
7. [Sounds/Music](#soundsmusic) <ol>
  1. Style Attributes
  2. Sounds Needed
  3. [Music Needed](#musicneeded) </ol>
8. [Schedule](#schedule)

## _Game Design_

<img src="https://user-images.githubusercontent.com/65837382/110875416-32473000-829b-11eb-8464-87d907c02c50.png" alt="Img1" width="100" height="100">
<img src="https://user-images.githubusercontent.com/65837382/110875437-3d9a5b80-829b-11eb-81c9-efc939dd0236.png" alt="Img2" width="100" height="100">
<img src="https://user-images.githubusercontent.com/65837382/110875461-4723c380-829b-11eb-8e4e-b9d36486dbf3.png" alt="Img3" width="100" height="100">

## Summary

The game consists of two essential parts, open world exploration and puzzles within certain areas.

## Gameplay

The player will start in an open map, where divere structures are to be found, each of these represent the electronic components of a pc, these will be accessible in order for the player to play puzzle minigames that will interactively represent the functions of these components.


## Mindset

It is intended that the player will develope an interest in discovering / unlocking the map, a pleasant and interesting map will be made so that the user wants to know what else there is, what other challenges he can face or what secrets he can find, when starting the unexplored map he will have a shading that will be removed when the player explores a certain area, in the same way there will be blocked parts of the map that will only be accessible when completing a certain amount of puzzles.


## Screens

1. Title Screen
  1. Options
2. Game
  1. Challenges completed counter
3. End Credits

## Controls

The player will be able to move through the arrow keys and will enter automatically each component by just moving through their doors. The puzzle mechanics are yet to be defined individually.

## Mechanics

The main aspect of the general map is pretty much 2D movement in a plane map from a cenital view. The mechanics of each individual component are still in the making to keep the game interesting and not repetitive.


## Themes

1. Motherboard
  1. Mood
    1. Calm, neutral
  2. Objects
    1. _Ambient_
      1. LEDS
      2. Beams of artificial light
      3. Microcomponents
    2. _Interactive_
      1. Components
      2. Breakable objects
      3. Non-breakable objects
2. RAM
  1. Mood
    1. Confusing, active
  2. Objects
    1. _Ambient_
      1. Labyrinth walls
    2. _Interactive_
      1. RAM
_(example)_

## Game Flow

1. Player starts in the motherboard
2. The player can move with the arrow keys
3. The player can explore freely the motherboard seeking for components
4. Player encounters a component and enters it
5. *Each component will have different mechanics

_(example)_

## _Development_

<img src="https://user-images.githubusercontent.com/65837382/110875661-aaadf100-829b-11eb-9dee-61e88df47035.png" alt="Img3" width="300" height="200">



## Abstract Classes / Components

1. Mainframe
  1. Player
  2. Enemy
  3. DestructibleObject
2. Obstacle
3. Collectable


## Derived Classes / Component Compositions

1. BasePlayer
  1. PlayerMain
2. BaseEnemy
  1. RedRobot
3. BaseObject
  1. Component (breakable)
  2. Component (unbreakable)
4. BaseInteractable
  1. Objective (may vary)

## _Graphics_

<img src="https://user-images.githubusercontent.com/65837382/110875800-ec3e9c00-829b-11eb-9980-fda9810e5a6a.png" alt="Img3" width="300" height="200">

## Style Attributes

The colors will try to be representative of IT stereotypes such as green, blue, but not limited to these, in order to resemble components of a PC.
Since it's 2D, it will be cartoony and pixel-y and not precisely realistic of the build of a real PC. Assests will have mainly have marked edges. 

## Graphics Needed

1. Characters
  1. Robots<br>
    1. Blue robot (idle, walking)<br>
    2. Red robot (idle, walking, seeking)<br>
2. Blocks
  1. Borders
  2. Random components
  3. RAM
  4. CPU
  5. GPU
  6. Random breakable components
3. Ambient
  1. Glitches
  2. LEDS

## _Sounds/Music_

https://soundcloud.com/jaime-emilio-828766911 <br>
https://open.spotify.com/artist/7i42XhcctTfHBvHRHMA0mV?si=1TnmpLuQTi2w0OfpsZXJ6g <br>
https://drive.google.com/drive/u/1/folders/1NNeCDcRpgLiupWv6B066B7M1ziq70b-M <br>

All songs written, produced, and arranged by Jaime Emilio Sánchez


## Style Attributes

Some of pre-existing Lawmes tracks share some particular characteristics of videogame music, adding time signature changes representative of prog rock music and some elements from IDM and techno as well that fit the general purpose of the game mood. 

In addition to that, some tracks were composed for the mere objective of adding a particular mood setting to some areas of the game, varying from cathartic music for completing tasks succesfully, passing through friendly exploration music to aggresive and intense tracks for adding pressure to the player.

The game sound effects are yet to be design by the same producer in order to fit the techy setting.


## Sounds Needed

1. Effects
  1. Moving sound (robot sounds)
  2. Enter the component (may vary)
  3. Level complete (may vary)
  4. Level failed (may vary)
  5. Object breaking
2. Feedback
  1. Task completed; (health) 
  2. Hurt; (attacked)
  3. Task failed (e)

(Yet to be produced)

## Music Needed

1. Upbeat, friendlyM track
2. Mysterious, danger injected track
3. Creepy, aggresive, intense track
4. Happy ending cathartic, happy sounding track

## _Schedule_

1. develop base classes
  1. base entity
    1. base player
    2. base enemy
  2. base app state
    1. game world
    2. menu world
2. develop player and basic block classes
  1. physics / collisions
3. find some smooth controls/physics
4. develop other derived classes
  1. blocks<br>
    1. grabbed<br>
    2. thrown<br>
    3. breaking<br>
  2. enemies<br>
    1. robot<br>
5. design levels
  1. introduce grabbing
6. design sounds
7. design music

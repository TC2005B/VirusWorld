# Easy to use Template for Software Requirements Specification
Start with a descriptive and succinct name for your project. Change the above with the name of your project

# Table of content

- [Introduction](#introduction)
    - [Purpose](#purpose)
    - [Scope](#scope)
    - [Definitions and Acronyms](#definitions-and-acronyms)
- [Overall Description](#overall-description)
    - [User classes](#user-classes)
    - [Assumptions and Dependencies](#assumptions-and-dependencies)
- [System Features and Requirements](#system-features-and-requirements)
    - [Functional Requirements](#functional-requirements)
    - [External Interface Requirements](#external-interface-requirements)
    - [Non-functional Requirements](#non-functional-requirements)
- [Screens](#screens)
    - [Wireframes](#wireframes)

<!-- _Table of content generated using VSCode plugin [Markdown TOC](https://marketplace.visualstudio.com/items?itemName=AlanWalk.markdown-toc)_ -->

# Introduction

## Purpose
Create a better understanding of the basics of Computer Science through the use of an online videogame based around STESM topics in Teenagers who are close to applying to university. More specifically explain the hardware of the average personal computer.

## Scope
A 2D puzzle/exploration videogame powered by Unity, thise engine was chosen beacause of its adaptability and ease of use in web projects. 
Another important tool that will be used is WebGl which will be used to render the 2D graphics of the game. 
The game will be as previously noted created in unity and transported to the web using the WebGL build plugin included with Unity.
<!--- Describe the software being specified. Include benefits, objectives, and goals. This should relate to overall business goals, especially if teams outside of development will have access to the SRS -->

## Definitions and Acronyms
- STEAM: Science, Technology, Engineering, Art, Mathematics
- GPU: graphics processor unit
- JS: JavaScript
- 2D: Two dimensions 
- WebGL: Web Graphics Library

<!--- Include any non-trivial definition or acronym used in the document. -->

# Overall Description
The game consists of a 2D cenital perspective exploration game which includes mini puzzles and. 
It's a brand new delivery that's based on existing videogames with similar concepts.
The player will take the role of a character inside a PC. The player's main objective will be to explore the environment and complete the tasks of each of the computer components in order to fix the PC. Each component will have an individual tasks that relates to the 'real-life' behaviour it has and will be a puzzle in nature.

## User classes
- Player: the target audience are college newcomers in whom we intend to delevop an interest for the careers STEAM has to offer through the gaming experience. 
- STEAM: with the information provided by the players, the organization will create an objective analysis about their particular interests while playing the game. 

## Assumptions and Dependencies
- Due to the lack of experience of the team in Unity, we fear a singinficant delay in the finished proyect.
- Remote work is required because of the current global circumstances which could possibly cause communication misunderstandings and decision making troubles.
<!--- There might be factors that impact your ability to fulfill the requirements outlined in this document. What are those factors? -->

<!--- Are there any assumptions you’re making that could turn out to be false? You should include those here, as well. -->
- We assume that we will be able to create a new entertaining puzzle connected to each component.
- We assume that we will be able to find visual and auditory assets to use in the game.
<!-- Finally, you should note if your project is dependent on any external factors. This might include software components you’re reusing from another project. -->
- Our project is dependent on Unity as it is the game engine that is defining all our work, and the WebGL plugin included with Unity.
- 
# System Features and Requirements
- 64bits OS
- 8gb RAM
- 2gb dedicated GPU
- Intel i5 or higher
- Stable internet connection
- Unity installed
- Github
- Zoom
- JS/Unity documentation access

## Functional Requirements 
<!--- The functional requirements describe the services and functions of a system. Functional requirements must be precise and unambiguous.-->

<!--- Include user stories, which are short descriptions of a feature, told from the perspective of one of your end user profiles. They are typically structured in the following fashion:-->

<!---  As a __[type of user]__, I want __[some goal]__ so that __[some reason]__.-->

<!--- You may want to use the following template table.-->
<!---  |_Short identifier_|_As a [type of user], I want [some goal] so that [some reason]_|_Must have_|_Write here any additional consideration_| -->
|Title|User story|Importance|Notes|
|---|---|---|---|
|Enter Game|As a player, I want to be able to enter the game's webpage|User must be able to load page|the user should be able to load the page regardless of the browser|
|Game playthrough|As a player I want to be able to play the game without losing progress|once loaded the game must not crash|the game should be thoroughly tested to prevent game breaking bugs|
|Copmuter Strain|As a player I don't want an online game to generate significant strain on my processor or graphics card|The game must be as efficent as possible|assets, both visual and auditory should be unloaded when not in use, and special effort should be made to make efficient code|

## External Interface Requirements
<!--- External interface requirements are types of functional requirements. They outline how your product will interface with other components or systems.-->

<!--- There are several types of interfaces you may have requirements for, including:-->
<!--- - User-->
<!--- - Hardware-->
<!--- - Software-->
<!--- - Communications-->
### Software
- The User must have a recent version browser.
- The User must have a recent Operating system.
---
### Hardware
- The user must have a recent Processor capable of handling basic to intermediate game rendering.
- Alternatively the User must have a graphics card.
---
### User
- The User must be familiar with the basic game mechanics of platformers and 2D games.

## Non-functional Requirements
<!--- Non-functional requirements are restrictions on the system or the development process. Non-functional requirements can be more critical than functional ones. If they are not met, the system is useless! -->
- Ensure that the information gathered is kept safely.
- Use an SSL certificate on the website

# Screens
<!--- Identifying the individual screens (for an app), or pages (for a website) are where a product’s shape starts to become clear. They are a distillation of the user stories into a set of distinct sections that satisfy the needs and behaviors identified so far. The process of outlining an application’s screens may also highlight any requirements or considerations that have been overlooked up to this point. -->

<!--- This has the dual purpose of both contributing to a more accurate vision of the product early on, and serving as a jumping-off point for the time when designers do get involved. -->

Game start
- basic start of the game with two buttons, one to start the game and another to see the title screen

Map View
- the whole motherboard of a generic PC turned into a walkable map where the user moves areund fixing components and doing puzzles

Puzzle view
- inside every component there are specific rooms, each with a unique view and puzzle that reflects the component

## Wireframes
Wireframes are simple page layouts that outline the size and placement of elements, and features on a page. They are generally devoid of color, font styles, logos or any design elements.

Wireframing is probably the most time-consuming step of this process and for some simple projects, it may be overkill. For complex projects where serious design thinking needs to happen, wireframes are an indispensable tool.

Here are some popular tools for wireframing:
- https://marvelapp.com/  
- https://balsamiq.com/ 
- https://jetstrap.com/ 
- https://www.fluidui.com/ 
- https://ninjamock.com/ 
- https://www.justinmind.com/ 
- https://moqups.com/

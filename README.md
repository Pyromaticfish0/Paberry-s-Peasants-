# First Flight – The AR Experience
In development by the Paberry-s-Peasants-

## Contents
* [Problem](#problem)
* [System Requirements](#system-requirements)
* [Users Profile](#users-profile)
* [Features](#features)
* [Functional Requirements](#functional-requirements)
* [Nonfunctional Requirements](#nonfunctional-requirements)

### Problem:

Each Fall there is an orientation at Discovery Park for 1st-year students. It is called First Flight. Due to the building’s large size, students get horribly lost. It would be nice to have an activity that orients new students to Discovery Park and the department through Augmented Reality. 

The AR application will run on Android phones (see system requirements). As students play the game, they will learn about Discovery Park’s prominent locations. Ideally, at completion of the game students will no longer feel lost. In actuality, students will feel at home.

### System Requirements:
- Android 7.0 or higher
- Preferred resolution of 720×1280 pixels (Not optimized for tablet)
- Strong internet connection (Wi-Fi, 3G, or 4G)
- GPS and Location Services
- Intel CPUs are not supported

### Users Profile
- The application is intended for 1st year students at University of North Texas. 
- Users need basic reading abilities (5th Grade or above reading level). 
- Users need a way to move a smart phone around to interact with AR features.
- Users need a way to navigate around / through Discovery Park. 
- Users need a way to see their phone screen and surroundings.

### Features
- A main menu will be present in the application.
- A play button will be present within the main menu.
- AR interactions on campus, will familiarize students with Discovery Park.
- A head-up display will be present during gameplay.
- A mission log will be present within the HUD.
- User’s coin balance will be present within the HUD.

### Functional Requirements
#### Main Menu

After initial application launch, the system will display a main menu consisting of the following buttons: play, collect, and quit.

#### Play Button

The play button resides within the main menu. After touching play, the main menu will disappear, and the system will begin utilizing the camera. The game has officially started.

#### In-Game Head-up Display

The HUD will allow users to view their coin balance and mission log.

#### Coin Balance

Coins are collected throughout the game’s campaign. The coins are used as a form of in-game currency to purchase clothing / accessories in the store page.

#### Mission Log

The mission log is opened by touching mission log in the HUD during gameplay. The mission log will inform the user of their current in-game objective.

**********************************************************************************************************************************
#### Augmented Images

The system will scan room numbers which will trigger AR events.

From https://developers.google.com/ar/discover/concepts on Augmented Images

Augmented Images allows you to build AR apps that can respond to specific 2D images such as product packaging or movie posters. Users can trigger AR experiences when they point their phone's camera at specific images - for instance, they could point their phone's camera at a movie poster and have a character pop out and enact a scene.

Images can be compiled offline to create an image database, or individual images can be added in real time from the device. Once registered, ARCore will detect these images, the images boundaries, and return a corresponding pose.
**********************************************************************************************************************************


#### Information Display
 
After AR Event has been triggered, information regarding Discovery Park(our school campus) will display to the screen. 

### Non-Functional Requirements
- The system will run on Android 7.0 or above.
- The system will utilize a graphical user interface.
- The system can analyze real life images and produce information based off of those 


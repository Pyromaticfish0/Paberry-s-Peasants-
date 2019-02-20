# First Flight – The AR Experience

Each Fall there is an orientation at Discovery Park for 1st-year students. It is called First Flight. Due to the building’s large size, students get horribly lost. It would be nice to have an activity that orients new students to Discovery Park and the department through Augmented Reality. 

The AR application will run on Android phones (see system requirements). As students play the game, they will learn about Discovery Park’s prominent locations. Ideally, at completion of the game students will no longer feel lost. In actuality, students will feel at home.

In development by the Paberry-s-Peasants-

## Table of Contents

* [System Requirements](#system-requirements)
* [Users Profile](#users-profile)
* [Features](#features)
* [Functional Requirements](#functional-requirements)
  * [Main Menu](#main-menu)
  * [Play Button](#play-button)
  * [Shop Button](#mission-log)
  * [Quit Button](#quit-button)
  * [Shop Page](#shop-page)
  * [Head-up Display](#head-up-display)
  * [Coin Balance](#coin-balance)
  * [Augmented Images](#augmented-images)
* [Nonfunctional Requirements](#nonfunctional-requirements)
* [Ideas and Tips](#ideas-and-tips)
  * [Automatic Placement](#automatic-placement)
  * [Scale and gameplay](#scale-and-gameplay)
  * [Initialization](#initialization)
  * [Interface](#interface)
  * [Easy Controls](#easy-controls)
  * [Onboarding and Instructions](#onboarding-and-instructions)
  * [Landscape and Portrait](#landscape-and-portrait)
  * [Errors](#errors)
  * [Permissions](#permissions)
  * [The Physical Environment Problem](#the-physical-enironment-problem)
  * [Environmental Limitations](#environmental-limitations)
  * [User Movement](#user-movement)
  * [Accessibility](#accessibility)
  * [Safety and Comfort](#safety-and-comfort)  
  
### System Requirements:
**********************************************************************************************************************************
- ARCore supported phone
  https://developers.google.com/ar/discover/supported-devices
- Android SDK 7.0 (API Level 24) or later
- Preferred resolution of 720×1280 pixels (Not optimized for tablet)
- Strong internet connection (Wi-Fi, 3G, or 4G)
- GPS and Location Services
- Intel CPUs are not supported

### Users Profile
**********************************************************************************************************************************
- The application is intended for 1st year students at University of North Texas. 
- Users need basic reading abilities (5th Grade or above reading level). 
- Users need a way to move a smart phone around to interact with AR features.
- Users need a way to navigate around / through Discovery Park. 
- Users need a way to see their phone screen and surroundings.

### Features
**********************************************************************************************************************************
- A main menu will be present in the application.
- A play button will be present within the main menu.
- AR interactions on campus, will familiarize students with Discovery Park.
- A head-up display will be present during gameplay.
- A mission log will be present within the HUD.
- User’s coin balance will be present within the HUD.

### Functional Requirements
**********************************************************************************************************************************
#### Main Menu
- After initial application launch, the system will display a main menu consisting of the following buttons: 
- Play
- Missions
- Shop
- Quit

#### Play Button
- The play button resides within the main menu. 
- After touching play, the main menu will disappear, and the system will begin utilizing the camera. 
- The game has officially started.

#### Missions Button
- The shop button resides in the main menu. 
- After touching shop, the user is take to the shop page.

#### Shop Button
- The shop button resides in the main menu. 
- After touching shop, the user is take to the shop page.

#### Quit Button
- The quit button resides in the main menu. 
- After touching quit, the application will exit.

#### Back Button
- resides in the HUD
- allows users to go back to main menu

#### Missions Page
- The missions page is opened by touching missions in the main menu during gameplay. 
- The missions page will inform the user of their current in-game objective.

#### Shop Page
- Users can spend their coins on in-game skins.

#### Head-up Display
- The HUD will allow users to view their coin balance. 
- The HUD will allow users to exit AR utilizing back button.

#### Coin Balance
- Coins are collected throughout the gameplay.
- The coins are used as a form of in-game currency to purchase in-game skins in the store page.

#### Augmented Images
- The system will scan room numbers which will trigger AR events.
- Augmented Images allows you to build AR apps that can respond to specific 2D images such as product packaging or movie posters. Users can trigger AR experiences when they point their phone's camera at specific images - for instance, they could point their phone's camera at a movie poster and have a character pop out and enact a scene.
- Images can be compiled offline to create an image database, or individual images can be added in real time from the device. Once registered, ARCore will detect these images, the images boundaries, and return a corresponding pose.
- Augmented Images in ARCore lets you build AR apps that can respond to 2D images, such as posters or product packaging, in the user's environment. You provide a set of reference images, and ARCore tracking tells you where those images are physically located in an AR session, once they are detected in the camera view.

##### Is Augmented Images is Suitable for our App
- Each image database can store feature point information for up to 1000 reference images.
- ARCore can track up to 20 images simultaneously in the environment, but it cannot track multiple instances of the same image.
- The physical image in the environment must be at least 15cm x 15cm and must be flat (for example, not wrinkled or wrapped around a bottle)
- Once tracked, ARCore provides estimates for position, orientation, and physical size. These estimates are continuously refined as ARCore gathers more data.
- ARCore cannot track a moving image, but it can resume tracking that image after it stops moving.
- All tracking happens on the device, so no internet connection is required. Reference images can be updated on-device or over the network without requiring an app update.

##### Select Reference Images
- Augmented Images supports PNG and JPEG file formats. For JPEG files, avoid heavy compression for best performance.
- Detection is solely based on points of high contrast, so both color and black/white images are detected, regardless of whether a color or black/white reference image is used.
- The image's resolution should be at least 300 x 300 pixels.
- Using images with high resolution does not improve performance.
- Avoid images with sparse features.
- Avoid images with repetitive features.
- A good reference image is hard to spot with the human eye. Use the arcoreimg tool to get a score between 0 and 100 for each image. We recommend a score of at least 75. Here are two examples: see website for image

##### Optimize Tracking
- The physical image must occupy 40% of the camera image. You can prompt users to fit the physical image in their camera frame with the FitToScan asset. See the Augmented Images sample app for an example of this prompt.
- When an image is initially detected by ARCore, and no expected physical size was specified, its tracking state will be paused. This means that ARCore has recognized the image, but has not gathered enough data to estimate its location in 3D space. Developers should not use the image's pose and size estimates until the image's tracking state is tracking.

##### Create Image Database
- The database stores a compressed representation of the reference images. Each image occupies ~6KB.
- It takes ~30ms to add an image to the database at runtime. Add images on a worker thread to avoid blocking the UI thread, or if possible, add images at compile time with the arcoreimg tool.
- If possible, specify the expected physical size of the image. This metadata improves tracking performance, especially for large physical images (over 75cm).
- Don't keep unused images in the database as there's a slight impact on system performance.
- Each image database can store information for up to 1000 images.
- There two ways to create an AugmentedImageDatabase:
- Load a saved image database. Then optionally add more reference images.
- Create a new empty database. Then add reference images one at a time.

##### Load Saved Image Database
- Use ```AugmentedImageDatabase.deserialize()``` to load an existing image database:
```java
InputStream inputStream = context.getAssets().open("example.imgdb");
AugmentedImageDatabase imageDatabase = AugmentedImageDatabase.deserialize(inputStream);
```
- Image databases can be created using the ```arcoreimg``` command line tool during development, or by calling ``` AugmentedImageDatabase.serialize()``` on a database that contains that is loaded in memory.

##### Create New Empty Database
- To create an empty image database at runtime, use the no-arg ```AugmentedImageDatabase()``` constructor:
```java
AugmentedImageDatabase imageDatabase = new AugmentedImageDatabase();
```

##### Add Images to Existing Database
- Add images to your image database by calling ```AugmentedImageDatabase.addImage()``` for each image:
```java
Bitmap bitmap;
try (InputStream inputStream = getAssets().open("dog.jpg")) {
  bitmap = BitmapFactory.decodeStream(inputStream);
} catch (IOException e) {
  Log.e(TAG, "I/O exception loading augmented image bitmap.", e);
}
int index = imageDatabase.addImage("dog", bitmap, imageWidthInMeters);
```
- The returned indexes can later be used to identify which reference image was detected.

##### Enable Image Tracking
- Configure your ARCore session to begin tracking images by setting the session config to one that is configured with the desired image database:
```java
config.setAugmentedImageDatabase(imageDatabase);
session.configure(config);
```
- During the session, ARCore looks for images by matching feature points from the camera image against those in the image database.

- To get the matched images, poll for updated ```AugmentedImage```s in your frame update loop.
```java
// Update loop, in onDrawFrame().
Frame frame = mSession.update();
Collection<AugmentedImage> updatedAugmentedImages =
  frame.getUpdatedTrackables(AugmentedImage.class);

for (AugmentedImage img : updatedAugmentedImages) {
  // Developers can:
  // 1. Check tracking state.
  // 2. Render something based on the pose, or attach an anchor.
  if (img.getTrackingState() == TrackingState.TRACKING) {
     // You can also check which image this is based on getName().
     if (img.getIndex() == dogIndex) {
       // TODO: Render a 3D version of a dog in front of img.getCenterPose().
     } else if (img.getIndex() == catIndex) {
       // TODO: Render a 3D version of a cat in front of img.getCenterPose().
     }
  }
}
```
- https://developers.google.com/ar/discover/concepts
- https://developers.google.com/ar/develop/java/augmented-images/
- https://developers.google.com/ar/develop/java/augmented-images/guide


### Non-Functional Requirements
**********************************************************************************************************************************
- The system will run on Android 7.0 or above.
- The system will utilize a graphical user interface.
- The system can analyze real life images and produce information based off of those 

### Ideas and Tips
**********************************************************************************************************************************
#### Automatic Placement
- It’s possible for the app itself to populate a scene. 
- Once a surface is detected, the app can start placing objects immediately.
- Automatic placement works best when:
 - A virtual environment is added, without any user input, into the real-world space
 - There’s no interaction, or minimal interaction
 - It doesn’t matter if objects appear in exactly the right spot
- AR mode is crucial to your experience
- AR mode starts when the experience is launched

#### Scale and gameplay
- Playing with scale can add an unexpected aspect to an experience. 
- Being surprised by a huge virtual character, depending on your intention, can be either hilariously surprising or absolutely terrifying. 
- Depending on your goals and the effect you’re trying to create, you can use surprise as a tool to evoke different emotions, whether a horror game or a silly playground.
- You can also communicate scale with sound effects. 
- Alter the scale and pitch of a sound to deepen the user’s immersion in your experience.

#### Initialization
- Make a clear transition into AR
 - Use visuals to let users know they’re about to transition from a 2D screen into AR. 
 - You can dim the phone display or use effects to blur the screen when a transition is about to take place.
- In some apps, only one part of the experience will take place in AR.
- Try to give the user a seamless transition to AR. 
- Let the user launch the transition from a 2D interface to AR. 
 - It’s less jarring when the user is in control.
 - You can include a button, such as an AR icon, to let users trigger the launch themselves.
- Send the user gently into your AR environment. 
 - Use an easy transition, like an animation or a fade out.
- To transition the user into AR, fade from a 2D screen to the AR experience

#### Interface
- Create a world that’s immersive and easy to use
- Immerse users, don’t distract them.
- Try to interrupt your AR world as little as you can. 
- Get users into the experience, and then get out of the way.
- Avoid pop-ups and full-screen takeovers unless the user explicitly selects it. 
- Buttons, 2D alerts, and notifications can distract the user from the 3D world that you’re creating around them. 
- Instead, let users focus on the scene itself.
- Persistent 2D overlays can also disrupt the user’s immersion. 
- It’s a constant reminder that the world they’re looking at isn’t completely real.
- Sudden pop-ups and quick transitions can break the immersive AR experience.

#### Easy Controls
- Make the controls so easy, users won’t have to think about what they mean
- It’s best to keep the user focused on the AR experience itself. 
- Sometimes, however, an app needs to have onscreen controls.
 - In those cases, make the controls as simple as possible. 
- Ideally, a user should be able to trigger an action without looking at it. 
 - Think of the camera button on your phone. 
 - It’s big, it’s not labeled, and you can tap it almost without thinking about it.
- Maintain the continuity of the experience. 
 - Try to avoid taking the user out of a scene too often. 
 - For instance, if users need to select, customize, or share an AR object, try to figure out a way they can do it without leaving AR.

#### Onboarding and Instructions
- Provide an onboarding flow within the experience
- Let users launch AR quickly. 
- Make your tutorial a part of the main experience flow. 
- Avoid teaching users all the key tasks or mechanics at once.
 - Rather, show them how to perform these tasks as they show up in the game. 
- Users won’t be overloaded with information, and they’ll be able to link helpful instructions and tips to the task at hand.
- Gide the user visually
- Use a combination of visual cues, motion, and animation to teach users. 
- Illustrate and use in-app experiences as much as possible. 
- Text instructions can take users out of the experience and make it harder to remember what they’re supposed to do.
 - For example, if you want users to swipe, give them an arrow or a hand icon rather than showing the word “swipe.”
- Use familiar UI patterns
- Take advantage of your users’ knowledge. 
 - If there’s a standard UX interaction model for a certain action, such as tapping or dragging, use it! 
 - You won’t have to teach the user a whole new way to perform simple tasks, and you can dive right into the important part of your experience.

#### Landscape and Portrait
- Provide support for both portrait and landscape modes. 
- If this isn’t possible, select the one that’s best for your experience.
- Supporting both modes creates a more immersive experience and increases user comfort.
- Think about camera and button placement for each mode. 
- Pay attention to how camera positioning affects depth sensing, spatial awareness, and accurate surface measurements in each mode.
- Rotate the UI and avoid cutting the camera feed.

#### Errors
- Help users easily recover from missteps and errors.
- Whether the error came from the system or the user, make it easy to get back into the experience. 
- Use a combination of visual cues, animation, and text to show a clear path to resolution.
- You can communicate what went wrong, especially if it helps avoid that error in the future. 
- Avoid blaming the user. 
- Focus on getting the user to take the right action.
- Sample error states can include:
 - A dark environment: 
  - Too dark to scan. 
  - Try turning on the lights or moving to a well-lit area.
 - User moving device too fast: 
  - Device moving too fast. 
  - Try moving more slowly.
 - User blocking the sensor or camera: 
  - Looks like the sensor is blocked. 
  - Try moving your finger or adjusting the device’s position..

#### Permissions
- Clearly tell users why the app needs certain permissions.
- Ask for permissions only when it’s necessary for users to move forward with the experience.
- Be clear about the relevance and benefits of each permission. 
- For instance, if the app needs access to the camera for AR to work, or the user’s position for multiplayer experiences, let them know.

#### The Physical Environment Problem
- Public spaces provide their own set of challenges for AR: 
- Tracking and occlusion become difficult, depending on the number of objects and people around
- Phone movement and AR immersion can be distracting or dangerous

#### Environmental Limitations
- For now, limitations that may hinder accurate understanding of surfaces include:
- Flat surfaces without texture, such as a white desk
- Environments with dim lighting
- Extremely bright environments
- Transparent or reflective surfaces like glass
- Dynamic or moving surfaces, such as blades of grass or ripples in water
- Possible Solutions:
- When users encounter environmental limitations, indicate what went wrong and point them in the right direction.

#### User Movement
- The user will be moving around in a real-world space:
- Let users know what movements will trigger the app
- Guide them through the types and range of movement possible
- Make easy transitions from one pose or movement to another
- Design for comfort. Try to avoid making the user do anything that’s physically demanding, uncomfortable, or too sudden.
- Try not to require movement until it’s necessary. Getting users to move is a great way to engage them, but let them ease into the experience.

#### Accessibility
- If a user is not able to move around, give them an alternative way to use your app:
- When the user is supposed to move closer to a target, give another way to access the target. 
- Whenever it’s possible, let users tap objects and move them closer, or offer a reticle to help users reach faraway objects. 
- Place text and instructions so they’re visible from every angle.
- Let the user move and rotate an object in case they can’t physically move around it

#### Safety and Comfort
- Sometimes, users can get too immersed in an AR experience. 
- When they pay attention to the phone’s camera and ignore the real world, users can bump into objects, people, and might not notice hazards around them.
- Build in reminders to look around, and sporadically remind them to check their surroundings.
- Don’t make users walk backward
- The danger of bumping into furniture, small animals, or other objects is much greater when a user is moving backward.
- Avoid long play sessions
- Users can get fatigued using AR for extended periods of time. 
- Try to find stopping points in the action or moments when users might need to take a break.
- Holding your phone for a prolonged period of time can be tiring. 
- Encourage users to move around their phone or change the position they’re holding it in. 
- You can also build resting points into the play cycle.
- Let users pause or save their progress. Make it easy to continue an experience where they left off, even if they switch their physical location.

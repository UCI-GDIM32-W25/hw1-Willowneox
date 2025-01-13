[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!
Here is my breakdown for HW1 from the lecture.
-players
	Attributes: bunny sprite
	Actions:
Movement: 
input:WASD
Output: player change location	
Can only be moved in the limitation of the screen window.
	Planting seeds:
		Input: press space
		Output: if player has seeds remaining: 1 seed is planted at player’s location;
Decrease seed count + increase plant count
Objects
-UI
	Seed planted UI: 
-Actions: the number starts with 0 and will increasing as the player hit the space
-Attributes: text
	Seeds remaining UI:
		-Actions: the number starts with 5 and  will decrease as the player hit the space.
		-Attributes: text

How do these objects act on and affect each other
Player plants one seed by hitting the space, by doing this, the seeds planted UI will be added one and seeds remaining UI will be minused one. This will be repeated until the seeds run out.

In the breakdown, I divided the assignment into two main parts: Player and UI. For the movement feature in the Player, I used the "Update" method in the player script, utilizing "Input.GetAxis" to capture the input from WASD and setting up a "Vector3" to allow the player to move. For the planting seeds feature, the script I first used the "Input.GetKeyDown" method to detect the spacebar input, which then triggers the "PlantSeed" method. Regarding the output of this feature, the breakdown pointed out that "PlantSeed" method can only be triggered if there are remaining seeds, so I used an "if" to check whether "_numSeedsLeft >0". If the condition is met, the "PlantSeed" method is called. This method requires that when seeds are still available, a seed object is created at the player's current position.I used the "Instantiate" class to generate the object, with the generated object being the seed prefab, the position being the player's current location (transform.position), and the rotation set to 0. Additionally, I ensured the quantities were updated using _numSeedsLeft--; and _numSeedsPlanted++;.

In the UI portion of the breakdown, the "UpdateSeeds" method in the "PlantCountUI" class dynamically updates the UI's planted seeds (_plantedText) and remaining seeds (_remainingText). 

Although the breakdown was as detailed as possible, I still encountered some issues while implementing various features, especially in the UI section. During runtime, the numbers in the UI did not update in real-time. However, through testing with the console, I found that the values of SeedsLeft and SeedsPlanted were being updated correctly. I suspected that this was due to improper linking of GameObjects in the Inspector. I noticed that in the Canvas GameObject, the PlantCountUI script was already attached and connected to the Text components. After multiple attempts, I understood the rules for connecting different GameObjects. I realized that although I couldn’t directly connect the UI script to the Player in the Inspector, I could link the Canvas GameObject (which contains the UI script) to allow the numbers to update and display correctly on the screen.
	


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

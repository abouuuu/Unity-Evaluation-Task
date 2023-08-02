# Unity Developer Evaluation Task
The project includes a simple scene with an animated capsule, a camera, and a game object that is enabled and disabled during the sequence. The sequence includes playing an audio clip, playing a random animation, moving the camera to a target position, and enabling/disabling a game object.

## How to Use
To use the project, follow these steps:

1. Clone or download the project to your local machine.
2. Open the project in Unity.
3. Open the ExampleScene scene located in the Assets/Scenes folder to see the actions that make up the sequence.
4. Press the play button to run the sequence.

   
## Customization
You can customize the sequence by modifying the actions in the ExampleScene script. You can add or remove animations, change the audio clip, modify the camera movement, and enable/disable different game objects.

## How it Works
- The SequenceController script is responsible for sequencing the actions in the sequence. Each action is a class that inherits from the Action class and implements the Execute method. The SequenceController script creates a list of actions and executes them in sequence.

- The ExampleScene script creates the actions for the sequence. It creates a PlayAnimationAction for each animation, a PlayAudioAction for the audio clip, an EnableDisableGameObjectAction for enabling/disabling the game object, and a MoveCameraAction for moving the camera to the target position.

- The waitForAnimationCompletion and waitForAudioCompletion boolean fields in the ExampleScene script control whether the sequence waits for the animation or audio to complete before moving on to the next action. If waitForAnimationCompletion is true, the sequence will wait for the animation to complete before moving on to the next action. Similarly, if waitForAudioCompletion is true, the sequence will wait for the audio to complete before moving on to the next action.

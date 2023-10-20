# Graphics Settings
Version: 1.0.1
Standard tools for managing graphics and quality settings.

## Use Cases:
* Set screen resolution and fullscreen status
* Monitor framerate through a UI text element
* Set target framerate.
## Package Mirrors:
[<img src='https://img.itch.zone/aW1nLzEzNzQ2ODg3LnBuZw==/original/npRUfq.png'>](https://github.com/Iron-Mountain-Software/graphics-settings)[<img src='https://img.itch.zone/aW1nLzEzNzQ2ODkyLnBuZw==/original/Fq0ORM.png'>](https://www.npmjs.com/package/com.iron-mountain.graphics-settings)[<img src='https://img.itch.zone/aW1nLzEzNzQ2ODk4LnBuZw==/original/Rv4m96.png'>](https://iron-mountain.itch.io/graphics-settings)
## Key Scripts & Components:
### ramerate
1. public class **FramerateText** : MonoBehaviour
1. public class **TargetFramerateSetter** : MonoBehaviour
### esolution
1. public class **FullScreenToggle** : MonoBehaviour
1. public class **ResolutionButton** : MonoBehaviour
   * Properties: 
      * public Int32 ***Width***  { get; set; }
      * public Int32 ***Height***  { get; set; }
      * public String ***AspectRatio***  { get; set; }

# Notes

## Here are the list of notable points regarding the unity


#### 1. Project setting -> Input manager:
* for using different input types

#### 2. Add component -> rigid body
* Attaches the physics
* You can set gravity to the object

#### 3. Post Processing:
* Add Post Process layer to the camera
* Add a new layer
* Assign the Post Process layer the new layer (now we can attach volumes to that layer)
* create an empty object
* Add the post process volume component
* Check the is global to make the effect global
* Add a profile (click new in front of the profile)
* Then add effects (Bloom, Vignette, ...)
* change the layer as well
* to add color grading effect: edit -> project settings -> player -. color space >> change to linear

#### 4. Quaternions and Euler Angles:
* Quaternions have 4 degrees of freedom but angles have three
* Unity uses the Quaternions angle but converts it to Euler angles to be more readable
* You should always change the Quaternions angles

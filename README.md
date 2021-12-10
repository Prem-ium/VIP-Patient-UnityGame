# VIP Patient - Unity Game Project
_________________________________
**(#3) Instruction Manual/Cheat Sheet &amp; (#2) GAME FEATURES**

**Instructions: (#3):**

IMPORTANT: If importing directly through a unity package file, the following attributes may need to be entered into the PLAYER script variables linked within the hierarchy:

![](RackMultipart20211210-4-15bp84f_html_53848839fa96d5d0.png)

**Premise** : A VIP Patient needs urgent transportation to a medical facility in a rural area while there is very little to no light available. It&#39;s your job to swerve and avoid colliding with any vehicles on your way to transport the patient. You&#39;ve been given clearance to do whatever is necessary to ensure no cars stand in your way…. your ambulance is equipped with a high-speed top-of-the-line missile launcher.

Utilize the specially equipped missile with your dare devil sophisticated driving skills to swerve and avoid contact with enemy cars/drivers.

Controls:

&#39;Up&#39; or &#39;W&#39; Start Game (No Hold Required) (No Player controlled Acceleration)

&#39;Left&#39; or &#39;A&#39; Shift Car to Left

&#39;Right or &#39;D&#39; Shift Car to Right

Space Bar Launch Missile Destroy &amp; Nullify any Vehicles in your path

Escape Pause Game Take A Breather

![](RackMultipart20211210-4-15bp84f_html_e8d791d69c3ccf7e.png)

Escape + Restart Button Click Restart Game Restart the game from the very beginning.

![](RackMultipart20211210-4-15bp84f_html_8111f43e9f8e4c27.png) ![](RackMultipart20211210-4-15bp84f_html_bb9c558bc691f46c.png)

Features: **(#2)**

The speed at which the player moves gradually increases every frame. Eventually, this can be mimic a scenario of driving on black ice, where it becomes increasingly difficult for the player not to accidentally swerve and hit an &#39;enemy&#39; vehicle by not planning farther ahead. The Player&#39;s speed, alongside remaining lives, missile ammunition, and time, are displayed on the top left corner of the game view.

Launching a missile can destroy any vehicle that it collides with and register the destroyed vehicle as a non-threat which will not penalize the player for any collisions.

![](RackMultipart20211210-4-15bp84f_html_8f74a82c166945b3.png)

Once destroyed, a vehicle will emit a large FX explosion and be rendered useless in terms of an enemy (lives will not be lost when the player collides or touches a destroyed &#39;enemy&#39; vehicle.)

![](RackMultipart20211210-4-15bp84f_html_43ab7c7054ddf6f8.png)

Two missiles are provided by default, and are the maximum you can hold in reserve. The moment you fire a missile, a new missile will automatically start to regenerate and be added to your arsenal within X seconds (dependent on a number within the script), the default being the following scaled:

![](RackMultipart20211210-4-15bp84f_html_b6000c9c522ecdf3.png)

Within scaled time, 15 seconds, and you&#39;ll have another missile ammunition in your arsenal. But, remember, the more time you survive, the more frequent the enemy cars spawn and the greater your speed.

Collisions with &#39;enemy&#39; vehicles will result in particles being instantiated to provide you with more details regarding when exactly you lose a life. ![](RackMultipart20211210-4-15bp84f_html_67200fb724f2a04f.png)

Just like the real world, lives are unrecoverable, once your vehicle sustains enough collisions, the rich VIP patient is dead Jim. What are you going to say to your bank acc… I mean… to his children.

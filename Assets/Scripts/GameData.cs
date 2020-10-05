using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameData : MonoBehaviour
{
    private int[] id = new int[60];
    private string[] location = new string[60];
    private string[] bodyText = new string[60];
    private string[] option1Text = new string[60];
    private int[] option1LeadsTo = new int[60];
    private string[] option2Text = new string[60];
    private int[] option2LeadsTo = new int[60];
    private string[] option3Text = new string[60];
    private int[] option3LeadsTo = new int[60];

    private List<object> objects = new List<object>();

    private void Awake() => InitializeObjects();

    public List<object> GetLocationData(int idToGet)
    {
        objects.Clear();
        objects.Add(id[idToGet]);
        objects.Add(location[idToGet]);
        objects.Add(bodyText[idToGet]);
        objects.Add(option1Text[idToGet]);
        objects.Add(option1LeadsTo[idToGet]);
        objects.Add(option2Text[idToGet]);
        objects.Add(option2LeadsTo[idToGet]);
        objects.Add(option3Text[idToGet]);
        objects.Add(option3LeadsTo[idToGet]);

        return objects;
    }

    private void InitializeObjects()
    {
        id[0] = 0;
        location[0] = "";
        bodyText[0] = "<i>A bright light flashes and when it subsides...</i>";
        option1Text[0] = "";
        option1LeadsTo[0] = -1;
        option2Text[0] = "Continue";
        option2LeadsTo[0] = 1;
        option3Text[0] = "";
        option3LeadsTo[0] = -1;

        id[1] = 1;
        location[1] = "A Small Tavern";
        bodyText[1] = "The light in this small tavern is dim. The bartender is pouring a pint when a portly man wearing an eyepatch enters. He walks towards the bar, sits down and orders an ale. He takes a drink and begins to tell the tale of a mad old wizard who was obsessed with groundhogs.\n\nHe says the wizard was so obsessed that he created a huge statue of a groundhog out of solid gold. Now legend has it that when the surrounding townsfolk heard about his creation that hordes of people stormed his lair in the Emerald Forest to steal it!\n\nThe portly man states how this enraged the wizard so much that he unleashed his full wrath of fire and magic upon the poor townsfolk. He goes on to say how they were slaughtered by the dozens, and those that weren't ran for the hills.\n\nHe takes another drink of his ale then mentions when the fighting was finished the mad old wizard took his creation and hid it from the eyes of the world. He finishes his drink and as he is getting up to leave, he points to his eye patch and says he was lucky then he pays the bartender and walks out of the bar into the night.\n\nThe bartender chuckles to himself as he is cleaning the bar. He looks up, winks his eye and mentions the Emerald Forest is just outside of town."; 
        option1Text[1] = "";
        option1LeadsTo[1] = -1;
        option2Text[1] = "Head towards the Emerald Forest";
        option2LeadsTo[1] = 2;
        option3Text[1] = "";
        option3LeadsTo[1] = -1;

        id[2] = 2;
        location[2] = "Emerald Forest";
        bodyText[2] = "An hour or so has passed and the edge of the Emerald Forest appears. It's a full moon and the moonlight illuminates the start of a path into the forest.\n\nLighting a torch and venturing in carefully, the sounds of crickets and other strange noises can be heard all around. After walking for a few minutes there is a fork in the path.\n\nTo the right two broken stone pillars stand, vines have tightly wrapped themselves around them. The faint sounds of a woman moaning can be heard.\n\nThe path to the left looks like it continues deeper into the forest.";
        option1Text[2] = "Take the left path";
        option1LeadsTo[2] = 6;
        option2Text[2] = "Take the right path";
        option2LeadsTo[2] = 3;
        option3Text[2] = "";
        option3LeadsTo[2] = -1;

        id[3] = 3;
        location[3] = "The Fallen Ruins";
        bodyText[3] = "Making your way past the broken pillars and the ground feels harder than it was before. Looking around tall structures can be seen in the shadows.\n\nWandering around some more it is clear that the forest has engulfed this place with vegetation and vines. In the shallow light of the burning torch two doorways can be seen. The moaning seems to be coming from the right doorway. ";
        option1Text[3] = "Take left doorway";
        option1LeadsTo[3] = 4;
        option2Text[3] = "Take right doorway";
        option2LeadsTo[3] = 5;
        option3Text[3] = "";
        option3LeadsTo[3] = -1;

        id[4] = 4;
        location[4] = "Moonlit Corridor";
        bodyText[4] = "The doorway on the left reveals a long dimly lit cooridor. Moonlight shines in at the far end illuminating several skeletons, with arrows protruding from their chests, lying against the back wall. <i>CLICK! SWOOSH! FADE TO BLACK...</i>";
        option1Text[4] = "";
        option1LeadsTo[4] = -1;
        option2Text[4] = "Continue";
        option2LeadsTo[4] = 0;
        option3Text[4] = "";
        option3LeadsTo[4] = -1;

        id[5] = 5;
        location[5] = "Long Corridor";
        bodyText[5] = "The doorway on the right reveals a long cooridor with another doorway, leading to a room, at the far end. The moaning is getting louder as the doorway at the end of the cooridor gets closer.\n\nUpon entering the room the moaning turns to an evil laughter and a large stone slab crashes down from the ceiling blocking the only exit. Water starts to pour in from several places in the surrounding walls and within minutes the water has reached the ceiling drowning out the laughter, drowning out everything...";
        option1Text[5] = "";
        option1LeadsTo[5] = -1;
        option2Text[5] = "Continue";
        option2LeadsTo[5] = 0;
        option3Text[5] = "";
        option3LeadsTo[5] = -1;

        id[6] = 6;
        location[6] = "Mysterious Cave";
        bodyText[6] = "Taking the left path eventually leads to a strange and mysterious cave. The light from the opening only penetrates several feet of the darkness within.\n\nSoon the only light is from the burning torch, as the cave seems to twist and descend before finally opening up to a large room.\n\nOld bones and broken rocks can be seen strewn about the floor along with some worn dark discolored marks. Three wooden levers can be seen on the wall to the right. The middle one looks more worn than the left or right one. ";
        option1Text[6] = "Pull the left lever";
        option1LeadsTo[6] = 9;
        option2Text[6] = "Pull the middle lever";
        option2LeadsTo[6] = 7;
        option3Text[6] = "Pull the right lever";
        option3LeadsTo[6] = 8;

        id[7] = 7;
        location[7] = "Mysterious Cave";
        bodyText[7] = "A loud <i>CLUNK</i> resonates in the room as the middle lever is pulled and a large bladed pendulum swings in from the right. Death is instantaneous...";
        option1Text[7] = "";
        option1LeadsTo[7] = -1;
        option2Text[7] = "Continue";
        option2LeadsTo[7] = 0;
        option3Text[7] = "";
        option3LeadsTo[7] = -1;

        id[8] = 8;
        location[8] = "Mysterious Cave";
        bodyText[8] = "A loud <i>CLUNK</i> resonates in the room as the right lever is pulled and a floor opens up to reveal deep pit with large spikes at the bottom. Death is instantaneous...";
        option1Text[8] = "";
        option1LeadsTo[8] = -1;
        option2Text[8] = "Continue";
        option2LeadsTo[8] = 0;
        option3Text[8] = "";
        option3LeadsTo[8] = -1;

        id[9] = 9;
        location[9] = "Fountain Room";
        bodyText[9] = "A loud <i>CLUNK</i> resonates in the room as the right lever is pulled and a hidden door in the wall behind you opens to reveal a winding staircase carved into the rock. At the bottom is a medium sized room with moss covered walls.\n\nThe sounds of running water can be heard at the far end of the room. It seems to be coming from inside the wall and over time it has worn enough of the rock away to have formed what looks like a fountain.\n\nAn small odd shaped rock sits near the natural looking fountain. There is a closed door on the opposite side of the room, covered with moss, with no apparent way to open it.\n\nTo the right of the door a portion of the wall juts out at an angle and a small hole can be seen.";
        option1Text[9] = "Drink some water";
        option1LeadsTo[9] = 10;
        option2Text[9] = "Burn the moss";
        option2LeadsTo[9] = 11;
        option3Text[9] = "Pour water in hole";
        option3LeadsTo[9] = 12;

        id[10] = 10;
        location[10] = "Fountain Room";
        bodyText[10] = "Staying hydrated is always a good thing, until it isn't. This is one of those cases, as the water is poisonous. Death is instantaneous...";
        option1Text[10] = "";
        option1LeadsTo[10] = -1;
        option2Text[10] = "Continue";
        option2LeadsTo[10] = 0;
        option3Text[10] = "";
        option3LeadsTo[10] = -1;

        id[11] = 11;
        location[11] = "Fountain Room";
        bodyText[11] = "The moss ignites the moment the torch touches it. A poisonous gas cloud fills the room as the moss burns. <i>The world fades to black...</i>";
        option1Text[11] = "";
        option1LeadsTo[11] = -1;
        option2Text[11] = "Continue";
        option2LeadsTo[11] = 0;
        option3Text[11] = "";
        option3LeadsTo[11] = -1;

        id[12] = 12;
        location[12] = "Tight Passage";
        bodyText[12] = "Using the odd shaped rock to scoop up water and then carefully pour it into the hole seems to have worked.\n\nThe lock is released with the sound of a <i>CLICK</i> and the door opens to reveal a rocky passage. The passage narrows as it twists and turns when a marble door can be seen in the distance.\n\nAs the door gets closer metal grates can be seen in the floor infront of it and to the left of it hangs a thick rope.A tiny bell sits in an small alcove in the left wall.";
        option1Text[12] = "Kick the door";
        option1LeadsTo[12] = 13;
        option2Text[12] = "Ring the bell";
        option2LeadsTo[12] = 14;
        option3Text[12] = "Pull the rope";
        option3LeadsTo[12] = 15;

        id[13] = 13;
        location[13] = "Tight Passage";
        bodyText[13] = "The marble door is really a mimic, a being able to change its shape to disguise its body as an inanimate object, and it hasn't eaten in a while. Death is slow and torturous...";
        option1Text[13] = "";
        option1LeadsTo[13] = -1;
        option2Text[13] = "Continue";
        option2LeadsTo[13] = 0;
        option3Text[13] = "";
        option3LeadsTo[13] = -1;

        id[14] = 14;
        location[14] = "Marble Room";
        bodyText[14] = "As the chimes of the bell echo in the passage the marble door fades from existance allowing entry into the room. The walls on the other side of the door are a beautiful black and white speckled marble.\n\nIn the back left corner of the room there is a portal device giving off a blue glow. To the right of it is a sign that reads:\n\n<i>RGB says to activate the portal you must press it's opposite!</i>.\n\nBelow the sign are three colored buttons.";
        option1Text[14] = "Press the red button";
        option1LeadsTo[14] = 16;
        option2Text[14] = "Press the yellow button";
        option2LeadsTo[14] = 17;
        option3Text[14] = "Press the green button";
        option3LeadsTo[14] = 18;

        id[15] = 15;
        location[15] = "Tight Passage";
        bodyText[15] = "Once the rope is pulled extremely hot air rises up from the metal grates just before scorching hot flames shoot out. Death is slow and torturous...";
        option1Text[15] = "";
        option1LeadsTo[15] = -1;
        option2Text[15] = "Continue";
        option2LeadsTo[15] = 0;
        option3Text[15] = "";
        option3LeadsTo[15] = -1;

        id[16] = 16;
        location[16] = "Marble Room";
        bodyText[16] = "When the red button is depressed the portal springs to life with a shimmering purple glow. Upon entering the portal death is instantaneous...";
        option1Text[16] = "";
        option1LeadsTo[16] = -1;
        option2Text[16] = "Continue";
        option2LeadsTo[16] = 0;
        option3Text[16] = "";
        option3LeadsTo[16] = -1;

        id[17] = 17;
        location[17] = "Open Field";
        bodyText[17] = "When the yellow button is depressed the portal springs to life with a shimmering green glow. Upon entering the portal everything goes black for a second before light returns.\n\nThe marble room is gone, replaced with a blue sky and an open field with tall grass and flowers. Hidden among the tall grass is an old dry well that is missing the rope and bucket.\n\nAt the edge of the field is a forest with tall lush trees, and birds flying in and out. Loud snorts can be heard around the well.";
        option1Text[17] = "Climb down the well";
        option1LeadsTo[17] = 19;
        option2Text[17] = "Investigate the noise";
        option2LeadsTo[17] = 20;
        option3Text[17] = "Head for the forest";
        option3LeadsTo[17] = 21;

        id[18] = 18;
        location[18] = "Marble Room";
        bodyText[18] = "When the green button is depressed the portal springs to life with a shimmering cyan glow. Upon entering the portal death is instantaneous...";
        option1Text[18] = "";
        option1LeadsTo[18] = -1;
        option2Text[18] = "Continue";
        option2LeadsTo[18] = 0;
        option3Text[18] = "";
        option3LeadsTo[18] = -1;

        id[19] = 19;
        location[19] = "Bottom of a Well";
        bodyText[19] = "The climb down the well was not easy but it was do able. At the bottom there is a strange wooden door with a metal handle and a keyhole. Opposite the door is a wooden barrel with a lid. One of the stones in the wall of the well juts out a little more than the rest of them.";
        option1Text[19] = "Open the door";
        option1LeadsTo[19] = 22;
        option2Text[19] = "Search the barrel";
        option2LeadsTo[19] = 23;
        option3Text[19] = "Push the stone";
        option3LeadsTo[19] = 24;

        id[20] = 20;
        location[20] = "Open Field";
        bodyText[20] = "Wandering in the tall grass around the well agitates the wild boar close by. They charge and attack...";
        option1Text[20] = "";
        option1LeadsTo[20] = -1;
        option2Text[20] = "Continue";
        option2LeadsTo[20] = 0;
        option3Text[20] = "";
        option3LeadsTo[20] = -1;

        id[21] = 21;
        location[21] = "Open Field";
        bodyText[21] = "Just at the edge of the field is in view there is some rustling in the tall grass off to the left. In an instant wild boar charge and attack...";
        option1Text[21] = "";
        option1LeadsTo[21] = -1;
        option2Text[21] = "Continue";
        option2LeadsTo[21] = 0;
        option3Text[21] = "";
        option3LeadsTo[21] = -1;

        id[22] = 22;
        location[22] = "Bottom of a Well";
        bodyText[22] = "The door is rigged with a lightning trap. The moment the handle was touch it activated. Death is instantaneous...";
        option1Text[22] = "";
        option1LeadsTo[22] = -1;
        option2Text[22] = "Continue";
        option2LeadsTo[22] = 0;
        option3Text[22] = "";
        option3LeadsTo[22] = -1;

        id[23] = 23;
        location[23] = "Bottom of a Well";
        bodyText[23] = "The act of lifting the lid triggers the barrel to explode. Death is instantaneous...";
        option1Text[23] = "";
        option1LeadsTo[23] = -1;
        option2Text[23] = "Continue";
        option2LeadsTo[23] = 0;
        option3Text[23] = "";
        option3LeadsTo[23] = -1;

        id[24] = 24;
        location[24] = "Stone Chamber";
        bodyText[24] = "When the stone is pushed a <i>CLICK</i> sound is heard and the door opens revealing a long tunnel that seems to go on forever. The tunnel twists and turns before ending at a chamber made out of stone.\n\nBoth the walls and the floor are made out of the same stone but there doesn't seem to be a ceiling as the wall disappear into darkness. On the far wall there is a metal door with three medium sized ropes next to it.\n\nThree cloaked figures can be seen near the ropes. They are arguing about which rope to pull and they are oblivious to everything else in the room.";
        option1Text[24] = "Pull the left rope";
        option1LeadsTo[24] = 25;
        option2Text[24] = "Pull the middle rope";
        option2LeadsTo[24] = 26;
        option3Text[24] = "Pull the right rope";
        option3LeadsTo[24] = 27;

        id[25] = 25;
        location[25] = "Laboratory";
        bodyText[25] = "When the left rope is pulled nothing seems to happen. Then the three cloaked figures disappear and the metal door creaks opens, which somewhat overshadows the sound of bubbling liquid.\n\nThree tables bend beneath a clutter of bottles of liquid and connected glass piping. Several bookshelves stand nearby stuffed to overfilling with a jumble of books, jars, bottles, bags, and boxes. Beakers of green and red fluids boil over burners on one of the tables.\n\nAgainst the back wall is a wooden door with rusty hinges and a big loop for a handle. Near one of the bookshelves a large empty cage sits on the floor with the door open, it's occupant was a giant spider that was busy spinning a web in the back corner until the creak of the door alerted it. ";
        option1Text[25] = "Attack spider with sword";
        option1LeadsTo[25] = 28;
        option2Text[25] = "Throw red liquid";
        option2LeadsTo[25] = 29;
        option3Text[25] = "Throw green liquid";
        option3LeadsTo[25] = 30;

        id[26] = 26;
        location[26] = "Stone Chamber";
        bodyText[26] = "When the middle rope is pulled nothing seems to happen. Then rocks fall, everybody dies...";
        option1Text[26] = "";
        option1LeadsTo[26] = -1;
        option2Text[26] = "Continue";
        option2LeadsTo[26] = 0;
        option3Text[26] = "";
        option3LeadsTo[26] = -1;

        id[27] = 27;
        location[27] = "Stone Chamber";
        bodyText[27] = "When the right rope is pulled nothing seems to happen. Then rocks fall, everybody dies...";
        option1Text[27] = "";
        option1LeadsTo[27] = -1;
        option2Text[27] = "Continue";
        option2LeadsTo[27] = 0;
        option3Text[27] = "";
        option3LeadsTo[27] = -1;

        id[28] = 28;
        location[28] = "Laboratory";
        bodyText[28] = "The giant spider is nimble and quick. It is able to dodge the sword attacks before finally ending the fight with it's poison. In a flash the battle is over in an instant...";
        option1Text[28] = "";
        option1LeadsTo[28] = -1;
        option2Text[28] = "Continue";
        option2LeadsTo[28] = 0;
        option3Text[28] = "";
        option3LeadsTo[28] = -1;

        id[29] = 29;
        location[29] = "Laboratory";
        bodyText[29] = "Tossing the red liquid seemed like a good idea at the time but when it splashed all over the spider and caused it to grow even larger it was apparent it was not a good idea...";
        option1Text[29] = "";
        option1LeadsTo[29] = -1;
        option2Text[29] = "Continue";
        option2LeadsTo[29] = 0;
        option3Text[29] = "";
        option3LeadsTo[29] = -1;

        id[30] = 30;
        location[30] = "Large Cavern";
        bodyText[30] = "As the green liquid splashes on the giant spider it reels back in pain, then falls into a heap on the floor. The wooden door was not locked but it took some effort to open it.\n\nThe hallway beyond is made out of stone blocks and continues quite a bit before ending in a rocky passage which descends downward for several hundred feet. The air is getting thick and humid, which is making it hard to breathe.\n\nThe passageway finally comes to an end in a large cavern that has a river of lava running through it effectively splitting the cavern in half. On the other side an opening can be seen which seems to lead away from the cavern.\n\nIn the middle of the room sits a mechanical bridge, but it is not apparent how to operate the bridge. The bridge is in an up position preventing anyone from crossing to the other side.\n\nA metal chain hangs near the bridge on it's left and a large crank attached to some piping sits on the ground on it's right. ";
        option1Text[30] = "Pull the matel chain";
        option1LeadsTo[30] = 31;
        option2Text[30] = "Attempt the jump across";
        option2LeadsTo[30] = 32;
        option3Text[30] = "Turn the large crank";
        option3LeadsTo[30] = 33;

        id[31] = 31;
        location[31] = "Large Cavern";
        bodyText[31] = "Pulling the metal chain causes a flood gate to fully open allowing more lava to rush down the river. The mechanism that normally regulates the flood gate to prevent it from fully opening seems to be broken.\n\nA huge wave of lava engulfs the area and everything in it...";
        option1Text[31] = "";
        option1LeadsTo[31] = -1;
        option2Text[31] = "Continue";
        option2LeadsTo[31] = 0;
        option3Text[31] = "";
        option3LeadsTo[31] = -1;

        id[32] = 32;
        location[32] = "Large Cavern";
        bodyText[32] = "The attempt to jump across the chasm might have been successful had it not been for the small puddle of oil near the edge. Death is instantaneous...";
        option1Text[32] = "";
        option1LeadsTo[32] = -1;
        option2Text[32] = "Continue";
        option2LeadsTo[32] = 0;
        option3Text[32] = "";
        option3LeadsTo[32] = -1;

        id[33] = 33;
        location[33] = "Crossroad";
        bodyText[33] = "With a lot of effort and several attempts the large crank gives up its fight and slowly turns. As it does the bridge begins to lower as the sound of metal grinding against metal echoes in the cavern.\n\nAfter what seems like an eternity it finishes lowering and now allows access to the other side. The opening on the other side does indeed lead away from the cavern as suspected.\n\nThe passageway has several bends in it before it ascends upward and then finally levels out before it splits into several passageways. To the left the passageway goes straight before turning to the right and out of view.\n\nTo the right the passageway leads to a wooden door that is a few hundred feet away. And lastly the passageway continues straight another several hundred feet before ascending upward. ";
        option1Text[33] = "Take left passageway";
        option1LeadsTo[33] = 34;
        option2Text[33] = "Continue straight on";
        option2LeadsTo[33] = 35;
        option3Text[33] = "Take right passageway";
        option3LeadsTo[33] = 36;

        id[34] = 34;
        location[34] = "Crossroad";
        bodyText[34] = "Not seeing the tripwire causes the floor collapse onto a well oiled chute that twists and turns before ending in a cavern several hundred feet in the air over a lake of lava. Death is instantaneous...";
        option1Text[34] = "";
        option1LeadsTo[34] = -1;
        option2Text[34] = "Continue";
        option2LeadsTo[34] = 0;
        option3Text[34] = "";
        option3LeadsTo[34] = -1;

        id[35] = 35;
        location[35] = "Dragon's Lair";
        bodyText[35] = "The passageway continues straight another several hundred feet before ascending upward. The passageway ends in a very large cavern, that is completely covered in gold coins and other gold items.\n\nThe amount of gold in this cavern can only mean one thing. One very bad thing. The owner of this amount of gold can be none other than a dragon. Which just happens to be lying down at the far end of the cavern.\n\nThe noise of it's coins being disturbed causes the large red dragon to stir and it rises up to investigate. ";
        option1Text[35] = "Dive into a coin pile";
        option1LeadsTo[35] = 37;
        option2Text[35] = "Running back to the passageway";
        option2LeadsTo[35] = 38;
        option3Text[35] = "Run towards the dragon";
        option3LeadsTo[35] = 39;

        id[36] = 36;
        location[36] = "Crossroad";
        bodyText[36] = "As the wooden door gets closer loud and rowdy voices can be heard coming from the other side. The wooden door opens and there stands several very large muscle bound orcs, clad in armor and brandishing some very sharp-looking weapons.\n\nThe lead orc bellows a war cry and they all begin to charge. Death is instantaneous...";
        option1Text[36] = "";
        option1LeadsTo[36] = -1;
        option2Text[36] = "Continue";
        option2LeadsTo[36] = 0;
        option3Text[36] = "";
        option3LeadsTo[36] = -1;

        id[37] = 37;
        location[37] = "Dragon's Lair";
        bodyText[37] = "Quickly diving into a coin pile causes the dragon to over look its intruder. It moves it large head sniffing the air for the scent of its prey.\n\nSatisfied there is nothing present the large red dragon wanders back to the other side of the cavern to lay down again. Before it gets there an opening behind the piles of gold it sleeps on can be seen.\n\nTactfully waiting for the dragon to begin its slumber has yielded a plan. Using a large golden serving tray will allow the piles of gold to be traversed much easier.\n\nOnce the plan is in motion it will only be a matter of time before the dragon is alert to the presence of an univited guest. With one last scan of the area, the destination is set and the plan is put into motion.\n\nAgain the dragon is awakened, this time it rises and lets out a ferocious roar before charging its prey.";
        option1Text[37] = "Attack the dragon";
        option1LeadsTo[37] = 40;
        option2Text[37] = "Bank hard right";
        option2LeadsTo[37] = 41;
        option3Text[37] = "Dive into a coin pile";
        option3LeadsTo[37] = 42;

        id[38] = 38;
        location[38] = "Dragon's Lair";
        bodyText[38] = "All of the gold piles in the room are disorienting which makes it very easy for the large red dragon to roasts its intruder. Death is instantaneous...";
        option1Text[38] = "";
        option1LeadsTo[38] = -1;
        option2Text[38] = "Continue";
        option2LeadsTo[38] = 0;
        option3Text[38] = "";
        option3LeadsTo[38] = -1;

        id[39] = 39;
        location[39] = "Dragon's Lair";
        bodyText[39] = "The gold coins make it hard maintain balance while running which makes it very easy for the large red dragon to roasts its intruder. Death is instantaneous...";
        option1Text[39] = "";
        option1LeadsTo[39] = -1;
        option2Text[39] = "Continue";
        option2LeadsTo[39] = 0;
        option3Text[39] = "";
        option3LeadsTo[39] = -1;

        id[40] = 40;
        location[40] = "Dragon's Lair";
        bodyText[40] = "As the serving tray barrels down the large pile of coins a large water urn is simultaneously picked up, aimed and deftly hurled in the direction of the dragon.\n\nJust as the large red dragon is about the spew its fire of fiery death the golden water urn lands directly in its left eye causing the red dragon to turn its head and the fire to be expelled in an upward direction.\n\nWith the destination reached the last part of the plan is ready. Near the serving tray is a vorpal shield of mighty might and a long sword of giant strength also the opening out of room is not to far away.\n\nThe large red dragon has regained it composure and is ready to deal with its unwelcomed guest.";
        option1Text[40] = "Attack with sword";
        option1LeadsTo[40] = 43;
        option2Text[40] = "Fling shield";
        option2LeadsTo[40] = 44;
        option3Text[40] = "Dash for opening";
        option3LeadsTo[40] = 45;

        id[41] = 41;
        location[41] = "Dragon's Lair";
        bodyText[41] = "Attempting to bank hard right causes the serving tray to flip over allowing the large red dragon to roasts its intruder. Death is instantaneous...";
        option1Text[41] = "";
        option1LeadsTo[41] = -1;
        option2Text[41] = "Continue";
        option2LeadsTo[41] = 0;
        option3Text[41] = "";
        option3LeadsTo[41] = -1;

        id[42] = 42;
        location[42] = "Dragon's Lair";
        bodyText[42] = "Attempting to dive into a coin pile at the speed the serving tray was moving fails and the large red dragon roasts its intruder. Death is instantaneous...";
        option1Text[42] = "";
        option1LeadsTo[42] = -1;
        option2Text[42] = "Continue";
        option2LeadsTo[42] = 0;
        option3Text[42] = "";
        option3LeadsTo[42] = -1;

        id[43] = 43;
        location[43] = "Dragon's Lair";
        bodyText[43] = "Grabbing the long sword and the serving tray the attack against the dragon is initiated! The long sword hit the dragon in the leg but its scale prevent it from taking any damage.\n\nThe only successful result was making the dragon angrier. The red dragon raises its left front leg and brings it crashing down. Death is instantaneous... ";
        option1Text[43] = "";
        option1LeadsTo[43] = -1;
        option2Text[43] = "Continue";
        option2LeadsTo[43] = 0;
        option3Text[43] = "";
        option3LeadsTo[43] = -1;

        id[44] = 44;
        location[44] = "Storeroom";
        bodyText[44] = "As the shield is released it spins violently as it hums towards its target, which is not the dragon but the large stalactites above its head.\n\nThe shield connects with the rocks above freeing them from there stoney prison. Now they are in the hands of thier new master, gravity!\n\nWithin moments the newly freed earthen spikes reach their target, the red dragons skull. With a loud <i>THUD</i> the large red dragon falls.\n\nSliding down the pile of coins on the serving tray closes the distance to the opening. Beyond is a stone hallway with a wooden ladder at the far end.\n\nClimbing the ladder leads to a trap door and beyond that a storeroom. Large bags of flour are stacked next to barrels of wine in this small room.\n\nThrough a doorway a solid wooden staircase, leading up, can be seen across from the trap door on the back wall. Between the doorway and the stairs sits a tall dragon statue.\n\nAt the bottom of the staircase a pentagram is carved into the stone wall.";
        option1Text[44] = "Climb the staircase";
        option1LeadsTo[44] = 46;
        option2Text[44] = "Examine the statue";
        option2LeadsTo[44] = 47;
        option3Text[44] = "Touch the pentagram";
        option3LeadsTo[44] = 48;

        id[45] = 45;
        location[45] = "Dragon's Lair";
        bodyText[45] = "This is it! The goal is in reach. Grabbing the serving tray and speeding down the pile of coins proves to be successful.\n\nThat is until the red dragon brings it large tail crashing down. Death is instantaneous...";
        option1Text[45] = "";
        option1LeadsTo[45] = -1;
        option2Text[45] = "Continue";
        option2LeadsTo[45] = 0;
        option3Text[45] = "";
        option3LeadsTo[45] = -1;

        id[46] = 46;
        location[46] = "Storeroom";
        bodyText[46] = "With nothing interesting in the storeroom it is time to leave. Halfway up the staircase the steps collapse revealing a spike trap. Death is instantaneous...";
        option1Text[46] = "";
        option1LeadsTo[46] = -1;
        option2Text[46] = "Continue";
        option2LeadsTo[46] = 0;
        option3Text[46] = "";
        option3LeadsTo[46] = -1;

        id[47] = 47;
        location[47] = "Storeroom";
        bodyText[47] = "The architecture of the dragon statue is exquisite and life-like that the movement it made goes unnoticed. The dragon statue breaths fire and death is instantaneous...";
        option1Text[47] = "";
        option1LeadsTo[47] = -1;
        option2Text[47] = "Continue";
        option2LeadsTo[47] = 0;
        option3Text[47] = "";
        option3LeadsTo[47] = -1;

        id[48] = 48;
        location[48] = "Library";
        bodyText[48] = "When the pentagram is touched it begins to glow blue and a <i>CLICK</i> sound is heard but nothing seems to happen. Upon reaching the top of the staircase the doorway reveals a short hallway that leads to library.\n\nInside there are tall bookshelves filled with books about everything. Mostly about magic, but there are also books about architecture, philosophy, alchemy and strangely enough there is an entire bookcase full of books about groundhogs.\n\nThe double wooden doors at the end of the room are locked. To the left of the door is a bookcase filled with books.Three books in particular standout, 'Magic and the Art of the Groundhog' on the middle shelf.\n\n'Groundhog Prestidigitation: Fact or Fiction' on the bottom shelf and lastly 'Pass The Peas: An Insight Into The Diet Of Groundhogs' on the top shelf.\n\nEach one has a number etched into the spine. From top to bottom they are 3, 7, and 1. To the right of the wooden doors are the number 1 throught 9 etched into the stone.";
        option1Text[48] = "Enter 137";
        option1LeadsTo[48] = 49;
        option2Text[48] = "Enter 371";
        option2LeadsTo[48] = 50;
        option3Text[48] = "Enter 731";
        option3LeadsTo[48] = 51;

        id[49] = 49;
        location[49] = "Library";
        bodyText[49] = "As each number is touched they light up. When all of the numbers are entered a deep sounding <i>Click</i> is heard.\n\nOnce the door handle is grasped sharp poisonous needles protrude, administering their poision. Death is instantaneous...";
        option1Text[49] = "";
        option1LeadsTo[49] = -1;
        option2Text[49] = "Continue";
        option2LeadsTo[49] = 0;
        option3Text[49] = "";
        option3LeadsTo[49] = -1;

        id[50] = 50;
        location[50] = "Statue Room";
        bodyText[50] = "As each number is touched they light up. When all of the numbers are entered a <i>CLICK</i> sound is heard and the wooden doors open to reveal a very short hallway and another wooden door.\n\nUpon opening the other wooden door a large room with six giant blue marble statues of groundhogs can be seen. They are arranged in a hexagram in the middle of the room and in the middle of the hexagram is a three tiered fountain.\n\nThe statue near the back wall is glowing black, facing the fountain, has an etched 1. Moving clockwise, the next statue is facing left, not glowing, has an etched 2, the next statue is facing left, not glowing, has an etched 3, the next statue is facing the fountain, is glowing green, has an etched 4, the next statue is facing right, not glowing, has an etched 5, and the last statue is facing right, not glowing, has an etched 6.\n\nThere is a door on the right wall that is locked.";
        option1Text[50] = "Turn 2R 3L 5R 6L";
        option1LeadsTo[50] = 52;
        option2Text[50] = "Turn 2L 3R 5L 6R";
        option2LeadsTo[50] = 53;
        option3Text[50] = "Turn 1L4x 4R4x";
        option3LeadsTo[50] = 54;

        id[51] = 51;
        location[51] = "Library";
        bodyText[51] = "As each number is touched they light up. When all of the numbers are entered a deep sounding <i>CLICK</i> is heard. Once the door handle is grasped sharp poisonous needles protrude, administering their poision. Death is instantaneous...";
        option1Text[51] = "";
        option1LeadsTo[51] = -1;
        option2Text[51] = "Continue";
        option2LeadsTo[51] = 0;
        option3Text[51] = "";
        option3LeadsTo[51] = -1;

        id[52] = 52;
        location[52] = "Statue Room";
        bodyText[52] = "With each turn of a statue a <i>CLICK</i> sound was heard as if some giant gears somewhere were rotating. The door will not budge and the statues have come to life and they do not look happy. Death is slow and torturous...";
        option1Text[52] = "";
        option1LeadsTo[52] = -1;
        option2Text[52] = "Continue";
        option2LeadsTo[52] = 0;
        option3Text[52] = "";
        option3LeadsTo[52] = -1;

        id[53] = 53;
        location[53] = "Portal Room";
        bodyText[53] = "As each statue is rotated a <i>CLICK</i> sound is heard and the statue begins to glow. Staute 2 glows a faint blue, staute 3 glows a faint red, staute 5 glows a faint orange, and staute 6 glows a faint purple.\n\nThe fountain in the center begins to glow a faint yellow and water begins to flow out of the top of it, trickling down until it finally lands in the bottom tier. Another /Click/ sound it heard and the door on the right wall opens on its own.\n\nThe new room contains 3 portals, each glowing a different color. The left portal has a faint blue glow, the middle portal has a faint green glow and the right one has a faint red glow.";
        option1Text[53] = "Take the blue portal";
        option1LeadsTo[53] = 55;
        option2Text[53] = "Take the green portal";
        option2LeadsTo[53] = 56;
        option3Text[53] = "Take the red portal";
        option3LeadsTo[53] = 57;

        id[54] = 54;
        location[54] = "Statue Room";
        bodyText[54] = "With each turn of a statue a <i>CLICK</i> sound was heard as if some giant gears somewhere were rotating. The door will not budge and the statues have come to life and they do not look happy. Death is slow and torturous...";
        option1Text[54] = "";
        option1LeadsTo[54] = -1;
        option2Text[54] = "Continue";
        option2LeadsTo[54] = 0;
        option3Text[54] = "";
        option3LeadsTo[54] = -1;

        id[55] = 55;
        location[55] = "Antichamber";
        bodyText[55] = "This small circular room has no furniture in it, nor does it have any decorations at all. The walls are barren white stone and the only light source is a glow in the center of the room.\n\nThe room also does not contain any stairs and there is only one door. Suddenly a mysterious figure emerges out of nowhere.\n\nAs the figure moves closer to the light you recgonize him as the portly old man from the tavern! He snaps his fingers and transforms into a wirey, old white haired wizard.\n\nHe apologizes for the false pretenses and explains it was necessary to make sure you were worthy of this honor. He says there is one final test and all you have to do is stand infront of the door and tell it what is in your heart.";
        option1Text[55] = "Lie and make up stuff";
        option1LeadsTo[55] = 58;
        option2Text[55] = "Say you only want the gold";
        option2LeadsTo[55] = 59;
        option3Text[55] = "Speak from the heart";
        option3LeadsTo[55] = 60;

        id[56] = 56;
        location[56] = "Portal Room";
        bodyText[56] = "Upon entering the portal death is instantaneous...";
        option1Text[56] = "";
        option1LeadsTo[56] = -1;
        option2Text[56] = "Continue";
        option2LeadsTo[56] = 0;
        option3Text[56] = "";
        option3LeadsTo[56] = -1;

        id[57] = 57;
        location[57] = "Portal Room";
        bodyText[57] = "Upon entering the portal death is instantaneous...";
        option1Text[57] = "";
        option1LeadsTo[57] = -1;
        option2Text[57] = "Continue";
        option2LeadsTo[57] = 0;
        option3Text[57] = "";
        option3LeadsTo[57] = -1;

        id[58] = 58;
        location[58] = "Antichamber";
        bodyText[58] = "Blah... blah... blah... Noble deeds... Noble quests... All hail the groundhog... NOW GIMME THE GOLD! Upon hearing your words the old wizard is enfuriated.\n\nHe screams at you and tells you that not only will your death loop continue but that you will just randomly spontaneously combust until you have truly learned your lession! Then he snaps his fingers...";
        option1Text[58] = "";
        option1LeadsTo[58] = -1;
        option2Text[58] = "Continue";
        option2LeadsTo[58] = 0;
        option3Text[58] = "";
        option3LeadsTo[58] = -1;

        id[59] = 59;
        location[59] = "Antichamber";
        bodyText[59] = "This was never about the groundhog. It was only about the golden statue and how much it can be sold for.\n\nUpon hearing your words the old wizard is saddened and he apologies for failing you. He says he will do better and with that he snaps his fingers.";
        option1Text[59] = "";
        option1LeadsTo[59] = -1;
        option2Text[59] = "Continue";
        option2LeadsTo[59] = 0;
        option3Text[59] = "";
        option3LeadsTo[59] = -1;

      
    }
}

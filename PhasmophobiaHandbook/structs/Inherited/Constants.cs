using System.Collections.Generic;
using System.Drawing;
using PhasmophobiaHandbook.Properties;
using PhasmophobiaHandbook.Structs.Base;

namespace PhasmophobiaHandbook.Structs.Inherited
{
    public static class Constants
    {
        #region Ghosts
        public static List<Ghost> ghosts = new List<Ghost>(new Ghost[]
        {
            new Ghost(
                "Spirit",
                new GhostEvidence[] {GhostEvidence.EMF5, GhostEvidence.SpiritBox, GhostEvidence.GhostWriting},
                new string[] {"Smudging prevents the ghost from hunting for 180 seconds, instead of the usual 90"},
                "50%",
                new object[][] {new object[] {"1.6m/s (no line of sight)", Resources.normal_speed}, new object[] { "2.5m/s (line of sight)", Resources.normal_speed_los } }
            ),
            new Ghost(
                "Wraith",
                new GhostEvidence[] { GhostEvidence.EMF5, GhostEvidence.SpiritBox, GhostEvidence.DOTSProjector },
                new string[] {"The ghost will not show any UV footsteps after walking in salt", "Can teleport near a random player inside the location and will leave EMF"},
                "50%",
                new object[][] {new object[] {"1.6m/s (no line of sight)", Resources.normal_speed}, new object[] { "2.5m/s (line of sight)", Resources.normal_speed_los } }
            ),
            new Ghost(
                "Phantom",
                new GhostEvidence[] { GhostEvidence.SpiritBox, GhostEvidence.Fingerprints, GhostEvidence.DOTSProjector },
                new string[] {
                    "Will prevent a ghost photo being taken by disappearing for a short time",
                    "Sanity drops 2x as fast while the ghost is visible",
                    "Can roam to an indoor player",
                    "Blinks a lot slower when hunting"
                },
                "50%",
                new object[][] {new object[] {"1.6m/s (no line of sight)", Resources.normal_speed}, new object[] { "2.5m/s (line of sight)", Resources.normal_speed_los } }
            ),
            new Ghost(
                "Poltergeist",
                new GhostEvidence[] { GhostEvidence.SpiritBox, GhostEvidence.Fingerprints, GhostEvidence.GhostWriting },
                new string[] {
                    "Can throw several items at the same time",
                    "Reduces sanity 2x more than a normal interaction when throwing numerous items"
                },
                "50%",
                new object[][] {new object[] {"1.6m/s (no line of sight)", Resources.normal_speed}, new object[] { "2.5m/s (line of sight)", Resources.normal_speed_los } }
            ),
            new Ghost(
                "Banshee",
                new GhostEvidence[] { GhostEvidence.Fingerprints, GhostEvidence.GhostOrbs, GhostEvidence.DOTSProjector },
                new string[] {
                    "Hunts only the target player unless they are killed or are outside",
                    "Will often roam to the target player",
                    "Prefers singing ghost events, and will drain +5% sanity when doing so",
                    "Has a low chance to scream through the parabolic microphone"
                },
                "50%",
                new object[][] {new object[] {"1.6m/s (no line of sight)", Resources.normal_speed}, new object[] { "2.5m/s (line of sight)", Resources.normal_speed_los } }
            ),
            new Ghost(
                "Jinn",
                new GhostEvidence[] { GhostEvidence.EMF5, GhostEvidence.Fingerprints, GhostEvidence.FreezingTemperatures },
                new string[] {
                    "Will never turn the breaker off",
                    "When the breaker is on, there is a chance to drop sanity by 25% when within 3 metres of the ghost"
                },
                "50%",
                new object[][] { new object[] { "1.6m/s (if close or breaker off)", Resources.jinn_no_breaker }, new object[] {"2.5m/s (if far and breaker on", Resources.jinn_fast } }
            ),
            new Ghost(
                "Mare",
                new GhostEvidence[] { GhostEvidence.SpiritBox, GhostEvidence.GhostOrbs, GhostEvidence.GhostWriting },
                new string[] {
                    "Cannot turn lights or the breaker on",
                    "Prefers turning lights or breaker off for interactions",
                    "Prefers blowing out lights for ghost events",
                    "Will attempt long roams to escape lit rooms",
                    "Can turn lights off immediately as they are turned on"
                },
                "60% (Ghost Room Lights off), 40% (Ghost Room Lights on)",
                new object[][] {new object[] {"1.6m/s (no line of sight)", Resources.normal_speed}, new object[] { "2.5m/s (line of sight)", Resources.normal_speed_los } }
            ),
            new Ghost(
                 "Revenant",
                 new GhostEvidence[] { GhostEvidence.GhostOrbs, GhostEvidence.GhostWriting, GhostEvidence.FreezingTemperatures },
                 new string[] {},
                 "50%",
                 new object[][] { new object[] { "3m/s (with line of sight)", Resources.revenant_fast }, new object[] {"1.1m/s (no line of sight)", Resources.revenant_slow } }
            ),
            new Ghost(
                "Shade",
                new GhostEvidence[] { GhostEvidence.EMF5, GhostEvidence.GhostWriting, GhostEvidence.FreezingTemperatures },
                new string[] {
                    "Very inactive when there are players nearby or in the ghost room",
                    "Ghost event chances are tied to sanity loss, beginning at 50% sanity",
                    "Prefers ghost breath events and shadow manifestation events",
                    "Will not try to hunt when a player is in the same room"
                },
                "35%",
                new object[][] {new object[] {"1.6m/s (no line of sight)", Resources.normal_speed}, new object[] { "2.5m/s (line of sight)", Resources.normal_speed_los } }
            ),
            new Ghost(
                "Demon",
                new GhostEvidence[] { GhostEvidence.Fingerprints, GhostEvidence.GhostWriting, GhostEvidence.FreezingTemperatures },
                new string[] {
                    "Crucifix range is 5 metres instead of the normal 3",
                    "Canot teleport to the target player when hunting if it had line of sight within 20 seconds",
                    "Has a lower chance to hunt at any sanity level",
                    "Delay between hunting is reduced to 20 seconds instead of the usual 25",
                    "Smudging the ghost prevents hunting for 60 seconds instead of the usual 90"
                },
                "70%",
                new object[][] {new object[] {"1.6m/s (no line of sight)", Resources.normal_speed}, new object[] { "2.5m/s (line of sight)", Resources.normal_speed_los } }
            ),
            new Ghost(
                "Yurei",
                new GhostEvidence[] { GhostEvidence.GhostOrbs, GhostEvidence.FreezingTemperatures, GhostEvidence.DOTSProjector },
                new string[] {
                    "There is a chance to drop sanity by 13% when within 3 metres. This is indicated by the closing of a nearby door",
                    "Cannot roam while smudged. If smudged during a hunt, the ghost will return to where it was smudged once the hunt ends"
                },
                "50%",
                new object[][] {new object[] {"1.6m/s (no line of sight)", Resources.normal_speed}, new object[] { "2.5m/s (line of sight)", Resources.normal_speed_los } }
            ),
            new Ghost(
                "Oni",
                new GhostEvidence[] { GhostEvidence.EMF5, GhostEvidence.FreezingTemperatures, GhostEvidence.DOTSProjector },
                new string[] {
                    "Very active",
                    "Can throw items at high speeds",
                    "Will not perform the mist ball ghost event",
                    "Prefers physical form for ghost events"
                },
                "50%",
                new object[][] {new object[] {"1.6m/s (no line of sight)", Resources.normal_speed}, new object[] { "2.5m/s (line of sight)", Resources.normal_speed_los } }
            ),
            new Ghost(
                "Yokai",
                new GhostEvidence[] { GhostEvidence.SpiritBox, GhostEvidence.GhostOrbs, GhostEvidence.DOTSProjector },
                new string[] {
                    "Increased activity when talking near the ghost",
                    "Can only detect players voice or held active electronics when less than 2 metres away"
                },
                "80% (When talking within 2 metres of ghost), 50% otherwise",
                new object[][] {new object[] {"1.6m/s (no line of sight)", Resources.normal_speed}, new object[] { "2.5m/s (line of sight)", Resources.normal_speed_los } }
            ),
            new Ghost(
                "Hantu",
                new GhostEvidence[] { GhostEvidence.Fingerprints, GhostEvidence.GhostOrbs, GhostEvidence.FreezingTemperatures },
                new string[] {
                    "2x more likely to turn off the breaker",
                    "Hunting speed does not increase when there is line of sight",
                    "Can breathe mist in rooms below 3°C (37.4°F) when hunting",
                    "If playing on Nightmare difficulty, Freezing evidence is guaranteed"
                },
                "50%",
                new object[][] { new object[] { "Up to 2.7m/s (if in cold areas)", Resources.hantu_cold }, new object[] {"As low as 1.4m/s (if in warm areas)", Resources.hantu_warm } }
            ),
            new Ghost(
                "Goryo",
                new GhostEvidence[] { GhostEvidence.EMF5, GhostEvidence.Fingerprints, GhostEvidence.DOTSProjector },
                new string[] {
                    "Will never roam far from the ghost room",
                    "Won't show DOTS when players are in the room",
                    "DOTS can only be seen with the video camera",
                    "If playing on Nightmare difficulty, DOTS evidence is guaranteed"
                },
                "50%",
                new object[][] {new object[] {"1.6m/s (no line of sight)", Resources.normal_speed}, new object[] { "2.5m/s (line of sight)", Resources.normal_speed_los } }
            ),
            new Ghost(
                "Myling",
                new GhostEvidence[] { GhostEvidence.EMF5, GhostEvidence.Fingerprints, GhostEvidence.GhostWriting },
                new string[] {
                    "Speaks through the parabolic microphone more often",
                    "When hunting, footstep hearing range is shorter than equipment malfunction range",
                    "When hunting, footsteps are much quieter"
                },
                "50%",
                 new object[][] { new object[] { "1.6m/s (quieter)", Resources.myling } }
            ),
            new Ghost(
                "Onryo",
                new GhostEvidence[] { GhostEvidence.SpiritBox, GhostEvidence.GhostOrbs, GhostEvidence.FreezingTemperatures },
                new string[] {
                    "Will blow out candles more often than other ghosts",
                    "There is a 50% chance to hunt when a candle is blown out below 80% sanity (except for the first 3 blowouts)",
                    "There is a +25% chance to hunt for every dead player",
                    "Candles act as crucifixes, with a 4 metre range. Has precedence over the crucifix",
                    "When candles prevent a hunt, it is blown out"
                },
                "60%",
                new object[][] {new object[] {"1.6m/s (no line of sight)", Resources.normal_speed}, new object[] { "2.5m/s (line of sight)", Resources.normal_speed_los } }
            ),
            new Ghost(
                "The Twins",
                new GhostEvidence[] { GhostEvidence.EMF5, GhostEvidence.SpiritBox, GhostEvidence.FreezingTemperatures },
                new string[] {
                    "Both twins can cause an interaction one after the other",
                    "The decoy twin will only give EMF evidence and won't trigger sensors",
                    "Decoy hunts will start immediately after a decoy interaction"
                },
                "50%",
                new object[][] { new object[] { "1.76m/s (decoy twin)", Resources.twin_decoy }, new object[] {"1.44m/s (main twin)", Resources.twin_main } }
            ),
            new Ghost(
                "Raiju",
                new GhostEvidence[] { GhostEvidence.EMF5, GhostEvidence.GhostOrbs, GhostEvidence.DOTSProjector },
                new string[] {
                    "Has an increased range of electronics malfunctioning"
                },
                "65% (When in presence of active electronics), 50% otherwise",
                new object[][] { new object[] { "2.5m/s (if near active electronics)", Resources.raiju_fast } }
            ),
            new Ghost(
                "Obake",
                new GhostEvidence[] { GhostEvidence.EMF5, GhostEvidence.Fingerprints, GhostEvidence.GhostOrbs },
                new string[] {
                    "There is a small chance to leave a 6-fingered handprint",
                    "There is a -25% chance to leave fingerprints",
                    "Fingerprints disappear after 50% of the normal time",
                    "If playing on Nightmare difficulty, Fingerprints evidence is guaranteed"
                },
                "50%",
                new object[][] {new object[] {"1.6m/s (no line of sight)", Resources.normal_speed}, new object[] { "2.5m/s (line of sight)", Resources.normal_speed_los } }
            ),
            new Ghost(
                "The Mimic",
                new GhostEvidence[] { GhostEvidence.SpiritBox, GhostEvidence.Fingerprints, GhostEvidence.FreezingTemperatures, GhostEvidence.GhostOrbs },
                new string[] {
                    "Can behave the same as any other ghost type, including hunting and trigger behaviours",
                    "Will change ghost type behaviour no more than once per minute",
                    "Shows false ghost orbs",
                    "When mimicking Thaye, a random ghost age is picked, and will change ghost type when aging occurs"
                },
                "Same as ghost type it is currently mimicing",
                 new object[][] {new object[] {"1.6m/s (normal ghost, no los)", Resources.normal_speed}, new object[] { "3m/s (deogen far)", Resources.deogen_fast }, new object[] {"1.76m/s (decoy twin)", Resources.twin_decoy} }
            ),
            new Ghost(
                "Moroi",
                new GhostEvidence[] { GhostEvidence.SpiritBox, GhostEvidence.GhostWriting, GhostEvidence.FreezingTemperatures },
                new string[] {
                    "Curses the spirit box player, dropping sanity 2x faster when indoors until pills are taken",
                    "Also curses parabloic microphone users upon hearing footsteps or whispers",
                    "When smudged while hunting, the targeting grace period is 12 seconds instead of the usual 6",
                    "If playing on Nightmare difficulty, Spirit Box evidence is guaranteed"
                },
                "50%",
                new object[][] { new object[] { "2.25m/s (0% sanity)", Resources.moroi_0 }, new object[] {"1.75m/s (35% sanity)", Resources.moroi_35 }, new object[] {"1.5m/s (50% sanity)", Resources.moroi_50 } }
            ),
            new Ghost(
                "Deogen",
                new GhostEvidence[] { GhostEvidence.SpiritBox, GhostEvidence.GhostWriting, GhostEvidence.DOTSProjector },
                new string[] {
                    "Can detect players locations during a hunt. Players cannot hide",
                    "Has an increased chance for DOTS and Ghost Writing evidences",
                    "If within 1 metre when using spirit box, there is a 33% chance for a unique breathing response"
                },
                "40%",
                new object[][] { new object[] { "Up to 3m/s (if farther than 6m)", Resources.deogen_fast }, new object[] {"0.4m/s if closer than 2.5m", Resources.deogen_slow } }
            ),
            new Ghost(
                "Thaye",
                new GhostEvidence[] { GhostEvidence.GhostOrbs, GhostEvidence.GhostWriting, GhostEvidence.DOTSProjector },
                new string[] {
                    "2x more likely to cause interactions and ghost events",
                    "Has an increased chance for DOTS and Ghost Writing evidences",
                    "Attempts to age 1 year every 1-2 minutes. If no players are in the ghost room, it retries every 20 seconds until it succeeds",
                    "Interaction and events chances are lowered every aging stage by 15% until it reaches 50%",
                    "When old, it won't try to hunt any player in the same room"
                },
                "75% (At start of game), -6% (every time ghost ages 1 year), 15% (When ghost is finished aging 10 years since start of game)",
                new object[][] { new object[] { "2.75m/s (young)", Resources.thaye_young }, new object[] {"1m/s (old)", Resources.thaye_old } }
            )
        });
        #endregion Ghosts

        #region Maps
        public static List<Map> maps = new List<Map>(new Map[] {
            new Map("Asylum", Resources.asylum, MapSize.Large),
            new Map("Bleasedale Farmhouse", Resources.bleasdale, MapSize.Small),
            new Map("Brownstone High School", Resources.brownstone, MapSize.Medium),
            new Map("Edgefield Street House", Resources.edgefield, MapSize.Small),
            new Map("Grafton Farmhouse", Resources.grafton, MapSize.Small),
            new Map("Maple Lodge Campsite", Resources.maplelodge, MapSize.Medium),
            new Map("Prison", Resources.prison, MapSize.Medium),
            new Map("Ridgeview Road House", Resources.ridgeview, MapSize.Small),
            new Map("Tanglewood Street House", Resources.tanglewood, MapSize.Small),
            new Map("Willow Street House", Resources.willow, MapSize.Small)
        });
        #endregion Maps

        #region CursedItems
        public static List<CursedItem> cursedItems = new List<CursedItem>(new CursedItem[]
        {
            new CursedItem(
                "Oujia Board",
                new string[]{
                    "It can be used to communicate with the ghost at the cost of sanity",
                    "Once activated, the Ouija Board will respond to voice input within 3 metres of it",
                    "The player asking the question must be within the investigation area to ask questions, but does not have to be in the ghost room (nor the ghost's current room)",
                    "If the question is recognised, the planchette will move to answer the question, and an EMF Level 2 reading will be generated around the Ouija Board",
                    "If the ghost has EMF Level 5 as evidence, there is a 25% chance for this to instead be the reading per question asked",
                    "To deactivate the Ouija Board, any nearby player must say \"Goodbye\", which will make the planchette disappear",
                    "The Ouija Board will break if the player who activated the board is more than 5 metres away from the still-active board",
                    "The Ouija Board will break if the player currently asking questions has less sanity than required to \"pay\" for the question",
                    "The Ouija Board will break if the player saying goodbye has no sanity left",
                    "The Ouija Board will break if the phrase \"hide and seek\" (or similar) is said",
                    "When the board is broken, a cursed hunt will begin if any player is indoors"
                },
                Resources.loog,
                null,
                new List<OujiaQuestion>(new OujiaQuestion[]{
                    new OujiaQuestion(
                        "Location",
                        "Early in the game or immediately after a hunt, using the Ouija Board may give a rough idea of where the Ghost Room is",
                        new string[]
                        {
                            "Where are you?",
                            "What is your favourite room?",
                            "Where is your room?",
                            "What is your room?"
                        },
                        40
                    ),
                    new OujiaQuestion(
                        "Hide And Seek",
                        "The Ouija Board will initiate a countdown from 5 to 0, before breaking and starting a cursed hunt",
                        new string[]
                        {
                            "Do you want to play hide and seek?",
                            "Hide and seek?",
                        },
                        25
                    ),
                    new OujiaQuestion(
                        "Location (not specific)",
                        "This simply answers whether the ghost is in the same room",
                        new string[]
                        {
                            "Are you here?",
                            "Are you close?",
                        },
                        20
                    ),
                    new OujiaQuestion(
                        "Bone",
                        "The name of the room where the bone is located will be given",
                        new string[]
                        {
                            "Where is the bone?",
                            "Where did you die?",
                            "Where is your body?"
                        },
                        20
                    ),
                    new OujiaQuestion(
                        "Room Count",
                        "It is unknown how the answer is determined, though the answer is believed to be at least partially influenced by the number of people in the room, including the ghost itself",
                        new string[]
                        {
                            "How many are in this room?",
                            "How many people are in this room?",
                            "How many people are here?",
                            "How many ghosts are in this room?",
                            "How many ghosts are here?",
                            "Are you alone?",
                            "Are we alone?",
                            "Who is here?",
                            "Who is in this room?",
                            "How many ghosts are present?",
                            "How many people are present?"
                        },
                        20
                    ),
                    new OujiaQuestion(
                        "Shyness",
                        "This will reply whether the ghost responds to people who are alone or to everyone when using the Spirit Box",
                        new string[]
                        {
                            "Do you respond to everyone?"
                        },
                        20
                    ),
                    new OujiaQuestion(
                        "Age",
                        "The age of the ghost is a randomly generated number between 2 and 90 years that is predetermined at level start. If the ghost is a Thaye, its age will increase over time",
                        new string[]
                        {
                            "How old are you?",
                            "What is your age?",
                            "Are you old?",
                            "Are you young?"
                        },
                        5
                    ),
                    new OujiaQuestion(
                        "Death",
                        "The length of death of a ghost is a randomly generated number between 50 and 1000 years that is predetermined at level start",
                        new string[]
                        {
                            "When did you die?",
                            "How long ago did you die?",
                            "How long have you been here?",
                            "How many years ago did you die?",
                            "How long have you been dead?"
                        },
                        5
                    ),
                    new OujiaQuestion(
                        "Sanity",
                        "These questions can give the player a rough estimate of their current sanity level",
                        new string[]
                        {
                            "What is my sanity?",
                            "How crazy am I?",
                            "How insane am I?",
                            "Am I insane?"
                        },
                        5
                    ),
                    new OujiaQuestion(
                        "Method of Death",
                        "The cause of death of the ghost is listed",
                        new string[]
                        {
                            "How did you die?"
                        },
                        5
                    ),
                    new OujiaQuestion(
                        "Yes or No",
                        "Asking these questions typically yields Yes, No, and Maybe responses",
                        new string[]
                        {
                            "Am I pretty?",
                            "Are we friends?",
                            "Do you hate me?",
                            "Do you like jazz?"
                        },
                        5
                    ),
                    new OujiaQuestion(
                        "Feeling",
                        "These questions tell the player how the ghost is feeling",
                        new string[]
                        {
                            "How do you feel?",
                            "Are you okay?",
                            "How are you?"
                        },
                        5
                    ),
                    new OujiaQuestion(
                        "Purpose",
                        "These questions tell the player why the ghost is present",
                        new string[]
                        {
                            "Why are you here?",
                            "What do you want?"
                        },
                        5
                    ),
                    new OujiaQuestion(
                        "Joke",
                        "Some jokes can be used on the ghost, each resulting in the ghost giving a specific answer in relation to the joke",
                        new string[]
                        {
                            "Knock knock",
                            "Marco"
                        },
                        5
                    )
                })
            ),
            new CursedItem(
                "Music Box",
                new string[]{
                    "Once activated, the music box will make the ghost sing along while remaining invisible, broadcasting its current location",
                    "If the music box is within 5 metres of the ghost, it will trigger a ghost event where the ghost manifests and begins to walk towards the box",
                    "The music box can be handheld or placed on the floor, the latter being the only safe way to discard the box without triggering a cursed hunt while it's playing",
                    "A cursed hunt will begin if the ghost touches the player holding the box",
                    "A cursed hunt will begin if the ghost walks (during the box-triggered ghost event) for more than 5 seconds",
                    "A cursed hunt will begin if the box is thrown while the tune is playing",
                    "A normal hunt will begin if the player reaches or is already at 0% sanity",
                    "A normal hunt will begin if the ghost initiates a hunt on its own, due to meeting normal hunt conditions rather than the box itself causing the hunt",
                    "Being within ~2.5 metres of an actively functioning music box drains the player's sanity at a rate of 2.5%/s, totalling approximately 75% if the entire song is listened to. This applies to all players within the range, regardless of who activated the music box"
                },
                Resources.music_box
            ),
            new CursedItem(
                "Haunted Mirror",
                new string[]{
                    "Can be used to determine the location of the ghost room",
                    "Using the haunted mirror will rapidly drain the sanity of the player at a rate of about 10%/s, including the animation of raising and lowering the mirror",
                    "If the user's sanity reaches zero, the mirror will break, and the ghost will start a cursed hunt from its current position"
                },
                Resources.mirror
            ),
            new CursedItem(
                "Summoning Circle",
                new string[]{
                    "Can be used to trigger a cursed hunt, beginning at the summoning circle",
                    "Each candle deducts 16% sanity for nearby players, leading to a total of 80% being deducted for all candles",
                    "The summoned ghost stays motionless for about 5 seconds, unable to kill players. This stationary period is considered a ghost event"
                },
                Resources.circle
            ),
            new CursedItem(
                "Voodoo Doll",
                new string[]{
                    "Interacting with the voodoo doll will cause one of the 10 pins stuck in the doll to be pushed into it at random",
                    "This will cause the ghost to perform an interaction, and will drop the user's sanity by 5%. These forced interactions can include evidence sources",
                    "If the heart pin is pressed down, the user's sanity will drop by 10%, and the ghost will initiate a cursed hunt",
                    "If the user's sanity is less than the sanity that the pressed pin would drain, all remaining pins will also get pushed in and a cursed hunt will also occur"
                },
                Resources.voodoo
            ),
            new CursedItem(
                "Tarot Cards",
                new string[]{
                    "Tarot cards can be picked up and one card can be drawn at a time. Each Tarot cards deck contains 10 randomly generated cards",
                    "A single card type can appear more than once in the deck",
                    "When the deck is used up, all future hunts will also be extended by 20 seconds, even if no Death card was drawn prior"
                },
                Resources.cards,
                new List<TarotCard>(new TarotCard[]
                {
                    new TarotCard(
                        "The Sun",
                        Color.Yellow,
                        Resources.card_sun,
                        "Sets the player's sanity to 100%",
                        "5%"
                    ),
                    new TarotCard(
                        "The Moon",
                        Color.White,
                        Resources.card_moon,
                        "Sets the player's sanity to 0%",
                        "5%"
                    ),
                    new TarotCard(
                        "The Tower",
                        Color.Blue,
                        Resources.card_tower,
                        "Causes an interaction",
                        "20%"
                    ),
                    new TarotCard(
                        "The Wheel of Fortune",
                        Color.Red,
                        Resources.card_fortune,
                        "Lose 25% sanity",
                        "20%"
                    ),
                    new TarotCard(
                        "The Wheel of Fortune",
                        Color.Green,
                        Resources.card_fortune,
                        "Gain 25% sanity",
                        "20%"
                    ),
                    new TarotCard(
                        "The Devil",
                        Color.Pink,
                        Resources.card_devil,
                        "Triggers a ghost event",
                        "10%"
                    ),
                    new TarotCard(
                        "The High Preistess",
                        Color.LightYellow,
                        Resources.card_preistess,
                        "Revives a random dead player. If no players are dead, will revive the next player who dies. Does not stack",
                        "2%"
                    ),
                    new TarotCard(
                        "The Hanged Man",
                        Color.Black,
                        Resources.card_man,
                        "Instantly kills the player",
                        "1%"
                    ),
                    new TarotCard(
                        "Death",
                        Color.Purple,
                        Resources.card_death,
                        "Triggers a cursed hunt",
                        "10%"
                    ),
                    new TarotCard(
                        "The Hermit",
                        Color.Cyan,
                        Resources.card_hermit,
                        "Teleports the ghost back to the ghost room and traps it for 1 minute. Does not affect hunts",
                        "10%"
                    ),
                    new TarotCard(
                        "The Fool",
                        Color.Purple,
                        Resources.card_fool,
                        "Will appear as another card at first. Does nothing",
                        "17%, 100% (during a hunt)"
                    )
                })
            )
        });
        #endregion CursedItems

        #region Items
        public static List<Item> items = new List<Item>(new Item[]
        {
            new Item(
                "Flashlight",
                new string[] {
                    "During a hunt, the flashlight will rapidly flicker if a ghost is within 10 metres and on the same floor (increased range for a Raiju)",
                    "Like other electronic equipment, holding a lit flashlight during a hunt will alert the ghost of the player's presence if it is within 10 metres (or 2 metres for a Yokai), and should be turned off immediately"
                },
                Resources.flash,
                30,
                4,
                true
            ),
            new Item(
                "Strong Flashlight",
                new string[] {
                    "During a hunt, the flashlight will rapidly flicker if a ghost is within 10 metres and on the same floor (increased range for a Raiju)",
                    "Like other electronic equipment, holding a lit flashlight during a hunt will alert the ghost of the player's presence if it is within 10 metres (or 2 metres for a Yokai), and should be turned off immediately",
                    "Strong flashlights are functionally the same as regular flashlights, with the exception of an increased area of effect, and a white shade of light instead of yellow"
                },
                Resources.s_flash,
                50,
                4,
                false
            ),
            new Item(
                "Salt",
                new string[] {
                    "Each salt shaker can be used 3 times",
                    "When a ghost walks onto a salt pile, a sole-like imprint will be left in the salt pile. Within the next 10 seconds after the salt has been stepped in, footprints may also be created if the ghost moves and makes footstep sounds, which can be found by shining a UV light around the area where the ghost walked. Taking a photo of these footprints counts toward photo rewards",
                    "Ghosts will not step in salt during a hunt",
                    "UV Footsteps will not be visibile if the ghost is a Wraith (or a Mimic behaving like a Wraith), and so will not count towards photo rewards"
                },
                Resources.salt,
                15,
                3,
                false
            ),
            new Item(
                "Photo Camera",
                new string[] {
                    "Each photo camera can take a maximum of 5 photos",
                    "When a ghost manifests during a ghost event or a hunt, the photo camera's display will be distorted, as well as any pictures taken. However, pictures taken in this state will still be labeled in the journal if a valid subject is detected",
                    "A Ghost picture will not be possible if the ghost is a Phantom, as the ghost will dissapear for a short time",
                    "There is a 1 second cooldown between taking pictures",
                    "The first 10 pictures recorded in journal and that are labeled in black will give the player \"points\" depending on the distance and category in the journal"
                },
                Resources.photocam,
                40,
                3,
                true
            ),
            new Item(
                "Video Camera",
                new string[] {
                    "The video camera can be used handheld with its built-in display or placed on the floor or a tripod",
                    "The video camera will automatically start streaming its video feed to the van when open or placed",
                    "Night vision can be toggled while holding the active video camera or via the van keyboard",
                    "When night vision is turned on, any Ghost Orbs present can be seen through the Video Camera",
                    "If the ghost is a Goryo, its DOTS Projector evidence will only be visible with the Video Camera"
                },
                Resources.videocam,
                50,
                6,
                true
            ),
            new Item(
                "Tripod",
                new string[] {
                    "Picking up a video camera and placing it on top of the tripod will mount the camera on the tripod. Carrying the tripod afterwards will bring the camera along as well, so the player does not need to carry both an empty tripod and an unmounted video camera",
                    "The video camera can be removed from the tripod by picking it up",
                    "A tripod must be placed by dropping it",
                    "The tripod will drop directly below the player, and will face the direction the player was facing when they dropped it",
                    "Tripods take up your hand slot while carrying it; they cannot be stored in your inventory, and switching to another item or hand while carrying a tripod will automatically drop the tripod"
                },
                Resources.tripod,
                25,
                5,
                false
            ),
            new Item(
                "Ghost Writing Book",
                new string[] {
                    "The book must then be placed to allow a ghost to write in it; the book cannot be written in if it is thrown on the ground or held in hand",
                    "If Ghost Writing is an evidence type for the ghost, the ghost has a chance of interacting with the book by writing in it. When this happens, the book will slightly levitate and the pen will start to frantically scribble on the pages visually and audibly, followed by the pen being thrown on the ground",
                    "Ghosts with the evidence type will prioritise writing in the book over attempting to throw it, though it will not write in the book during a hunt",
                    "Ghosts without the evidence are only able to throw the book",
                    "Once written in, the book can be photographed using a Photo Camera to receive photo points for a Ghost Interaction"
                },
                Resources.book,
                40,
                2,
                true
            ),
            new Item(
                "Spirit Box",
                new string[] {
                    "Players can ask questions via the Spirit Box using Voice Chat",
                    "The player must be within 3 metres for the Spirit Box to receive questions",
                    "The player must either be in the same room as the ghost, or within 3 meters of it if not in the same room",
                    "The Deogen has a 33% chance to respond with heavy breathing instead of a regular response if the player is standing within 1 metre of the ghost",
                    "The Moroi will curse the player who asked a question if they successfully obtain a response. The cursing response will not sound any different",
                    "Some of the valid questions listed are not intentionally added to the game, and are misinterpreted variants of valid questions"
                },
                Resources.box,
                50,
                2,
                true,
                new List<SpiritBoxQuestion>(new SpiritBoxQuestion[]{
                    new SpiritBoxQuestion(
                        "Aggression",
                        new string[]
                        {
                            "What do you want?",
                            "Why are you here?",
                            "Do you want to hurt us?",
                            "Are you angry?",
                            "Do you want us here?",
                            "Shall we leave?",
                            "Should we leave?",
                            "Do you want us to leave?",
                            "What should we do?",
                            "Can we help?",
                            "Is anything wrong?",
                            "Are you friendly?",
                            "Are you dangerous?",
                            "Are you French?",
                            "Are you hungry?",
                            "What do you want to eat?",
                            "Do you want to build a snowman?",
                            "Do you want to watch Spongebob?",
                            "Do you want to smash?"
                        }
                    ),
                    new SpiritBoxQuestion(
                        "Location",
                        new string[]
                        {
                            "Where are you?",
                            "Are you close?",
                            "Can you show yourself?",
                            "Give us a sign",
                            "Let us know you are here",
                            "Show yourself",
                            "Can you talk?",
                            "Speak to us",
                            "Are you here?",
                            "Are you with us?",
                            "Anybody with us?",
                            "Is anyone here?",
                            "Anybody in the room?",
                            "Anybody here?",
                            "Is there a spirit here?",
                            "Is there a Ghost here?",
                            "What is your location?",
                            "Are you among us?",
                            "Are you Casper?",
                            "Yourself?",
                            "Let us know you want a beer"
                        }
                    ),
                    new SpiritBoxQuestion(
                        "Age",
                        new string[]
                        {
                            "How old are you?",
                            "How young are you?",
                            "What is your age?",
                            "When were you born?",
                            "Are you a child?",
                            "Are you old?",
                            "Are you young?",
                            "Are you bored?"
                        }
                    )
                })
            ),
            new Item(
                "Candle",
                new string[] {
                    "Players can light a candle held in their hand if they carry a lighter in their inventory",
                    "When held, a lit candle will stop passive sanity drain that results from being in the dark",
                    "Ghosts will occasionally blow out a candle that is within 4 metres of it. The fire will be extinguished with a blowing \"sigh\" effect",
                    "Candles can be placed down on surfaces, which will be indicated by a translucent outline of the candle. This will place the candle upright relative to the surface",
                    "If an Onryo blows out a candle, it has a chance of starting a hunt, regardless of sanity; this chance increases for every dead player"
                },
                Resources.candle,
                15,
                4,
                false
            ),
            new Item(
                "Crucifix",
                new string[] {
                    "At the point the ghost initiates a hunt, if a crucifix is within 3 metres of it (or 5 for a Demon), the hunt will fail to begin. Does not apply to cursed hunts",
                    "The crucifix works both when thrown down or while held in hand",
                    "Each time a crucifix is used, an EMF 2 reading is shown",
                    "The crucifix has 2 charges. When one charge is used, one side of the crucifix will break off and disappear. When the whole crucifix is used, it will glow red. At this point, it will have no effect on the ghost",
                    "Each time a crucifix is used, the ghost will wait a minimum of 5 seconds before attempting to hunt again",
                    "The crucifix range is not limited by any obstacles like walls or doors",
                    "A picture of a used crucifix can be a taken for a photo reward, once for each charge is used"
                },
                Resources.crucifix,
                30,
                2,
                false
            ),
            new Item(
                "DOTS Projector",
                new string[] {
                    "The DOTS Projector can be mounted on the wall or floor similar to a motion sensor",
                    "It emits a matrix of bright green laser points in a small area from the projector",
                    "If DOTS Projector is one of the ghost's evidences, and the ghost is within 7 metres of the projector on the same floor, the ghost will occasionally interact with the projector",
                    "A mesh-like figure representative of the ghost model will appear running or crawling through the grid. This can be observed by the naked eye or through a video camera, except if the ghost is a Goryo, which requires a video camera to see the figure",
                    "Dead players cannot see the ghost pass through the DOTS Projector",
                    "The figure seen via the DOTS Projector is unrelated to the actual motion of the ghost; its appearance only indicates that the ghost is near enough to interact with the DOTS Projector"
                },
                Resources.dots,
                65,
                2,
                true
            ),
            new Item(
                "EMF Reader",
                new string[] {
                    "If the EMF reader is within ~1.5 metres of an EMF emission, the reader will light up various numbers of its LEDs",
                    "If multiple EMF emissions are in range, the one with the highest EMF level will be indicated by the reader",
                    "EMF 1 (Blue) - No EMF (EMF Reader is on, defualt state)",
                    "EMF 2 (Green) - Interaction",
                    "EMF 3 (Yellow) - Throwing an object",
                    "EMF 4 (Orange) - Manifestation",
                    "EMF 5 (Red) - Evidence (25% chance)"
                },
                Resources.emf,
                45,
                2,
                true
            ),
            new Item(
                "Glowstick",
                new string[] {
                    "The UV light emitted by the glowstick has the same functionality as the UV Flashlight",
                    "Once used, glows brightly for 1 minute, then fades to half intensity over the next 10 seconds"
                },
                Resources.glow,
                20,
                4,
                false
            ),
            new Item(
                "Head Mounted Camera",
                new string[] {
                    "Picking up the cameras will put them on the player's head; they can be placed back at any time",
                    "These cameras do not take up an inventory slot, and act as a regular video camera when worn, providing a Video Feed in the van",
                    "They move with the player and look in the direction the player's model is facing at the time",
                    "Head Mounted Cameras do not attract the ghost during hunts and will not power the Raiju's ability",
                    "Like with regular video cameras, Head Mounted Cameras can switch between visual and night-vision modes, and can be used to detect Ghost Orbs when in night vision mode"
                },
                Resources.hmc,
                60,
                4,
                false
            ),
            new Item(
                "Lighter",
                new string[] {
                    "The lighter can be used either when held or when in the inventory. The lighter can be lit by right-clicking while holding it",
                    "Smudge sticks, summoning circle candles and regular candles can then be lit by aiming at the item and pressing the Secondary Use key",
                    "If the lighter is offhand in the inventory, smudge sticks or candles being held on-hand can be lit by pressing the Secondary Use key"
                },
                Resources.lighter,
                10,
                4,
                false
            ),
            new Item(
                "Motion Sensor",
                new string[] {
                    "A motion sensor can used by placing it on the wall or floor",
                    "Motion sensors placed on a wall display on the Site Map in the van as a red bar, indicating its effective detection distance",
                    "When a player, ghost, or dead player walks past the front of it, the motion sensor will emit a bright light for 3 seconds",
                    "The bar on the site map will also turn green for 6 seconds, and an audible beep will play from the monitor",
                    "Motion sensors that are not displayed will still play the beep"
                },
                Resources.motion,
                100,
                4,
                false
            ),
            new Item(
                "Sound Sensor",
                new string[] {
                    "A sound sensor can be placed on the ground",
                    "The detection area is highlighted as an orange circle on the Site Map in the Van",
                    "The sound sensor picks up most noises, except for players talking through local and global chat",
                    "Any noise picked up will appear as a bar on the Sound Monitor, showing how loud the sound was and identifying which sensor picked up the sound",
                    "The value displayed will update every second",
                    "0.1 dB picked up on a Parabolic Microphone is equivalent to 1% on the Sound Monitor",
                    "The area covered by a sound sensor is fixed, but relative to the in-game map and not the building"
                },
                Resources.sound,
                80,
                4,
                false
            ),
            new Item(
                "Parabolic Microphone",
                new string[] {
                    "The parabolic microphone must be pointed in the direction that sounds are being made to pick up any form of interaction on the screen. It has a range of 30 meters with a 6 meter wide cone",
                    "If a ghost interacts with something, such as moving a door, throwing an object, or causing footsteps, the microphone will detect the sound for 3 seconds",
                    "Mylings make paranormal sounds more often than other ghosts",
                    "Banshees have a certain chance of using a unique scream",
                    "Morois will curse players that hear their paranormal sounds, resulting in an increased passive sanity drain",
                    "Ambient sounds not caused by ghost - less than 0.5 dB",
                    "Ghost's current room - less than 1 dB",
                    "Keyboard being pressed - 1.0-2.0 dB",
                    "Light being toggled - 1.0-2.0 dB",
                    "Fuse box - 3.0 dB",
                    "Door (player) - 4dB",
                    "Door (ghost) - variable",
                    "Desk radio static - 5.0 dB",
                    "Running sink - 5.0 dB",
                    "Spirit box static - 5.0 dB",
                    "Objects thrown - more than 1dB"
                },
                Resources.paramic,
                50,
                2,
                false
            ),
            new Item(
                "Sanity Pills",
                new string[] {
                    "Consuming a sanity pill will replenish a certain amount of the player's sanity up to the maximum of 100%",
                    "Amateur - 40%",
                    "Intermediate - 35%",
                    "Professional - 30%",
                    "Nightmare - 25%",
                    "Sanity pills cannot be consumed if the player's sanity is above 95%"
                },
                Resources.pills,
                20,
                4,
                false
            ),
            new Item(
                "Smudge Stick",
                new string[] {
                    "To light a smudge stick, have a lighter in the inventory, hold the smudge stick, then press the Primary Use key",
                    "Once lit, the smudge sticks will begin to smoke for 6 seconds",
                    "When the smudge stick is used up, the smoke will stop being emitted and the model will finish burning to a stub",
                    "When the ghost is within 6 metres of a smudge stick while it is burning, ghost activity will be increased marginally, and the ghost will be unable to initiate a regular hunt for 90 seconds, 180 seconds for a Spirit, or 60 seconds for a Demon",
                    "If the ghost is a Yurei, it will also not wander outside of its current room for 90 seconds",
                    "Smudging will not prevent cursed hunts nor stop an already ongoing hunt, but doing this during a hunt it will prevent further attempts to initiate regular hunts for the specified duration starting from when the smudging effect is applied",
                    "Using another smudge stick before an existing hunt prevention timer has run out will not reset or extend the timer; the effect does not stack in this case",
                    "Smudge sticks can be used to \"repel\" the ghost during a hunt. When the effect is successfully applied, the ghost will act as if there were no players around; one can walk through it without dying. After this period, the ghost will be able to see and kill players again"
                },
                Resources.smudge,
                15,
                4,
                false
            ),
            new Item(
                "Thermometer",
                new string[] {
                    "The thermometer reads the temperature by casting a short ray in the direction the player is facing",
                    "The reading shown will update every two seconds"
                },
                Resources.thermo,
                30,
                3,
                false
            ),
            new Item(
                "UV Light",
                new string[] {
                    "The UV flashlight can be activated at the same time as a standard flashlight or Strong Flashlight, but any visible fingerprints or footprints may contrast poorly and be hard to see under their light",
                    "The UV flashlight projects a conical, purple light in front of it. This light is weak relative to flashlights or strong flashlights, but stronger than a dimmed-out glowstick",
                    "When a UV Flashlight is shone towards a fingerprint, a visible green print will be highlighted. The same applies to footprints",
                    "The UV flashlight counts as an electronic equipment, and will flicker rapidly near a ghost which has manifested and attract it during a hunt when nearby"
                },
                Resources.uv,
                35,
                2,
                true
            )
        });
        #endregion
    }
}

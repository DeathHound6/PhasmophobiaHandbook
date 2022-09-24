using System.Collections.Generic;
using System.Drawing;
using PhasmophobiaHandbook.Properties;
using PhasmophobiaHandbook.Structs.Base;

namespace PhasmophobiaHandbook.Structs.Inherited
{
    public static class Constants
    {

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
                        "Teleports the ghost back to the ghost room and traps it for 1 minute. DOes not affect hunts",
                        "10%"
                    ),
                    new TarotCard(
                        "The Fool",
                        Color.MediumPurple,
                        Resources.card_fool,
                        "Will appear as another card at first. Does nothing",
                        "100% (during a hunt), 17% otherwise"
                    )
                })
            )
        });
    }
}

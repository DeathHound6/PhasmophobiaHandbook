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
                new string[] {"Smudging prevents the ghost from hunting for 180 seconds, instead of the usual 90s"},
                "50%",
                new string[][] { new string[] {"Hunting Speed" } }
            ),
            new Ghost(
                "Wraith",
                new GhostEvidence[] { GhostEvidence.EMF5, GhostEvidence.SpiritBox, GhostEvidence.DOTSProjector },
                new string[] {"The ghost will not show any UV footsteps after walking in salt", "Can teleport near a random player inside the location and will leave EMF"},
                "50%",
                new string[][] { new string[] { "Hunting Speed" } }
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
                new string[][] { new string[] { "Hunting Speed" } }
            ),
            new Ghost(
                "Poltergeist",
                new GhostEvidence[] { GhostEvidence.SpiritBox, GhostEvidence.Fingerprints, GhostEvidence.GhostWriting },
                new string[] {
                    "Can throw several items at the same time",
                    "Reduces sanity 2x more than a normal interaction when throwing numerous items"
                },
                "50%",
                new string[][] { new string[] { "Hunting Speed" } }
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
                new string[][] { new string[] { "Hunting Speed" } }
            ),
            new Ghost(
                "Jinn",
                new GhostEvidence[] { GhostEvidence.EMF5, GhostEvidence.Fingerprints, GhostEvidence.FreezingTemperatures },
                new string[] {
                    "Will never turn the breaker off",
                    "When the breaker is on, there is a chance to drop sanity by 25% when within 3 metres of the ghost"
                },
                "50%",
                new string[][] { new string[] { "Hunting Speed" } }
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
                new string[][] { new string[] { "Hunting Speed" } }
            ),
            new Ghost(
                 "Revenant",
                 new GhostEvidence[] { GhostEvidence.GhostOrbs, GhostEvidence.GhostWriting, GhostEvidence.FreezingTemperatures },
                 new string[] {},
                 "50%",
                 new string[][] { new string[] { "Hunting Speed (Line of Sight)" } }
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
                new string[][] { new string[] { "Hunting Speed" } }
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
                new string[][] { new string[] { "Hunting Speed" } }
            ),
            new Ghost(
                "Yurei",
                new GhostEvidence[] { GhostEvidence.GhostOrbs, GhostEvidence.FreezingTemperatures, GhostEvidence.DOTSProjector },
                new string[] {
                    "There is a chance to drop sanity by 13% when within 3 metres. This is indicated by the closing of a nearby door",
                    "Cannot roam while smudged. If smudged during a hunt, the ghost will return to where it was smudged once the hunt ends"
                },
                "50%",
                new string[][] { new string[] { "Hunting Speed" } }
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
                new string[][] { new string[] { "Hunting Speed" } }
            ),
            new Ghost(
                "Yokai",
                new GhostEvidence[] { GhostEvidence.SpiritBox, GhostEvidence.GhostOrbs, GhostEvidence.DOTSProjector },
                new string[] {
                    "Increased activity when talking near the ghost",
                    "Can only detect players voice or held active electronics when less than 2 metres away"
                },
                "80% (When talking within 2 metres of ghost), 50% otherwise",
                new string[][] { new string[] { "Hunting Speed" } }
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
                new string[][] { new string[] { "Hunting Speed" } }
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
                new string[][] { new string[] { "Hunting Speed" } }
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
                 new string[][] { new string[] { "Hunting Speed" } }
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
                new string[][] { new string[] { "Hunting Speed" } }
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
                new string[][] { new string[] { "Hunting Speed" } }
            ),
            new Ghost(
                "Raiju",
                new GhostEvidence[] { GhostEvidence.EMF5, GhostEvidence.GhostOrbs, GhostEvidence.DOTSProjector },
                new string[] {
                    "Has an increased range of electronics malfunctioning"
                },
                "65% (When in presence of active electronics), 50% otherwise",
                new string[][] { new string[] { "Hunting Speed" } }
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
                new string[][] { new string[] { "Hunting Speed" } }
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
                 new string[][] { new string[] { "Hunting Speed" } }
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
                new string[][] { new string[] { "Hunting Speed" } }
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
                new string[][] { new string[] { "Hunting Speed" } }
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
                new string[][] { new string[] { "Hunting Speed (Young)" } }
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

        public static List<CursedItem> items = new List<CursedItem>(new CursedItem[]
        {
            new CursedItem(
                "Oujia Board",
                new string[]{},
                Resources.loog
            ),
            new CursedItem(
                "Music Box",
                new string[]{},
                Resources.music_box
            ),
            new CursedItem(
                "Haunted Mirror",
                new string[]{},
                Resources.mirror
            ),
            new CursedItem(
                "Summoning Circle",
                new string[]{},
                Resources.circle
            ),
            new CursedItem(
                "Voodoo Doll",
                new string[]{},
                Resources.voodoo
            ),
            new CursedItem(
                "Tarot Cards",
                new string[]{},
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

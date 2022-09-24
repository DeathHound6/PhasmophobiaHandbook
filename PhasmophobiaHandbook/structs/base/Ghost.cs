namespace PhasmophobiaHandbook.Structs.Base
{
    public class Ghost
    {
        public Ghost(string name, GhostEvidence[] evidences, string[] notes, string sanity, object[][] audio)
        {
            Name = name;
            Evidences = evidences;
            Notes = notes;
            HuntingSanity = sanity;
            Audio = audio;
        }

        public string Name { get; private set; }
        public GhostEvidence[] Evidences { get; private set; }
        public string[] Notes { get; private set; }
        public string HuntingSanity { get; private set; }
        public object[][] Audio { get; private set; }
    }

    public enum GhostEvidence
    {
        EMF5,
        DOTSProjector,
        Fingerprints,
        GhostOrbs,
        GhostWriting,
        SpiritBox,
        FreezingTemperatures
    }
}

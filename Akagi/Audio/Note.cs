namespace Akagi.Audio
{
    public struct Note
    {
        public int Tone { get; }
        public Duration Duration { get; }

        public Note(int tone, Duration duration)
        {
            Tone = tone;
            Duration = duration;
        }
    }
}

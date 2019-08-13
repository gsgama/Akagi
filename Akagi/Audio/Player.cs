using System;
using System.Threading;

namespace Akagi.Audio
{
    public static class Player
    {
        public static void Play(
            Note[] tune,
            double tempo = 1.0)
        {
            if (tune == null)
                throw new ArgumentNullException(nameof(tune));
            if (tempo < 1)
                throw new ArgumentOutOfRangeException(nameof(tempo));

            new Thread(() =>
            {
                foreach (Note note in tune)
                {
                    if (note.Tone == 0)
                        Thread.Sleep((int)((int)note.Duration / tempo));
                    else
                        Console.Beep(note.Tone, (int)((int)note.Duration / tempo));
                }
            }).Start();
        }
    }
}

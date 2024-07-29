namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPlayer player = new MediaPlayer();
            player.Play();
            player.Pause();
            player.Record();
            player.StopRecording();
        }
    }

    interface IPlayable
    {
        void Play();
        void Pause();
    }

    interface IRecordable
    {
        void Record();
        void StopRecording();
    }

    class MediaPlayer : IRecordable, IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("Paused.");
        }

        public void Play()
        {
            Console.WriteLine("Played.");
        }

        public void Record()
        {
            Console.WriteLine("Recored.");
        }

        public void StopRecording()
        {
            Console.WriteLine("Recording stopped.");
        }
    }
}

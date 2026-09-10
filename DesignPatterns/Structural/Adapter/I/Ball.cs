namespace DesignPatterns.Structural.Adapter.I
{
    internal class Ball : IBall
    {
        public double R { get; set; }

        public double GetRadius()
        {
            return R;
        }
    }
}

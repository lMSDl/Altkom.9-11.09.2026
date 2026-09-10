namespace DesignPatterns.Structural.Adapter.I
{
    internal class CubeToBallAdapter : IBall
    {
        private readonly Cube _cube;

        public CubeToBallAdapter(Cube cube)
        {
            _cube = cube;
        }

        public double GetRadius()
        {
            return _cube.A * Math.Sqrt(3) / 2;
        }
    }
}

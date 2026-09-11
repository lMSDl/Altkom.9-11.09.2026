namespace DesignPatterns.Behavioral.NullObject
{
    internal class NullObject : AbstractObject
    {
        public override void Method3()
        {
            // Do nothing
        }

        public override void Method2()
        {
        }

        new public void Method1()
        {
        }
    }
}

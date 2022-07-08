namespace DependencyInjection.Demo
{
    public class Logic
    {
        public int Value1 { get; private set; }

        public int Value2 { get; private set; }
    public Logic()
        {
            Value1 = Random.Shared.Next(0, 100);
            Value2 = Random.Shared.Next(0, 100);
        }
    }
}

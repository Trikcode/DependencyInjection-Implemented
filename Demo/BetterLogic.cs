namespace DependencyInjection.Demo
{
    public class BetterLogic : IBetterlogic
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }

        public BetterLogic()
        {
            Value1 = 1;
            Value2 = 2;
        }
    }
}

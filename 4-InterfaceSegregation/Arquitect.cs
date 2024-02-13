namespace InterfaceSegregation
{
    public class Arquitect : IActivities
    {
        public Arquitect()
        {
        }

        public void Plan()
        {
            throw new ArgumentException();
        }

        public void Comunicate()
        {
            throw new ArgumentException();
        }

        public void Design()
        {
            Console.WriteLine("I'm designing new futures");
        }

        public void Develop()
        {
            throw new ArgumentException();
        }

        public void Test()
        {
            throw new ArgumentException();
        }
    }
}
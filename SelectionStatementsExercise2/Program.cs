namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I LOVE math!");
                    break;
                case "science":
                    Console.WriteLine("Science is okay");
                    break;
                case "pe":
                    Console.WriteLine("I am super competitive in PE");
                    break;
                case "english":
                    Console.WriteLine("English is chellenging");
                    break;
                default:
                    Console.WriteLine("I don't know that subject.");
                    break;
            }
        }
    }
}
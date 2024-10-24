namespace DegreeDeterminer;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World!");
        Console.WriteLine("Welcome to the Degree Determiner!");
        int digitalPortfolio = 0;
        int openBookExam = 0;
        int capstoneProject = 0;
        
        do {
            Console.WriteLine("Please enter your Digital Portfolio raw score: ");
            digitalPortfolio = Convert.ToInt32(Console.ReadLine());
            if (digitalPortfolio < 0 || digitalPortfolio > 30)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 30.");
            }
        } while (digitalPortfolio <= 0 || digitalPortfolio > 30);

        do {
            Console.WriteLine("Please enter your Open Book Exam raw score: ");
            openBookExam = Convert.ToInt32(Console.ReadLine());
            if (openBookExam < 0 || openBookExam > 20)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 20.");
            }
        } while (openBookExam <= 0 || openBookExam > 20);

        do {
            Console.WriteLine("Please enter your Capstone Project raw score: ");
            capstoneProject = Convert.ToInt32(Console.ReadLine());
            if (capstoneProject < 0 || capstoneProject > 100)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
            }
        } while (capstoneProject <= 0 || capstoneProject > 100);
        
        double doubleDigitalPortfolio = digitalPortfolio;
        double doubleOpenBookExam = openBookExam;
        double doubleCapstoneProject = capstoneProject;

        double portfolioPercentage = 100 * doubleDigitalPortfolio / 30;
        portfolioPercentage = Math.Round(portfolioPercentage, 2, MidpointRounding.AwayFromZero);
        //Console.WriteLine($"Your Digital Portfolio percentage is: {portfolioPercentage}");
        //Thread.Sleep(1000);
        
        double openBookExamPercentage = 100 * doubleOpenBookExam / 20;
        openBookExamPercentage = Math.Round(openBookExamPercentage, 2, MidpointRounding.AwayFromZero);
        //Console.WriteLine($"Your Open Book Exam percentage is: {openBookExamPercentage}");
        //Thread.Sleep(1000);
        
        double capstoneProjectPercentage = 100 * doubleCapstoneProject / 100;
        capstoneProjectPercentage = Math.Round(capstoneProjectPercentage, 2, MidpointRounding.AwayFromZero);
        //Console.WriteLine($"Your Capstone Project percentage is: {capstoneProjectPercentage}");
        //Thread.Sleep(1000);
        
       double totalPercentage = (portfolioPercentage * 50 / 100) + (openBookExamPercentage * 25 / 100) + (capstoneProjectPercentage * 25 / 100);
       totalPercentage = Math.Round(totalPercentage, 2, MidpointRounding.AwayFromZero);
       Console.WriteLine($"Your total percentage is: {totalPercentage}");
       //Thread.Sleep(1000);

       if (totalPercentage >= 70)
       {
           Console.WriteLine("Congratulations! You have passed the course with a First-Class Honours.");
       }
       else if (totalPercentage >= 60 && totalPercentage < 70)
       {
           Console.WriteLine("Congratulations! You have passed the course with an Upper Second-Class Honours.");
       }
       else if (totalPercentage >= 50 && totalPercentage < 60)
       {
           Console.WriteLine("Congratulations! You have passed the course with a Lower Second-Class Honours.");
       }
       else if (totalPercentage >= 40 && totalPercentage < 50)
       {
           Console.WriteLine("Congratulations! You have passed the course with a Third-Class Degree.");
       }
       else if (openBookExamPercentage < 40 || capstoneProjectPercentage < 40)
       {
           Console.WriteLine("Unfortunately, you have failed one (or more) modules. Therefore, you are ineligible to pass the course.");
       }
       
    }
}

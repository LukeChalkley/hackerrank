using Microsoft.Extensions.DependencyInjection;
using SolutionCode;
using SolutionCode.Algorithms.Warmup;
using SolutionCode.Prepare.Data_Structures.Stacks;

namespace ConsoleRunner
{
    internal class Program
    {
        /*
        private static ServiceProvider _services;

        public static ServiceProvider Services { get => _services; }

        private static void Main(string[] args)
        {
            _services = CreateServices();

            Application app = _services.GetRequiredService<Application>();
            IChallenge challenge = _services.GetRequiredService<IChallenge>();
            IChallengeParam challengeParam = _services.GetRequiredService<IChallengeParam>();

            app.RunChallenge(challenge, challengeParam);
        }

        private static ServiceProvider CreateServices()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<Application>(new Application())
                .AddSingleton<IChallenge,BetweenTwoSets>()
                .AddSingleton<IChallengeParam,BetweenTwoSets.BetweenTwoSetsParams>()
                .AddLogging()
                .BuildServiceProvider();

            return serviceProvider;
        }
    }

    public class Application
    {
        public void RunChallenge(IChallenge challenge, IChallengeParam challengeParam)
        {
            BetweenTwoSets.BetweenTwoSetsParams param = challengeParam as BetweenTwoSets.BetweenTwoSetsParams;

            param.ListA = new List<int> { 2, 6 };
            param.ListB = new List<int> { 24, 36 };

            challenge.Run(challengeParam);
        }
    }
    */

        public static void Main(string[] args)
        {
            int commandCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Commands: {commandCount}");
            SimpleTextEditor simpleTextEditor = new SimpleTextEditor();

            for (int i = 0; i < commandCount; i++)
            {
                string fullCommand = Console.ReadLine();
                
                string[] splittedCommand = fullCommand.Split(' ');
                
                int commandNumber = Int32.Parse(splittedCommand[0]);
                
                ITextEditorCommand command;
                
                switch (commandNumber)
                {
                    case 1:
                    {
                        string strToAppend = splittedCommand[1];
                        command = new AppendCommand(strToAppend);
                        simpleTextEditor.AddCommandAndRun(command);
                        break;
                    }
                    case 2:
                    {
                        int lastCharsCountToRemove = int.Parse(splittedCommand[1]);
                        command = new DeleteCommand(lastCharsCountToRemove);
                        simpleTextEditor.AddCommandAndRun(command);
                        break;
                    }
                    case 3:
                    {
                        int indexToPrint = int.Parse(splittedCommand[1]);
                        command = new PrintCommand(indexToPrint);
                        simpleTextEditor.AddCommandAndRun(command);
                        break;   
                    }
                    case 4:
                    {
                        // Undo
                        Console.WriteLine("Undoing last command.");
                        simpleTextEditor.UndoLast();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Not a valid option. Defaulting to print string.");
                        command = new PrintStringCommand();
                        simpleTextEditor.AddCommandAndRun(command);
                        break;
                    }
                }
            }
        }
    }
}
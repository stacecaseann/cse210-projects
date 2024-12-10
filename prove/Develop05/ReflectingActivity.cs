public class ReflectingActivity : Activity
{
    HashSet<int> _usedPrompts = [];
    HashSet<int> _usedQuestions = [];
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";        
    }

    public void Run()
    {
        DisplayStartMessage();
        DisplayPrompt();
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine();
        DateTime endTime = CalculateEndTime();
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(7);
            Console.WriteLine();
            Console.WriteLine();
        }
        DisplayEndMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(_prompts.Length);
        while (_usedPrompts.Contains(randomNumber))
        {
            randomNumber = random.Next(_prompts.Length);
            _usedPrompts.Add(randomNumber);
            if (_usedPrompts.Count == _prompts.Length)
            {
                _usedPrompts.Clear();
            }
        }
        return _prompts[randomNumber];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomNumber = random.Next(_questions.Length);
        while (_usedQuestions.Contains(randomNumber))
        {
            randomNumber = random.Next(_questions.Length);
        }
        _usedQuestions.Add(randomNumber);
        if (_usedQuestions.Count == _questions.Length)
        {
            _usedQuestions.Clear();
        }
        return _questions[randomNumber];
    }

    public void DisplayPrompt()
    {
        Console.Write(GetRandomPrompt());
    }

    public void DisplayQuestion()
    {
        Console.Write(GetRandomQuestion());
    }

    private string[] _prompts = [
        "Think of a time when you stood up for someone else...",
        "Think of a time when you did something really difficult...",
        "Think of a time when you helped someone in need...",
        "Think of a time when you did something truly selfless...",
        "Think of a time when you tried something new...",
        "Think of a time when you showed innovation...",
        "Think of a time when you felt very peaceful and happy...",
        "Think of a time when you had to have a lot of faith to follow through..."
    ];    

    private string[] _questions = 
    [
        "Why was this experience meaningful to you? ...",
        "Have you ever done anything like this before? ...",
        "How did you get started? ...",
        "How did you feel when it was complete? ...",
        "What made this time different than other times when you were not as successful? ...",
        "What is your favorite thing about this experience? ...",
        "What could you learn from this experience that applies to other situations? ...",
        "What did you learn about yourself through this experience? ...",
        "How can you keep this experience in mind in the future? ..."
    ];
}
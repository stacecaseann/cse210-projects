public class PromptCreator
{
    public PromptCreator()
    {
        CreatePrompts();
    }
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0,_prompts.Count);
        
        return _prompts[randomNumber];
    }

    private void CreatePrompts()
    {
        _prompts = new List<string>(){
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }
}
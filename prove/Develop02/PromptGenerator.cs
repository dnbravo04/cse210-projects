class PromptGenerator
{
    Random _rnd = new Random();
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the most surprising thing I learned today?",
        "What's one act of kindness I witnessed or experienced today?",
        "If I could express my gratitude to someone I interacted with today, who would it be and what would I say?",
        "What accomplishment, no matter how small, am I most proud of from today?"
    };

    public string GetRandomPrompt()
    {
        int index = _rnd.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }
}
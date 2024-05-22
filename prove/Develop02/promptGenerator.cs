using System;
using System.Security.Cryptography;

public class PromptGenerator {
    private List<string> Prompts;
    private Random random;

    public PromptGenerator(List<string> Prompts) {
        this.Prompts = Prompts;
        this.random = new();
    }
    public string GetRandomPrompt()
    {
        int index = random.Next(Prompts.Count);
        return Prompts[index];
    }
    
    
    
}
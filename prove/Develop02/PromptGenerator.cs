using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        // Instantiate a Random object.
        Random randomGenerator = new Random();
        // Store _prompts length.
        int promptsLength = _prompts.Count;
        // Pick a random index between 0 and whatever promptsLength is.
        int randomIndex = randomGenerator.Next(0, promptsLength);
        // Return a random prompt from the provided list.
        return _prompts[randomIndex];
    }

    public void AddPrompts(params string[] prompts)
    {
        // Go through each provided prompt and add it to the _prompts list.
        foreach (string prompt in prompts)
        {
            _prompts.Add(prompt);
        }
    }
}
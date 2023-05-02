using System;
using System.Collections.Generic;

public class Entry
{
    public string _date = DateTime.Now.ToLongDateString();
    public string _prompt;
    public string _answer;
    public void WriteEntry(PromptGenerator promptGenerator)
    {
        List<string> prompts = promptGenerator._prompts;
        string randomPrompt = promptGenerator.GetRandomPrompt();
        _prompt = randomPrompt;
        Console.WriteLine(_prompt);
        Console.Write("> ");
        _answer = Console.ReadLine();
    }
    public void Display()
    {
        Console.WriteLine(
            $"\nDate: {_date} \nPrompt: {_prompt} \nAnswer: {_answer}\n"
        );
    }
}
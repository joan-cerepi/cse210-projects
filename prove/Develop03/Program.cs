using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scripture Memorizer!");
        Console.WriteLine();
        Scripture randomScripture = GetRandomScripture();
        randomScripture.UpdateText();
        randomScripture.Display();

        ConsoleKey key;
        do
        {
            key = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Scripture Memorizer!");
            Console.WriteLine();
            randomScripture.HideWords();
            randomScripture.UpdateText();
            randomScripture.Display();
        } while (key == ConsoleKey.Enter && !randomScripture.IsFullyHidden());
    }

    static Scripture GetRandomScripture()
    {
        List<Scripture> scriptures = new List<Scripture>();
        Random randomGenerator = new Random();

        Reference reference1 = new Reference("Moses", 1, 39);
        Scripture scripture1 = new Scripture(reference1, "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.");
        scriptures.Add(scripture1);

        Reference reference2 = new Reference("Moses", 7, 18);
        Scripture scripture2 = new Scripture(reference2, "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.");
        scriptures.Add(scripture2);

        Reference reference3 = new Reference("2 Nephi", 2, 25);
        Scripture scripture3 = new Scripture(reference3, "Adam fell that men might be; and men are, that they might have joy.");
        scriptures.Add(scripture3);

        Reference reference4 = new Reference("Genesis", 1, 26, 27);
        Scripture scripture4 = new Scripture(reference4, "And God said, Let us make man in our image, after our likeness: and let them have dominion over the fish of the sea, and over the fowl of the air, and over the cattle, and over all the earth, and over every creeping thing that creepeth upon the earth. So God created man in his own image, in the image of God created he him; male and female created he them.");
        scriptures.Add(scripture4);

        Reference reference5 = new Reference("2 Nephi", 32, 3);
        Scripture scripture5 = new Scripture(reference5, "Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do.");
        scriptures.Add(scripture5);

        Reference reference6 = new Reference("John", 17, 3);
        Scripture scripture6 = new Scripture(reference6, "And this is life eternal, that they might know thee the only true God, and Jesus Christ, whom thou hast sent.");
        scriptures.Add(scripture6);

        Reference reference7 = new Reference("Mosiah", 3, 19);
        Scripture scripture7 = new Scripture(reference7, "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.");
        scriptures.Add(scripture7);

        Reference reference8 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture8 = new Scripture(reference8, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        scriptures.Add(scripture8);

        Reference reference9 = new Reference("James", 1, 5, 6);
        Scripture scripture9 = new Scripture(reference9, "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.");
        scriptures.Add(scripture9);

        Reference reference10 = new Reference("James", 2, 17, 18);
        Scripture scripture10 = new Scripture(reference10, "Even so faith, if it hath not works, is dead, being alone. Yea, a man may say, Thou hast faith, and I have works: shew me thy faith without thy works, and I will shew thee my faith by my works.");
        scriptures.Add(scripture10);

        int randomIndex = randomGenerator.Next(0, scriptures.Count);
        return scriptures[randomIndex];
    }
}
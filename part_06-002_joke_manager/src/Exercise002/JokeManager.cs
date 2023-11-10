namespace Exercise002
{
    using System.Collections.Generic;
    using System;

    public class JokeManager
    {
        private List<string> jokesList;

        public JokeManager()
        {
            this.jokesList = new List<string>();
        }

        public void AddJoke(string joke)
        {
            jokesList.Add(joke);
        }

        public string DrawJoke()
        {
            if (jokesList.Count == 0)
            {
                return "Jokes are in short supply";
            }

            System.Console.WriteLine("Drawing random joke: ");

            Random random = new Random();
            int i = random.Next(jokesList.Count);

            return jokesList[i];
        }

        public void PrintJokes()
        {
            System.Console.WriteLine("Printing the jokes: ");
            foreach (var i in jokesList)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}

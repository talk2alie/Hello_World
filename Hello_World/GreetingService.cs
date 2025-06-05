using System;

namespace Hello_World
{
    public class GreetingService
    {
        /// <summary>
        /// Gets the greeting message
        /// </summary>
        /// <returns>The greeting message to display</returns>
        public string GetGreeting()
        {
            return "Hello Jenkins!";
        }

        /// <summary>
        /// Gets a personalized greeting message
        /// </summary>
        /// <param name="name">The name to greet</param>
        /// <returns>A personalized greeting message</returns>
        public string GetPersonalizedGreeting(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return GetGreeting();
            }
            
            return $"Hello {name.Trim()}!";
        }
    }
}


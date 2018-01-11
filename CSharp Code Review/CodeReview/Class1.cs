using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReview
{
    /// <summary>
    /// The Salutation class represents something that can say hello or goodbye
    /// </summary>
    public class Salutation
    {
        #region  Properties and Fields - What the Salutation objects will "look like"
        // Fields 
        private string _Greeting;
        private string _Farewell;

        #region Constructor and Methods - How the Salutation objects will "behave"
        /// <summary>
        /// Instansiates a salutation object with appropiate messages
        /// </summary>
        /// <param name="greetingMessage">The message to use when greeting</param>
        /// <param name="farewellMessage">The message to use to say goodbye</param>
        public Salutation(string greetingMessage, string farewellMessage)
        {
            _Greeting = greetingMessage;
            _Farewell = farewellMessage;
        }

        public string Greet()
        {
            return _Greeting;
        }
        public string SayFarewell()
        {
            return _Farewell;
        }
        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Web;

namespace TriviaApp
{
    class Program
    {
        class TriviaResult
        {
            public string category;
            public string type;
            public string difficulty;
            public string question;
            public string correct_answer;
            public List<string> incorrect_answers;
            
        }
        class Trivia
        {
            public int response_code;
            public List<TriviaResult> results;

        }
        static void Main(string[] args)
        {
            string url = null;
            string s = null;

            HttpWebRequest request;
            HttpWebResponse response;
            StreamReader reader;

            url = "https://opentdb.com/api.php?amount=1&category=15&type=multiple";

            request = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)request.GetResponse();

            reader = new StreamReader(response.GetResponseStream());
            s = reader.ReadToEnd();
            reader.Close();

            Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

            trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
            trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].correct_answer);

            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; ++i)
            {
                trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
            }

            //Trivia game code
            
            Console.WriteLine(trivia.results[0].question);
            int n = 0;
            int count = 1;
            Random rand = new Random();
            int answerSpot = rand.Next(0, 4);
            int nResponse = 0;

            for(int i = 0; i < 4; i++)
            {
                if(i == answerSpot)
                {
                    Console.WriteLine(answerSpot + 1 + ". " + trivia.results[0].correct_answer);
                    count += 1;

                }
                else
                {
                    Console.WriteLine(count  + ". " + trivia.results[0].incorrect_answers[n]);
                    n++;
                    count++;
                    
                }
                
            }
            Console.WriteLine("Choose from 1-4 to answer");

            while(!int.TryParse(Console.ReadLine(), out nResponse)){
                Console.WriteLine("Enter a number please");
            }

            if (nResponse - 1 == answerSpot)
            {
                Console.WriteLine("Correct!");
            }
            
            else
            {
                Console.WriteLine("Incorrect! The correct answer to this is " + (answerSpot + 1)+ ". " + trivia.results[0].correct_answer);
            }

        }
    }
}

using System.Diagnostics;

namespace TechnicalAssessment
{
    internal class Program
    {
        static void Main()
        {
            Helpers.WriteIntro();

            //Run the process 10 times to provide range of results.
            for (int i = 0; i < 10; i++)
            {
                List<Work> data = Helpers.GetData();

                Stopwatch stopwatch = Stopwatch.StartNew();

                //Uncomment EITHER a synchronous method or an asynchronous method to do work

                 DoWork(data);
                //await DoWorkAsync(data);

                stopwatch.Stop();
                Helpers.WriteResult(i, stopwatch.Elapsed.TotalMilliseconds);
            }
        }

        /// <summary>
        /// Method that will house your logic to perform the two steps of work
        /// </summary>
        /// <param name="data">List of Work data</param>
        /// <returns></returns>
        private static void DoWork(List<Work> data)
        {
            //Work obj = new Work();
            //data = new List<Work>(10000);
            

            foreach (Work work in data) 
            {

                String strGuidId = work.Id.ToString();
                char[] charArray = strGuidId.ToCharArray();
                Array.Sort(charArray);
                strGuidId = new string(charArray);
                int sum = 0;
                work.Step1Result = strGuidId;
                for (int i = 0; i < strGuidId.Length; i++)
                {
                    if (char.IsDigit(strGuidId[i]))
                    {
                        sum = sum + (int)char.GetNumericValue(strGuidId[i]);
                    }
                   
                }

                 work.Step2Result = sum.ToString();

            }
         

        }

        /// <summary>
        /// Asynchronous Method that will house your logic to perform the two steps of work
        /// </summary>
        /// <param name="data">List of Work data</param>
        /// <returns></returns>
        //private static async Task DoWorkAsync(List<Work> data)
        //{

        //}

    }
}
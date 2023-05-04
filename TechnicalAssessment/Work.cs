using System;

namespace TechnicalAssessment
{
    public class Work
    {
        public Guid Id { get; }

        public string Step1Result { get; set; }

        public string Step2Result { get; set; }

        public Work()
        {
            Id = Guid.NewGuid();
        }
    }
}

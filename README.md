# TechnicalAssessment
The task will be to perform a task a quickly as possible.
There are 10 000 objects in a list.
Each object must have 2 steps performed on it.
The object:
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
The first step:
•	Order the Id, and set on Step1Result property
•	An example of a sorted Id looks as follows:
o	----00001334444566677889ABBCCEEEEFFF
The second step:
•	Sum all numbers in the Id, and set on Step2Result property
•	An example of all integers summed is as follows:
o	85
Additional Requirements:
•	The Work class cannot be modified.
•	You will be required to use the existing .Net Console Application, located in the “Question 1” folder. 

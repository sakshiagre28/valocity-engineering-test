//PR COMMENT: Indent the entire code for better readability.
using System;
//PR COMMENT: Correct this typo for collections
using System.Collegctions.Generic;
using System.Linq;

namespace Utility.Valocity.ProfileHelper
{
    //PR COMMENT: The class name should be Person as it only contains information for a single person. Make changes wherever impacted throughout the code.
    public class People
    {
    //PR COMMENT: DateTime calculation uses multiple ways to calculate i.e DateTimeOffset, DateTime, etc. Make it uniform throught the code. Also use either AddYears or Subtract for uniform calculation.
     private static readonly DateTimeOffset Under16 = DateTimeOffset.UtcNow.AddYears(-15);
     public string Name { get; private set; }
     public DateTimeOffset DOB { get; private set; }
     //PR COMMENT: This constructor can be removed as it is not used. DOB is explicitly calculated in GetPeople method. Also remove Under16 as it will not be used.
     public People(string name) : this(name, Under16.Date) { }
     public People(string name, DateTime dob) {
         Name = name;
         DOB = dob;
     }}

    public class BirthingUnit
    {
        //PR COMMENT: The summary does not make sense. Please correct it for better description of code.
        /// <summary>
        /// MaxItemsToRetrieve
        /// </summary>
        private List<People> _people;

        public BirthingUnit()
        {
            _people = new List<People>();
        }

        //PR COMMENT: Summary can be elaborated more. Fix the typo for GetPeoples.
        /// <summary>
        /// GetPeoples
        /// </summary>
        /// <param name="j"></param>
        /// <returns>List<object></returns>
        // PR COMMENT: The method name should also be changed to CreatePeople/GeneratePeople. The parameter name should be changed from i to count.
        public List<People> GetPeople(int i)
        {
            for (int j = 0; j < i; j++)
            {
                try
                {
                    //PR COMMENT: Dandon seems to be a typo. It should be 'random'.
                    // Creates a dandon Name
                    string name = string.Empty;
                    var random = new Random();
                    //PR COMMENT: This will always be 0. It should be random.Next(0,2)
                    if (random.Next(0, 1) == 0) {
                        name = "Bob";
                    }
                    else {
                        name = "Betty";
                    }
                    // PR COMMENT: To calculate dob, multiply the random value by 365 instead of 356. Convert all the numbers to constants if possible. Dob can be calculated into seperate variable and then used to create the object for better readability.
                    // Adds new people to the list
                    _people.Add(new People(name, DateTime.UtcNow.Subtract(new TimeSpan(random.Next(18, 85) * 356, 0, 0, 0))));
                }
                catch (Exception e)
                {
                    //PR COMMENT: Throw the exception (e) as well along with generic message. The comment added is misleading. Please correct it.
                    // Dont think this should ever happen
                    throw new Exception("Something failed in user creation");
                }
            }
            return _people;
        }

        private IEnumerable<People> GetBobs(bool olderThan30)
        {
            //PR COMMENT: To calculate dob, multiply 30 with 365 instead of 356. Convert all the numbers to constants if possible. Extract this value DateTime.Now.Subtract(new TimeSpan(30 * 356, 0, 0, 0)) to a different variable for better readability
            return olderThan30 ? _people.Where(x => x.Name == "Bob" && x.DOB >= DateTime.Now.Subtract(new TimeSpan(30 * 356, 0, 0, 0))) : _people.Where(x => x.Name == "Bob");
        }

        public string GetMarried(People p, string lastName)
        {
            if (lastName.Contains("test"))
                return p.Name;
            //PR COMMENT: 255 can be created as a constant
            if ((p.Name.Length + lastName).Length > 255)
            {
                //PR COMMENT: This will give an error for 'not all code paths return a value'. Add return before the statement.
                (p.Name + " " + lastName).Substring(0, 255);
            }

            return p.Name + " " + lastName;
        }
    }
}
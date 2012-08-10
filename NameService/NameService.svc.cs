using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NameService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NameService" in code, svc and config file together.
    public class NameService : INameService
    {
        public Person GetRandomPerson()
        {
            string[] firstNames = new[] {"Jack", "Joe", "Bob"};
            string[] lastNames = new[] {"Johnson", "Jackson", "Bobson"};

            Random r = new Random();
            Person person = new Person();
            person.FirstName = firstNames[r.Next(firstNames.Length)];
            person.LastName = lastNames[r.Next(lastNames.Length)];
            return person;
        }
    }
}

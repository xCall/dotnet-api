﻿using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services.Implementations {
    public class PersonServiceImplementation : IPersonService {
        private volatile int count;

        public Person Create(Person person) {
            return person;
        }

        public void Delete(long id) {

        }

        public List<Person> FindAll() {
            List<Person> persons = new List<Person>();
            for(int i = 0; i <8; i++) {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        private Person MockPerson(int i) {
            return new Person {
                Id = IncrementeAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Address = "Piumhi - Minas Gerais" + i,
                Gender = "Male"
            };
        }

        private long IncrementeAndGet() {
            return Interlocked.Increment(ref count);
        }

        public Person FindById(long id) {
            return new Person {
                Id = IncrementeAndGet(),
                FirstName = "Carlos",
                LastName = "Uberlandia",
                Address = "Piumhi - Minas Gerais",
                Gender = "Male"
            };
        }

        public Person Update(Person person) {
            return person;
        }
    }
}

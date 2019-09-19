using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Clients
    { 
    public void Queue()
    {
        Queue Persons = new Queue();
        Persons.Enqueue("Client1");
        Persons.Enqueue("Client2");
        Persons.Enqueue("Client3");
        Persons.Enqueue("Client4");
        Persons.Enqueue("Client5");
        Persons.Enqueue("Client6");
    }
    }

}

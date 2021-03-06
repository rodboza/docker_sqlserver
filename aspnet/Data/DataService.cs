using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnet.Models;
using Microsoft.EntityFrameworkCore;


namespace aspnet.Data
{
    public class DataService : IDataService
    {
        private readonly Contexto _contexto;
        public DataService(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public DataService()
        {
        }

        public async void AddPersons(Person person)
        {
            ContextoWrite myCtxt = new ContextoWrite();
            myCtxt.Add(person);
            await myCtxt.SaveChangesAsync();
            //myCtxt.SaveChangesAsync();
            Console.WriteLine("Salvando!");
                //_context.Add(person);
                //await _context.SaveChangesAsync();
        }

        public List<Person> GetPersons()
        {
            List<Person> lista = new List<Person>{};
            int erro = 1;
            while ( erro > 0 && erro < 10)
                try
                {
                    Contexto myCtxt = new Contexto();
                    lista =  myCtxt.Persons.ToList();
                    erro = 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine("---------------->>>>>>> erro " + erro.ToString());
                    erro++;
                }
            Console.WriteLine("Passou");
            return lista;
        }

        public void InicializaDB()
        {
            this._contexto.Database.EnsureCreated();
        }

        public List<Msg> GetMsgs()
        {
            List<Msg> lista = new List<Msg> { };
            int erro = 1;
            while (erro > 0 && erro < 10)
                try
                {
                    Contexto myCtxt = new Contexto();
                    lista = myCtxt.qa_msgs.ToList();
                    erro = 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine("---------------->>>>>>> erro " + e.ToString());
                    erro++;
                }
            Console.WriteLine("Passou");
            return lista;
        }
    }
}

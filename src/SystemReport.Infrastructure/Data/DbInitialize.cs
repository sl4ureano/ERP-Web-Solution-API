using SystemReport.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemReport.Infrastructure.Data
{
    public static class DbInitialize
    {

        public static void Initialize(ClienteContext context)
        {

            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Adriano Laureano",
                    CPF = "434343434343"
                },
                new Cliente
                {
                    Nome = "André Leal",
                    CPF = "1234565432"
                }
            };

            context.AddRange(clientes);


            if (context.Contatos.Any())
            {
                return;
            }

            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome = "Contato 1",
                    Telefone = "975665444",
                    Email = "contato1@live.com",
                    Cliente = clientes[0]
                },
                new Contato
                {
                    Nome = "Contato 2",
                    Telefone = "343445454",
                    Email = "contato2@live.com",
                    Cliente = clientes[1]
                }
            };

            context.AddRange(contatos);

            context.SaveChanges();

        }
    }
}

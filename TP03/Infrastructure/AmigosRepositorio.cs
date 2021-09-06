using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Infrastructure
{
    public class AmigosRepositorio
    {
        public AmigosRepositorio(BancoDeDados bancoDeDados)
        {
            Database = bancoDeDados;
        }

        public BancoDeDados Database { get; }

        public IEnumerable<Amigo> GetAll()
        {
            var lstAmigos = Database.Amigos.ToList();
            return lstAmigos;
        }
        
        public void Delete(int id)
        {
            if (Database.Amigos.Find(id) == null)
            {
                
            }
            else
            {
            Database.Amigos.Remove(GetById(id));
            Database.SaveChanges();
            }
        }
        
        public Amigo GetById(int id)
        {
            var amigo = Database.Amigos.Find(id);
            return amigo;
        }
        
        public void Create(string nome, string sobrenome, string email, int telefone, DateTime aniversario)
        {
            var amigo = new Amigo();
            amigo.Nome = nome;
            amigo.Sobrenome = sobrenome;
            amigo.Email = email;
            amigo.Aniversario = aniversario;
            amigo.Telefone = telefone;
            Database.Amigos.Add(amigo);
            Database.SaveChanges();
        }

        public void Update(int id, string nome, string sobrenome, string email, int telefone, DateTime aniversario)
        {
            var up = Database.Amigos.Find(id);
            up.Nome = nome;
            up.Sobrenome = sobrenome;
            up.Telefone = telefone;
            up.Email = email;
            up.Aniversario = aniversario;
            Database.SaveChanges();
        }

    }
}

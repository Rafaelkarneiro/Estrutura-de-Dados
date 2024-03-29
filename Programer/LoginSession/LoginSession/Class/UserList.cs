﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSession
{
    class UserList
    {
        //instanciando
        /*
           UserList userList = new UserList();
        */

        private List<User> users = new List<User>();
 
        public void userAdd(User user)
        {
            User u = new User();
            u.Nome = user.Nome;
            u.Email = user.Email;
            u.Senha = user.Senha;
            u.Cpf = user.Cpf;
            u.Ativo = user.Ativo;
            users.Add(u);

            //adicionar um usuario
            /*
                User user = new User();
                user.Nome = "guilherme";
                user.Email = "jho@gmail.com";
                user.Senha = "123";
                user.Cpf = 458;
                user.Ativo = true;
                userList.userAdd(user);
            */
    }

    public object[] select(int index)
        {
            string nome = users[index].Nome;
            string email = users[index].Email;
            string senha = users[index].Senha;
            long cpf = users[index].Cpf;
            bool ativo = users[index].Ativo;

            object[] vetor = { nome, email, senha, cpf, ativo };
            return vetor;

            //buscar um usuario pelo index
            //retorna um objeto vetor com as informacoes do usuario
            /*
            string str = "Nome: {0} \nEmail: {1} \nSenha: {2} \nCPF: {3} \nStatus: {4} \n";
            Console.WriteLine(String.Format(str, userList.select(i)));
            */
        }

        public void userDel(int index)
        {
            users[index].Ativo = false;

            //tornar usuario inativo
            /*
             userList.userDel(1);
            */
        }

        public int Tam
        {
            get { return users.Count; }

            //ver total de itens da lista
            /*
             userList.Tam
            */
        }

        public void alter(int index, User u)
        {
            users[index].Nome = u.Nome;
            users[index].Email = u.Email;
            users[index].Senha = u.Senha;
            users[index].Cpf = u.Cpf;
            users[index].Ativo = u.Ativo;

            //altera um usuario
            /*
             user.Nome = "chagas";
             user.Email = "chagas@gmail.com";
             user.Senha = "321";
             user.Cpf = 854;
             user.Ativo = true;
             userList.alter(0, user);
            */
        }

        public List<User> selectAll()
        {
            List<User> lista = new List<User>();
            foreach (var item in users)
            {
                User u = new User();
                u.Nome = item.Nome;
                u.Email = item.Email;
                u.Senha = item.Senha;
                u.Cpf = item.Cpf;
                u.Ativo = item.Ativo;
                lista.Add(u);
            }
            return lista;

            //executa uma busca completa
            //retorna uma copia da lista principal
            /*
             string str = "Nome: {0} \nEmail: {1} \nSenha: {2} \nCPF: {3} \nStatus: {4} \n";
             foreach (var item in userList.selectAll())
            {
                Console.WriteLine(String.Format(str, item.Nome, item.Email, item.Senha, item.Cpf, item.Ativo));
            }
            */
        }

    }
}

﻿using DAL;
using Model;
using System.Data;

namespace BLL
{
   public class TarefaBLL
    {
        public Tarefa Inserir(Tarefa tarefa)
        {
            TarefaDAL tarefaDAL = new TarefaDAL();
            return tarefaDAL.Inserir(tarefa);
        }
        public DataTable Buscar(string _filtro)
        {
            TarefaDAL tarefaDAL = new TarefaDAL();
            return tarefaDAL.Buscar(_filtro);
        }
        public void Excluir(int _id)
        {
            TarefaDAL tarefaDAL = new TarefaDAL();
            tarefaDAL.Excluir(_id);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToDoAPI.Models.Banco
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ToDoAppEntities1 : DbContext
    {
        public ToDoAppEntities1()
            : base("name=ToDoAppEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ListaTarefa> ListaTarefa { get; set; }
        public virtual DbSet<Tarefa> Tarefa { get; set; }
        public virtual DbSet<TarefaHist> TarefaHist { get; set; }
        public virtual DbSet<TarefaUsuario> TarefaUsuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}

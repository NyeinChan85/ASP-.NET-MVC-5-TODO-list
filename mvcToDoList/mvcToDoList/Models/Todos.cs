using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcToDoList.Models
{
    public class Todos
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public string Attributes { get; set; }
        public string Priority { get; set; }
    }

    public class TodosDBContext : DbContext
    {
        public DbSet<Todos> Todo { get; set; }
    }
}
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaXamarinForms.Models
{
    public class Contato
    {
        [PrimaryKey, AutoIncrement]
        public int? Id { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }
    }
}

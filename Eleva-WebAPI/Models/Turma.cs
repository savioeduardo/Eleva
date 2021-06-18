using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Eleva_WebAPI.Models
{
    public class Turma{
        public int id {get; set;}
        public string codigo {get; set;}
        public int EscolaId {get; set;}
        public Escola Escola {get; set;}

        public Turma(int id, string codigo, int EscolaId)
        {
            this.id = id;
            this.codigo = codigo;
            this.EscolaId = EscolaId;
        }
    }
}
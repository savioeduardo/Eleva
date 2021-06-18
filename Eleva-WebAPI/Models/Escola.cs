using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Eleva_WebAPI.Models
{
    public class Escola{
        public int id {get; set;}
        public string nome {get; set;}
        public string endereco {get; set;}
        public string cidade {get; set;}
        public string estado {get; set;}
        public string telefone {get; set;}

        public Escola(int id, string nome, string endereco, string cidade, string estado, string telefone)
        {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.cidade = cidade;
            this.estado = estado;
            this.telefone = telefone;
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourBrasil___SENAC.Models
{
    public class pontoTuristico
    {
        public int idUsuario{get;set;}
        public string nomeUsuario{get;set;}
        public string origemPacote{get;set;}
        public string destinoPacote{get;set;}
        public string atrativosPacote{get;set;}
        public DateTime saidaPacote{get;set;}
        public DateTime retornoPacote{get;set;}
        public int user{get;set;}        
    }
}
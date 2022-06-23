using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;

namespace TourBrasil___SENAC.Models
{
    public class usuarioRepository
    {
        private const string DadosConexao="Database=tourbrasil; Data Source=localhost; User Id=root;";
        public void inserir(usuario a)
        {
           MySqlConnection Conexao = new MySqlConnection(DadosConexao);

           Conexao.Open();

           string Query = "INSERT INTO usuario (nomeUsuario,user,senhaUsuario,dataNascimento) VALUES (@nomeUsuario,@user,@senhaUsuario,@dataNascimento)";

           MySqlCommand Comando = new MySqlCommand(Query,Conexao);

           Comando.Parameters.AddWithValue("@nomeUsuario",a.nomeUsuario); 
           Comando.Parameters.AddWithValue("@user",a.user); 
           Comando.Parameters.AddWithValue("@senhaUsuario",a.senhaUsuario); 
           Comando.Parameters.AddWithValue("@dataNascimento",a.dataNascimento); 

           Comando.ExecuteNonQuery();

           Conexao.Close();

        }

    }
}
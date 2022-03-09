using Dapper;
using Microsoft.Extensions.Configuration;
using RazorPage.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage.Data
{
    public class AnimesControl : IAnimesControl
    {
        private readonly IConfiguration _configuration;

        public AnimesControl(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Animes AnimesPorID(int Id)
        {
            var connectionString = _configuration.GetConnectionString("IngresoGastoDB");
            var connection = new SqlConnection(connectionString);
            var resulset = connection.QuerySingle<Animes>("select Id,Nombre from Animes_Por_Ver Where Id=@Id",new 
                {
                Id                
                });
            return resulset;
        }

        public void CreateAnime(Animes animes)
        {
            var connectionString = _configuration.GetConnectionString("IngresoGastoDB");
            var connection = new SqlConnection(connectionString);
            var resulset = connection.Execute(
                "insert into Animes_Por_Ver " +
                "values (@Nombre,@Id)", new
                {
                    /*Si el nombre de la variable es igual al nombre de los parametros, solo se pone el nombre de la variable
                     de lo contrario se igualan ambos valores*/
                    animes.Nombre,
                    animes.Id                    
                });
        }

        public void DeleteAnimes(Animes animes)
        {
            var connectionString = _configuration.GetConnectionString("IngresoGastoDB");
            var connection = new SqlConnection(connectionString);
            var resulset = connection.Execute(
                "delete Animes_Por_Ver Where " +
                "Id=@Id", new
                {
                    /*Si el nombre de la variable es igual al nombre de los parametros, solo se pone el nombre de la variable
                     de lo contrario se igualan ambos valores*/
                    animes.Id,
                    animes.Nombre
                   });
        }

        public IEnumerable<Animes> GetAnimes()
        {
            var connectionString = _configuration.GetConnectionString("IngresoGastoDB");
            var connection = new SqlConnection(connectionString);
            var resulset = connection.Query<Animes>("select Id,Nombre FROM Animes_Por_Ver");
            return resulset;

        }

        public void UpdateAnimes(Animes animes)
        {
            var connectionString = _configuration.GetConnectionString("IngresoGastoDB");
            var connection = new SqlConnection(connectionString);
            var resulset = connection.Execute(
                "update Animes_Por_Ver " +
                "set Nombre=@Nombre " +
                "where Id=@Id", new
            {
                    /*Si el nombre de la variable es igual al nombre de los parametros, solo se pone el nombre de la variable
                     de lo contrario se igualan ambos valores*/
                animes.Id,
                animes.Nombre
            });
            
        }
    }
}

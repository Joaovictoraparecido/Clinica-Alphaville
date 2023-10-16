using Microsoft.EntityFrameworkCore;

namespace CLINICA_ALPHAVILLE.Models
{
    public class DATACLINICA : DbContext

    {
       /// DATACLINICA nome do banco de dados
       public DbSet<ListaPaciente> ListaPacientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("workstation id=DATACLINICA.mssql.somee.com;packet size=4096;user id=joaopajesus_SQLLogin_1;pwd=JOAO2202;data source=DATACLINICA.mssql.somee.com;persist security info=False;initial catalog=DATACLINICA");
        }

    }
}

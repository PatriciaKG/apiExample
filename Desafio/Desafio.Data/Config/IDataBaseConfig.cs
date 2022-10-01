namespace Desafio.Data.Config
{
    public interface IDatabaseConfig
    {
        string DatabaseName{get; set;}

        string ConnectionString{get; set;}
       
    }
}
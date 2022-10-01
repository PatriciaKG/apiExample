namespace Desafio.Data.Config
{

    public class DataBaseConfig: IDatabaseConfig
    {
        public string DatabaseName{get; set;}

        public string ConnectionString{get; set;}
    }
}
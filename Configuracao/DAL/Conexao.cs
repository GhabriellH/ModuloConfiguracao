namespace DAL
{
    public static class Conexao
    {
        public static string StringDeConexao
        { 
            get
            {
                return @"User ID=SA;    
                        Inital Catalog=Configuracao; 
                        Data Sourse=.\SQLEXPRESS2019;
                        Password=Senailab02";
            }
        }
                
    }
}

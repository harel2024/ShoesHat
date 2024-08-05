namespace ShoesHat.DAL
{
    public class Data
    {
        string connectionString = "server=HAREL\\SA;initial catalog=ShoesHat;user id=SA;password=1234;TrustServerCertificate=Yes";
   
        private static Data _data;
        private dataLayer dataLayer;

        private Data()
        {
            dataLayer = new dataLayer(connectionString);
        }
        public static dataLayer Get
        {
            get
            {
                if (_data == null)
                    _data = new Data();
                return _data.dataLayer;
            }
        }
    }
}

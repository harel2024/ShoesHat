namespace ShoesHat.DAL
{
    public class Data
    {
        string connectionString = "Server = DESKTOP-2RPAOHT\\SA;initial catalog = Friends; user id =SA;" +
            "password = 1234;TrustServerCertificate = Yes";

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

using DataProvider;

namespace Client
{
    public class School : DataContext
    {
        public DataSet<User> Users { get; set; }
        public DataSet<Group> Groups { get; set; } 

        public School()
        {
            Users = new DataSet<User>();
            Groups = new DataSet<Group>();
        }
    }
}

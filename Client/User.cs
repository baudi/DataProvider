namespace Client
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}

namespace DomRobot.Account
{
    public class Logout : DomRobot<Logout, Logout.Result>
    {
        public Logout() : base() {}


        public class Parameters : BasicParameters { }
        public class Result : IDomrobotResult<Logout>
        {
        }
    }
}

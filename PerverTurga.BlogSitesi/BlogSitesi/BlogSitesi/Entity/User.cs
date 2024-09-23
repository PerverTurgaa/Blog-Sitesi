namespace BlogSitesi.Entity
{
    public class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }

        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Image {  get; set; }

        //  postla user arasında bire çok ilişki
        public List<Post> Posts { get; set; } = new List<Post>();
        // initialize ediyorum listeyi

        // user kaç tane yorum yapmışsa ona bakalım
        public List<Comment> Comments { get; set; } = new List<Comment>();

    }
}

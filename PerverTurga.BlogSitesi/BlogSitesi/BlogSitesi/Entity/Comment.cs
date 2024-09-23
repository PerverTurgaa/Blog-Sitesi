namespace BlogSitesi.Entity
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string? Text { get; set; }
        public DateTime PublishedOn { get; set; }

        // bir yorum sadece bir postu ilgilendirir

        public int PostId { get; set; }
        public Post Post { get; set; } = null!;

        // her bir commenti yapacak kullanıcı
        // bir commenti bir kkullanıcı yazıcak mantığında
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}

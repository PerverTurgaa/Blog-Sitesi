using BlogSitesi.Entity;

namespace BlogSitesi.Data.Abstract
{
    public interface IPostRepository
    {
        IQueryable<Post> Posts { get; }
        // ienumerable yazsaydık hepsini alcaktım iqueryable ile sadece örnek 5 tanesini alcaz

        void CreatePost(Post post);

        void EditPost(Post post);

        void EditPost(Post post, int[] tagIds);



    }
}

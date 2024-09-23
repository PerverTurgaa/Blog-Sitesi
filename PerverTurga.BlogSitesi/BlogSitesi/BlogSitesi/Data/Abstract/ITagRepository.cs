using BlogSitesi.Entity;

namespace BlogSitesi.Data.Abstract
{
    public interface ITagRepository
    {
        IQueryable<Tag> Tags { get; }

        void CreateTag(Tag tag);
    }
}


namespace Domain.Entities;

public class BaseEntity
{

    public int Id { get; set; }

    public DateTime CreateDate { get; set; }

    public BaseEntity()
    {
        CreateDate = DateTime.Now;
    }
}

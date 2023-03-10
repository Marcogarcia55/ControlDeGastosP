namespace Control.FP.Core.Entities;

public class EntitiyBase
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string UpdateBy { get; set; }
    public DateTime UpdateDate { get; set; }
    
}

public class Test1 : EntitiyBase
{
        
}

namespace TodoApi.Models
{
  public class TodoItemDTO : BaseItemDTO
  {    
    public string Name { get; set; }
    public bool IsComplete { get; set; }
    public TaskDTO[] Tasks { get; set; }
  }
}
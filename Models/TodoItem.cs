using System.Collections.Generic;

namespace TodoApi.Models
{
  public class TodoItem : BaseItem
  {    
    public string Name { get; set; }
    public bool IsComplete { get; set; }
    public string Secret { get; set; }
    public ICollection<TaskItem> Tasks { get; set; }
  }
}
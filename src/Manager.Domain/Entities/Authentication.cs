namespace Manager.Domain.Entities
{
 public class Authentication : Base
 {
  public int Name { get; private set; }
     public bool Validate()
            => true;
 }
}
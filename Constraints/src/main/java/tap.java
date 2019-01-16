public class tap implements IConstraint
{
  private variable val;
  private String name;

  public tap(variable v, String s)
  {
    val  = v;
    name = s;

    val.connect(this);
  }

  public void valueChanged()
  {
    System.out.println(name + ": " + val.get_value());
  }
  
  public void reset()
  {
    System.out.println(name + ": " + val.get_value());
  }
}
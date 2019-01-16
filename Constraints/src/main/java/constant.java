public class constant implements IConstraint
{
  public constant(double d, variable v)
  {
    v.connect(this);
    v.set_value(d, this);
  }

  public void valueChanged()
  {
    // no op
  }

  public void reset()
  {
    // no op
  }
}
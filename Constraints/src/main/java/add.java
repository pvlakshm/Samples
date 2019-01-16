public class add implements IConstraint
{
  private variable addend;
  private variable augend;
  private variable sum;

  public add(variable v1, variable v2, variable v3)
  {
    addend = v1;
    augend = v2;
    sum    = v3;

    addend.connect(this);
    augend.connect(this);
    sum.connect(this);
  }

  public void valueChanged()
  {
    if (addend.has_value() && augend.has_value())
    {
      sum.set_value(addend.get_value() + augend.get_value(), this);
    }
    else if (addend.has_value() && sum.has_value())
    {
      augend.set_value(sum.get_value() - addend.get_value(), this);
    }
    else if (augend.has_value() && sum.has_value())
    {
      addend.set_value(sum.get_value() - augend.get_value(), this);
    }
  }

  public void reset()
  {
    addend.reset(this);
    augend.reset(this);
    sum.reset(this);
  }
}
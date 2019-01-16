import java.util.ArrayList;

public class variable
{
  private boolean   hasValue;
  private double    value;
  private ArrayList constraints;
  private IConstraint setter;

  public boolean has_value()
  {
    return hasValue;
  }

  public double get_value()
  {
    return value;
  }

  public void set_value(double d, IConstraint theConstraint)
  {
    value    = d;
    hasValue = true;
    setter   = theConstraint;

    for (int i = 0; i < constraints.size(); i++)
    {
      IConstraint m = (IConstraint) constraints.get(i);
      if (m != setter)
      {
        m.valueChanged();
      }
    }
  }

  public void reset(IConstraint theConstraint)
  {
    if (theConstraint == setter)
    {
      value    = 0.0;
      hasValue = false;
      setter   = null;

      // notify the mediators
      for (int i = 0; i < constraints.size(); i++)
      {
        IConstraint m = (IConstraint) constraints.get(i);
        if (m != setter)
        {
          m.reset();
        }
      }
    }
  }

  public void connect(IConstraint theConstraint)
  {
    if (constraints == null)
    {
      constraints = new ArrayList();
    }
    constraints.add(theConstraint);
  }
}
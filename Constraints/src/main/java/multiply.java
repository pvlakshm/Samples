public class multiply implements IConstraint
{
  private variable multiplier;
  private variable multiplicand;
  private variable product;

  public multiply(variable v1, variable v2, variable v3)
  {
    multiplier   = v1;
    multiplicand = v2;
    product      = v3;

    multiplier.connect(this);
    multiplicand.connect(this);
    product.connect(this);
  }

  public void valueChanged()
  {
    if (multiplier.has_value() && multiplicand.has_value())
    {
      product.set_value(multiplier.get_value() * multiplicand.get_value(), this);
    }
    else if (multiplier.has_value() && product.has_value())
    {
      if (multiplier.get_value() == 0.0)
      {
        multiplicand.set_value(0.0, this);
      }
      else
      {
        multiplicand.set_value(product.get_value() / multiplier.get_value(), this);
      }
    }
    else if (multiplicand.has_value() && product.has_value())
    {
      if (multiplicand.get_value() == 0)
      {
        multiplier.set_value(0.0, this);
      }
      else
      {
        multiplier.set_value(product.get_value() / multiplicand.get_value(), this);
      }
    }
  }

  public void reset()
  {
    multiplier.reset(this);
    multiplicand.reset(this);
    product.reset(this);
  }
}
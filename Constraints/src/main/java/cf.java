public class cf
{
  public static void cfconverter(variable c, variable f)
  {
    variable u  = new variable();    tap tu = new tap(u, "tu");
    variable k  = new variable();    tap tk = new tap(k, "tk");
    constant c1 = new constant(9, k);
    multiply m1 = new multiply(c, k, u);

    variable l  = new variable();    tap tl = new tap(l, "tl");
    constant c2 = new constant(5, l);

    variable v  = new variable();    tap tv = new tap(v, "tv");
    multiply m2 = new multiply(v, l, u);

    variable m  = new variable();    tap tm = new tap(m, "tm");
    constant c3 = new constant(32, m);
    add a = new add(v, m, f);
  }

  public static void main(String[] args)
  {
    variable c = new variable();    tap tc = new tap(c, "c");

    variable f = new variable();    tap tf = new tap(f, "f");

    cfconverter(c, f);

    c.set_value(100, null);
    c.reset(null);
    f.set_value(32, null);
  }
}
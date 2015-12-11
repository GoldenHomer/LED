public class Iteration
{
  public static double Gamma()
  {
    double result = 0;
    for (int i = 1; i<= 500000; ++i)
    {
      result+= 1.0/i - Math.Log((i+1.0)/i);
    }
    return result;
  }
}

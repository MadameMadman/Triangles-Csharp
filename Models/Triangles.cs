namespace Triangles.Models
{
  public class Triangle
  {
    private int _sideA;
    private int _sideB;
    private int _sideC;


    public void SetSides(string a, string b, string c)
    {
      _sideA = int.Parse(a);
      _sideB = int.Parse(b);
      _sideC = int.Parse(c);
    }

    public string GetTriangleType()
    {
      if (_sideA + _sideB <= _sideC)
        return "Not A ";
      if (_sideA + _sideC <= _sideB)
        return "Not A ";
      if (_sideB + _sideC <= _sideA)
        return "Not A ";

      int matchingSides = 0;
      if (_sideA == _sideB)
        matchingSides++;
      if (_sideB == _sideC)
        matchingSides++;
      if (_sideA == _sideC)
        matchingSides++;

      if (matchingSides == 3)
        return "Equilateral";
      else if (matchingSides == 1)
        return "Isoscolese";
      else
        return "Scalene";
    }
  }
}

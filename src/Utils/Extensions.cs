namespace FirstLight.Utils;

public static class Extensions
{
   public static int[] ToIntArray(this string src)
   {
      return src.Split(',').Select(x => int.Parse(x)).ToArray();
   }

   public static Coordinate[] ToCoordinates(this float[] points)
   {
      var coordinates = new List<Coordinate>();
      for (int x = 0; x < points.Length; x += 2)
      {
         coordinates.Add(new Coordinate(points[x], points[x + 1]));
      }
      return coordinates.ToArray();
   }

   public static string CombineWithPath(this string src, string path)
   {
      int index = path.LastIndexOf('/');
      return path.Substring(0, index + 1) + src;
   }
}
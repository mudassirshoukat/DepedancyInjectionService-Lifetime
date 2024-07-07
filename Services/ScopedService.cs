using System.Diagnostics;

namespace DepInjServiceLifetime.Services
{

   public class ScopedService : IScopedService
   {
      public ScopedService()
      {
         Debug.WriteLine("Scoped Service Has Created");
      }
   }


   public interface IScopedService
   {
   }
}

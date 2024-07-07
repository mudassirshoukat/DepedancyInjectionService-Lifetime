using System.Diagnostics;

namespace DepInjServiceLifetime.Services
{

   public class ScopedService : IScopedService
   {
      public ScopedService()
      {
         Debug.WriteLine("ScopedService Has Created");
      }
   }


   public interface IScopedService
   {
   }
}

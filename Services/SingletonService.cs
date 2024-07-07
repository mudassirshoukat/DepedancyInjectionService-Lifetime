using System.Diagnostics;

namespace DepInjServiceLifetime.Services
{


   public class SingletonService : ISingletonService
   {
      public SingletonService()
      {
         Debug.WriteLine("Singleton Service Has Created");
       
      }
   }


   public interface ISingletonService
   {
   }
}

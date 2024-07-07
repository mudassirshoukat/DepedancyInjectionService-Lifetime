using System.Diagnostics;

namespace DepInjServiceLifetime.Services
{
  
   public class TransientService : ITransientService
   {
      public TransientService()
      {
         Debug.WriteLine("Transient Service Has Created");
      }
   }


   public interface ITransientService
   {
   }
}

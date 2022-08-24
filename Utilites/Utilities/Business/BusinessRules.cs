using Melumatlar.Abstract;
using Utilites.Abstract;

namespace CoreAndUtilites.Utilities.Business
{
    public static class BusinessRules<T> where T : class, IEntity, new()
    {

        public static IDataResult<T> Run(params IDataResult<T>[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }


    }
}

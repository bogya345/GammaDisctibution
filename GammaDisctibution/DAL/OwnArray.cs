using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GammaDisctibution.DAL
{
    class OwnArray<T>
    {
        #region stuff

        private int actualSize;

        #endregion
        public OwnArray()
        {
            //Context.chartsList.Where()
        }

        public int Size { get; private set; }

        public T[] Values { get; set; }

        public void Add(T item)
        {
            //if ()
        }

        public T Where(Func<T, bool> predicate)
        {
            return this.Values.FirstOrDefault(predicate);
        }
    }
}

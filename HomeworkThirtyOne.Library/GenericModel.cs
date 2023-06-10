using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkThirtyOne.Library
{
    public class GenericModel<T> where T : IHelper
    {
        public string GetMessage(T item)
        {
            string output;

            if (item.HasError)
            {
                output = $"{item.ToString()} : Error Found";
            }
            else
            {
                output = $"{item.ToString()} : Clear";
            }

            return output;
        }
    }
}

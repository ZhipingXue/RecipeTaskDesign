using System.Collections.Generic;

namespace RecipeTaskQuene
{
    public abstract class BaseRecipe<T>
        where T: new()
    {
        public Dictionary<string,T> properties;
    }
}
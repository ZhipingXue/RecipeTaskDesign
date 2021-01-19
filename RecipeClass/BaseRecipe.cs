using System.Collections.Generic;

namespace RecipeTaskQuene.RecipeStruct
{
    public abstract class BaseRecipe
    {
        Dictionary<string,object> properties;
    }

    public class Heating:BaseRecipe
    {
        public bool HeatingStyle { get; set; }
    }

    public class PreHeating : BaseRecipe
    {
        
    }

    public class Pressure : BaseRecipe
    {
        
    }
}
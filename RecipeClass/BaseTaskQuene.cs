using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Reflection;
using RecipeTaskQuene.RecipeStruct;

#nullable enable

namespace RecipeTaskQuene
{

    public interface IBaseTaskElement
    {
        BaseRecipe Craft{ get; }
        void ConfigHardware(object WFBRecipeHardwareInstace);
        void TaskFinished();
    }

    public sealed class HeatingTask:IBaseTaskElement
    {
        public BaseRecipe Craft { get; }
        
        public HeatingTask()
        {
            
        }
        public void ConfigHardware(object WFBRecipeHardwareInstace)
        {
            
        }

        public void TaskFinished()
        {

        }
    }
    
    public class TaskQuene
    {
        IBaseTaskElement[] RecipeData;
        public TaskQuene(List<BaseRecipe> recipelist)
        {
            //Initial the OL_2604_instance, GT_Press_instance and 

            //
        }
    }
}
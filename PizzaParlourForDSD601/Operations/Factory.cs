using PizzaParlourForDSD601.Models;

namespace PizzaParlourForDSD601.Operations
{
    public static class Factory
    {
        public static Pizza GetAPizza(int? id)
        {
            switch(id)
                {
                case 1:
                    return new Hawaiian();
                case 2:
                return new Meatlovers();
                case 3:
                    return new Vegetarian();
                default : 
                    return new Hawaiian();
            }
        }
    }
}

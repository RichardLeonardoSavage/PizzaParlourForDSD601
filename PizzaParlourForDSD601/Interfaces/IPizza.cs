namespace PizzaParlourForDSD601.Interfaces
{
    public interface IPizza
    {
        string Description { get; set; }
        string Image { get; set; }
        bool IsGlutenFree { get; set; }
        bool IsVegetarian { get; set; }
        string PizzaChefName { get; set; }
        List<string> PizzaIngredients { get; set; }
        string PizzaName { get; set; }
        List<string> PizzaSizesAndPrices { get; set; }

        void PizzaChef(string pizzaChef);
    }
}
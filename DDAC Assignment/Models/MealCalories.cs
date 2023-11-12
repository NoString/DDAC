namespace DDAC_Assignment.Models
{
    public class MealCalories
    {
        public int MealCaloriesID { get; set; }
        public string? Meals { get; set; }
        public string? FoodBeverage { get; set; }
        public int Calories { get; set; }
        public DateOnly DateRecord { get; set; }
    }
}

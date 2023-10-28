namespace RetirementСalculator
{
    internal class Program
    {
        public static double CalculatePension_Ukraine(int age, int experience)
        {
            return 0.2 * age + 0.1 * experience;
        }

        public static double CalculatePension_USA(int age, int experience)
        {
            return 0.3 * age + 0.2 * experience;
        }

        public static double CalculatePension_Japan(int age, int experience)
        {
            return 0.4 * age + 0.3 * experience;
        }

        public static void Main()
        {
            Person person = new Person("John", 60, 40);
            double pension_Ukraine = person.GetRetiremetnValue(CalculatePension_Ukraine);
            double pension_USA = person.GetRetiremetnValue(CalculatePension_USA);
            double pension_Japan = person.GetRetiremetnValue(CalculatePension_Japan);
        }
    }
}
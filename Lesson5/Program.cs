namespace Lesson5;

public class Program
{
    public static void Main()
    {
        var dentist = new Doctor(5, "Доктор Ватсон", "стоматолог", 35);
        var therapist = new Doctor(12, "Доктор Уизли", "терапевт", 48);
        var neurologist = new Doctor(17, "Доктор Стрейндж", "невролог", 50);

        var patient1 = new Patient("Шерлок", 28, "Baker street", "Болен");
        var patient2 = new Patient("Мориарти", 30, "Downing street", "Болен");

        dentist.Cure(patient1);
        neurologist.Cure(patient2);

        Console.WriteLine(patient1.Status);
        Console.WriteLine(patient2.Status);
        }
}
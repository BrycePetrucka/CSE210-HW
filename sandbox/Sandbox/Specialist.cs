public class Specialist : Staff
{
    private string _specialization;

    public Specialist(string firstName, string lastName, string gender, string special) : base(firstName, lastName, gender)
    {
        _specialization = special;
    }

    public string IntroMessage()
    {
        string lastName = GetLastName();
        string gender = GetGender();
        return $"Hello students, I am {gender} {lastName}. I am a {_specialization} specialist.";
    }
}
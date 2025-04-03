public class Volunteer : Staff
{
    public Volunteer(string firstName, string lastName, string gender) : base(firstName, lastName, gender)
    {

    }

    public string IntroMessage()
    {
        string lastName = GetLastName();
        string gender = GetGender();
        return $"Hello students, I am {gender} {lastName}. I am a volunteer.";
    }
}